/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSplice  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.Reinforcement RebarGroup1
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement_.FromTSObject(teklaObject.RebarGroup1);
			set { teklaObject.RebarGroup1 = Dynamic.Tekla.Structures.Model.Reinforcement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement RebarGroup2
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement_.FromTSObject(teklaObject.RebarGroup2);
			set { teklaObject.RebarGroup2 = Dynamic.Tekla.Structures.Model.Reinforcement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum_.GetTSObject(value); }
		}

		public System.Double LapLength
		{
			get => teklaObject.LapLength;
			set { teklaObject.LapLength = value; }
		}

		public System.Double Offset
		{
			get => teklaObject.Offset;
			set { teklaObject.Offset = value; }
		}

		public System.Double Clearance
		{
			get => teklaObject.Clearance;
			set { teklaObject.Clearance = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum BarPositions
		{
			get => Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum_.FromTSObject(teklaObject.BarPositions);
			set { teklaObject.BarPositions = Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum_.GetTSObject(value); }
		}

        

        

		public RebarSplice()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarSplice(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public RebarSplice(Dynamic.Tekla.Structures.Model.RebarGroup InputRebar1, Dynamic.Tekla.Structures.Model.RebarGroup InputRebar2)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(InputRebar1);
			args[1] = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(InputRebar2);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice", args);
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




    public enum RebarSpliceTypeEnum
    {
			SPLICE_TYPE_LAP_RIGHT,
			SPLICE_TYPE_LAP_LEFT,
			SPLICE_TYPE_LAP_BOTH,
			SPLICE_TYPE_MUFF,
			SPLICE_TYPE_WELD        
    }

    internal static class RebarSpliceTypeEnum_
    {
        public static dynamic GetTSObject(RebarSpliceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_RIGHT:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_RIGHT");
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_LEFT:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_LEFT");
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_BOTH:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_BOTH");
				case RebarSpliceTypeEnum.SPLICE_TYPE_MUFF:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_MUFF");
				case RebarSpliceTypeEnum.SPLICE_TYPE_WELD:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_WELD");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarSpliceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPLICE_TYPE_LAP_RIGHT", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_RIGHT;
			else if (tsEnumValue.Equals("SPLICE_TYPE_LAP_LEFT", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_LEFT;
			else if (tsEnumValue.Equals("SPLICE_TYPE_LAP_BOTH", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_BOTH;
			else if (tsEnumValue.Equals("SPLICE_TYPE_MUFF", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_MUFF;
			else if (tsEnumValue.Equals("SPLICE_TYPE_WELD", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_WELD;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarSpliceBarPositionsEnum
    {
			SPLICE_BAR_ON_TOP,
			SPLICE_BAR_PARALLEL        
    }

    internal static class RebarSpliceBarPositionsEnum_
    {
        public static dynamic GetTSObject(RebarSpliceBarPositionsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum").GetType();

            switch (dynEnum)
            {
				case RebarSpliceBarPositionsEnum.SPLICE_BAR_ON_TOP:
					return System.Enum.Parse(tsType, "SPLICE_BAR_ON_TOP");
				case RebarSpliceBarPositionsEnum.SPLICE_BAR_PARALLEL:
					return System.Enum.Parse(tsType, "SPLICE_BAR_PARALLEL");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarSpliceBarPositionsEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPLICE_BAR_ON_TOP", System.StringComparison.InvariantCulture))
				return RebarSpliceBarPositionsEnum.SPLICE_BAR_ON_TOP;
			else if (tsEnumValue.Equals("SPLICE_BAR_PARALLEL", System.StringComparison.InvariantCulture))
				return RebarSpliceBarPositionsEnum.SPLICE_BAR_PARALLEL;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSplice_
    {
        public static dynamic GetTSObject(RebarSplice dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSplice FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarSplice)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSpliceArray_
    {
        public static dynamic GetTSObject(RebarSplice[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSplice_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSplice[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSplice>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSplice_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
