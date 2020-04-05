/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class CurvedDimensionBase  : Dynamic.Tekla.Structures.Drawing.DimensionBase
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint1"); }
			}
			set
			{
				try {
				teklaObject.ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint1"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint2"); }
			}
			set
			{
				try {
				teklaObject.ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint2"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint3);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint3"); }
			}
			set
			{
				try {
				teklaObject.ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint3"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
			set
			{
				try {
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

		public System.Double Distance
		{
			get
			{
				try {
					return teklaObject.Distance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance"); }
			}
			set
			{
				try {
					teklaObject.Distance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase.CurvedDimensionSetBaseAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase.CurvedDimensionSetBaseAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase.CurvedDimensionSetBaseAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
		}

        

        






    }

    internal static class CurvedDimensionBase_
    {
        public static dynamic GetTSObject(CurvedDimensionBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedDimensionBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionBaseArray_
    {
        public static dynamic GetTSObject(CurvedDimensionBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedDimensionBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
