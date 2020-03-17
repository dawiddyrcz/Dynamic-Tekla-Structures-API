﻿using System;
using System.IO;

namespace CodeGenerator
{
    public class FileGenerator
    {
        public FileGenerator() { }

        public void SaveToFile(Type type)
        {
            return;

            var generator = new TypeGenerator();
            string outputText = String.Copy(text);

            string fileName = Path.Combine(Path.GetDirectoryName(Program.GetProjectDirectory())
                  , "Dynamic.Tekla.Structures",
                  type.Name + ".cs");

            outputText = outputText.Replace("$typeContent", generator.GetTextFromType(type));
            outputText = outputText.Replace("$namespace", type.Namespace);
            
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
