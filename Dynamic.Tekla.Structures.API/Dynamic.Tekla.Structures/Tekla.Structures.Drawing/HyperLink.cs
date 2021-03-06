/*Copyright (C) Dawid Dyrcz 2020
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

    public  class HyperLink  : Dynamic.Tekla.Structures.Drawing.LinkBase
    {


        public System.Uri Target
        {
            get
            {
                try
                {
                return teklaObject.Target;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Target), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Target = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Target), ex); 
                }
            }
        }
        

        

		internal HyperLink() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public HyperLink(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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





    }

    internal static class HyperLink_
    {
        public static dynamic GetTSObject(HyperLink dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static HyperLink FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.HyperLink)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class HyperLinkArray_
    {
        public static dynamic GetTSObject(HyperLink[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(HyperLink_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static HyperLink[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<HyperLink>();
            foreach(var tsItem in tsArray)
            {
                list.Add(HyperLink_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
