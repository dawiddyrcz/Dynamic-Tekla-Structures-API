using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project directory: " + GetProjectDirectory());

            Console.WriteLine("Do you want to generate API codes?\ny - yes\nn - no\nt - show all types");
            var input = Console.ReadLine();

            if (input.Equals("y", StringComparison.InvariantCulture))
            {
                GenerateAPICode();
            }

            if (input.Equals("t", StringComparison.InvariantCulture))
            {
                ShowAllTypes();
            }
            
            //hide private get set accessors in properties
            //new Tekla.Structures.Geometry3d.Point().

            if (input.Equals("n", StringComparison.InvariantCulture))
            {
                var constructors = typeof(Tekla.Structures.Geometry3d.Point).GetConstructors();

                foreach (var item in constructors)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.GetParameters().Count());

                    foreach (var param in item.GetParameters())
                    {
                        Console.WriteLine(param.ParameterType);
                        Console.WriteLine(param.Name);
                    }
                }

                Console.ReadKey(); 
            }
        }

        private static void ShowAllTypes()
        {
            Console.WriteLine("Shows all types");

            var sb = new StringBuilder();

            var ts = LoadTeklaStructures();

            var tsTypes = ts.GetTypes().Where(
                t => t.IsPublic
                && t.Namespace.StartsWith("Tekla.Structures")
                && !t.Namespace.Contains("Internal"));

            foreach (var type in tsTypes)
            {
                Console.WriteLine(type.Name);
                sb.AppendLine(type.Name);

                Console.WriteLine(type.Name);
                sb.AppendLine(type.Name + "\t" + type.IsNested);

                foreach (var nestedType in type.GetNestedTypes())
                {
                    Console.WriteLine(nestedType.Name);
                    sb.AppendLine("\t" + nestedType.Name + "\t" + nestedType.IsNested);
                }
            }


            var tsm = LoadTeklaStructuresModel();
            var tsmTypes = tsm.GetTypes().Where(
                t => t.IsPublic
                && t.Namespace.StartsWith("Tekla.Structures")
                && !t.Namespace.Contains("Internal"));


            foreach (var type in tsmTypes)
            {
                Console.WriteLine(type.Name);
                sb.AppendLine(type.Name + "\t" +type.IsNested);

                foreach (var nestedType in type.GetNestedTypes())
                {
                    Console.WriteLine(nestedType.Name);
                    sb.AppendLine("\t" + nestedType.Name + "\t" + nestedType.IsNested);
                }

            }

            File.WriteAllText("..\\..\\types.txt", sb.ToString());

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

        private static Assembly LoadTeklaStructures() => LoadAssembly("Tekla.Structures.dll");

        private static Assembly LoadTeklaStructuresModel() => LoadAssembly("Tekla.Structures.Model.dll");

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
            var ts = LoadTeklaStructures();
            var tsTypes = ts.GetTypes().Where(
                t => t.IsPublic
                && t.Namespace.StartsWith("Tekla.Structures")
                && !t.Namespace.Contains("Internal"));

            var tsm = LoadTeklaStructuresModel();
            var tsmTypes = tsm.GetTypes().Where(
                t => t.IsPublic
                && t.Namespace.StartsWith("Tekla.Structures")
                && !t.Namespace.Contains("Internal"));

            var output = new List<Type>();
            output.AddRange(tsTypes);
            output.AddRange(tsmTypes);

            return output;
        }
    }
}
