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
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint1);
			set { teklaObject.ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint2);
			set { teklaObject.ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint3);
			set { teklaObject.ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double Distance
		{
			get => teklaObject.Distance;
			set { teklaObject.Distance = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints
		{
			get => Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.DimensionPoints);
			set { teklaObject.DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value); }
		}

        

        


		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}




    public abstract class CurvedDimensionSetBaseAttributes  : Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes
    {

        

        






    }

    internal static class CurvedDimensionSetBaseAttributes_
    {
        public static dynamic GetTSObject(CurvedDimensionSetBaseAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetBaseAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase.CurvedDimensionSetBaseAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionSetBaseAttributesArray_
    {
        public static dynamic GetTSObject(CurvedDimensionSetBaseAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetBaseAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetBaseAttributes[] FromTSObject(dynamic[] tsArray)
        {
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
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetBase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionSetBaseArray_
    {
        public static dynamic GetTSObject(CurvedDimensionSetBase[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetBase[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CurvedDimensionSetBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionSetBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
