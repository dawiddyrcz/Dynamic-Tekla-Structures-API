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
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Filtering
{

    public  class BooleanFilterExpression  : Dynamic.Tekla.Structures.Filtering.DataFilterExpression
    {

        

        

		internal BooleanFilterExpression() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BooleanFilterExpression(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class BooleanFilterExpression_
    {
        public static dynamic GetTSObject(BooleanFilterExpression dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BooleanFilterExpression FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BooleanFilterExpressionArray_
    {
        public static dynamic GetTSObject(BooleanFilterExpression[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BooleanFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BooleanFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BooleanFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BooleanFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
