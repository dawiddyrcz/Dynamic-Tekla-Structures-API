/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Tests
{
    [TestFixture]
    public class MethodGeneratorTests
    {
        [Test]
        public void Solid_Intersect()
        {
            var methodInfo = typeof(Tekla.Structures.Model.Solid).GetMethods()
                .Where(m => m.Name.Equals("Intersect", StringComparison.InvariantCulture) && m.GetParameters().Length >2)
                .FirstOrDefault();

            var methodCode = MethodGeneratorSingle.GenerateCode(methodInfo);
            Console.WriteLine(methodCode);
        }

        [Test]
        public void ModelObject_GetIntegerReportProperties()
        {
            var methodInfo = typeof(Tekla.Structures.Model.ModelObject).GetMethods()
                .Where(m => m.Name.Equals("GetIntegerReportProperties", StringComparison.InvariantCulture) && m.GetParameters().Length > 1)
                .FirstOrDefault();

            var methodCode = MethodGeneratorSingle.GenerateCode(methodInfo);
            Console.WriteLine(methodCode);
        }
    }
}
