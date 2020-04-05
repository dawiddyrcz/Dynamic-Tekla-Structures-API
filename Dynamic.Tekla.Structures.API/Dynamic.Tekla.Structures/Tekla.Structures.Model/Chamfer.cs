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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Chamfer.ChamferTypeEnum_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Model.Chamfer.ChamferTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
		}

		public System.Double X
		{
			get
			{
				try {
					return teklaObject.X;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("X"); }
			}
			set
			{
				try {
					teklaObject.X = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("X"); }
			}
		}

		public System.Double Y
		{
			get
			{
				try {
					return teklaObject.Y;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Y"); }
			}
			set
			{
				try {
					teklaObject.Y = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Y"); }
			}
		}

		public System.Double DZ1
		{
			get
			{
				try {
					return teklaObject.DZ1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DZ1"); }
			}
			set
			{
				try {
					teklaObject.DZ1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DZ1"); }
			}
		}

		public System.Double DZ2
		{
			get
			{
				try {
					return teklaObject.DZ2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DZ2"); }
			}
			set
			{
				try {
					teklaObject.DZ2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DZ2"); }
			}
		}

        

        internal dynamic teklaObject;

		public Chamfer()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Chamfer");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Chamfer(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Chamfer_
    {
        public static dynamic GetTSObject(Chamfer dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Chamfer FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Chamfer)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ChamferArray_
    {
        public static dynamic GetTSObject(Chamfer[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Chamfer_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Chamfer[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Chamfer>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Chamfer_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
