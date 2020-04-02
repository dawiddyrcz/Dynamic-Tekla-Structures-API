using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    internal static class TypeFullName
    {
        private static bool IsTeklaType(Type type)
        {
            return type.FullName?.StartsWith("Tekla.Structures") ?? false;
        }

        public static string GetTypeFullName_old(Type type)
        {
            StringBuilder sb = new StringBuilder();

            if (IsTeklaType(type))
            {
                sb.Append("Dynamic.");
            }

            var fullName = type.FullName;
            if (fullName.Contains(","))
            {
                fullName = fullName.Split(',')[0];
                if (type.IsGenericType && !fullName.Contains("System.Nullable"))
                {
                    fullName = fullName.Split('[')[0];
                }
            }

            string typeName = fullName.Replace("`1", "").Replace("`2", "").Replace("`3", "").Replace("`4", "").Replace("`5", "");
            typeName = typeName.Replace("[", "").Replace("]", "");

            if (type.IsGenericType && !typeName.StartsWith("System.Nullable"))
            {
                sb.Append(typeName);
                sb.Append("<");

                int i = 0;
                foreach (var generictype in type.GetGenericArguments())
                {
                    if (i != 0)
                        sb.Append(", ");
                    sb.Append(GetTypeFullName_WithDynamic(generictype));
                    i++;
                }

                sb.Append(">");
            }
            else
            {
                typeName = typeName.Replace("System.Nullable", "");
                sb.Append(typeName);
            }

            sb.Replace("&", "");
            sb.Replace("+", ".");

            return sb.ToString();
        }

        public static string GetTypeFullName_WithDynamic(Type type)
        {
            var result = GetTypeFullName(type);
            result = result.Replace("Tekla.Structures.", "Dynamic.Tekla.Structures.");
            return result;
        }

        public static string GetTypeFullName(Type type)
        {
            if (type.IsByRef)
                type = type.GetElementType();

            var result = GetCSharpRepresentation(type, true);
            return result;
        }

        private static string FullName(Type type)
        {
            if (type.Name.Contains("Dictionary"))
            {
                int a = 0;
            }
            var result = type.Name;

            var currentType = type;
            while (currentType.DeclaringType != null)
            {
                currentType = currentType.DeclaringType;
                result =  currentType.Name + "." + result;
            }

            result = type.Namespace + "." + result;
            result = result.Replace("&", "");
            return result;
        }

        //From stack overflow
        private static string GetCSharpRepresentation(Type t, bool trimArgCount)
        {
            if (t.IsGenericType)
            {
                var genericArgs = t.GetGenericArguments().ToList();

                return GetCSharpRepresentation(t, trimArgCount, genericArgs);
            }

            return FullName(t);
        }

        //From stack overflow
        private static string GetCSharpRepresentation(Type t, bool trimArgCount, List<Type> availableArguments)
        {
            if (t.IsGenericType)
            {
                string value = FullName(t);
                if (trimArgCount && value.IndexOf("`") > -1)
                {
                    value = value.Substring(0, value.IndexOf("`"));
                }

                if (t.DeclaringType != null)
                {
                    // This is a nested type, build the nesting type first
                    value = GetCSharpRepresentation(t.DeclaringType, trimArgCount, availableArguments) + "+" + value;
                }

                // Build the type arguments (if any)
                string argString = "";
                var thisTypeArgs = t.GetGenericArguments();
                for (int i = 0; i < thisTypeArgs.Length && availableArguments.Count > 0; i++)
                {
                    if (i != 0) argString += ", ";

                    argString += GetCSharpRepresentation(availableArguments[0], trimArgCount);
                    availableArguments.RemoveAt(0);
                }

                // If there are type arguments, add them with < >
                if (argString.Length > 0)
                {
                    value += "<" + argString + ">";
                }

                return value;
            }

            return FullName(t);
        }
    }
}
