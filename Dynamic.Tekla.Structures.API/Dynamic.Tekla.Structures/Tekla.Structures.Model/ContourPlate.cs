/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ContourPlate  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get => Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
			set { teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value); }
		}

        

        

		public ContourPlate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPlate");
		}

		public System.Boolean AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint contourPoint)
		{
			return teklaObject.AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint_.GetTSObject(contourPoint));
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




    public enum ContourPlateTypeEnum
    {
			UNKNOWN,
			PLATE,
			SLAB        
    }

    internal static class ContourPlateTypeEnum_
    {
        public static dynamic GetTSObject(ContourPlateTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum").GetType();

            switch (dynEnum)
            {
				case ContourPlateTypeEnum.UNKNOWN:
					return System.Enum.Parse(tsType, "UNKNOWN");
				case ContourPlateTypeEnum.PLATE:
					return System.Enum.Parse(tsType, "PLATE");
				case ContourPlateTypeEnum.SLAB:
					return System.Enum.Parse(tsType, "SLAB");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ContourPlateTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
				return ContourPlateTypeEnum.UNKNOWN;
			else if (tsEnumValue.Equals("PLATE", System.StringComparison.InvariantCulture))
				return ContourPlateTypeEnum.PLATE;
			else if (tsEnumValue.Equals("SLAB", System.StringComparison.InvariantCulture))
				return ContourPlateTypeEnum.SLAB;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ContourPlate_
    {
        public static dynamic GetTSObject(ContourPlate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ContourPlate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ContourPlate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
