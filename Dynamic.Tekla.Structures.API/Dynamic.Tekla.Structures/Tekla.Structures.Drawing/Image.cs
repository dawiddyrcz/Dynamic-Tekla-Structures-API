/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Image  : Dynamic.Tekla.Structures.Drawing.EmbeddedObjectBase
    {

        

        

		public Image() {}
		public Image(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Image", args);
		}
		public Image(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName, Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes attributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			args[3] = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Image", args);
		}
		public Image(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, Dynamic.Tekla.Structures.Drawing.Size frameSize, System.String fileName)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(frameSize);
			args[3] = fileName;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Image", args);
		}
		public Image(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, Dynamic.Tekla.Structures.Drawing.Size frameSize, System.String fileName, Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(frameSize);
			args[3] = fileName;
			args[4] = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Image", args);
		}





    }

    internal static class Image_
    {
        public static dynamic GetTSObject(Image dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Image FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Image)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
