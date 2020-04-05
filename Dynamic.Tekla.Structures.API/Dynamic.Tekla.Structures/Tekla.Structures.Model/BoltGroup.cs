/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BoltGroup  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.Double BoltSize
		{
			get => teklaObject.BoltSize;
			set { teklaObject.BoltSize = value; }
		}

		public System.String BoltStandard
		{
			get => teklaObject.BoltStandard;
			set { teklaObject.BoltStandard = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum BoltType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(teklaObject.BoltType);
			set { teklaObject.BoltType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum ThreadInMaterial
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(teklaObject.ThreadInMaterial);
			set { teklaObject.ThreadInMaterial = Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.GetTSObject(value); }
		}

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public System.Double CutLength
		{
			get => teklaObject.CutLength;
			set { teklaObject.CutLength = value; }
		}

		public System.Double ExtraLength
		{
			get => teklaObject.ExtraLength;
			set { teklaObject.ExtraLength = value; }
		}

		public System.Double Tolerance
		{
			get => teklaObject.Tolerance;
			set { teklaObject.Tolerance = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum HoleType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(teklaObject.HoleType);
			set { teklaObject.HoleType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.GetTSObject(value); }
		}

		public System.Double SlottedHoleX
		{
			get => teklaObject.SlottedHoleX;
			set { teklaObject.SlottedHoleX = value; }
		}

		public System.Double SlottedHoleY
		{
			get => teklaObject.SlottedHoleY;
			set { teklaObject.SlottedHoleY = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum RotateSlots
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(teklaObject.RotateSlots);
			set { teklaObject.RotateSlots = Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get => Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.StartPointOffset);
			set { teklaObject.StartPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get => Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.EndPointOffset);
			set { teklaObject.EndPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value); }
		}

		public System.Boolean Washer1
		{
			get => teklaObject.Washer1;
			set { teklaObject.Washer1 = value; }
		}

		public System.Boolean Washer2
		{
			get => teklaObject.Washer2;
			set { teklaObject.Washer2 = value; }
		}

		public System.Boolean Washer3
		{
			get => teklaObject.Washer3;
			set { teklaObject.Washer3 = value; }
		}

		public System.Boolean Nut1
		{
			get => teklaObject.Nut1;
			set { teklaObject.Nut1 = value; }
		}

		public System.Boolean Nut2
		{
			get => teklaObject.Nut2;
			set { teklaObject.Nut2 = value; }
		}

		public System.Boolean Bolt
		{
			get => teklaObject.Bolt;
			set { teklaObject.Bolt = value; }
		}

		public System.Boolean Hole1
		{
			get => teklaObject.Hole1;
			set { teklaObject.Hole1 = value; }
		}

		public System.Boolean Hole2
		{
			get => teklaObject.Hole2;
			set { teklaObject.Hole2 = value; }
		}

		public System.Boolean Hole3
		{
			get => teklaObject.Hole3;
			set { teklaObject.Hole3 = value; }
		}

		public System.Boolean Hole4
		{
			get => teklaObject.Hole4;
			set { teklaObject.Hole4 = value; }
		}

		public System.Boolean Hole5
		{
			get => teklaObject.Hole5;
			set { teklaObject.Hole5 = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBoltTo
		{
			get => Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.PartToBoltTo);
			set { teklaObject.PartToBoltTo = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBeBolted
		{
			get => Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.PartToBeBolted);
			set { teklaObject.PartToBeBolted = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value); }
		}

		public System.Collections.ArrayList OtherPartsToBolt
		{
			get => teklaObject.OtherPartsToBolt;

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstPosition
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.FirstPosition);
			set { teklaObject.FirstPosition = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondPosition
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.SecondPosition);
			set { teklaObject.SecondPosition = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => teklaObject.ConnectAssemblies;
			set { teklaObject.ConnectAssemblies = value; }
		}

		public System.Collections.ArrayList BoltPositions
		{
			get => teklaObject.BoltPositions;

		}

        

        


		public System.Boolean AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
		{
			return teklaObject.AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(M));
		}

		public System.Boolean RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
		{
			return teklaObject.RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(M));
		}

		public System.Collections.ArrayList GetOtherPartsToBolt()
		{
			return teklaObject.GetOtherPartsToBolt();
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
		{
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(System.Boolean withHighAccuracy)
		{
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(withHighAccuracy));
		}

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
		{
			return Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(teklaObject.GetFatherPour());
		}

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
		{
			return Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());
		}




    public enum BoltTypeEnum
    {
			BOLT_TYPE_SITE,
			BOLT_TYPE_WORKSHOP        
    }

    internal static class BoltTypeEnum_
    {
        public static dynamic GetTSObject(BoltTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltTypeEnum").GetType();

            switch (dynEnum)
            {
				case BoltTypeEnum.BOLT_TYPE_SITE:
					return System.Enum.Parse(tsType, "BOLT_TYPE_SITE");
				case BoltTypeEnum.BOLT_TYPE_WORKSHOP:
					return System.Enum.Parse(tsType, "BOLT_TYPE_WORKSHOP");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BOLT_TYPE_SITE", System.StringComparison.InvariantCulture))
				return BoltTypeEnum.BOLT_TYPE_SITE;
			else if (tsEnumValue.Equals("BOLT_TYPE_WORKSHOP", System.StringComparison.InvariantCulture))
				return BoltTypeEnum.BOLT_TYPE_WORKSHOP;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum BoltThreadInMaterialEnum
    {
			THREAD_IN_MATERIAL_NO,
			THREAD_IN_MATERIAL_YES        
    }

    internal static class BoltThreadInMaterialEnum_
    {
        public static dynamic GetTSObject(BoltThreadInMaterialEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum").GetType();

            switch (dynEnum)
            {
				case BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO:
					return System.Enum.Parse(tsType, "THREAD_IN_MATERIAL_NO");
				case BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES:
					return System.Enum.Parse(tsType, "THREAD_IN_MATERIAL_YES");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltThreadInMaterialEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("THREAD_IN_MATERIAL_NO", System.StringComparison.InvariantCulture))
				return BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;
			else if (tsEnumValue.Equals("THREAD_IN_MATERIAL_YES", System.StringComparison.InvariantCulture))
				return BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum BoltHoleTypeEnum
    {
			HOLE_TYPE_OVERSIZED,
			HOLE_TYPE_SLOTTED,
			HOLE_TYPE_NO_HOLE        
    }

    internal static class BoltHoleTypeEnum_
    {
        public static dynamic GetTSObject(BoltHoleTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum").GetType();

            switch (dynEnum)
            {
				case BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED:
					return System.Enum.Parse(tsType, "HOLE_TYPE_OVERSIZED");
				case BoltHoleTypeEnum.HOLE_TYPE_SLOTTED:
					return System.Enum.Parse(tsType, "HOLE_TYPE_SLOTTED");
				case BoltHoleTypeEnum.HOLE_TYPE_NO_HOLE:
					return System.Enum.Parse(tsType, "HOLE_TYPE_NO_HOLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltHoleTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HOLE_TYPE_OVERSIZED", System.StringComparison.InvariantCulture))
				return BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED;
			else if (tsEnumValue.Equals("HOLE_TYPE_SLOTTED", System.StringComparison.InvariantCulture))
				return BoltHoleTypeEnum.HOLE_TYPE_SLOTTED;
			else if (tsEnumValue.Equals("HOLE_TYPE_NO_HOLE", System.StringComparison.InvariantCulture))
				return BoltHoleTypeEnum.HOLE_TYPE_NO_HOLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum BoltRotateSlotsEnum
    {
			ROTATE_SLOTS_ODD,
			ROTATE_SLOTS_EVEN,
			ROTATE_SLOTS_PARALLEL        
    }

    internal static class BoltRotateSlotsEnum_
    {
        public static dynamic GetTSObject(BoltRotateSlotsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum").GetType();

            switch (dynEnum)
            {
				case BoltRotateSlotsEnum.ROTATE_SLOTS_ODD:
					return System.Enum.Parse(tsType, "ROTATE_SLOTS_ODD");
				case BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN:
					return System.Enum.Parse(tsType, "ROTATE_SLOTS_EVEN");
				case BoltRotateSlotsEnum.ROTATE_SLOTS_PARALLEL:
					return System.Enum.Parse(tsType, "ROTATE_SLOTS_PARALLEL");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltRotateSlotsEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ROTATE_SLOTS_ODD", System.StringComparison.InvariantCulture))
				return BoltRotateSlotsEnum.ROTATE_SLOTS_ODD;
			else if (tsEnumValue.Equals("ROTATE_SLOTS_EVEN", System.StringComparison.InvariantCulture))
				return BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN;
			else if (tsEnumValue.Equals("ROTATE_SLOTS_PARALLEL", System.StringComparison.InvariantCulture))
				return BoltRotateSlotsEnum.ROTATE_SLOTS_PARALLEL;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BoltGroup_
    {
        public static dynamic GetTSObject(BoltGroup dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BoltGroup FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BoltGroup)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BoltGroupArray_
    {
        public static dynamic GetTSObject(BoltGroup[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BoltGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BoltGroup[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BoltGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BoltGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
