/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DrawingLink  : Dynamic.Tekla.Structures.Drawing.LinkBase
    {

		public Dynamic.Tekla.Structures.Drawing.Drawing Target
		{
			get => Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.Target);
			set { teklaObject.Target = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(value); }
		}

        

        

		internal DrawingLink() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingLink(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DrawingLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.Drawing Target, System.String Text)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(Target);
			args[3] = Text;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingLink", args);
		}
		public DrawingLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.Drawing Target, System.String Text, Dynamic.Tekla.Structures.Drawing.LinkAttributes Attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(Target);
			args[3] = Text;
			args[4] = Dynamic.Tekla.Structures.Drawing.LinkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingLink", args);
		}
		public DrawingLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.Drawing Target, System.String Text, Dynamic.Tekla.Structures.Drawing.Size Size)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(Target);
			args[3] = Text;
			args[4] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(Size);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingLink", args);
		}
		public DrawingLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.Drawing Target, System.String Text, Dynamic.Tekla.Structures.Drawing.Size Size, Dynamic.Tekla.Structures.Drawing.LinkAttributes Attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(Target);
			args[3] = Text;
			args[4] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(Size);
			args[5] = Dynamic.Tekla.Structures.Drawing.LinkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingLink", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
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





    }

    internal static class DrawingLink_
    {
        public static dynamic GetTSObject(DrawingLink dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingLink FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingLink)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingLinkArray_
    {
        public static dynamic GetTSObject(DrawingLink[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingLink_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingLink[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DrawingLink>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingLink_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
