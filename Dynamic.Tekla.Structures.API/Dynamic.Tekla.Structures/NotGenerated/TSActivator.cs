﻿/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
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
        
        /// <summary>Gets the method from the type</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find metod</exception>
        public static MethodInfo GetMethod(string methodName, object[] parameters, Type type)
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

    }
}
