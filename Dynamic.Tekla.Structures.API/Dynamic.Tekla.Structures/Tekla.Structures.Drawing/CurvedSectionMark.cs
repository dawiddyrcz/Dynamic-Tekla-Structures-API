/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CurvedSectionMark  : Dynamic.Tekla.Structures.Drawing.SectionMarkBase
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point MiddlePoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.MiddlePoint);
			set { teklaObject.MiddlePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public CurvedSectionMark() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class CurvedSectionMark_
    {
        public static dynamic GetTSObject(CurvedSectionMark dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CurvedSectionMark FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedSectionMark)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedSectionMarkArray_
    {
        public static dynamic GetTSObject(CurvedSectionMark[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedSectionMark_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedSectionMark[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CurvedSectionMark>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedSectionMark_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
