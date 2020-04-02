using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TSM = Tekla.Structures.Model;

namespace CodeGenerator
{
    static class Program
    {
        //TODO static classes and properties

        static void Main(string[] args)
        {
            Console.WriteLine("Project directory: " + GetProjectDirectory());

            Console.WriteLine("Do you want to generate API codes?\ny - yes\nn - no\n");
            var input = Console.ReadLine();

            if (input.Equals("y", StringComparison.InvariantCulture))
            {
                GenerateAPICode();
            }
            
        }

        public static string GetProjectDirectory()
        {
            var debugFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
            var binFolder = Directory.GetParent(debugFolder);
            var projectFolder = Directory.GetParent(binFolder.FullName);
            return projectFolder.FullName;
        }

        private static Assembly LoadAssembly(string fileName)
        {
            string filePath = Path.Combine(GetProjectDirectory(), fileName);
            return Assembly.LoadFile(filePath);
        }

        private static void GenerateAPICode()
        {
            Console.WriteLine("Generate API code");
            var generator = new FileGenerator();

            var allTypes = GetTypesFromDll();

            foreach (var type in allTypes)
            {
                //if (type.Name.Contains("Beam"))
                {
                    generator.SaveToFile(type);
                }
            }
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

                );

           var output = new List<Type>();
            output.AddRange(tsTypes);
            output.AddRange(tsmTypes);
            output.AddRange(tsdTypes);
            output.AddRange(talTypes);
            output.AddRange(tsdiTypes);
            
            return output;
        }
    }
}
