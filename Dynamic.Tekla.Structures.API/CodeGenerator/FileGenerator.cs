﻿using System;
using System.IO;

namespace CodeGenerator
{
    public class FileGenerator
    {
        public FileGenerator() { }

        public void SaveToFile(Type type)
        {
           // return;
           if (type.Name.Equals("ModificationInfo"))
            {
                int a = 1;
            }

            var generator = new TypeGenerator();
            string outputText = String.Copy(text);

            string fileName = Path.Combine(Path.GetDirectoryName(Program.GetProjectDirectory())
                  , "Dynamic.Tekla.Structures", type.Namespace,
                  type.Name + ".cs");

            outputText = outputText.Replace("$typeContent", generator.GetTextFromType(type));
            outputText = outputText.Replace("$namespace", type.Namespace);

            if (!Directory.Exists(Path.GetDirectoryName(fileName)))
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));
            File.WriteAllText(fileName, outputText);
        }


        private readonly string text = @"//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.$namespace
{
$typeContent
}
    
";
    }
}