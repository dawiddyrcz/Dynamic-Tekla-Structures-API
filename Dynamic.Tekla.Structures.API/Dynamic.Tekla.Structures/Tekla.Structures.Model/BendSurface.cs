/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BendSurface 
    {

		public System.Boolean InwardCurved
		{
			get
			{
				try {
					return teklaObject.InwardCurved;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InwardCurved"); }
			}

		}

		public Dynamic.Tekla.Structures.Geometry3d.Line IntersectionLine
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.IntersectionLine);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IntersectionLine"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.EndFaceNormal1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndFaceNormal1"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.EndFaceNormal2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndFaceNormal2"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line CenterLine
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.CenterLine);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CenterLine"); }
			}
			set
			{
				try {
				teklaObject.CenterLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CenterLine"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxis
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.RotationAxis);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxis"); }
			}
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary1
		{
			get
			{
				try {
					return teklaObject.LateralBoundary1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LateralBoundary1"); }
			}
			set
			{
				try {
					teklaObject.LateralBoundary1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LateralBoundary1"); }
			}
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary2
		{
			get
			{
				try {
					return teklaObject.LateralBoundary2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LateralBoundary2"); }
			}
			set
			{
				try {
					teklaObject.LateralBoundary2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LateralBoundary2"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.SideBoundary1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SideBoundary1"); }
			}
			set
			{
				try {
				teklaObject.SideBoundary1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SideBoundary1"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.SideBoundary2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SideBoundary2"); }
			}
			set
			{
				try {
				teklaObject.SideBoundary2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SideBoundary2"); }
			}
		}

        

        internal dynamic teklaObject;






    }

    internal static class BendSurface_
    {
        public static dynamic GetTSObject(BendSurface dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BendSurface FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BendSurface)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BendSurfaceArray_
    {
        public static dynamic GetTSObject(BendSurface[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BendSurface_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BendSurface[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BendSurface>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BendSurface_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
