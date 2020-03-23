/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Tekla.Structures.Model;

namespace CodeGenerator.Tests
{
    public class TypeNameTests
    {
        [Test]
        public void GenericList()
        {
            var type = typeof(List<string>);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("System.Collections.Generic.List<System.String>", result);
        }

        [Test]
        public void Dictionary()
        {
            var type = typeof(Dictionary<string, string>);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("System.Collections.Generic.Dictionary<System.String, System.String>", result);
        }

        [Test]
        public void Dictionary2()
        {
            var type = typeof(Dictionary<string, Beam.BeamTypeEnum>);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("System.Collections.Generic.Dictionary<System.String, Tekla.Structures.Model.Beam.BeamTypeEnum>", result);
        }

        [Test]
        public void TSM_Beam()
        {
            var type = typeof(Tekla.Structures.Model.Beam);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("Tekla.Structures.Model.Beam", result);
        }

        [Test]
        public void TSM_Beam_BeamTypeEnum()
        {
            var type = typeof(Tekla.Structures.Model.Beam.BeamTypeEnum);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("Tekla.Structures.Model.Beam.BeamTypeEnum", result);
        }

        [Test]
        public void Int32()
        {
            var type = typeof(int[]);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("System.Int32[]", result);
        }


        [Test]
        public void Dictionary3()
        {
            var type = typeof(Dictionary<string, Dictionary<string, int[]>>);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32[]>>", result);
        }

        [Test]
        public void Nullable1()
        {
            var type = typeof(DateTime?);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("System.Nullable<System.DateTime>", result);
        }

        [Test]
        public void Nullable2()
        {
            var type = typeof(System.Nullable<DateTime>);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("System.Nullable<System.DateTime>", result);
        }

        [Test]
        public void Dictionary_In_DatabaseObject()
        {
            var method = typeof(Tekla.Structures.Drawing.DatabaseObject).GetMethods()
                .Where(m => m.Name.Equals("GetStringUserProperties", StringComparison.InvariantCulture) 
                && m.GetParameters().Count().Equals(1)).FirstOrDefault();
            Assert.NotNull(method);

            var param = method.GetParameters().FirstOrDefault();

            var result = TypeFullName.GetTypeFullName(param.ParameterType);
            Console.WriteLine(result);
            Assert.AreEqual("System.Collections.Generic.Dictionary<System.String, System.String>", result);
        }

        [Test]
        public void DetailMark_DetailMarkAttributes()
        {
            var type = typeof(Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape);
            Console.WriteLine(type.ToString());

            var result = TypeFullName.GetTypeFullName(type);
            Console.WriteLine("Result:\t" + result);
            Assert.AreEqual("Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape", result);
        }

    }
}
