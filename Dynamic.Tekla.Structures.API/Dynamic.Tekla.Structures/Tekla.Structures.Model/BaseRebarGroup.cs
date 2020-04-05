/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BaseRebarGroup  : Dynamic.Tekla.Structures.Model.Reinforcement
    {

		public System.String Size
		{
			get
			{
				try {
					return teklaObject.Size;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size"); }
			}
			set
			{
				try {
					teklaObject.Size = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.StartHook);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartHook"); }
			}
			set
			{
				try {
				teklaObject.StartHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartHook"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.EndHook);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndHook"); }
			}
			set
			{
				try {
				teklaObject.EndHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndHook"); }
			}
		}

		public System.Double FromPlaneOffset
		{
			get
			{
				try {
					return teklaObject.FromPlaneOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromPlaneOffset"); }
			}
			set
			{
				try {
					teklaObject.FromPlaneOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromPlaneOffset"); }
			}
		}

		public System.Double StartFromPlaneOffset
		{
			get
			{
				try {
					return teklaObject.StartFromPlaneOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartFromPlaneOffset"); }
			}
			set
			{
				try {
					teklaObject.StartFromPlaneOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartFromPlaneOffset"); }
			}
		}

		public System.Double EndFromPlaneOffset
		{
			get
			{
				try {
					return teklaObject.EndFromPlaneOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndFromPlaneOffset"); }
			}
			set
			{
				try {
					teklaObject.EndFromPlaneOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndFromPlaneOffset"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum ExcludeType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(teklaObject.ExcludeType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExcludeType"); }
			}
			set
			{
				try {
				teklaObject.ExcludeType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExcludeType"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum SpacingType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(teklaObject.SpacingType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SpacingType"); }
			}
			set
			{
				try {
				teklaObject.SpacingType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SpacingType"); }
			}
		}

		public System.Collections.ArrayList Spacings
		{
			get
			{
				try {
					return teklaObject.Spacings;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spacings"); }
			}
			set
			{
				try {
					teklaObject.Spacings = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spacings"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
			set
			{
				try {
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

        

        





    public enum ExcludeTypeEnum
    {
			EXCLUDE_TYPE_NONE,
			EXCLUDE_TYPE_FIRST,
			EXCLUDE_TYPE_LAST,
			EXCLUDE_TYPE_BOTH        
    }

    internal static class ExcludeTypeEnum_
    {
        public static dynamic GetTSObject(ExcludeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum").GetType();

            switch (dynEnum)
            {
				case ExcludeTypeEnum.EXCLUDE_TYPE_NONE:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_NONE");
				case ExcludeTypeEnum.EXCLUDE_TYPE_FIRST:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_FIRST");
				case ExcludeTypeEnum.EXCLUDE_TYPE_LAST:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_LAST");
				case ExcludeTypeEnum.EXCLUDE_TYPE_BOTH:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_BOTH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ExcludeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXCLUDE_TYPE_NONE", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_NONE;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_FIRST", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_FIRST;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_LAST", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_LAST;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_BOTH", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_BOTH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarGroupSpacingTypeEnum
    {
			SPACING_TYPE_UNDEFINED,
			SPACING_TYPE_EXACT_SPACINGS,
			SPACING_TYPE_EXACT_NUMBER,
			SPACING_TYPE_TARGET_SPACE,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_START,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_END,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE        
    }

    internal static class RebarGroupSpacingTypeEnum_
    {
        public static dynamic GetTSObject(RebarGroupSpacingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_UNDEFINED:
					return System.Enum.Parse(tsType, "SPACING_TYPE_UNDEFINED");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACINGS:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACINGS");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_NUMBER:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_NUMBER");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE:
					return System.Enum.Parse(tsType, "SPACING_TYPE_TARGET_SPACE");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_START:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_START");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_END:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_END");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarGroupSpacingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPACING_TYPE_UNDEFINED", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_UNDEFINED;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACINGS", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACINGS;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_NUMBER", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_NUMBER;
			else if (tsEnumValue.Equals("SPACING_TYPE_TARGET_SPACE", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_START", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_START;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_END", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_END;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BaseRebarGroup_
    {
        public static dynamic GetTSObject(BaseRebarGroup dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BaseRebarGroup FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BaseRebarGroup)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BaseRebarGroupArray_
    {
        public static dynamic GetTSObject(BaseRebarGroup[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BaseRebarGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BaseRebarGroup[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BaseRebarGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BaseRebarGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
