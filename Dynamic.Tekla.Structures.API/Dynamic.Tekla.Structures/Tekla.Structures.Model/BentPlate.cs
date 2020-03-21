//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class BentPlate  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry Geometry
		{
			get => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(teklaObject.Geometry);
			set { teklaObject.Geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(value); }
		}

		public System.Double Thickness
		{
			get => teklaObject.Thickness;
			set { teklaObject.Thickness = value; }
		}

        

        

		public BentPlate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlate");
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public System.Boolean Modify()
			 => teklaObject.Modify();




    public enum BendShape
    {
			Cylindrical,
			Conical        
    }

    internal static class BendShape_
    {
        public static dynamic GetTSObject(BendShape dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlate.BendShape").GetType();

            switch (dynEnum)
            {
				case BendShape.Cylindrical:
					return System.Enum.Parse(tsType, "Cylindrical");
				case BendShape.Conical:
					return System.Enum.Parse(tsType, "Conical");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BendShape FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Cylindrical", System.StringComparison.InvariantCulture))
				return BendShape.Cylindrical;
			else if (tsEnumValue.Equals("Conical", System.StringComparison.InvariantCulture))
				return BendShape.Conical;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BentPlate_
    {
        public static dynamic GetTSObject(BentPlate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BentPlate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BentPlate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
