/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Chamfer 
    {

		public Dynamic.Tekla.Structures.Model.Chamfer.ChamferTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.Chamfer.ChamferTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.Chamfer.ChamferTypeEnum_.GetTSObject(value); }
		}

		public System.Double X
		{
			get => teklaObject.X;
			set { teklaObject.X = value; }
		}

		public System.Double Y
		{
			get => teklaObject.Y;
			set { teklaObject.Y = value; }
		}

		public System.Double DZ1
		{
			get => teklaObject.DZ1;
			set { teklaObject.DZ1 = value; }
		}

		public System.Double DZ2
		{
			get => teklaObject.DZ2;
			set { teklaObject.DZ2 = value; }
		}

        

        internal dynamic teklaObject;

		public Chamfer()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Chamfer");
		}
		public Chamfer(System.Double X, System.Double Y, Dynamic.Tekla.Structures.Model.Chamfer.ChamferTypeEnum Type)
		{
			var args = new object[3];
			args[0] = X;
			args[1] = Y;
			args[2] = Dynamic.Tekla.Structures.Model.Chamfer.ChamferTypeEnum_.GetTSObject(Type);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Chamfer", args);
		}




    public enum ChamferTypeEnum
    {
			CHAMFER_NONE,
			CHAMFER_LINE,
			CHAMFER_ROUNDING,
			CHAMFER_ARC,
			CHAMFER_ARC_POINT,
			CHAMFER_SQUARE,
			CHAMFER_SQUARE_PARALLEL,
			CHAMFER_LINE_AND_ARC        
    }

    internal static class ChamferTypeEnum_
    {
        public static dynamic GetTSObject(ChamferTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Chamfer.ChamferTypeEnum").GetType();

            switch (dynEnum)
            {
				case ChamferTypeEnum.CHAMFER_NONE:
					return System.Enum.Parse(tsType, "CHAMFER_NONE");
				case ChamferTypeEnum.CHAMFER_LINE:
					return System.Enum.Parse(tsType, "CHAMFER_LINE");
				case ChamferTypeEnum.CHAMFER_ROUNDING:
					return System.Enum.Parse(tsType, "CHAMFER_ROUNDING");
				case ChamferTypeEnum.CHAMFER_ARC:
					return System.Enum.Parse(tsType, "CHAMFER_ARC");
				case ChamferTypeEnum.CHAMFER_ARC_POINT:
					return System.Enum.Parse(tsType, "CHAMFER_ARC_POINT");
				case ChamferTypeEnum.CHAMFER_SQUARE:
					return System.Enum.Parse(tsType, "CHAMFER_SQUARE");
				case ChamferTypeEnum.CHAMFER_SQUARE_PARALLEL:
					return System.Enum.Parse(tsType, "CHAMFER_SQUARE_PARALLEL");
				case ChamferTypeEnum.CHAMFER_LINE_AND_ARC:
					return System.Enum.Parse(tsType, "CHAMFER_LINE_AND_ARC");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ChamferTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CHAMFER_NONE", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_NONE;
			else if (tsEnumValue.Equals("CHAMFER_LINE", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_LINE;
			else if (tsEnumValue.Equals("CHAMFER_ROUNDING", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_ROUNDING;
			else if (tsEnumValue.Equals("CHAMFER_ARC", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_ARC;
			else if (tsEnumValue.Equals("CHAMFER_ARC_POINT", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_ARC_POINT;
			else if (tsEnumValue.Equals("CHAMFER_SQUARE", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_SQUARE;
			else if (tsEnumValue.Equals("CHAMFER_SQUARE_PARALLEL", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_SQUARE_PARALLEL;
			else if (tsEnumValue.Equals("CHAMFER_LINE_AND_ARC", System.StringComparison.InvariantCulture))
				return ChamferTypeEnum.CHAMFER_LINE_AND_ARC;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Chamfer_
    {
        public static dynamic GetTSObject(Chamfer dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Chamfer FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Chamfer)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ChamferArray_
    {
        public static dynamic GetTSObject(Chamfer[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Chamfer_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Chamfer[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Chamfer>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Chamfer_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
