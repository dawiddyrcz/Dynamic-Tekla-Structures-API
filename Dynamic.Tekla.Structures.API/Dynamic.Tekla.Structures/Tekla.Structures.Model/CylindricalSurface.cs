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

namespace Dynamic.Tekla.Structures.Model
{

    public  class CylindricalSurface  : Dynamic.Tekla.Structures.Model.BendSurface
    {


        public System.Double Radius
        {
            get
            {
                try
                {
                return teklaObject.Radius;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radius), ex); 
                }
            }
            
        }
        

        

		internal CylindricalSurface() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CylindricalSurface(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary1, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary2);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}
		public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = lateralBoundary1;
			args[3] = lateralBoundary2;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}
		public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Arc baseArc, System.Double height)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(baseArc);
			args[1] = height;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}
		public CylindricalSurface(System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2, Dynamic.Tekla.Structures.Geometry3d.Line centerLine, Dynamic.Tekla.Structures.Geometry3d.Vector rotationAxis)
		{
			var args = new object[4];
			args[0] = lateralBoundary1;
			args[1] = lateralBoundary2;
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(centerLine);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(rotationAxis);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}





    }

    internal static class CylindricalSurface_
    {
        public static dynamic GetTSObject(CylindricalSurface dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CylindricalSurface FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.CylindricalSurface)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CylindricalSurfaceArray_
    {
        public static dynamic GetTSObject(CylindricalSurface[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CylindricalSurface_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CylindricalSurface[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CylindricalSurface>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CylindricalSurface_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
