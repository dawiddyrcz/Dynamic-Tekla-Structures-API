/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
using System;
using System.IO;
using TSM = Dynamic.Tekla.Structures.Model;
using Dynamic.Tekla.Structures.Filtering;
using Dynamic.Tekla.Structures.Filtering.Categories;

namespace Examples
{
    public class Create_Filter_And_Get_Objects_From_Model : ExampleBase
    {
        private readonly string filterName = "--filter-created-by-api";

        public override void Run()
        {
            Console.WriteLine("Creating selection filter: " + filterName);
            CreateSelectionFilter();

            var model = new TSM.Model();

            Console.WriteLine("Trying to get objects form model ...");
            var filteredObjects = model.GetModelObjectSelector().GetObjectsByFilterName(filterName);

            Console.WriteLine($"{nameof(filteredObjects)}.GetSize() = {filteredObjects.GetSize()}");

            int i = 0;
            while (filteredObjects.MoveNext())
            {
                Console.WriteLine("Filtered object id: " + filteredObjects.Current.Identifier.ID);
                i++;
                if (i == 50) break;
            }

            Console.WriteLine("End of test");
        }

        //Example from official documentation: developer.tekla.com
        public void CreateSelectionFilter()
        {
            // Creates the filter expressions
            PartFilterExpressions.Name PartName = new PartFilterExpressions.Name();
            StringConstantFilterExpression Beam1 = new StringConstantFilterExpression("BEAM1");
            StringConstantFilterExpression Beam2 = new StringConstantFilterExpression("BEAM2");
            StringConstantFilterExpression Beam3 = new StringConstantFilterExpression("BEAM3");

            // Creates a custom part filter
            PartFilterExpressions.CustomString PartComment = new PartFilterExpressions.CustomString("Comment");
            StringConstantFilterExpression Test = new StringConstantFilterExpression("test");

            // Creates the binary filter expressions
            BinaryFilterExpression Expression1 = new BinaryFilterExpression(PartName, StringOperatorType.IS_EQUAL, Beam1);
            BinaryFilterExpression Expression2 = new BinaryFilterExpression(PartName, StringOperatorType.IS_EQUAL, Beam2);
            BinaryFilterExpression Expression3 = new BinaryFilterExpression(PartName, StringOperatorType.IS_EQUAL, Beam3);
            BinaryFilterExpression Expression4 = new BinaryFilterExpression(PartComment, StringOperatorType.STARTS_WITH, Test);

            // Creates the binary filter expression collection
            BinaryFilterExpressionCollection ExpressionCollection = new BinaryFilterExpressionCollection();
            ExpressionCollection.Add(new BinaryFilterExpressionItem(Expression1, BinaryFilterOperatorType.BOOLEAN_OR));
            ExpressionCollection.Add(new BinaryFilterExpressionItem(Expression2, BinaryFilterOperatorType.BOOLEAN_OR));
            ExpressionCollection.Add(new BinaryFilterExpressionItem(Expression3, BinaryFilterOperatorType.BOOLEAN_OR));
            ExpressionCollection.Add(new BinaryFilterExpressionItem(Expression4));

            var modelPath = new TSM.Model().GetInfo().ModelPath;
            string AttributesPath = Path.Combine(modelPath, "attributes");
            string FilterName = Path.Combine(AttributesPath, this.filterName);

            Filter Filter = new Filter(ExpressionCollection);
            // Generates the filter file
            Filter.CreateFile(FilterExpressionFileType.OBJECT_GROUP_SELECTION, FilterName);
        }

    }
}
