/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class LayoutAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.Boolean ListHiddenObjectsInTemplates
		{
			get => teklaObject.ListHiddenObjectsInTemplates;
			set { teklaObject.ListHiddenObjectsInTemplates = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.SizeDefinitionMode SizeDefinitionMode
		{
			get => Dynamic.Tekla.Structures.Drawing.SizeDefinitionMode_.FromTSObject(teklaObject.SizeDefinitionMode);
			set { teklaObject.SizeDefinitionMode = Dynamic.Tekla.Structures.Drawing.SizeDefinitionMode_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.AutoSizeOptions AutoSizeOptions
		{
			get => Dynamic.Tekla.Structures.Drawing.AutoSizeOptions_.FromTSObject(teklaObject.AutoSizeOptions);
			set { teklaObject.AutoSizeOptions = Dynamic.Tekla.Structures.Drawing.AutoSizeOptions_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.Size SheetSize
		{
			get => Dynamic.Tekla.Structures.Drawing.Size_.FromTSObject(teklaObject.SheetSize);
			set { teklaObject.SheetSize = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(value); }
		}

        

        

		public LayoutAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LayoutAttributes");
		}
		public LayoutAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LayoutAttributes", args);
		}
		public LayoutAttributes(System.String AttributeFile, Dynamic.Tekla.Structures.Drawing.Drawing Drawing)
		{
			var args = new object[2];
			args[0] = AttributeFile;
			args[1] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(Drawing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LayoutAttributes", args);
		}
		public LayoutAttributes(Dynamic.Tekla.Structures.Drawing.Drawing Drawing)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(Drawing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LayoutAttributes", args);
		}

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class LayoutAttributes_
    {
        public static dynamic GetTSObject(LayoutAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LayoutAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.LayoutAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LayoutAttributesArray_
    {
        public static dynamic GetTSObject(LayoutAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LayoutAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LayoutAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<LayoutAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LayoutAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
