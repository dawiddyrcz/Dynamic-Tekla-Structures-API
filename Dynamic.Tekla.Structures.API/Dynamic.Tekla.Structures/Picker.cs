//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class Picker 
    {

        

        dynamic picker;
        
        public Picker()
        {
            this.picker =  new Tekla.Structures.Model.UI.Picker();
        }

        public Picker(dynamic tsObject)
        {
            this.picker = tsObject;

        }


        public dynamic GetTSObject() => picker;

		public Dynamic.Tekla.Structures.Geometry3d.Point PickPoint()
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(picker.PickPoint());

		public Dynamic.Tekla.Structures.Geometry3d.Point PickPoint(System.String Prompt)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(picker.PickPoint(Prompt));

		public System.Collections.ArrayList PickPoints(Dynamic.Tekla.Structures.Model.UI.Picker.PickPointEnum Enum)
			 => picker.PickPoints(Enum.GetTSObject());

		public System.Collections.ArrayList PickPoints(Dynamic.Tekla.Structures.Model.UI.Picker.PickPointEnum Enum, System.String Prompt)
			 => picker.PickPoints(Enum.GetTSObject(), Prompt);

		public System.Collections.ArrayList PickLine()
			 => picker.PickLine();

		public System.Collections.ArrayList PickLine(System.String Prompt)
			 => picker.PickLine(Prompt);

		public Dynamic.Tekla.Structures.Model.UI.PickInput PickFace()
			 => new Dynamic.Tekla.Structures.Model.UI.PickInput(picker.PickFace());

		public Dynamic.Tekla.Structures.Model.UI.PickInput PickFace(System.String Prompt)
			 => new Dynamic.Tekla.Structures.Model.UI.PickInput(picker.PickFace(Prompt));

		public Dynamic.Tekla.Structures.Model.ModelObject PickObject(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectEnum Enum)
			 => new Dynamic.Tekla.Structures.Model.ModelObject(picker.PickObject(Enum.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.ModelObject PickObject(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectEnum Enum, System.String Prompt)
			 => new Dynamic.Tekla.Structures.Model.ModelObject(picker.PickObject(Enum.GetTSObject(), Prompt));

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator PickObjects(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectsEnum Enum)
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(picker.PickObjects(Enum.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator PickObjects(Dynamic.Tekla.Structures.Model.UI.Picker.PickObjectsEnum Enum, System.String Prompt)
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(picker.PickObjects(Enum.GetTSObject(), Prompt));

		public System.Boolean Equals(System.Object obj)
			 => picker.Equals(obj);

		public System.Int32 GetHashCode()
			 => picker.GetHashCode();

		public System.Type GetType()
			 => picker.GetType();

		public System.String ToString()
			 => picker.ToString();




    public enum PickPointEnum
    {
			PICK_ONE_POINT,
			PICK_TWO_POINTS,
			PICK_POLYGON,
			PICK_LINE,
			PICK_FACE        
    }

    public static class PickPointEnum_
    {
        public static dynamic GetTSObject(PickPointEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.PickPointEnum");

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

    public static class PickObjectEnum_
    {
        public static dynamic GetTSObject(PickObjectEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.PickObjectEnum");

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

    public static class PickObjectsEnum_
    {
        public static dynamic GetTSObject(PickObjectsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.PickObjectsEnum");

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

}
    
