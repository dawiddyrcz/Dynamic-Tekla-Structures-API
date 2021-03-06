﻿/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
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
    public class MethodParameterTests
    {
        public MethodParameterTests()
        {

        }

        [Test]
        public void WhenNullInConstructor_ShouldThrow_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var param = new MethodParameter(null);
            });
        }

        [Test]
        public void For_StringType()
        {
            var parameterInfo = typeof(Tekla.Structures.Model.Model)
                .GetMethod("GetIdentifierByGUID")
                .GetParameters().FirstOrDefault();

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("System.String guid", methodParameter.MethodDeclaration);
            Assert.AreEqual(string.Empty, methodParameter.ConverterToTS);
            Assert.AreEqual("guid", methodParameter.ParameterName);
        }

        [Test]
        public void For_TeklaType()
        {
            var parameterInfo = typeof(Tekla.Structures.Model.Operations.Operation)
                .GetMethods().Where(m => m.Name.Equals("Combine", StringComparison.InvariantCulture)).FirstOrDefault()
                .GetParameters().FirstOrDefault();

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("Dynamic.Tekla.Structures.Model.Beam ObjectToCombineTo_", methodParameter.MethodDeclaration);
            Assert.AreEqual("var ObjectToCombineTo = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToCombineTo_);", methodParameter.ConverterToTS);
            Assert.AreEqual("ObjectToCombineTo", methodParameter.ParameterName);
            Assert.AreEqual("ObjectToCombineTo_ = Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(ObjectToCombineTo);", methodParameter.ConverterFromTS);

        }

        [Test]
        public void For_ArrayofType()
        {
            var parameterInfo = typeof(Tekla.Structures.Model.ModelObjectSelector)
                .GetMethods()
                .FirstOrDefault(m => m.Name.Equals("GetAllObjectsWithType", StringComparison.InvariantCulture)
                && m.GetParameters().FirstOrDefault().ParameterType.IsArray)
                .GetParameters().FirstOrDefault();

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("System.Type[] TypeFilter_", methodParameter.MethodDeclaration);
            Assert.AreEqual("var TypeFilter = TypeConverter.ToTSObjects(TypeFilter_);", methodParameter.ConverterToTS);
            Assert.AreEqual("TypeFilter", methodParameter.ParameterName);
            Assert.AreEqual("TypeFilter_ = TypeConverter.FromTSObject(TypeFilter);", methodParameter.ConverterFromTS);

        }

        [Test]
        public void For_ArrayList()
        {
            var parameterInfo = typeof(Tekla.Structures.Model.Assembly)
               .GetMethods()
               .FirstOrDefault(m => m.Name.Equals("Add", StringComparison.InvariantCulture)
               && m.GetParameters().FirstOrDefault().ParameterType.IsAssignableFrom(typeof(System.Collections.ArrayList)))
               .GetParameters().FirstOrDefault();

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("System.Collections.ArrayList Assemblables_", methodParameter.MethodDeclaration);
            Assert.AreEqual("var Assemblables = ArrayListConverter.ToTSObjects(Assemblables_);", methodParameter.ConverterToTS);
            Assert.AreEqual("Assemblables", methodParameter.ParameterName);
            Assert.AreEqual("Assemblables_ = ArrayListConverter.FromTSObjects(Assemblables);", methodParameter.ConverterFromTS);

        }

        [Test]
        public void For_Type()
        {
            var parameterInfo = typeof(Tekla.Structures.Drawing.ViewBase)
               .GetMethods()
               .FirstOrDefault(m => m.Name.Equals("GetAllObjects", StringComparison.InvariantCulture)
               && m.GetParameters().Length > 0
               && m.GetParameters().FirstOrDefault().ParameterType.IsAssignableFrom(typeof(System.Type)))
               .GetParameters().FirstOrDefault();

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("System.Type Type_", methodParameter.MethodDeclaration);
            Assert.AreEqual("var Type = TypeConverter.ToTSObjects(Type_);", methodParameter.ConverterToTS);
            Assert.AreEqual("Type", methodParameter.ParameterName);
            Assert.AreEqual("Type_ = TypeConverter.FromTSObject(Type);", methodParameter.ConverterFromTS);

        }

        [Test]
        public void For_List()
        {
            var parameterInfo = typeof(Tekla.Structures.Drawing.DatabaseObject)
               .GetMethods()
               .FirstOrDefault(m => m.Name.Equals("GetIntegerUserProperties", StringComparison.InvariantCulture)
               && m.GetParameters().Length > 1)
               .GetParameters().FirstOrDefault();

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("System.Collections.Generic.List<System.String> names", methodParameter.MethodDeclaration);
            Assert.AreEqual(string.Empty, methodParameter.ConverterToTS);
            Assert.AreEqual("names", methodParameter.ParameterName);
            Assert.AreEqual(string.Empty, methodParameter.ConverterFromTS);

        }

        [Test]
        public void For_Out_Phase()
        {
            var parameterInfo = typeof(Tekla.Structures.Model.Beam)
               .GetMethods()
               .FirstOrDefault(m => m.Name.Equals("GetPhase", StringComparison.InvariantCulture)
               && m.GetParameters().Length > 0)
               .GetParameters().FirstOrDefault();

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("out Dynamic.Tekla.Structures.Model.Phase phase_", methodParameter.MethodDeclaration);
            Assert.AreEqual("var phase = Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(null);", methodParameter.ConverterToTS);
            Assert.AreEqual("phase", methodParameter.ParameterName);
            Assert.AreEqual("phase_ = Dynamic.Tekla.Structures.Model.Phase_.FromTSObject(phase);", methodParameter.ConverterFromTS);

        }

        [Test]
        public void For_Ref_String()
        {
            var parameterInfo = typeof(Tekla.Structures.Model.ModelObject)
               .GetMethods()
               .FirstOrDefault(m => m.Name.Equals("GetReportProperty", StringComparison.InvariantCulture)
               && m.GetParameters().Length > 1)
               .GetParameters().FirstOrDefault(p => p.ParameterType.IsByRef);

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("ref System.String value", methodParameter.MethodDeclaration);
            Assert.AreEqual(string.Empty, methodParameter.ConverterToTS);
            Assert.AreEqual("value", methodParameter.ParameterName);
            Assert.AreEqual(string.Empty, methodParameter.ConverterFromTS);

        }

        [Test]
        public void For_Params_Int()
        {
            var parameterInfo = typeof(Tekla.Structures.MacroBuilder)
               .GetMethods()
               .FirstOrDefault(m => m.Name.Equals("TableSelect", StringComparison.InvariantCulture)
               && m.GetParameters().Length > 1)
               .GetParameters().FirstOrDefault(p => p.GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0);

            var methodParameter = new MethodParameter(parameterInfo);

            Assert.AreEqual("params System.Int32[] items", methodParameter.MethodDeclaration);
            Assert.AreEqual(string.Empty, methodParameter.ConverterToTS);
            Assert.AreEqual("items", methodParameter.ParameterName);
            Assert.AreEqual(string.Empty, methodParameter.ConverterFromTS);

        }
    }
}
