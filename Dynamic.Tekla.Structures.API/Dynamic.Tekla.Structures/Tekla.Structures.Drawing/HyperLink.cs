/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class HyperLink  : Dynamic.Tekla.Structures.Drawing.LinkBase
    {

		public System.Uri Target
		{
			get => teklaObject.Target;
			set { teklaObject.Target = value; }
		}

        

        

		public HyperLink() {}
		public HyperLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, System.Uri Target, System.String Text)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Target;
			args[3] = Text;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.HyperLink", args);
		}
		public HyperLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, System.Uri Target, System.String Text, Dynamic.Tekla.Structures.Drawing.LinkAttributes Attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Target;
			args[3] = Text;
			args[4] = Dynamic.Tekla.Structures.Drawing.LinkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.HyperLink", args);
		}
		public HyperLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, System.Uri Target, System.String Text, Dynamic.Tekla.Structures.Drawing.Size Size)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Target;
			args[3] = Text;
			args[4] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(Size);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.HyperLink", args);
		}
		public HyperLink(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, System.Uri Target, System.String Text, Dynamic.Tekla.Structures.Drawing.Size Size, Dynamic.Tekla.Structures.Drawing.LinkAttributes Attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Target;
			args[3] = Text;
			args[4] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(Size);
			args[5] = Dynamic.Tekla.Structures.Drawing.LinkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.HyperLink", args);
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

    internal static class HyperLink_
    {
        public static dynamic GetTSObject(HyperLink dynObject)
        {
            return dynObject.teklaObject;
        }

        public static HyperLink FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.HyperLink)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
