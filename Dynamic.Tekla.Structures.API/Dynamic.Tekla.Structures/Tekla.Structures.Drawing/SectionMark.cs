/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class SectionMark  : Dynamic.Tekla.Structures.Drawing.SectionMarkBase
    {

        

        

		public SectionMark() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SectionMark(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SectionMark(Dynamic.Tekla.Structures.Drawing.View view, Dynamic.Tekla.Structures.Geometry3d.Point leftPoint, Dynamic.Tekla.Structures.Geometry3d.Point rightPoint)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(leftPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rightPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMark", args);
		}
		public SectionMark(Dynamic.Tekla.Structures.Drawing.View view, Dynamic.Tekla.Structures.Geometry3d.Point leftPoint, Dynamic.Tekla.Structures.Geometry3d.Point rightPoint, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes sectionMarkAttributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(leftPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rightPoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes_.GetTSObject(sectionMarkAttributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMark", args);
		}





    }

    internal static class SectionMark_
    {
        public static dynamic GetTSObject(SectionMark dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SectionMark FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SectionMark)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionMarkArray_
    {
        public static dynamic GetTSObject(SectionMark[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionMark_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionMark[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<SectionMark>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionMark_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
