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
			get
			{
				try {
					return teklaObject.PlateProfileName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlateProfileName", ex); }
			}
			set
			{
				try {
					teklaObject.PlateProfileName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlateProfileName", ex); }
			}
		}

		public System.String FoldedPlateProfileName
		{
			get
			{
				try {
					return teklaObject.FoldedPlateProfileName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FoldedPlateProfileName", ex); }
			}
			set
			{
				try {
					teklaObject.FoldedPlateProfileName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FoldedPlateProfileName", ex); }
			}
		}

		public System.Double BoltEdgeDistanceFactor
		{
			get
			{
				try {
					return teklaObject.BoltEdgeDistanceFactor;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltEdgeDistanceFactor", ex); }
			}
			set
			{
				try {
					teklaObject.BoltEdgeDistanceFactor = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltEdgeDistanceFactor", ex); }
			}
		}

		public Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum BoltEdgeDistanceReference
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum_.FromTSObject(teklaObject.BoltEdgeDistanceReference);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltEdgeDistanceReference", ex); }
			}
			set
			{
				try {
				teklaObject.BoltEdgeDistanceReference = Dynamic.Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltEdgeDistanceReference", ex); }
			}
		}

		public System.String BoltStandard
		{
			get
			{
				try {
					return teklaObject.BoltStandard;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltStandard", ex); }
			}
			set
			{
				try {
					teklaObject.BoltStandard = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltStandard", ex); }
			}
		}

		public System.String BoltSize
		{
			get
			{
				try {
					return teklaObject.BoltSize;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltSize", ex); }
			}
			set
			{
				try {
					teklaObject.BoltSize = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltSize", ex); }
			}
		}

		public System.String PartMaterial
		{
			get
			{
				try {
					return teklaObject.PartMaterial;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartMaterial", ex); }
			}
			set
			{
				try {
					teklaObject.PartMaterial = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartMaterial", ex); }
			}
		}

		public System.Int32 PartWeldedToPrimaryStartNumber
		{
			get
			{
				try {
					return teklaObject.PartWeldedToPrimaryStartNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToPrimaryStartNumber", ex); }
			}
			set
			{
				try {
					teklaObject.PartWeldedToPrimaryStartNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToPrimaryStartNumber", ex); }
			}
		}

		public System.String PartWeldedToPrimaryPositionPrefix
		{
			get
			{
				try {
					return teklaObject.PartWeldedToPrimaryPositionPrefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToPrimaryPositionPrefix", ex); }
			}
			set
			{
				try {
					teklaObject.PartWeldedToPrimaryPositionPrefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToPrimaryPositionPrefix", ex); }
			}
		}

		public System.Int32 PartWeldedToSecondaryStartNumber
		{
			get
			{
				try {
					return teklaObject.PartWeldedToSecondaryStartNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToSecondaryStartNumber", ex); }
			}
			set
			{
				try {
					teklaObject.PartWeldedToSecondaryStartNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToSecondaryStartNumber", ex); }
			}
		}

		public System.String PartWeldedToSecondaryPositionPrefix
		{
			get
			{
				try {
					return teklaObject.PartWeldedToSecondaryPositionPrefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToSecondaryPositionPrefix", ex); }
			}
			set
			{
				try {
					teklaObject.PartWeldedToSecondaryPositionPrefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartWeldedToSecondaryPositionPrefix", ex); }
			}
		}

		public System.Int32 LoosePartStartNumber
		{
			get
			{
				try {
					return teklaObject.LoosePartStartNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoosePartStartNumber", ex); }
			}
			set
			{
				try {
					teklaObject.LoosePartStartNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoosePartStartNumber", ex); }
			}
		}

		public System.String LoosePartPositionPrefix
		{
			get
			{
				try {
					return teklaObject.LoosePartPositionPrefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoosePartPositionPrefix", ex); }
			}
			set
			{
				try {
					teklaObject.LoosePartPositionPrefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoosePartPositionPrefix", ex); }
			}
		}

		public System.Int32 AssemblyLoosePartStartNumber
		{
			get
			{
				try {
					return teklaObject.AssemblyLoosePartStartNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyLoosePartStartNumber", ex); }
			}
			set
			{
				try {
					teklaObject.AssemblyLoosePartStartNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyLoosePartStartNumber", ex); }
			}
		}

		public System.String AssemblyLoosePartPositionPrefix
		{
			get
			{
				try {
					return teklaObject.AssemblyLoosePartPositionPrefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyLoosePartPositionPrefix", ex); }
			}
			set
			{
				try {
					teklaObject.AssemblyLoosePartPositionPrefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyLoosePartPositionPrefix", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public ComponentOptions()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.ComponentOptions");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ComponentOptions(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ComponentOptions_
    {
        public static dynamic GetTSObject(ComponentOptions dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ComponentOptions FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.ComponentOptions)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ComponentOptionsArray_
    {
        public static dynamic GetTSObject(ComponentOptions[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ComponentOptions_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ComponentOptions[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ComponentOptions>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ComponentOptions_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
