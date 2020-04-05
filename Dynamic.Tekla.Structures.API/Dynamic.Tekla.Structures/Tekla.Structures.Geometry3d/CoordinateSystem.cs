/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class CoordinateSystem 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin"); }
			}
			set
			{
				try {
				teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisX
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.AxisX);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AxisX"); }
			}
			set
			{
				try {
				teklaObject.AxisX = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AxisX"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisY
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.AxisY);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AxisY"); }
			}
			set
			{
				try {
				teklaObject.AxisY = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AxisY"); }
			}
		}

        

        internal dynamic teklaObject;

		public CoordinateSystem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CoordinateSystem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector AxisX, Dynamic.Tekla.Structures.Geometry3d.Vector AxisY)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(AxisX);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(AxisY);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem", args);
		}





    }

    internal static class CoordinateSystem_
    {
        public static dynamic GetTSObject(CoordinateSystem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CoordinateSystem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CoordinateSystemArray_
    {
        public static dynamic GetTSObject(CoordinateSystem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CoordinateSystem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CoordinateSystem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CoordinateSystem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CoordinateSystem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
