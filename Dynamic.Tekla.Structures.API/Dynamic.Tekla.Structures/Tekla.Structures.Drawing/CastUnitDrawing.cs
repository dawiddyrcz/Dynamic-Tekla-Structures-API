/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CastUnitDrawing  : Dynamic.Tekla.Structures.Drawing.Drawing
    {

		public Dynamic.Tekla.Structures.Identifier CastUnitIdentifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.CastUnitIdentifier);
			set { teklaObject.CastUnitIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

		public System.Int32 SheetNumber
		{
			get => teklaObject.SheetNumber;
			set { teklaObject.SheetNumber = value; }
		}

		public System.Boolean CastUnitById
		{
			get => teklaObject.CastUnitById;
			set { teklaObject.CastUnitById = value; }
		}

        

        

		public CastUnitDrawing() {}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
		}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier, System.String AttributeFile)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			args[1] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
		}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier, Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType castUnitDrawingCreationType)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			args[1] = Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType_.GetTSObject(castUnitDrawingCreationType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
		}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier, Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType castUnitDrawingCreationType, System.String AttributeFile)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			args[1] = Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType_.GetTSObject(castUnitDrawingCreationType);
			args[2] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
		}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier, System.Int32 sheetNumber)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			args[1] = sheetNumber;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
		}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier, System.Int32 sheetNumber, System.String AttributeFile)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			args[1] = sheetNumber;
			args[2] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
		}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier, Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType castUnitDrawingCreationType, System.Int32 sheetNumber)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			args[1] = Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType_.GetTSObject(castUnitDrawingCreationType);
			args[2] = sheetNumber;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
		}
		public CastUnitDrawing(Dynamic.Tekla.Structures.Identifier castUnitIdentifier, Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType castUnitDrawingCreationType, System.Int32 sheetNumber, System.String AttributeFile)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(castUnitIdentifier);
			args[1] = Dynamic.Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType_.GetTSObject(castUnitDrawingCreationType);
			args[2] = sheetNumber;
			args[3] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing", args);
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




    public enum CastUnitDrawingCreationType
    {
			CastUnitDrawingByPosition,
			CastUnitDrawingById        
    }

    internal static class CastUnitDrawingCreationType_
    {
        public static dynamic GetTSObject(CastUnitDrawingCreationType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.CastUnitDrawing.CastUnitDrawingCreationType").GetType();

            switch (dynEnum)
            {
				case CastUnitDrawingCreationType.CastUnitDrawingByPosition:
					return System.Enum.Parse(tsType, "CastUnitDrawingByPosition");
				case CastUnitDrawingCreationType.CastUnitDrawingById:
					return System.Enum.Parse(tsType, "CastUnitDrawingById");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CastUnitDrawingCreationType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CastUnitDrawingByPosition", System.StringComparison.InvariantCulture))
				return CastUnitDrawingCreationType.CastUnitDrawingByPosition;
			else if (tsEnumValue.Equals("CastUnitDrawingById", System.StringComparison.InvariantCulture))
				return CastUnitDrawingCreationType.CastUnitDrawingById;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class CastUnitDrawing_
    {
        public static dynamic GetTSObject(CastUnitDrawing dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CastUnitDrawing FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CastUnitDrawing)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    