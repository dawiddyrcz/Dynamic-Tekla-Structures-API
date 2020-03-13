using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project directory: " + GetProjectDirectory());

            Console.WriteLine("Do you want to generate API codes?\ny - yes\nn - no");
            var input = Console.ReadLine();

            if (input.Equals("y", StringComparison.InvariantCulture))
            {
                GenerateAPICode();
            }

            Console.ReadKey();
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

            var classGenerator = new ClassGenerator();

            var ts = LoadTeklaStructures();

            //foreach (var type in ts.GetTypes().Where(t => t.IsPublic && !t.Namespace.Contains("Internal")))
            //{
            //    Console.WriteLine(type.Name);

            //    if (type.IsClass)
            //        classGenerator.SaveToFile(type);
            //}

            //TODO sort namespaces: Internal Render

            var tsm = LoadTeklaStructuresModel();

            foreach (var type in tsm.GetTypes().Where(t => t.IsPublic && !t.Namespace.Contains("Internal")))
            {
                Console.WriteLine(type.Name);

                if (type.IsClass)
                {
                    if (type.Name.EndsWith("Beam"))
                        classGenerator.SaveToFile(type);
                }
            }
        }

        
    }
}
