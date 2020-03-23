/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public abstract class FilterExpression  : Dynamic.Tekla.Structures.Filtering.Expression
    {

		public System.Boolean IsEnable
		{
			get => teklaObject.IsEnable;
			set { teklaObject.IsEnable = value; }
		}

        

        






    }

    internal static class FilterExpression_
    {
        public static dynamic GetTSObject(FilterExpression dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FilterExpression FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.FilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FilterExpressionArray_
    {
        public static dynamic GetTSObject(FilterExpression[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<FilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
