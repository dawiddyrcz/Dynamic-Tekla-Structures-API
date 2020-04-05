/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSpacing 
    {

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarSpacingZone> Zones
		{
			get
			{
				try {
					return teklaObject.Zones;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Zones"); }
			}
			set
			{
				try {
					teklaObject.Zones = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Zones"); }
			}
		}

		public System.Double StartOffset
		{
			get
			{
				try {
					return teklaObject.StartOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartOffset"); }
			}
			set
			{
				try {
					teklaObject.StartOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartOffset"); }
			}
		}

		public System.Double EndOffset
		{
			get
			{
				try {
					return teklaObject.EndOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndOffset"); }
			}
			set
			{
				try {
					teklaObject.EndOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndOffset"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum StartOffsetType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.FromTSObject(teklaObject.StartOffsetType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartOffsetType"); }
			}
			set
			{
				try {
				teklaObject.StartOffsetType = Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartOffsetType"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum EndOffsetType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.FromTSObject(teklaObject.EndOffsetType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndOffsetType"); }
			}
			set
			{
				try {
				teklaObject.EndOffsetType = Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndOffsetType"); }
			}
		}

		public System.Boolean StartOffsetIsAutomatic
		{
			get
			{
				try {
					return teklaObject.StartOffsetIsAutomatic;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartOffsetIsAutomatic"); }
			}
			set
			{
				try {
					teklaObject.StartOffsetIsAutomatic = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartOffsetIsAutomatic"); }
			}
		}

		public System.Boolean EndOffsetIsAutomatic
		{
			get
			{
				try {
					return teklaObject.EndOffsetIsAutomatic;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndOffsetIsAutomatic"); }
			}
			set
			{
				try {
					teklaObject.EndOffsetIsAutomatic = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndOffsetIsAutomatic"); }
			}
		}

		public System.Boolean InheritFromPrimary
		{
			get
			{
				try {
					return teklaObject.InheritFromPrimary;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InheritFromPrimary"); }
			}
			set
			{
				try {
					teklaObject.InheritFromPrimary = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InheritFromPrimary"); }
			}
		}

        

        internal dynamic teklaObject;

		public RebarSpacing()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarSpacing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum OffsetEnum
    {
			EXACT,
			MINIMUM        
    }

    internal static class OffsetEnum_
    {
        public static dynamic GetTSObject(OffsetEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing.OffsetEnum").GetType();

            switch (dynEnum)
            {
				case OffsetEnum.EXACT:
					return System.Enum.Parse(tsType, "EXACT");
				case OffsetEnum.MINIMUM:
					return System.Enum.Parse(tsType, "MINIMUM");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static OffsetEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXACT", System.StringComparison.InvariantCulture))
				return OffsetEnum.EXACT;
			else if (tsEnumValue.Equals("MINIMUM", System.StringComparison.InvariantCulture))
				return OffsetEnum.MINIMUM;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSpacing_
    {
        public static dynamic GetTSObject(RebarSpacing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSpacing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarSpacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSpacingArray_
    {
        public static dynamic GetTSObject(RebarSpacing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSpacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSpacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSpacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSpacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
