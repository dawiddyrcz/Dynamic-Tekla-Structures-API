/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class BaseLinePlacing  : Dynamic.Tekla.Structures.Drawing.PlacingBase
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint", ex); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint", ex); }
			}
			set
			{
				try {
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint", ex); }
			}
		}

        

        

		internal BaseLinePlacing() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BaseLinePlacing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public BaseLinePlacing(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.BaseLinePlacing", args);
		}





    }

    internal static class BaseLinePlacing_
    {
        public static dynamic GetTSObject(BaseLinePlacing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BaseLinePlacing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.BaseLinePlacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BaseLinePlacingArray_
    {
        public static dynamic GetTSObject(BaseLinePlacing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BaseLinePlacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BaseLinePlacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BaseLinePlacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BaseLinePlacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
