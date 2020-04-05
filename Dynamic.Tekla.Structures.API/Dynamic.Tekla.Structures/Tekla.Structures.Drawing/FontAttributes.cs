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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
		}

		public System.Double Height
		{
			get
			{
				try {
					return teklaObject.Height;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height"); }
			}
			set
			{
				try {
					teklaObject.Height = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height"); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public System.Boolean Italic
		{
			get
			{
				try {
					return teklaObject.Italic;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Italic"); }
			}
			set
			{
				try {
					teklaObject.Italic = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Italic"); }
			}
		}

		public System.Boolean Bold
		{
			get
			{
				try {
					return teklaObject.Bold;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Bold"); }
			}
			set
			{
				try {
					teklaObject.Bold = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Bold"); }
			}
		}

        

        

		public FontAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.FontAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FontAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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

		public System.Object Clone()
		{
			try {
			return teklaObject.Clone();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Clone()"); }
		}





    }

    internal static class FontAttributes_
    {
        public static dynamic GetTSObject(FontAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static FontAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.FontAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FontAttributesArray_
    {
        public static dynamic GetTSObject(FontAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FontAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FontAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<FontAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FontAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
