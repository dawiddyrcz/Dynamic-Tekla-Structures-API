/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class Reinforcement  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
		}

		public System.String Grade
		{
			get => teklaObject.Grade;
			set { teklaObject.Grade = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Int32 Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries NumberingSeries
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.NumberingSeries);
			set { teklaObject.NumberingSeries = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.Collections.ArrayList OnPlaneOffsets
		{
			get => teklaObject.OnPlaneOffsets;
			set { teklaObject.OnPlaneOffsets = value; }
		}

		public System.Double FromPlaneOffset
		{
			get => teklaObject.FromPlaneOffset;
			set { teklaObject.FromPlaneOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum StartPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(teklaObject.StartPointOffsetType);
			set { teklaObject.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value); }
		}

		public System.Double StartPointOffsetValue
		{
			get => teklaObject.StartPointOffsetValue;
			set { teklaObject.StartPointOffsetValue = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum EndPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(teklaObject.EndPointOffsetType);
			set { teklaObject.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value); }
		}

		public System.Double EndPointOffsetValue
		{
			get => teklaObject.EndPointOffsetValue;
			set { teklaObject.EndPointOffsetValue = value; }
		}

		public System.Collections.ArrayList RadiusValues
		{
			get => teklaObject.RadiusValues;
			set { teklaObject.RadiusValues = value; }
		}

		public Dynamic.Tekla.Structures.Forming.DeformingType InputPointDeformingState
		{
			get => Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(teklaObject.InputPointDeformingState);
			set { teklaObject.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(value); }
		}

        

        


		public System.Collections.ArrayList GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum options)
		{
			return teklaObject.GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum_.GetTSObject(options));
		}

		public System.Collections.ArrayList GetRebarGeometries(System.Boolean withHooks)
		{
			return teklaObject.GetRebarGeometries(withHooks);
		}

		public System.Collections.ArrayList GetRebarGeometriesWithoutClashes(System.Boolean withHooks)
		{
			return teklaObject.GetRebarGeometriesWithoutClashes(withHooks);
		}

		public System.Boolean IsGeometryValid()
		{
			return teklaObject.IsGeometryValid();
		}

		public System.Int32 GetNumberOfRebars()
		{
			return teklaObject.GetNumberOfRebars();
		}

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebar(System.Int32 index, System.Boolean withHooks)
		{
			return Dynamic.Tekla.Structures.Model.RebarGeometry_.FromTSObject(teklaObject.GetSingleRebar(index, withHooks));
		}

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebarWithoutClash(System.Int32 index, System.Boolean withHooks)
		{
			return Dynamic.Tekla.Structures.Model.RebarGeometry_.FromTSObject(teklaObject.GetSingleRebarWithoutClash(index, withHooks));
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
		{
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());
		}

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
		{
			return Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(teklaObject.GetFatherPour());
		}

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
		{
			return Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());
		}




    public enum RebarGeometryOptionEnum
    {
			NONE,
			HOOKS,
			AVOID_CLASH,
			LENGTH_ADJUSTMENTS        
    }

    internal static class RebarGeometryOptionEnum_
    {
        public static dynamic GetTSObject(RebarGeometryOptionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum").GetType();

            switch (dynEnum)
            {
				case RebarGeometryOptionEnum.NONE:
					return System.Enum.Parse(tsType, "NONE");
				case RebarGeometryOptionEnum.HOOKS:
					return System.Enum.Parse(tsType, "HOOKS");
				case RebarGeometryOptionEnum.AVOID_CLASH:
					return System.Enum.Parse(tsType, "AVOID_CLASH");
				case RebarGeometryOptionEnum.LENGTH_ADJUSTMENTS:
					return System.Enum.Parse(tsType, "LENGTH_ADJUSTMENTS");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarGeometryOptionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NONE", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.NONE;
			else if (tsEnumValue.Equals("HOOKS", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.HOOKS;
			else if (tsEnumValue.Equals("AVOID_CLASH", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.AVOID_CLASH;
			else if (tsEnumValue.Equals("LENGTH_ADJUSTMENTS", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.LENGTH_ADJUSTMENTS;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarOffsetTypeEnum
    {
			OFFSET_TYPE_COVER_THICKNESS,
			OFFSET_TYPE_LEG_LENGTH        
    }

    internal static class RebarOffsetTypeEnum_
    {
        public static dynamic GetTSObject(RebarOffsetTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS:
					return System.Enum.Parse(tsType, "OFFSET_TYPE_COVER_THICKNESS");
				case RebarOffsetTypeEnum.OFFSET_TYPE_LEG_LENGTH:
					return System.Enum.Parse(tsType, "OFFSET_TYPE_LEG_LENGTH");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarOffsetTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("OFFSET_TYPE_COVER_THICKNESS", System.StringComparison.InvariantCulture))
				return RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
			else if (tsEnumValue.Equals("OFFSET_TYPE_LEG_LENGTH", System.StringComparison.InvariantCulture))
				return RebarOffsetTypeEnum.OFFSET_TYPE_LEG_LENGTH;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Reinforcement_
    {
        public static dynamic GetTSObject(Reinforcement dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Reinforcement FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Reinforcement)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
