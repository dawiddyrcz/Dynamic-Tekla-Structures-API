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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.SymbolInfo_.FromTSObject(teklaObject.Symbol);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Symbol"); }
			}
			set
			{
				try {
				teklaObject.Symbol = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Symbol"); }
			}
		}

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

        

        

		public SymbolElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolElement");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SymbolElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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





    }

    internal static class SymbolElement_
    {
        public static dynamic GetTSObject(SymbolElement dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SymbolElement FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SymbolElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SymbolElementArray_
    {
        public static dynamic GetTSObject(SymbolElement[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SymbolElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SymbolElement[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SymbolElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SymbolElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
