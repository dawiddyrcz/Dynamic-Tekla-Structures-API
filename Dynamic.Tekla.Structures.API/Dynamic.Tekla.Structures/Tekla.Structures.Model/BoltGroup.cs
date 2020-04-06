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
			get
			{
				try {
					return teklaObject.BoltSize;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltSize"); }
			}
			set
			{
				try {
					teklaObject.BoltSize = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltSize"); }
			}
		}

		public System.String BoltStandard
		{
			get
			{
				try {
					return teklaObject.BoltStandard;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltStandard"); }
			}
			set
			{
				try {
					teklaObject.BoltStandard = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltStandard"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum BoltType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(teklaObject.BoltType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltType"); }
			}
			set
			{
				try {
				teklaObject.BoltType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltType"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum ThreadInMaterial
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(teklaObject.ThreadInMaterial);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ThreadInMaterial"); }
			}
			set
			{
				try {
				teklaObject.ThreadInMaterial = Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ThreadInMaterial"); }
			}
		}

		public System.Double Length
		{
			get
			{
				try {
					return teklaObject.Length;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length"); }
			}
			set
			{
				try {
					teklaObject.Length = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length"); }
			}
		}

		public System.Double CutLength
		{
			get
			{
				try {
					return teklaObject.CutLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutLength"); }
			}
			set
			{
				try {
					teklaObject.CutLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutLength"); }
			}
		}

		public System.Double ExtraLength
		{
			get
			{
				try {
					return teklaObject.ExtraLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtraLength"); }
			}
			set
			{
				try {
					teklaObject.ExtraLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtraLength"); }
			}
		}

		public System.Double Tolerance
		{
			get
			{
				try {
					return teklaObject.Tolerance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Tolerance"); }
			}
			set
			{
				try {
					teklaObject.Tolerance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Tolerance"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum HoleType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(teklaObject.HoleType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HoleType"); }
			}
			set
			{
				try {
				teklaObject.HoleType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HoleType"); }
			}
		}

		public System.Double SlottedHoleX
		{
			get
			{
				try {
					return teklaObject.SlottedHoleX;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SlottedHoleX"); }
			}
			set
			{
				try {
					teklaObject.SlottedHoleX = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SlottedHoleX"); }
			}
		}

		public System.Double SlottedHoleY
		{
			get
			{
				try {
					return teklaObject.SlottedHoleY;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SlottedHoleY"); }
			}
			set
			{
				try {
					teklaObject.SlottedHoleY = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SlottedHoleY"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum RotateSlots
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(teklaObject.RotateSlots);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotateSlots"); }
			}
			set
			{
				try {
				teklaObject.RotateSlots = Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotateSlots"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position"); }
			}
			set
			{
				try {
				teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.StartPointOffset);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPointOffset"); }
			}
			set
			{
				try {
				teklaObject.StartPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPointOffset"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.EndPointOffset);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPointOffset"); }
			}
			set
			{
				try {
				teklaObject.EndPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPointOffset"); }
			}
		}

		public System.Boolean Washer1
		{
			get
			{
				try {
					return teklaObject.Washer1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Washer1"); }
			}
			set
			{
				try {
					teklaObject.Washer1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Washer1"); }
			}
		}

		public System.Boolean Washer2
		{
			get
			{
				try {
					return teklaObject.Washer2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Washer2"); }
			}
			set
			{
				try {
					teklaObject.Washer2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Washer2"); }
			}
		}

		public System.Boolean Washer3
		{
			get
			{
				try {
					return teklaObject.Washer3;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Washer3"); }
			}
			set
			{
				try {
					teklaObject.Washer3 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Washer3"); }
			}
		}

		public System.Boolean Nut1
		{
			get
			{
				try {
					return teklaObject.Nut1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Nut1"); }
			}
			set
			{
				try {
					teklaObject.Nut1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Nut1"); }
			}
		}

		public System.Boolean Nut2
		{
			get
			{
				try {
					return teklaObject.Nut2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Nut2"); }
			}
			set
			{
				try {
					teklaObject.Nut2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Nut2"); }
			}
		}

		public System.Boolean Bolt
		{
			get
			{
				try {
					return teklaObject.Bolt;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Bolt"); }
			}
			set
			{
				try {
					teklaObject.Bolt = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Bolt"); }
			}
		}

		public System.Boolean Hole1
		{
			get
			{
				try {
					return teklaObject.Hole1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole1"); }
			}
			set
			{
				try {
					teklaObject.Hole1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole1"); }
			}
		}

		public System.Boolean Hole2
		{
			get
			{
				try {
					return teklaObject.Hole2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole2"); }
			}
			set
			{
				try {
					teklaObject.Hole2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole2"); }
			}
		}

		public System.Boolean Hole3
		{
			get
			{
				try {
					return teklaObject.Hole3;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole3"); }
			}
			set
			{
				try {
					teklaObject.Hole3 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole3"); }
			}
		}

		public System.Boolean Hole4
		{
			get
			{
				try {
					return teklaObject.Hole4;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole4"); }
			}
			set
			{
				try {
					teklaObject.Hole4 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole4"); }
			}
		}

		public System.Boolean Hole5
		{
			get
			{
				try {
					return teklaObject.Hole5;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole5"); }
			}
			set
			{
				try {
					teklaObject.Hole5 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hole5"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBoltTo
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.PartToBoltTo);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartToBoltTo"); }
			}
			set
			{
				try {
				teklaObject.PartToBoltTo = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartToBoltTo"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBeBolted
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.PartToBeBolted);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartToBeBolted"); }
			}
			set
			{
				try {
				teklaObject.PartToBeBolted = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartToBeBolted"); }
			}
		}

		public System.Collections.ArrayList OtherPartsToBolt
		{
			get
			{
				try {
					return teklaObject.OtherPartsToBolt;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OtherPartsToBolt"); }
			}

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstPosition
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.FirstPosition);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstPosition"); }
			}
			set
			{
				try {
				teklaObject.FirstPosition = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstPosition"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondPosition
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.SecondPosition);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondPosition"); }
			}
			set
			{
				try {
				teklaObject.SecondPosition = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondPosition"); }
			}
		}

		public System.Boolean ConnectAssemblies
		{
			get
			{
				try {
					return teklaObject.ConnectAssemblies;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConnectAssemblies"); }
			}
			set
			{
				try {
					teklaObject.ConnectAssemblies = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConnectAssemblies"); }
			}
		}

		public System.Collections.ArrayList BoltPositions
		{
			get
			{
				try {
					return teklaObject.BoltPositions;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltPositions"); }
			}

		}

        

        


		public System.Boolean AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
		{
			try {
			var result = teklaObject.AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(M));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddOtherPartToBolt()"); }
		}

		public System.Boolean RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
		{
			try {
			var result = teklaObject.RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(M));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveOtherPartToBolt()"); }
		}

		public System.Collections.ArrayList GetOtherPartsToBolt()
		{
			try {
			var result = teklaObject.GetOtherPartsToBolt();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOtherPartsToBolt()"); }
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
		{
			try {
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSolid()"); }
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(System.Boolean withHighAccuracy)
		{
			try {
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(withHighAccuracy));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSolid()"); }
		}

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
		{
			try {
			return Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(teklaObject.GetFatherPour());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetFatherPour()"); }
		}

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
		{
			try {
			return Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetFatherPourUnit()"); }
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
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
    
