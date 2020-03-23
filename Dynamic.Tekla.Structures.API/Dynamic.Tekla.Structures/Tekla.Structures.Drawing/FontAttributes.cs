/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class FontAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

		public System.Double Height
		{
			get => teklaObject.Height;
			set { teklaObject.Height = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Boolean Italic
		{
			get => teklaObject.Italic;
			set { teklaObject.Italic = value; }
		}

		public System.Boolean Bold
		{
			get => teklaObject.Bold;
			set { teklaObject.Bold = value; }
		}

        

        

		public FontAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.FontAttributes");
		}
		public FontAttributes(Dynamic.Tekla.Structures.Drawing.DrawingColors color, System.Double height, System.String fontName, System.Boolean italic, System.Boolean bold)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(color);
			args[1] = height;
			args[2] = fontName;
			args[3] = italic;
			args[4] = bold;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.FontAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class FontAttributes_
    {
        public static dynamic GetTSObject(FontAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FontAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.FontAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FontAttributesArray_
    {
        public static dynamic GetTSObject(FontAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FontAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FontAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<FontAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FontAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
