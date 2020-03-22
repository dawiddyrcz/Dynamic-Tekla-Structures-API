/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoftedPlate  : Dynamic.Tekla.Structures.Model.Part
    {

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.ICurve> BaseCurves
		{
			get => teklaObject.BaseCurves;
			set { teklaObject.BaseCurves = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum FaceType
		{
			get => Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum_.FromTSObject(teklaObject.FaceType);
			set { teklaObject.FaceType = Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum_.GetTSObject(value); }
		}

        

        

		public LoftedPlate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlate");
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}




    public enum LoftedPlateFaceTypeEnum
    {
			Perpendicular,
			BoundedByCurvePlanes        
    }

    internal static class LoftedPlateFaceTypeEnum_
    {
        public static dynamic GetTSObject(LoftedPlateFaceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum").GetType();

            switch (dynEnum)
            {
				case LoftedPlateFaceTypeEnum.Perpendicular:
					return System.Enum.Parse(tsType, "Perpendicular");
				case LoftedPlateFaceTypeEnum.BoundedByCurvePlanes:
					return System.Enum.Parse(tsType, "BoundedByCurvePlanes");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoftedPlateFaceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Perpendicular", System.StringComparison.InvariantCulture))
				return LoftedPlateFaceTypeEnum.Perpendicular;
			else if (tsEnumValue.Equals("BoundedByCurvePlanes", System.StringComparison.InvariantCulture))
				return LoftedPlateFaceTypeEnum.BoundedByCurvePlanes;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoftedPlate_
    {
        public static dynamic GetTSObject(LoftedPlate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LoftedPlate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.LoftedPlate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
