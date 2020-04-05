/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSpacingZone 
    {

		public System.Int32 NumberOfSpaces
		{
			get
			{
				try {
					return teklaObject.NumberOfSpaces;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NumberOfSpaces"); }
			}
			set
			{
				try {
					teklaObject.NumberOfSpaces = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NumberOfSpaces"); }
			}
		}

		public System.Double Spacing
		{
			get
			{
				try {
					return teklaObject.Spacing;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spacing"); }
			}
			set
			{
				try {
					teklaObject.Spacing = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spacing"); }
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

		public Dynamic.Tekla.Structures.Model.RebarSpacingZone.SpacingEnum NumberOfSpacesType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarSpacingZone.SpacingEnum_.FromTSObject(teklaObject.NumberOfSpacesType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NumberOfSpacesType"); }
			}
			set
			{
				try {
				teklaObject.NumberOfSpacesType = Dynamic.Tekla.Structures.Model.RebarSpacingZone.SpacingEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NumberOfSpacesType"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarSpacingZone.SpacingEnum SpacingType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarSpacingZone.SpacingEnum_.FromTSObject(teklaObject.SpacingType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SpacingType"); }
			}
			set
			{
				try {
				teklaObject.SpacingType = Dynamic.Tekla.Structures.Model.RebarSpacingZone.SpacingEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SpacingType"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarSpacingZone.LengthEnum LengthType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarSpacingZone.LengthEnum_.FromTSObject(teklaObject.LengthType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LengthType"); }
			}
			set
			{
				try {
				teklaObject.LengthType = Dynamic.Tekla.Structures.Model.RebarSpacingZone.LengthEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LengthType"); }
			}
		}

        

        internal dynamic teklaObject;

		public RebarSpacingZone()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacingZone");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarSpacingZone(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum LengthEnum
    {
			ABSOLUTE,
			RELATIVE        
    }

    internal static class LengthEnum_
    {
        public static dynamic GetTSObject(LengthEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacingZone.LengthEnum").GetType();

            switch (dynEnum)
            {
				case LengthEnum.ABSOLUTE:
					return System.Enum.Parse(tsType, "ABSOLUTE");
				case LengthEnum.RELATIVE:
					return System.Enum.Parse(tsType, "RELATIVE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LengthEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ABSOLUTE", System.StringComparison.InvariantCulture))
				return LengthEnum.ABSOLUTE;
			else if (tsEnumValue.Equals("RELATIVE", System.StringComparison.InvariantCulture))
				return LengthEnum.RELATIVE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum SpacingEnum
    {
			EXACT,
			TARGET        
    }

    internal static class SpacingEnum_
    {
        public static dynamic GetTSObject(SpacingEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacingZone.SpacingEnum").GetType();

            switch (dynEnum)
            {
				case SpacingEnum.EXACT:
					return System.Enum.Parse(tsType, "EXACT");
				case SpacingEnum.TARGET:
					return System.Enum.Parse(tsType, "TARGET");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SpacingEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXACT", System.StringComparison.InvariantCulture))
				return SpacingEnum.EXACT;
			else if (tsEnumValue.Equals("TARGET", System.StringComparison.InvariantCulture))
				return SpacingEnum.TARGET;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSpacingZone_
    {
        public static dynamic GetTSObject(RebarSpacingZone dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSpacingZone FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarSpacingZone)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSpacingZoneArray_
    {
        public static dynamic GetTSObject(RebarSpacingZone[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSpacingZone_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSpacingZone[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSpacingZone>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSpacingZone_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
