/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class SymbolElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public Dynamic.Tekla.Structures.Drawing.SymbolInfo Symbol
		{
			get => Dynamic.Tekla.Structures.Drawing.SymbolInfo_.FromTSObject(teklaObject.Symbol);
			set { teklaObject.Symbol = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(value); }
		}

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

        

        

		public SymbolElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolElement");
		}
		public SymbolElement(Dynamic.Tekla.Structures.Drawing.SymbolInfo Symbol)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(Symbol);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolElement", args);
		}
		public SymbolElement(Dynamic.Tekla.Structures.Drawing.SymbolInfo Symbol, Dynamic.Tekla.Structures.Drawing.DrawingColors Color, System.Double Height)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(Symbol);
			args[1] = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(Color);
			args[2] = Height;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolElement", args);
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

    internal static class SymbolElement_
    {
        public static dynamic GetTSObject(SymbolElement dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SymbolElement FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.SymbolElement)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
