/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeGenerator.Tests
{
    [TestFixture]
    public class PropertyGeneratorTests
    {
        [Test]
        public void NonStatic_String()
        {
            var property = typeof(Tekla.Structures.Model.Beam).GetProperty("Name");

            var code = SinglePropertyGenerator.GetCode(property);
            Console.WriteLine(code);
        }

        [Test]
        public void NonStatic_TSM_NumberingSeries()
        {
            var property = typeof(Tekla.Structures.Model.Beam).GetProperty("AssemblyNumber");

            var code = SinglePropertyGenerator.GetCode(property);
            Console.WriteLine(code);
        }

        [Test]
        public void NonStatic_Bool()
        {
            var property = typeof(Tekla.Structures.Model.ModelObjectEnumerator).GetProperty("SelectInstances");

            var code = SinglePropertyGenerator.GetCode(property);
            Console.WriteLine(code);
        }

        [Test]
        public void Static_Bool()
        {
            var property = typeof(Tekla.Structures.Model.ModelObjectEnumerator).GetProperty("AutoFetch");

            var code = SinglePropertyGenerator.GetCode(property);
            Console.WriteLine(code);
        }
    }
}
