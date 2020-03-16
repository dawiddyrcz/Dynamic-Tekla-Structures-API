//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class ComponentOptions 
    {

		public System.String PlateProfileName
		{
			get => componentoptions.PlateProfileName;
			set { componentoptions.PlateProfileName = value; }
		}

		public System.String FoldedPlateProfileName
		{
			get => componentoptions.FoldedPlateProfileName;
			set { componentoptions.FoldedPlateProfileName = value; }
		}

		public System.Double BoltEdgeDistanceFactor
		{
			get => componentoptions.BoltEdgeDistanceFactor;
			set { componentoptions.BoltEdgeDistanceFactor = value; }
		}

		public Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum BoltEdgeDistanceReference
		{
			get => Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum_.FromTSObject(componentoptions.BoltEdgeDistanceReference);
			set { componentoptions.BoltEdgeDistanceReference = Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum_.FromTSObject(value); }
		}

		public System.String BoltStandard
		{
			get => componentoptions.BoltStandard;
			set { componentoptions.BoltStandard = value; }
		}

		public System.String BoltSize
		{
			get => componentoptions.BoltSize;
			set { componentoptions.BoltSize = value; }
		}

		public System.String PartMaterial
		{
			get => componentoptions.PartMaterial;
			set { componentoptions.PartMaterial = value; }
		}

		public System.Int32 PartWeldedToPrimaryStartNumber
		{
			get => componentoptions.PartWeldedToPrimaryStartNumber;
			set { componentoptions.PartWeldedToPrimaryStartNumber = value; }
		}

		public System.String PartWeldedToPrimaryPositionPrefix
		{
			get => componentoptions.PartWeldedToPrimaryPositionPrefix;
			set { componentoptions.PartWeldedToPrimaryPositionPrefix = value; }
		}

		public System.Int32 PartWeldedToSecondaryStartNumber
		{
			get => componentoptions.PartWeldedToSecondaryStartNumber;
			set { componentoptions.PartWeldedToSecondaryStartNumber = value; }
		}

		public System.String PartWeldedToSecondaryPositionPrefix
		{
			get => componentoptions.PartWeldedToSecondaryPositionPrefix;
			set { componentoptions.PartWeldedToSecondaryPositionPrefix = value; }
		}

		public System.Int32 LoosePartStartNumber
		{
			get => componentoptions.LoosePartStartNumber;
			set { componentoptions.LoosePartStartNumber = value; }
		}

		public System.String LoosePartPositionPrefix
		{
			get => componentoptions.LoosePartPositionPrefix;
			set { componentoptions.LoosePartPositionPrefix = value; }
		}

		public System.Int32 AssemblyLoosePartStartNumber
		{
			get => componentoptions.AssemblyLoosePartStartNumber;
			set { componentoptions.AssemblyLoosePartStartNumber = value; }
		}

		public System.String AssemblyLoosePartPositionPrefix
		{
			get => componentoptions.AssemblyLoosePartPositionPrefix;
			set { componentoptions.AssemblyLoosePartPositionPrefix = value; }
		}

        

        dynamic componentoptions;
        
        public ComponentOptions()
        {
            this.componentoptions =  new Tekla.Structures.ComponentOptions();
        }

        public ComponentOptions(dynamic tsObject)
        {
            this.componentoptions = tsObject;
			this.PlateProfileName = componentoptions.PlateProfileName;
			this.FoldedPlateProfileName = componentoptions.FoldedPlateProfileName;
			this.BoltEdgeDistanceFactor = componentoptions.BoltEdgeDistanceFactor;
			this.BoltEdgeDistanceReference = Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum_.FromTSObject(componentoptions.BoltEdgeDistanceReference);
			this.BoltStandard = componentoptions.BoltStandard;
			this.BoltSize = componentoptions.BoltSize;
			this.PartMaterial = componentoptions.PartMaterial;
			this.PartWeldedToPrimaryStartNumber = componentoptions.PartWeldedToPrimaryStartNumber;
			this.PartWeldedToPrimaryPositionPrefix = componentoptions.PartWeldedToPrimaryPositionPrefix;
			this.PartWeldedToSecondaryStartNumber = componentoptions.PartWeldedToSecondaryStartNumber;
			this.PartWeldedToSecondaryPositionPrefix = componentoptions.PartWeldedToSecondaryPositionPrefix;
			this.LoosePartStartNumber = componentoptions.LoosePartStartNumber;
			this.LoosePartPositionPrefix = componentoptions.LoosePartPositionPrefix;
			this.AssemblyLoosePartStartNumber = componentoptions.AssemblyLoosePartStartNumber;
			this.AssemblyLoosePartPositionPrefix = componentoptions.AssemblyLoosePartPositionPrefix;

        }


        public dynamic GetTSObject() => componentoptions;

		public System.Boolean Equals(System.Object obj)
			 => componentoptions.Equals(obj);

		public System.Int32 GetHashCode()
			 => componentoptions.GetHashCode();

		public System.Type GetType()
			 => componentoptions.GetType();

		public System.String ToString()
			 => componentoptions.ToString();




    public enum BoltEdgeDistanceReferenceEnum
    {
			BOLT_DIAMETER,
			HOLE_DIAMETER        
    }

    public static class BoltEdgeDistanceReferenceEnum_
    {
        public static dynamic GetTSObject(BoltEdgeDistanceReferenceEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.BoltEdgeDistanceReferenceEnum");

            switch (dynEnum)
            {
				case BoltEdgeDistanceReferenceEnum.BOLT_DIAMETER:
					return System.Enum.Parse(tsType, "BOLT_DIAMETER");
				case BoltEdgeDistanceReferenceEnum.HOLE_DIAMETER:
					return System.Enum.Parse(tsType, "HOLE_DIAMETER");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltEdgeDistanceReferenceEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BOLT_DIAMETER", System.StringComparison.InvariantCulture))
				return BoltEdgeDistanceReferenceEnum.BOLT_DIAMETER;
			else if (tsEnumValue.Equals("HOLE_DIAMETER", System.StringComparison.InvariantCulture))
				return BoltEdgeDistanceReferenceEnum.HOLE_DIAMETER;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
