/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using NUnit.Framework;
using System;
using System.Collections.Generic;
using Tekla.Structures.Model;

namespace CodeGenerator.Tests
{
    public class TypeNameTests
    {
        public TypeNameTests()
        {

        }

        [Test]
        public void GenericList()
        {
            var type = typeof(List<string>);
            Console.WriteLine(type.ToString());
        }

        [Test]
        public void Dictionary()
        {
            var type = typeof(Dictionary<string, string>);
            Console.WriteLine(type.ToString());

            var type2 = typeof(Dictionary<string, Beam>);
            Console.WriteLine(type2.ToString());
        }

        [Test]
        public void TSM_Beam()
        {
            var type = typeof(Tekla.Structures.Model.Beam);
            Console.WriteLine(type.ToString());
        }

        [Test]
        public void TSM_Beam_BeamTypeEnum()
        {
            var type = typeof(Tekla.Structures.Model.Beam.BeamTypeEnum);
            Console.WriteLine(type.ToString());
        }

        [Test]
        public void Nullable()
        {
            var type = typeof(DateTime?);
            Console.WriteLine(type.ToString());

            var type2 = typeof(System.Nullable<DateTime>);
            Console.WriteLine(type2.ToString());

            Console.WriteLine(TypeFullName.GetTypeFullName2(type2));
        }
    }
}
