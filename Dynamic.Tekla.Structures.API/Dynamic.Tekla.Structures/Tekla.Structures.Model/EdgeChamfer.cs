/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class EdgeChamfer  : Dynamic.Tekla.Structures.Model.Boolean
    {

		public Dynamic.Tekla.Structures.Model.Chamfer Chamfer
		{
			get
			{
				 return Dynamic.Tekla.Structures.Model.Chamfer_.FromTSObject(teklaObject.Chamfer);
			}
			set
			{
				teklaObject.Chamfer = Dynamic.Tekla.Structures.Model.Chamfer_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstEnd
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.FirstEnd);
			}
			set
			{
				teklaObject.FirstEnd = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondEnd
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.SecondEnd);
			}
			set
			{
				teklaObject.SecondEnd = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum FirstChamferEndType
		{
			get
			{
				 return Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(teklaObject.FirstChamferEndType);
			}
			set
			{
				teklaObject.FirstChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum SecondChamferEndType
		{
			get
			{
				 return Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(teklaObject.SecondChamferEndType);
			}
			set
			{
				teklaObject.SecondChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.GetTSObject(value);
			}
		}

		public System.Double SecondBevelDimension
		{
			get => teklaObject.SecondBevelDimension;
			set { teklaObject.SecondBevelDimension = value; }
		}

		public System.Double FirstBevelDimension
		{
			get => teklaObject.FirstBevelDimension;
			set { teklaObject.FirstBevelDimension = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

        

        

		public EdgeChamfer()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public EdgeChamfer(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public EdgeChamfer(Dynamic.Tekla.Structures.Geometry3d.Point FirstEnd, Dynamic.Tekla.Structures.Geometry3d.Point SecondEnd)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(FirstEnd);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SecondEnd);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer", args);
		}




    public enum ChamferEndTypeEnum
    {
			FULL,
			STRAIGHT,
			BEVELLED        
    }

    internal static class ChamferEndTypeEnum_
    {
        public static dynamic GetTSObject(ChamferEndTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum").GetType();

            switch (dynEnum)
            {
				case ChamferEndTypeEnum.FULL:
					return System.Enum.Parse(tsType, "FULL");
				case ChamferEndTypeEnum.STRAIGHT:
					return System.Enum.Parse(tsType, "STRAIGHT");
				case ChamferEndTypeEnum.BEVELLED:
					return System.Enum.Parse(tsType, "BEVELLED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ChamferEndTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("FULL", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.FULL;
			else if (tsEnumValue.Equals("STRAIGHT", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.STRAIGHT;
			else if (tsEnumValue.Equals("BEVELLED", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.BEVELLED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class EdgeChamfer_
    {
        public static dynamic GetTSObject(EdgeChamfer dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static EdgeChamfer FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.EdgeChamfer)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EdgeChamferArray_
    {
        public static dynamic GetTSObject(EdgeChamfer[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EdgeChamfer_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EdgeChamfer[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<EdgeChamfer>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EdgeChamfer_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
