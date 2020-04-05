/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class TextElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public System.String Value
		{
			get => teklaObject.Value;
			set { teklaObject.Value = value; }
		}

        

        

		internal TextElement() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TextElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TextElement(System.String Text)
		{
			var args = new object[1];
			args[0] = Text;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextElement", args);
		}
		public TextElement(System.String Text, Dynamic.Tekla.Structures.Drawing.FontAttributes Font)
		{
			var args = new object[2];
			args[0] = Text;
			args[1] = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(Font);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextElement", args);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.String GetUnformattedString()
		{
			return teklaObject.GetUnformattedString();
		}





    }

    internal static class TextElement_
    {
        public static dynamic GetTSObject(TextElement dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TextElement FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.TextElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TextElementArray_
    {
        public static dynamic GetTSObject(TextElement[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TextElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TextElement[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TextElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TextElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
