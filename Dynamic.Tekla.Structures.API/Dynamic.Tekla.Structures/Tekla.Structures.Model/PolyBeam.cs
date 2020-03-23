/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PolyBeam  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get => Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
			set { teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value); }
		}

        

        

		public PolyBeam()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam");
		}
		public PolyBeam(Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum polyBeamType)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.GetTSObject(polyBeamType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam", args);
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

		public System.Collections.ArrayList GetPolybeamCoordinateSystems()
		{
			return teklaObject.GetPolybeamCoordinateSystems();
		}




    public enum PolyBeamTypeEnum
    {
			BEAM,
			PANEL,
			STRIP_FOOTING,
			COLUMN        
    }

    internal static class PolyBeamTypeEnum_
    {
        public static dynamic GetTSObject(PolyBeamTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum").GetType();

            switch (dynEnum)
            {
				case PolyBeamTypeEnum.BEAM:
					return System.Enum.Parse(tsType, "BEAM");
				case PolyBeamTypeEnum.PANEL:
					return System.Enum.Parse(tsType, "PANEL");
				case PolyBeamTypeEnum.STRIP_FOOTING:
					return System.Enum.Parse(tsType, "STRIP_FOOTING");
				case PolyBeamTypeEnum.COLUMN:
					return System.Enum.Parse(tsType, "COLUMN");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PolyBeamTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.BEAM;
			else if (tsEnumValue.Equals("PANEL", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.PANEL;
			else if (tsEnumValue.Equals("STRIP_FOOTING", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.STRIP_FOOTING;
			else if (tsEnumValue.Equals("COLUMN", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.COLUMN;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class PolyBeam_
    {
        public static dynamic GetTSObject(PolyBeam dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PolyBeam FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.PolyBeam)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
