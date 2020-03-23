/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class Picker 
    {

        

        internal dynamic teklaObject;

		public Picker()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Picker");
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point PickPoint()
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PickPoint());
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point PickPoint(System.String Prompt)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PickPoint(Prompt));
		}

		public System.Collections.ArrayList PickPoints(Dynamic.Tekla.Structures.Model.UI.Picker.PickPointEnum Enum)
		{
			return teklaObject.PickPoints(Dynamic.Tekla.Structures.Model.UI.Picker.PickPointEnum_.GetTSObject(Enum));
		}

		public System.Collections.ArrayList PickPoints(Dynamic.Tekla.Structures.Model.UI.Picker.PickPointEnum Enum, System.String Prompt)
		{
			return teklaObject.PickPoints(Dynamic.Tekla.Structures.Model.UI.Picker.PickPointEnum_.GetTSObject(Enum), Prompt);
		}

		public System.Collections.ArrayList PickLine()
		{
			return teklaObject.PickLine();
		}

		public System.Collections.ArrayList PickLine(System.String Prompt)
		{
			return teklaObject.PickLine(Prompt);
		}

		public Dynamic.Tekla.Structures.Model.UI.PickInput PickFace()
		{
			return Dynamic.Tekla.Structures.Model.UI.PickInput_.FromTSObject(teklaObject.PickFace());
		}

		public Dynamic.Tekla.Structures.Model.UI.PickInput PickFace(System.String Prompt)
		{
			return Dynamic.Tekla.Structures.Model.UI.PickInput_.FromTSObject(teklaObject.PickFace(Prompt));
		}

		public Dynamic.Tekla.Structures.Model.ModelObject PickObject(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectEnum Enum)
		{
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.PickObject(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectEnum_.GetTSObject(Enum)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObject PickObject(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectEnum Enum, System.String Prompt)
		{
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.PickObject(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectEnum_.GetTSObject(Enum), Prompt));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator PickObjects(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectsEnum Enum)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.PickObjects(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectsEnum_.GetTSObject(Enum)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator PickObjects(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectsEnum Enum, System.String Prompt)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.PickObjects(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectsEnum_.GetTSObject(Enum), Prompt));
		}




    public enum PickPointEnum
    {
			PICK_ONE_POINT,
			PICK_TWO_POINTS,
			PICK_POLYGON,
			PICK_LINE,
			PICK_FACE        
    }

    internal static class PickPointEnum_
    {
        public static dynamic GetTSObject(PickPointEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Picker.PickPointEnum").GetType();

            switch (dynEnum)
            {
				case PickPointEnum.PICK_ONE_POINT:
					return System.Enum.Parse(tsType, "PICK_ONE_POINT");
				case PickPointEnum.PICK_TWO_POINTS:
					return System.Enum.Parse(tsType, "PICK_TWO_POINTS");
				case PickPointEnum.PICK_POLYGON:
					return System.Enum.Parse(tsType, "PICK_POLYGON");
				case PickPointEnum.PICK_LINE:
					return System.Enum.Parse(tsType, "PICK_LINE");
				case PickPointEnum.PICK_FACE:
					return System.Enum.Parse(tsType, "PICK_FACE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PickPointEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PICK_ONE_POINT", System.StringComparison.InvariantCulture))
				return PickPointEnum.PICK_ONE_POINT;
			else if (tsEnumValue.Equals("PICK_TWO_POINTS", System.StringComparison.InvariantCulture))
				return PickPointEnum.PICK_TWO_POINTS;
			else if (tsEnumValue.Equals("PICK_POLYGON", System.StringComparison.InvariantCulture))
				return PickPointEnum.PICK_POLYGON;
			else if (tsEnumValue.Equals("PICK_LINE", System.StringComparison.InvariantCulture))
				return PickPointEnum.PICK_LINE;
			else if (tsEnumValue.Equals("PICK_FACE", System.StringComparison.InvariantCulture))
				return PickPointEnum.PICK_FACE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum PickObjectEnum
    {
			PICK_ONE_OBJECT,
			PICK_ONE_PART,
			PICK_ONE_WELD,
			PICK_ONE_BOLTGROUP,
			PICK_ONE_REINFORCEMENT        
    }

    internal static class PickObjectEnum_
    {
        public static dynamic GetTSObject(PickObjectEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Picker.PickObjectEnum").GetType();

            switch (dynEnum)
            {
				case PickObjectEnum.PICK_ONE_OBJECT:
					return System.Enum.Parse(tsType, "PICK_ONE_OBJECT");
				case PickObjectEnum.PICK_ONE_PART:
					return System.Enum.Parse(tsType, "PICK_ONE_PART");
				case PickObjectEnum.PICK_ONE_WELD:
					return System.Enum.Parse(tsType, "PICK_ONE_WELD");
				case PickObjectEnum.PICK_ONE_BOLTGROUP:
					return System.Enum.Parse(tsType, "PICK_ONE_BOLTGROUP");
				case PickObjectEnum.PICK_ONE_REINFORCEMENT:
					return System.Enum.Parse(tsType, "PICK_ONE_REINFORCEMENT");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PickObjectEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PICK_ONE_OBJECT", System.StringComparison.InvariantCulture))
				return PickObjectEnum.PICK_ONE_OBJECT;
			else if (tsEnumValue.Equals("PICK_ONE_PART", System.StringComparison.InvariantCulture))
				return PickObjectEnum.PICK_ONE_PART;
			else if (tsEnumValue.Equals("PICK_ONE_WELD", System.StringComparison.InvariantCulture))
				return PickObjectEnum.PICK_ONE_WELD;
			else if (tsEnumValue.Equals("PICK_ONE_BOLTGROUP", System.StringComparison.InvariantCulture))
				return PickObjectEnum.PICK_ONE_BOLTGROUP;
			else if (tsEnumValue.Equals("PICK_ONE_REINFORCEMENT", System.StringComparison.InvariantCulture))
				return PickObjectEnum.PICK_ONE_REINFORCEMENT;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum PickObjectsEnum
    {
			PICK_N_OBJECTS,
			PICK_N_PARTS,
			PICK_N_WELDS,
			PICK_N_BOLTGROUPS,
			PICK_N_REINFORCEMENTS        
    }

    internal static class PickObjectsEnum_
    {
        public static dynamic GetTSObject(PickObjectsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Picker.PickObjectsEnum").GetType();

            switch (dynEnum)
            {
				case PickObjectsEnum.PICK_N_OBJECTS:
					return System.Enum.Parse(tsType, "PICK_N_OBJECTS");
				case PickObjectsEnum.PICK_N_PARTS:
					return System.Enum.Parse(tsType, "PICK_N_PARTS");
				case PickObjectsEnum.PICK_N_WELDS:
					return System.Enum.Parse(tsType, "PICK_N_WELDS");
				case PickObjectsEnum.PICK_N_BOLTGROUPS:
					return System.Enum.Parse(tsType, "PICK_N_BOLTGROUPS");
				case PickObjectsEnum.PICK_N_REINFORCEMENTS:
					return System.Enum.Parse(tsType, "PICK_N_REINFORCEMENTS");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PickObjectsEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PICK_N_OBJECTS", System.StringComparison.InvariantCulture))
				return PickObjectsEnum.PICK_N_OBJECTS;
			else if (tsEnumValue.Equals("PICK_N_PARTS", System.StringComparison.InvariantCulture))
				return PickObjectsEnum.PICK_N_PARTS;
			else if (tsEnumValue.Equals("PICK_N_WELDS", System.StringComparison.InvariantCulture))
				return PickObjectsEnum.PICK_N_WELDS;
			else if (tsEnumValue.Equals("PICK_N_BOLTGROUPS", System.StringComparison.InvariantCulture))
				return PickObjectsEnum.PICK_N_BOLTGROUPS;
			else if (tsEnumValue.Equals("PICK_N_REINFORCEMENTS", System.StringComparison.InvariantCulture))
				return PickObjectsEnum.PICK_N_REINFORCEMENTS;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Picker_
    {
        public static dynamic GetTSObject(Picker dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Picker FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.UI.Picker)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerArray_
    {
        public static dynamic GetTSObject(Picker[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Picker_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Picker[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Picker>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Picker_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
