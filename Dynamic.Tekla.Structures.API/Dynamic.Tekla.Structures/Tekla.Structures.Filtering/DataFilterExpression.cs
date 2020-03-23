/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public abstract class DataFilterExpression  : Dynamic.Tekla.Structures.Filtering.Expression
    {

        

        






    }

    internal static class DataFilterExpression_
    {
        public static dynamic GetTSObject(DataFilterExpression dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DataFilterExpression FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.DataFilterExpression)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DataFilterExpressionArray_
    {
        public static dynamic GetTSObject(DataFilterExpression[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DataFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DataFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<DataFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DataFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
