/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Dynamic.Tekla.Structures
{
    internal static class TSActivator
    {
        private static Dictionary<string, Assembly> assemblies;

        public static dynamic CreateInstance(string typeName)
        {
            var type = GetTypeFromTypeName(typeName);
            return Activator.CreateInstance(type);
        }

        public static object InvokeMethod(object instance, string typeName, string methodName, object[] parameters)
        {
            var type = GetTypeFromTypeName(typeName);
            MethodInfo method = GetMethod(methodName, parameters, type);

            return method.Invoke(instance, parameters);
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object[] parameters)
        {
            var type = GetTypeFromTypeName(typeName);
            MethodInfo method = GetMethod(methodName, parameters, type);

            return method.Invoke(null, parameters);
        }

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

            throw new DynamicAPIException("Could not find method " + methodName + " in type " + type.Name);
        }

        public static dynamic CreateInstance(string typeName, object[] args)
        {
            var type = GetTypeFromTypeName(typeName);
            return Activator.CreateInstance(type, args);
        }

        public static Type GetTypeFromTypeName(string typeName)
        {
            if (IsTeklaRunning())
            {
                if (assemblies.ContainsKey(typeName))
                {
                    var assembly = assemblies[typeName];
                    var tsAPITypes = assembly;
                    var type = tsAPITypes.GetType(typeName);

                    if (type != null) return type;

                    type = TryGetNestedType(typeName, ref assembly);
                    if (type != null) return type;

                    throw new DynamicAPIException("Unknown error. Type is null in GetTypeFromTypeName() method.");
                }
                else
                {
                    throw new DynamicAPINotFoundException("Could not find type " + typeName + " in Tekla API assemblies");
                }
            }
            else
            {
                throw new DynamicAPIException("Tekla Structures is not running. Start program before using API");
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
        
        private static TeklaProcess teklaProcess;

        private static bool IsTeklaRunning()
        {
            if (teklaProcess != null)
            {
                if (teklaProcess.IsTeklaRunning())
                {
                    return true;
                }
            }

            teklaProcess = new TeklaProcess();
            if (teklaProcess.IsTeklaRunning())
            {
                assemblies = GetAssemblies();
                return true;
            }

            return false;
        }

        private static Dictionary<string, Assembly> GetAssemblies()
        {
            var output = new Dictionary<string, Assembly>();

            foreach (var dllPath in GetDllPathes(teklaProcess.GetTeklaProcessDirectoryPath()))
            {
                var assembly = Assembly.LoadFrom(dllPath);

                foreach (var tsType in assembly.GetTypes().Where(t => t.IsPublic))
                {
                    var typeFullName = CodeGenerator.TypeFullName.GetTypeFullName(tsType);
                    output.Add(typeFullName, assembly);

                    foreach (var nestedType in NestedTypes(tsType))
                    {
                        var nestedTypeFullName = CodeGenerator.TypeFullName.GetTypeFullName(nestedType);
                        output.Add(nestedTypeFullName, assembly);
                    }
                }
            }

            return output;
        }

        private static List<Type> NestedTypes(Type type)
        {
            var output = new List<Type>();

            foreach (var nestedType in type.GetNestedTypes())
            {
                output.Add(nestedType);
                output.AddRange(NestedTypes(nestedType));
            }
            return output;
        }

        private static List<string> GetDllPathes(string binPath)
        {
            return new List<string>()
            {
                Path.Combine(binPath, "plugins", "Tekla.Structures.dll"),
                Path.Combine(binPath, "plugins",  "Tekla.Structures.Model.dll"),
                Path.Combine(binPath, "plugins",  "Tekla.Structures.Datatype.dll"),
                Path.Combine(binPath, "plugins",  "Tekla.Structures.Drawing.dll"),
                Path.Combine(binPath, "applications", "Tekla", "Common", "Tekla.Application.Library.dll"),
                Path.Combine(binPath, "dialogs", "Tekla.Structures.Dialog.dll"),
            };

        }
    }
}
