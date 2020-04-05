/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class TransformationPlane 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Matrix TransformationMatrixToGlobal
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.TransformationMatrixToGlobal);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TransformationMatrixToGlobal"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Matrix TransformationMatrixToLocal
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.TransformationMatrixToLocal);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TransformationMatrixToLocal"); }
			}
		}

        

        internal dynamic teklaObject;

		public TransformationPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TransformationPlane");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TransformationPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TransformationPlane(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordinateSystem)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordinateSystem);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TransformationPlane", args);
		}
		public TransformationPlane(Dynamic.Tekla.Structures.Geometry3d.Point Origo, Dynamic.Tekla.Structures.Geometry3d.Vector Xvector, Dynamic.Tekla.Structures.Geometry3d.Vector Yvector)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origo);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Xvector);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Yvector);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TransformationPlane", args);
		}





    }

    internal static class TransformationPlane_
    {
        public static dynamic GetTSObject(TransformationPlane dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TransformationPlane FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.TransformationPlane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TransformationPlaneArray_
    {
        public static dynamic GetTSObject(TransformationPlane[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TransformationPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TransformationPlane[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TransformationPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TransformationPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
