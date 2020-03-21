using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public static class TypeFullName
    {
        private static bool IsTeklaType(Type type)
        {
            return type.FullName?.StartsWith("Tekla.Structures") ?? false;
        }
        
        public static string GetTypeFullName(Type type)
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
                    sb.Append(GetTypeFullName(generictype));
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
    }
}
