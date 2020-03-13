using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public class ClassGenerator
    {
        public ClassGenerator()
        {

        }

        public void SaveToFile(Type type)
        {
            if (!type.IsClass) return;

            string fileName = Path.Combine(Path.GetDirectoryName(Program.GetProjectDirectory())
                , "Dynamic.Tekla.Structures",
                type.Name + ".cs");

            string classText = String.Copy(text);
            
            classText = AddProperties(type, classText);
            classText = AddMethods(type, classText);
            classText = AddConstructor(type, classText);



            classText = classText.Replace("$classname", type.Name);
            classText = classText.Replace("$dfield", type.Name.ToLower());
            classText = classText.Replace("$namespace", type.Namespace);

            //TODO father class
            classText = classText.Replace("$fatherClass", "");

            //$constructor2

            File.WriteAllText(fileName, classText);
        }

        private string AddMethods(Type type, string classText)
        {
            var sb = new StringBuilder();

            foreach (var method in type.GetMethods().Where(m => m.IsPublic))
            {
                var name = method.Name;
                
                if (name.Contains("get_") || name.Contains("set_")) continue;
                
                sb.Append("\t\t");
                sb.Append("public ");
                
                if (IsTeklaType(method.ReturnType))
                {
                    sb.Append(GetTypeFullName(method.ReturnType));
                    sb.Append(" ");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");
                        sb.Append(GetTypeFullName(param.ParameterType));
                        sb.Append(" ");
                        sb.Append(param.Name);
                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append(")\n\t\t\t => ");
                    sb.Append("new ");
                    sb.Append(GetTypeFullName(method.ReturnType));
                    sb.Append("($dfield.");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");
                        sb.Append(param.Name);
                        if (IsTeklaType(param.ParameterType))
                            sb.Append(".GetTSObject()");
                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append("));");
                }
                else
                {
                    sb.Append(GetTypeFullName(method.ReturnType));
                    sb.Append(" ");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");
                        sb.Append(GetTypeFullName(param.ParameterType));
                        sb.Append(" ");
                        sb.Append(param.Name);
                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append(")\n\t\t\t => ");
                    sb.Append("$dfield.");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");
                        
                        sb.Append(param.Name);
                        if (IsTeklaType(param.ParameterType))
                            sb.Append(".GetTSObject()");
                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append(");");
                }

                sb.Append("\n\n");
            }

            classText = classText.Replace("$dmethods", sb.ToString());
            return classText;
        }

        private bool IsTeklaType(Type type)
        {
            return type.FullName?.StartsWith("Tekla.Structures") ?? false;
        }
        
        private string AddProperties(Type type, string classText)
        {
            var sb = new StringBuilder();

            foreach (var property in type.GetProperties())
            {
                sb.Append("\t\tpublic ");
                
                sb.Append(GetTypeFullName(property.PropertyType));

                sb.Append(" ");
                sb.Append(property.Name);
                sb.Append(" {get; set; }\n");

            }

            classText = classText.Replace("$dproperties", sb.ToString());
            return classText;
        }

        private string GetTypeFullName( Type type)
        {
            StringBuilder sb = new StringBuilder();

            if (IsTeklaType(type))
            {
                sb.Append("Dynamic.");
            }

            sb.Append(type.Namespace);
            sb.Append(".");

            if (type.IsGenericType)
            {
                sb.Append(
                    type.Name.Replace("`1", "").Replace("`2", "") + "<"
                    );

                int i = 0;
                foreach (var generictype in type.GetGenericArguments())
                {
                    if (i != 0)
                    {
                        sb.Append(", ");

                    }
                    sb.Append(type.GetGenericArguments()[0]);
                    i++;

                }

                sb.Replace("+", ".");
                sb.Append(">");
            }
            else
                sb.Append(type.Name);

            sb.Replace("&", "");

            return sb.ToString();
        }

        private string AddConstructor(Type type, string classText)
        {
            var sb = new StringBuilder();

            foreach (var property in type.GetProperties())
            {
                if (IsTeklaType(property.PropertyType))
                {
                    sb.Append("\t\t\t");
                    sb.Append("this.");
                    sb.Append(property.Name);
                    sb.Append(" = new Dynamic.");
                    sb.Append(property.PropertyType.Namespace);
                    sb.Append(".");
                    sb.Append(property.PropertyType.Name);
                    sb.Append("($dfield.");
                    sb.Append(property.Name);
                    sb.Append(");\n");
                }
                else
                {
                    sb.Append("\t\t\t");
                    sb.Append("this.");
                    sb.Append(property.Name);
                    sb.Append(" = $dfield.");
                    sb.Append(property.Name);
                    sb.Append(";\n");

                }
            }

            classText = classText.Replace("$constructor2", sb.ToString());
            return classText;
        }



        private readonly string text = @"
//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file



namespace Dynamic.$namespace
{
    public sealed class $classname $fatherClass
    {

$dproperties        

        dynamic $dfield;
        
        public $classname()
        {
            this.$dfield =  new $namespace.$classname();
        }

        public $classname(dynamic tsObject)
        {
            this.$dfield = tsObject;
$constructor2
        }


        public dynamic GetTSObject() => $dfield;

$dmethods

    }
}

            ";
    }
}
