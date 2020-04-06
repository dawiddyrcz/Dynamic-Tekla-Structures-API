/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class CurvedDimensionSetBase  : Dynamic.Tekla.Structures.Drawing.DimensionSetBase
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint1", ex); }
			}
			set
			{
				try {
				teklaObject.ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint1", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint2", ex); }
			}
			set
			{
				try {
				teklaObject.ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint2", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint3);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint3", ex); }
			}
			set
			{
				try {
				teklaObject.ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint3", ex); }
			}
		}

		public System.Double Distance
		{
			get
			{
				try {
					return teklaObject.Distance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance", ex); }
			}
			set
			{
				try {
					teklaObject.Distance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.DimensionPoints);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionPoints", ex); }
			}
			set
			{
				try {
				teklaObject.DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionPoints", ex); }
			}
		}

        

        





    public abstract class CurvedDimensionSetBaseAttributes  : Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes
    {

        

        






    }

    internal static class CurvedDimensionSetBaseAttributes_
    {
        public static dynamic GetTSObject(CurvedDimensionSetBaseAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetBaseAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase.CurvedDimensionSetBaseAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionSetBaseAttributesArray_
    {
        public static dynamic GetTSObject(CurvedDimensionSetBaseAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetBaseAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetBaseAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedDimensionSetBaseAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionSetBaseAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class CurvedDimensionSetBase_
    {
        public static dynamic GetTSObject(CurvedDimensionSetBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionSetBaseArray_
    {
        public static dynamic GetTSObject(CurvedDimensionSetBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedDimensionSetBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionSetBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
