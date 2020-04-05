/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BaseRebarModifier  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.RebarSet Father
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarSet_.FromTSObject(teklaObject.Father);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
			set
			{
				try {
				teklaObject.Father = Dynamic.Tekla.Structures.Model.RebarSet_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Contour Curve
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Curve);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Curve"); }
			}
			set
			{
				try {
				teklaObject.Curve = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Curve"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum BarsAffected
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum_.FromTSObject(teklaObject.BarsAffected);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BarsAffected"); }
			}
			set
			{
				try {
				teklaObject.BarsAffected = Dynamic.Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BarsAffected"); }
			}
		}

		public System.Int32 FirstAffectedBar
		{
			get
			{
				try {
					return teklaObject.FirstAffectedBar;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstAffectedBar"); }
			}
			set
			{
				try {
					teklaObject.FirstAffectedBar = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstAffectedBar"); }
			}
		}

        

        





    public enum AffectedRebarEnum
    {
			START,
			END,
			EITHER        
    }

    internal static class AffectedRebarEnum_
    {
        public static dynamic GetTSObject(AffectedRebarEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum").GetType();

            switch (dynEnum)
            {
				case AffectedRebarEnum.START:
					return System.Enum.Parse(tsType, "START");
				case AffectedRebarEnum.END:
					return System.Enum.Parse(tsType, "END");
				case AffectedRebarEnum.EITHER:
					return System.Enum.Parse(tsType, "EITHER");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AffectedRebarEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("START", System.StringComparison.InvariantCulture))
				return AffectedRebarEnum.START;
			else if (tsEnumValue.Equals("END", System.StringComparison.InvariantCulture))
				return AffectedRebarEnum.END;
			else if (tsEnumValue.Equals("EITHER", System.StringComparison.InvariantCulture))
				return AffectedRebarEnum.EITHER;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum BarsAffectedEnum
    {
			ALL_BARS,
			EVERY_SECOND_BAR,
			EVERY_THIRD_BAR,
			EVERY_FOURTH_BAR        
    }

    internal static class BarsAffectedEnum_
    {
        public static dynamic GetTSObject(BarsAffectedEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum").GetType();

            switch (dynEnum)
            {
				case BarsAffectedEnum.ALL_BARS:
					return System.Enum.Parse(tsType, "ALL_BARS");
				case BarsAffectedEnum.EVERY_SECOND_BAR:
					return System.Enum.Parse(tsType, "EVERY_SECOND_BAR");
				case BarsAffectedEnum.EVERY_THIRD_BAR:
					return System.Enum.Parse(tsType, "EVERY_THIRD_BAR");
				case BarsAffectedEnum.EVERY_FOURTH_BAR:
					return System.Enum.Parse(tsType, "EVERY_FOURTH_BAR");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BarsAffectedEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ALL_BARS", System.StringComparison.InvariantCulture))
				return BarsAffectedEnum.ALL_BARS;
			else if (tsEnumValue.Equals("EVERY_SECOND_BAR", System.StringComparison.InvariantCulture))
				return BarsAffectedEnum.EVERY_SECOND_BAR;
			else if (tsEnumValue.Equals("EVERY_THIRD_BAR", System.StringComparison.InvariantCulture))
				return BarsAffectedEnum.EVERY_THIRD_BAR;
			else if (tsEnumValue.Equals("EVERY_FOURTH_BAR", System.StringComparison.InvariantCulture))
				return BarsAffectedEnum.EVERY_FOURTH_BAR;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BaseRebarModifier_
    {
        public static dynamic GetTSObject(BaseRebarModifier dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BaseRebarModifier FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BaseRebarModifier)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BaseRebarModifierArray_
    {
        public static dynamic GetTSObject(BaseRebarModifier[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BaseRebarModifier_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BaseRebarModifier[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BaseRebarModifier>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BaseRebarModifier_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
