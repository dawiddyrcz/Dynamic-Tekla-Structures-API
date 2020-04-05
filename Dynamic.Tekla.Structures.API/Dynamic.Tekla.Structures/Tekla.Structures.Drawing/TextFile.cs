/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class TextFile  : Dynamic.Tekla.Structures.Drawing.EmbeddedObjectBase
    {

		public Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes_.GetTSObject(value); }
		}

        

        

		internal TextFile() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TextFile(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TextFile(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName, Dynamic.Tekla.Structures.Drawing.Size size)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			args[3] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(size);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextFile", args);
		}
		public TextFile(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName, Dynamic.Tekla.Structures.Drawing.Size size, Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			args[3] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(size);
			args[4] = Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextFile", args);
		}
		public TextFile(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextFile", args);
		}
		public TextFile(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String fileName, Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes attributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = fileName;
			args[3] = Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextFile", args);
		}




    public  class TextFileAttributes  : Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
			set { teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes LineType
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.LineType);
			set { teklaObject.LineType = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ScalingOptions Scaling
		{
			get => Dynamic.Tekla.Structures.Drawing.ScalingOptions_.FromTSObject(teklaObject.Scaling);
			set { teklaObject.Scaling = Dynamic.Tekla.Structures.Drawing.ScalingOptions_.GetTSObject(value); }
		}

        

        

		public TextFileAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextFile.TextFileAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TextFileAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class TextFileAttributes_
    {
        public static dynamic GetTSObject(TextFileAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TextFileAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.TextFile.TextFileAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TextFileAttributesArray_
    {
        public static dynamic GetTSObject(TextFileAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TextFileAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TextFileAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TextFileAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TextFileAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class TextFile_
    {
        public static dynamic GetTSObject(TextFile dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TextFile FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.TextFile)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TextFileArray_
    {
        public static dynamic GetTSObject(TextFile[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TextFile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TextFile[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TextFile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TextFile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
