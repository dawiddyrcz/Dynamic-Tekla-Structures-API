/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace Dynamic.Tekla.Structures
{
    internal static class TSActivator
    {
        /// <summary>Creates instance of type with typeName. TypeName should be c# full name like: Tekla.Structures.Model.Beam.BeamTypeEnum</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
        public static dynamic CreateInstance(string typeName)
        {
            var type = GetTypeFromTypeName(typeName);
            return Activator.CreateInstance(type);
        }

        /// <summary>Creates instance of type with typeName. TypeName should be c# full name like: Tekla.Structures.Model.Beam.BeamTypeEnum</summary>
        /// <param name="args">Constructor parameters</param>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
        public static dynamic CreateInstance(string typeName, object[] args)
        {
            //TODO convert parameters
            var type = GetTypeFromTypeName(typeName);
            return Activator.CreateInstance(type, args);
        }

        ///<summary>Invoke method in the instance of the object</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
        public static object InvokeMethod(object instance, string typeName, string methodName, object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] is System.Collections.ArrayList)
                    parameters[i] = ConvertToTSArrayList((ArrayList)parameters[i]);
            }

            var type = GetTypeFromTypeName(typeName);
            MethodInfo method = GetMethod(methodName, parameters, type);

            var result = method.Invoke(instance, parameters);
            if (result is null) return null;

            if (result is System.Collections.ArrayList)
                return ConvertArrayList((ArrayList)result);
            else return result;
        }

        ///<summary>Invoke static method in the type with typeName</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
        public static object InvokeStaticMethod(string typeName, string methodName, object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] is System.Collections.ArrayList)
                    parameters[i] = ConvertToTSArrayList((ArrayList)parameters[i]);
            }

            var type = GetTypeFromTypeName(typeName);
            MethodInfo method = GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            if (result is null) return null;

            if (result is System.Collections.ArrayList)
                return ConvertArrayList((ArrayList)result);
            else return result;
        }

        ///<summary>Gets value of static field or property in type with typeName</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
        public static object Get_StaticPropertyOrFieldValue(string typeName, string fieldOrPropertyName)
        {
            var type = GetTypeFromTypeName(typeName);
            var fieldInfo = type.GetField(fieldOrPropertyName);
            if (fieldInfo != null)
            {
                var result = fieldInfo.GetValue(null);
                if (result is null) return null;

                if (result is System.Collections.ArrayList)
                    return ConvertArrayList((ArrayList)result);
                else return result;
            }

            var propertyInfo = type.GetProperty(fieldOrPropertyName);
            if (propertyInfo != null)
            {
                var result = propertyInfo.GetValue(null);
                if (result is null) return null;

                if (result is System.Collections.ArrayList)
                    return ConvertArrayList((ArrayList)result);
                else return result;
            }

            throw new DynamicAPINotFoundException("Could not find static property or field " + fieldOrPropertyName + " in type " + typeName);
        }

        ///<summary>Sets value of static field or property in type with typeName</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
        public static void Set_StaticPropertyOrFieldValue(string typeName, string fieldOrPropertyName, object value)
        {
            object valueCorrected;
            if (value is ArrayList)
                valueCorrected = ConvertToTSArrayList((ArrayList)value);
            else
                valueCorrected = value;

            var type = GetTypeFromTypeName(typeName);
            var fieldInfo = type.GetField(fieldOrPropertyName);

            if (fieldInfo != null)
            {
                fieldInfo.SetValue(null, valueCorrected);
                return;
            }
            var propertyInfo = type.GetProperty(fieldOrPropertyName);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(null, valueCorrected);
                return;
            }

            throw new DynamicAPINotFoundException("Could not find static property or field " + fieldOrPropertyName + " in type " + typeName);
        }

        /// <summary>Gets the method from the type</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find metod</exception>
        private static MethodInfo GetMethod(string methodName, object[] parameters, Type type)
        {
            var methods = type.GetMethods()
                .Where(m => m.Name.Equals(methodName, StringComparison.InvariantCulture)
                && m.GetParameters().Length.Equals(parameters.Length)
                ).ToList();
            int count = methods.Count;

            if (count.Equals(1))
            {
                return methods[0];
            }
            else
            {
                foreach (var method in methods)
                {
                    bool parametersMath = true;

                    int i = 0;
                    var methodParameters = method.GetParameters();
                    foreach (var parameter in methodParameters)
                    {
                        if (!(parameter.ParameterType.Equals(parameters[i].GetType())
                            || parameter.ParameterType.Equals(parameters[i].GetType().MakeByRefType())))
                        {
                            parametersMath = false;
                            break;
                        }
                        i++;
                    }

                    if (parametersMath) return method;
                }
            }

            throw new DynamicAPINotFoundException("Could not find method " + methodName + " in type " + type.Name);
        }


        /// <summary>Finds type from loaded Tekla API assemblies</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception>
        public static Type GetTypeFromTypeName(string typeName)
        {
            if (TeklaProcess.IsTeklaRunning())
            {
                if (TeklaProcess.APIAssemblies.ContainsKey(typeName))
                {
                    var assembly = TeklaProcess.APIAssemblies[typeName];
                    var tsAPITypes = assembly;
                    var type = tsAPITypes.GetType(typeName);

                    if (type != null) return type;

                    type = TryGetNestedType(typeName, ref assembly);
                    if (type != null) return type;

                    throw new DynamicAPIException("Unknown error. Type is null in GetTypeFromTypeName() method. Type name: " + typeName);
                }
                else
                {
                    throw new DynamicAPINotFoundException("Could not find type " + typeName + " in Tekla API assemblies");
                }
            }
            else
            {
                throw new DynamicAPITeklaNotRunningException();
            }
        }

        private static Type TryGetNestedType(string typeName, ref Assembly assembly)
        {
            if (typeName.Contains('.'))
            {
                string output = string.Copy(typeName);
                var lastDotPosition = typeName.LastIndexOf('.');
                output = typeName.Insert(lastDotPosition, "+");
                output = output.Remove(lastDotPosition + 1, 1);

                var type = assembly.GetType(output);

                if (type != null)
                    return type;
                else
                    return TryGetNestedType(output, ref assembly);
            }
            else return assembly.GetType(typeName);
        }

        public static ArrayList ConvertArrayList(ArrayList tsObjects)
        {
            if (tsObjects.Count.Equals(0))
                return new ArrayList();

            var output = new ArrayList(tsObjects.Count + 1);
            var assembly = Assembly.GetExecutingAssembly();

            foreach (var tsObject in tsObjects)
            {
                string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                var converterType = assembly.GetType(converterName);
                var parameters = new object[] { tsObject };
                var fromTSObjectMethod = GetMethod("FromTSObject", parameters, converterType);

                output.Add(fromTSObjectMethod.Invoke(null, parameters));
            }
            return output;
        }

        public static ArrayList ConvertToTSArrayList(ArrayList dynAPIObjects)
        {
            if (dynAPIObjects.Count.Equals(0))
                return new ArrayList();

            var output = new ArrayList(dynAPIObjects.Count + 1);

            foreach (dynamic dynObject in dynAPIObjects)
            {
                output.Add(dynObject.teklaObject);
            }
            return output;
        }

        public static object[] ConvertTupleTSTypes(object input)
        {
            object[] values = input.GetType()
                  .GetProperties()
                  .Select(property => property.GetValue(input))
                  .ToArray();
            if (values.Length.Equals(0)) return values;

            var assembly = Assembly.GetExecutingAssembly();

            for (int i = 0; i < values.Length; i++)
            {
                var currentValue = values[i];
                if (currentValue.GetType().ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
                {
                    string converterName = "Dynamic." + currentValue.GetType().ToString() + "_";
                    var converterType = assembly.GetType(converterName);
                    var parameters = new object[] { currentValue };
                    var fromTSObjectMethod = GetMethod("FromTSObject", parameters, converterType);
                    var converted = fromTSObjectMethod.Invoke(null, parameters);
                    values[i] = converted;
                }
            }
            return values;
        }

        public static System.Tuple<T1, T2> ArrayToTuple<T1, T2>(object[] array)
        {
            if (array.Length != 2)
                throw new ArgumentException("Input array should have 2 elements but has " + array.Length);
            return new Tuple<T1, T2>((T1)array[0], (T2)array[1]);
        }

        public static System.Tuple<T1, T2, T3> ArrayToTuple<T1, T2, T3>(object[] array)
        {
            if (array.Length != 3)
                throw new ArgumentException("Input array should have 3 elements but has " + array.Length);
            return new Tuple<T1, T2, T3>((T1)array[0], (T2)array[1], (T3)array[2]);
        }

        public static System.Tuple<T1, T2, T3, T4> ArrayToTuple<T1, T2, T3, T4>(object[] array)
        {
            if (array.Length != 4)
                throw new ArgumentException("Input array should have 4 elements but has " + array.Length);
            return new Tuple<T1, T2, T3, T4>((T1)array[0], (T2)array[1], (T3)array[2], (T4)array[3]);
        }
    }
}
