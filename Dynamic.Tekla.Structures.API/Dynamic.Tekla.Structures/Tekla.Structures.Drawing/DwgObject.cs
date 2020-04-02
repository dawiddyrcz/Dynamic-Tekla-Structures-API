/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DwgObject  : Dynamic.Tekla.Structures.Drawing.EmbeddedObjectBase
    {

        

        

		internal DwgObject() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DwgObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DwgObject(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DwgObject", args);
		}
		public DwgObject(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName, Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes attributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			args[3] = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DwgObject", args);
		}
		public DwgObject(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, Dynamic.Tekla.Structures.Drawing.Size frameSize, System.String fileName)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(frameSize);
			args[3] = fileName;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DwgObject", args);
		}
		public DwgObject(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, Dynamic.Tekla.Structures.Drawing.Size frameSize, System.String fileName, Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(frameSize);
			args[3] = fileName;
			args[4] = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DwgObject", args);
		}





    }

    internal static class DwgObject_
    {
        public static dynamic GetTSObject(DwgObject dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DwgObject FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DwgObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DwgObjectArray_
    {
        public static dynamic GetTSObject(DwgObject[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DwgObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DwgObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DwgObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DwgObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
