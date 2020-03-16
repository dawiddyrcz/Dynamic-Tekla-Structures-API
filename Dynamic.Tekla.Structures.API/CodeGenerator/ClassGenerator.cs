using System;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public class ClassGenerator
    {
        public ClassGenerator() { }

        public string GetTextFromType(Type type)
        {
            if (!type.IsClass) return string.Empty;

            string outputText = String.Copy(text);
            
            outputText = AddProperties(type, outputText);
            outputText = AddMethods(type, outputText);
            outputText = AddConstructor(type, outputText);

            
            outputText = outputText.Replace("$classname", type.Name);
            
            if (type.Name.ToLower().Equals("object", StringComparison.InvariantCulture))
                outputText = outputText.Replace("$dfield", "@object");
            else
                outputText = outputText.Replace("$dfield", type.Name.ToLower());
            
            //TODO father class
            outputText = outputText.Replace("$fatherClass", "");

            var nestedTypeGenerator = new TypeGenerator();
            var nestedTypeText = new StringBuilder(1000);
            var nestedTypes = type.GetNestedTypes()
                ;

            foreach (var nestedType in nestedTypes)
            {
                nestedTypeText.AppendLine(nestedTypeGenerator.GetTextFromType(nestedType));
            }

            outputText = outputText.Replace("$nestedTypes", nestedTypeText.ToString());
            
            return outputText;
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
                    sb.Append(GetTypeFullName(method.ReturnType).Replace("System.Void", "void"));
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
                    sb.Append(GetTypeFullName(method.ReturnType).Replace("System.Void", "void"));
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
                if (IsTeklaType(property.PropertyType))
                {
                    if (property.PropertyType.IsEnum)
                    {
                        sb.Append("\t\tpublic ");
                        sb.Append(GetTypeFullName(property.PropertyType));
                        sb.Append(" ");
                        sb.Append(property.Name);
                        sb.Append("\n\t\t{" +
                            "\n\t\t\tget => " + GetTypeFullName(property.PropertyType) + "_.FromTSObject($dfield." +
                            "" + property.Name + ");" +
                            "\n\t\t\tset { $dfield." + property.Name + " = " + GetTypeFullName(property.PropertyType) + "_.FromTSObject(value); }" +
                            "\n\t\t}\n\n");
                    }
                    else
                    {
                        sb.Append("\t\tpublic ");
                        sb.Append(GetTypeFullName(property.PropertyType));
                        sb.Append(" ");
                        sb.Append(property.Name);
                        sb.Append("\n\t\t{" +
                            "\n\t\t\tget => new " + GetTypeFullName(property.PropertyType) + "($dfield." +
                            "" + property.Name + ".GetTSObject());" +
                            "\n\t\t\tset { $dfield." + property.Name + " = value.GetTSObject(); }" +
                            "\n\t\t}\n\n");
                    }
                }
                else
                {
                    sb.Append("\t\tpublic ");
                    sb.Append(GetTypeFullName(property.PropertyType));
                    sb.Append(" ");
                    sb.Append(property.Name);
                    sb.Append("\n\t\t{" +
                        "\n\t\t\tget => $dfield." + property.Name + ";" +
                        "\n\t\t\tset { $dfield." + property.Name + " = value; }" +
                        "\n\t\t}\n\n");
                }

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

            string typeName = type.Name.Replace("`1", "").Replace("`2", "").Replace("`3", "").Replace("`4", "").Replace("`5", "");
            typeName = typeName.Replace("[", "").Replace("]", "");

            if (type.IsGenericType)
            {
                sb.Append(typeName);
                sb.Append("<");

                int i = 0;
                foreach (var generictype in type.GetGenericArguments())
                {
                    if (i != 0)
                        sb.Append(", ");
                    sb.Append(GetTypeFullName(generictype));
                    i++;
                }

                sb.Replace("+", ".");
                sb.Append(">");
            }
            else
                sb.Append(typeName);

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
                    sb.Append(" = ");

                    if (property.PropertyType.IsEnum)
                    {
                        sb.Append("Dynamic.");
                        sb.Append(property.PropertyType.Namespace);
                        sb.Append(".");
                        sb.Append(property.PropertyType.Name);
                        sb.Append("_.FromTSObject($dfield.");
                        sb.Append(property.Name);
                        sb.Append(");\n");
                    }
                    else
                    {
                        sb.Append("new Dynamic.");
                        sb.Append(property.PropertyType.Namespace);
                        sb.Append(".");
                        sb.Append(property.PropertyType.Name);
                        sb.Append("($dfield.");
                        sb.Append(property.Name);
                        sb.Append(");\n");
                    }
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

$nestedTypes

    }
";
    }
}
