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


        private readonly string text = @"/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.$namespace
{
$typeContent
}
    
";
    }
}
