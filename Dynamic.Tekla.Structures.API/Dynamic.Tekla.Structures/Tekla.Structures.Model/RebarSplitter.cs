/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSplitter  : Dynamic.Tekla.Structures.Model.BaseRebarModifier
    {

		public Dynamic.Tekla.Structures.Model.RebarSplitter.StaggerTypeEnum StaggerType
		{
			get => Dynamic.Tekla.Structures.Model.RebarSplitter.StaggerTypeEnum_.FromTSObject(teklaObject.StaggerType);
			set { teklaObject.StaggerType = Dynamic.Tekla.Structures.Model.RebarSplitter.StaggerTypeEnum_.GetTSObject(value); }
		}

		public System.Double StaggerOffset
		{
			get => teklaObject.StaggerOffset;
			set { teklaObject.StaggerOffset = value; }
		}

		public System.Double SplitOffset
		{
			get => teklaObject.SplitOffset;
			set { teklaObject.SplitOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSplitter.SplitTypeEnum SplitType
		{
			get => Dynamic.Tekla.Structures.Model.RebarSplitter.SplitTypeEnum_.FromTSObject(teklaObject.SplitType);
			set { teklaObject.SplitType = Dynamic.Tekla.Structures.Model.RebarSplitter.SplitTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarLapping Lapping
		{
			get => Dynamic.Tekla.Structures.Model.RebarLapping_.FromTSObject(teklaObject.Lapping);
			set { teklaObject.Lapping = Dynamic.Tekla.Structures.Model.RebarLapping_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarCranking Cranking
		{
			get => Dynamic.Tekla.Structures.Model.RebarCranking_.FromTSObject(teklaObject.Cranking);
			set { teklaObject.Cranking = Dynamic.Tekla.Structures.Model.RebarCranking_.GetTSObject(value); }
		}

        

        

		public RebarSplitter()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplitter");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarSplitter(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAffectedBars(Dynamic.Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum whichEnd)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetAffectedBars(Dynamic.Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum_.GetTSObject(whichEnd)));
		}




    public enum StaggerTypeEnum
    {
			NO_STAGGER,
			STAGGER_LEFT,
			STAGGER_RIGHT,
			STAGGER_MIDDLE        
    }

    internal static class StaggerTypeEnum_
    {
        public static dynamic GetTSObject(StaggerTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplitter.StaggerTypeEnum").GetType();

            switch (dynEnum)
            {
				case StaggerTypeEnum.NO_STAGGER:
					return System.Enum.Parse(tsType, "NO_STAGGER");
				case StaggerTypeEnum.STAGGER_LEFT:
					return System.Enum.Parse(tsType, "STAGGER_LEFT");
				case StaggerTypeEnum.STAGGER_RIGHT:
					return System.Enum.Parse(tsType, "STAGGER_RIGHT");
				case StaggerTypeEnum.STAGGER_MIDDLE:
					return System.Enum.Parse(tsType, "STAGGER_MIDDLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static StaggerTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NO_STAGGER", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.NO_STAGGER;
			else if (tsEnumValue.Equals("STAGGER_LEFT", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.STAGGER_LEFT;
			else if (tsEnumValue.Equals("STAGGER_RIGHT", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.STAGGER_RIGHT;
			else if (tsEnumValue.Equals("STAGGER_MIDDLE", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.STAGGER_MIDDLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum SplitTypeEnum
    {
			LAPPING,
			CRANKING        
    }

    internal static class SplitTypeEnum_
    {
        public static dynamic GetTSObject(SplitTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplitter.SplitTypeEnum").GetType();

            switch (dynEnum)
            {
				case SplitTypeEnum.LAPPING:
					return System.Enum.Parse(tsType, "LAPPING");
				case SplitTypeEnum.CRANKING:
					return System.Enum.Parse(tsType, "CRANKING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SplitTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LAPPING", System.StringComparison.InvariantCulture))
				return SplitTypeEnum.LAPPING;
			else if (tsEnumValue.Equals("CRANKING", System.StringComparison.InvariantCulture))
				return SplitTypeEnum.CRANKING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSplitter_
    {
        public static dynamic GetTSObject(RebarSplitter dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSplitter FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarSplitter)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSplitterArray_
    {
        public static dynamic GetTSObject(RebarSplitter[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSplitter_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSplitter[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<RebarSplitter>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSplitter_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
