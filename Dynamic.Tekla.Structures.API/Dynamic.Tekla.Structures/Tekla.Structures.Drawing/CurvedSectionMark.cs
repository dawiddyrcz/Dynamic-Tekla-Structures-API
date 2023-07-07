/*Copyright (C) Yury Isachenkov 2023
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

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CurvedSectionMark  : Dynamic.Tekla.Structures.Drawing.SectionMarkBase
    {


        public Dynamic.Tekla.Structures.Geometry3d.Point MiddlePoint
        {
            get
            {
                try
                {
                var value = teklaObject.MiddlePoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MiddlePoint), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.MiddlePoint = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MiddlePoint), ex); 
                }
            }
        }
        

        

		internal CurvedSectionMark() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CurvedSectionMark(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class CurvedSectionMark_
    {
        public static dynamic GetTSObject(CurvedSectionMark dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedSectionMark FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedSectionMark)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedSectionMarkArray_
    {
        public static dynamic GetTSObject(CurvedSectionMark[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedSectionMark_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedSectionMark[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedSectionMark>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedSectionMark_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
