/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class ComponentOptions 
    {

		public System.String PlateProfileName
		{
			get => teklaObject.PlateProfileName;
			set { teklaObject.PlateProfileName = value; }
		}

		public System.String FoldedPlateProfileName
		{
			get => teklaObject.FoldedPlateProfileName;
			set { teklaObject.FoldedPlateProfileName = value; }
		}

		public System.Double BoltEdgeDistanceFactor
		{
			get => teklaObject.BoltEdgeDistanceFactor;
			set { teklaObject.BoltEdgeDistanceFactor = value; }
		}

		public Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum BoltEdgeDistanceReference
		{
			get => Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum_.FromTSObject(teklaObject.BoltEdgeDistanceReference);
			set { teklaObject.BoltEdgeDistanceReference = Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum_.GetTSObject(value); }
		}

		public System.String BoltStandard
		{
			get => teklaObject.BoltStandard;
			set { teklaObject.BoltStandard = value; }
		}

		public System.String BoltSize
		{
			get => teklaObject.BoltSize;
			set { teklaObject.BoltSize = value; }
		}

		public System.String PartMaterial
		{
			get => teklaObject.PartMaterial;
			set { teklaObject.PartMaterial = value; }
		}

		public System.Int32 PartWeldedToPrimaryStartNumber
		{
			get => teklaObject.PartWeldedToPrimaryStartNumber;
			set { teklaObject.PartWeldedToPrimaryStartNumber = value; }
		}

		public System.String PartWeldedToPrimaryPositionPrefix
		{
			get => teklaObject.PartWeldedToPrimaryPositionPrefix;
			set { teklaObject.PartWeldedToPrimaryPositionPrefix = value; }
		}

		public System.Int32 PartWeldedToSecondaryStartNumber
		{
			get => teklaObject.PartWeldedToSecondaryStartNumber;
			set { teklaObject.PartWeldedToSecondaryStartNumber = value; }
		}

		public System.String PartWeldedToSecondaryPositionPrefix
		{
			get => teklaObject.PartWeldedToSecondaryPositionPrefix;
			set { teklaObject.PartWeldedToSecondaryPositionPrefix = value; }
		}

		public System.Int32 LoosePartStartNumber
		{
			get => teklaObject.LoosePartStartNumber;
			set { teklaObject.LoosePartStartNumber = value; }
		}

		public System.String LoosePartPositionPrefix
		{
			get => teklaObject.LoosePartPositionPrefix;
			set { teklaObject.LoosePartPositionPrefix = value; }
		}

		public System.Int32 AssemblyLoosePartStartNumber
		{
			get => teklaObject.AssemblyLoosePartStartNumber;
			set { teklaObject.AssemblyLoosePartStartNumber = value; }
		}

		public System.String AssemblyLoosePartPositionPrefix
		{
			get => teklaObject.AssemblyLoosePartPositionPrefix;
			set { teklaObject.AssemblyLoosePartPositionPrefix = value; }
		}

        

        internal dynamic teklaObject;

		public ComponentOptions()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.ComponentOptions");
		}




    public enum BoltEdgeDistanceReferenceEnum
    {
			BOLT_DIAMETER,
			HOLE_DIAMETER        
    }

    internal static class BoltEdgeDistanceReferenceEnum_
    {
        public static dynamic GetTSObject(BoltEdgeDistanceReferenceEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum").GetType();

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

    internal static class ComponentOptions_
    {
        public static dynamic GetTSObject(ComponentOptions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ComponentOptions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.ComponentOptions)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
