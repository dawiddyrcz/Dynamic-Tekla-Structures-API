/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Weld  : Dynamic.Tekla.Structures.Model.BaseWeld
    {

		public Dynamic.Tekla.Structures.Model.Weld.WeldPositionEnum Position
		{
			get => Dynamic.Tekla.Structures.Model.Weld.WeldPositionEnum_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Model.Weld.WeldPositionEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Direction
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Direction);
			set { teklaObject.Direction = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        

		public Weld()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Weld");
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

		public System.Boolean GetLogicalWeld(ref Dynamic.Tekla.Structures.Model.LogicalWeld LogicalWeld)
		{
			return teklaObject.GetLogicalWeld(Dynamic.Tekla.Structures.Model.LogicalWeld_.GetTSObject(LogicalWeld));
		}




    public enum WeldPositionEnum
    {
			WELD_POSITION_PLUS_X,
			WELD_POSITION_MINUS_X,
			WELD_POSITION_PLUS_Y,
			WELD_POSITION_MINUS_Y,
			WELD_POSITION_PLUS_Z,
			WELD_POSITION_MINUS_Z        
    }

    internal static class WeldPositionEnum_
    {
        public static dynamic GetTSObject(WeldPositionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Weld.WeldPositionEnum").GetType();

            switch (dynEnum)
            {
				case WeldPositionEnum.WELD_POSITION_PLUS_X:
					return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_X");
				case WeldPositionEnum.WELD_POSITION_MINUS_X:
					return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_X");
				case WeldPositionEnum.WELD_POSITION_PLUS_Y:
					return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_Y");
				case WeldPositionEnum.WELD_POSITION_MINUS_Y:
					return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_Y");
				case WeldPositionEnum.WELD_POSITION_PLUS_Z:
					return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_Z");
				case WeldPositionEnum.WELD_POSITION_MINUS_Z:
					return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_Z");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldPositionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_POSITION_PLUS_X", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_PLUS_X;
			else if (tsEnumValue.Equals("WELD_POSITION_MINUS_X", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_MINUS_X;
			else if (tsEnumValue.Equals("WELD_POSITION_PLUS_Y", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_PLUS_Y;
			else if (tsEnumValue.Equals("WELD_POSITION_MINUS_Y", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_MINUS_Y;
			else if (tsEnumValue.Equals("WELD_POSITION_PLUS_Z", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_PLUS_Z;
			else if (tsEnumValue.Equals("WELD_POSITION_MINUS_Z", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_MINUS_Z;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Weld_
    {
        public static dynamic GetTSObject(Weld dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Weld FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Weld)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
