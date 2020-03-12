using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class ClassGenerator
    {
        public ClassGenerator()
        {

        }

        public void SaveToFile(Type type)
        {
            string fileName = type.Name + ".cs";

            string classText = text;

            text = text.Replace("$classname", type.Name);
            text = text.Replace("$dproperty", type.Name.ToLower());
            text = text.Replace("$namespace", type.Namespace);

            File.WriteAllText(fileName, text);
        }


        private string text = @"

using System;

namespace Dynamic.$namespace
{
    public class $classname
    {
        
        dynamic $dproperty;
        
        public $classname()
        {
            this.$dproperty = new $namespace.$classname();
        }

    }
}




            ";
    }
}
