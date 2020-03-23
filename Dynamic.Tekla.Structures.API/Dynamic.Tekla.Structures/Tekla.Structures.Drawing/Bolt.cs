/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Bolt  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.Bolt.BoltAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Bolt.BoltAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Bolt.BoltAttributes_.GetTSObject(value); }
		}

        

        

		public Bolt() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}




    public enum Representation
    {
			Solid,
			Symbol,
			Symbol2,
			Symbol3,
			DINSymbol,
			UserDefined,
			ExactSolid        
    }

    internal static class Representation_
    {
        public static dynamic GetTSObject(Representation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Bolt.Representation").GetType();

            switch (dynEnum)
            {
				case Representation.Solid:
					return System.Enum.Parse(tsType, "Solid");
				case Representation.Symbol:
					return System.Enum.Parse(tsType, "Symbol");
				case Representation.Symbol2:
					return System.Enum.Parse(tsType, "Symbol2");
				case Representation.Symbol3:
					return System.Enum.Parse(tsType, "Symbol3");
				case Representation.DINSymbol:
					return System.Enum.Parse(tsType, "DINSymbol");
				case Representation.UserDefined:
					return System.Enum.Parse(tsType, "UserDefined");
				case Representation.ExactSolid:
					return System.Enum.Parse(tsType, "ExactSolid");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Representation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Solid", System.StringComparison.InvariantCulture))
				return Representation.Solid;
			else if (tsEnumValue.Equals("Symbol", System.StringComparison.InvariantCulture))
				return Representation.Symbol;
			else if (tsEnumValue.Equals("Symbol2", System.StringComparison.InvariantCulture))
				return Representation.Symbol2;
			else if (tsEnumValue.Equals("Symbol3", System.StringComparison.InvariantCulture))
				return Representation.Symbol3;
			else if (tsEnumValue.Equals("DINSymbol", System.StringComparison.InvariantCulture))
				return Representation.DINSymbol;
			else if (tsEnumValue.Equals("UserDefined", System.StringComparison.InvariantCulture))
				return Representation.UserDefined;
			else if (tsEnumValue.Equals("ExactSolid", System.StringComparison.InvariantCulture))
				return Representation.ExactSolid;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class BoltAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.Bolt.Representation Representation
		{
			get => Dynamic.Tekla.Structures.Drawing.Bolt.Representation_.FromTSObject(teklaObject.Representation);
			set { teklaObject.Representation = Dynamic.Tekla.Structures.Drawing.Bolt.Representation_.GetTSObject(value); }
		}

		public System.Boolean SymbolContainsHole
		{
			get => teklaObject.SymbolContainsHole;
			set { teklaObject.SymbolContainsHole = value; }
		}

		public System.Boolean SymbolContainsAxis
		{
			get => teklaObject.SymbolContainsAxis;
			set { teklaObject.SymbolContainsAxis = value; }
		}

		public System.String CustomPresentation
		{
			get => teklaObject.CustomPresentation;
			set { teklaObject.CustomPresentation = value; }
		}

        

        

		public BoltAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Bolt.BoltAttributes");
		}
		public BoltAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Bolt.BoltAttributes", args);
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

    internal static class BoltAttributes_
    {
        public static dynamic GetTSObject(BoltAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BoltAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Bolt.BoltAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class Bolt_
    {
        public static dynamic GetTSObject(Bolt dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Bolt FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Bolt)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
