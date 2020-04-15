/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/

//TODO modelobject enumerator example
//TODO filtering example
//TODO macro example

#define OVERRIDE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeGenerator
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project directory: " + GetProjectDirectory());

            Console.WriteLine("Do you want to generate API codes?\ny - yes\nn - no\n");
            var input = Console.ReadLine();

            if (input.Equals("y", StringComparison.InvariantCulture))
            {

                string outputDirectory = string.Empty;

#if OVERRIDE
                outputDirectory = Path.GetDirectoryName(Program.GetProjectDirectory());
#else
                outputDirectory = "DynamicAPI";
#endif
                GenerateAPICode(outputDirectory);

                System.Diagnostics.Debug.WriteLine("op names: ");
                foreach (var item in ClassGenerator.opStrings)
                {
                    System.Diagnostics.Debug.WriteLine(item);
                }

#if !OVERRIDE
                var solutionPath = Path.GetDirectoryName(Program.GetProjectDirectory());
                var notGeneratedInputPath = Path.Combine(solutionPath, "Dynamic.Tekla.Structures", "NotGenerated");
                var notGeneratedOutputPath =Path.Combine( Path.GetFullPath(outputDirectory), "Dynamic.Tekla.Structures", "NotGenerated");

                CopyDir(notGeneratedInputPath, notGeneratedOutputPath);

                try
                {
                    System.Diagnostics.Process.Start(outputDirectory);
                }
                catch (Exception)
                {

                }
#endif

            }
            else
            {
                Console.WriteLine("Wrong choice");
                Console.ReadKey();
            }
            
        }

        private static void GenerateAPICode(string outputDirectory)
        {
            Console.WriteLine("Generate API code");
            var generator = new FileGenerator(outputDirectory);

            foreach (var type in GetTypesFromDll())
            {
                if (type.BaseType != null)
                    if (type.BaseType.Equals(typeof(System.MulticastDelegate))) continue;

                generator.SaveToFile(type);
            }
        }


        private static string GetProjectDirectory()
        {
            var debugFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
            var binFolder = Directory.GetParent(debugFolder);
            var projectFolder = Directory.GetParent(binFolder.FullName);
            return projectFolder.FullName;
        }

        private static Assembly LoadAssembly(string fileName)
        {
            string filePath = Path.Combine(GetProjectDirectory(), "API_dll_files_version_2019i", fileName);
            return Assembly.LoadFile(filePath);
        }

        private static List<Type> GetTypesFromDll()
        {
            var ts = LoadAssembly("Tekla.Structures.dll");
            var tsTypes = ts.GetTypes().Where(
                t => t.IsPublic
                && t.Namespace.StartsWith("Tekla.Structures")
                && !t.Namespace.Contains("Internal")
                );

            var tsm = LoadAssembly("Tekla.Structures.Model.dll");
            var tsmTypes = tsm.GetTypes().Where(
                t => t.IsPublic
                && t.Namespace.StartsWith("Tekla.Structures")
                && !t.Namespace.Contains("Internal")
                && !t.Name.Equals("Events")
                && !t.Name.Equals("ClashChekerEvent")
                );

            var tsd = LoadAssembly("Tekla.Structures.Drawing.dll");
            var tsdTypes = tsd.GetTypes().Where(
                t => t.IsPublic
                && (t.Namespace?.StartsWith("Tekla.Structures") ?? false)
                && !t.Namespace.Contains("Internal")
                && !t.Name.Equals("InputDefinitionFactory")
                && !t.Name.Equals("Events")
                );

            var tal = LoadAssembly("Tekla.Application.Library.dll");
            var talTypes = tal.GetTypes().Where(
                t => t.Name.Equals("MacroBuilder", StringComparison.InvariantCulture) 
                || t.Name.Equals("TeklaStructures", StringComparison.InvariantCulture)
                || t.Name.Equals("IConnection", StringComparison.InvariantCulture)
                || t.Name.Equals("IRegistry", StringComparison.InvariantCulture)
                || t.Name.Equals("IModel", StringComparison.InvariantCulture)
                || t.Name.Equals("IMainWindow", StringComparison.InvariantCulture)
                || t.Name.Equals("IEnvironment", StringComparison.InvariantCulture)
                || t.Name.Equals("IDrawing", StringComparison.InvariantCulture)
                || t.Name.Equals("Configuration", StringComparison.InvariantCulture)
                || t.Name.Equals("ICommonTasks", StringComparison.InvariantCulture)
                || t.Name.Equals("ModelFolder", StringComparison.InvariantCulture)
                || t.Name.Equals("VirtualFolder", StringComparison.InvariantCulture)
                );

            var tsdi = LoadAssembly("Tekla.Structures.Dialog.dll");
            var tsdiTypes = tsdi.GetTypes().Where(
                t => t.Name.Equals("MainWindow") 
                || t.Name.Equals("HelpViewer")
                || t.Name.Equals("Localization")
                || t.Name.Equals("StructuresInstallation")

                );

            var tsc = LoadAssembly("Tekla.Structures.Catalogs.dll");
            var tscTypes = tsc.GetTypes().Where(
                 t => t.IsPublic
                 && (t.Namespace?.StartsWith("Tekla.Structures") ?? false)
                  && !t.Namespace.Contains("Internal")
                 );

            var tsdt = LoadAssembly("Tekla.Structures.Datatype.dll");
            var tsdtTypes = tsdt.GetTypes().Where(
                 t => t.IsPublic
                 && (t.Namespace?.StartsWith("Tekla.Structures") ?? false)
                  && !t.Namespace.Contains("Internal")
                );

            var output = new List<Type>();
            output.AddRange(tsTypes);
            output.AddRange(tsmTypes);
            output.AddRange(tsdTypes);
            output.AddRange(talTypes);
            output.AddRange(tsdiTypes);
            output.AddRange(tscTypes);
            output.AddRange(tsdtTypes);

            return output;
        }

        private static void CopyDir(string inputDir, string outputDir)
        {
            if (!Directory.Exists(inputDir)) return;
            if (!Directory.Exists(outputDir)) Directory.CreateDirectory(outputDir);
            var inputDirectoryInfo = new DirectoryInfo(inputDir);

            var filesToCopy = inputDirectoryInfo.GetFiles();
            foreach (var file in filesToCopy)
            {
                File.Copy(file.FullName, Path.Combine(outputDir, file.Name), true);
            }

            var directoriesToCopy = inputDirectoryInfo.GetDirectories();
            foreach (var directory in directoriesToCopy)
            {
                CopyDir(Path.Combine(inputDir, directory.Name), Path.Combine(outputDir, directory.Name));
            }
        }
    }
}
