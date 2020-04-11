/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PolygonWeld  : Dynamic.Tekla.Structures.Model.BaseWeld
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon", ex); }
			}
			set
			{
				try {
				teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon", ex); }
			}
		}

        

        

		public PolygonWeld()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolygonWeld");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolygonWeld(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean GetLogicalWeld(
	ref Dynamic.Tekla.Structures.Model.LogicalWeld LogicalWeld_
	)
{
	var LogicalWeld = Dynamic.Tekla.Structures.Model.LogicalWeld_.GetTSObject(LogicalWeld_);
    try
    {
        	var result = teklaObject.GetLogicalWeld(ref LogicalWeld);
	LogicalWeld_ = Dynamic.Tekla.Structures.Model.LogicalWeld_.FromTSObject(LogicalWeld);
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetLogicalWeld), ex);
    }
}






    }

    internal static class PolygonWeld_
    {
        public static dynamic GetTSObject(PolygonWeld dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolygonWeld FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PolygonWeld)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolygonWeldArray_
    {
        public static dynamic GetTSObject(PolygonWeld[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolygonWeld_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolygonWeld[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolygonWeld>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolygonWeld_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
