/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public abstract class AttributeConfiguration 
    {

        

        internal dynamic teklaObject;





    public enum DrawingTypes
    {
			UNKNOWN,
			GA,
			Assembly,
			CastUnit,
			SinglePart,
			Wizard        
    }

    internal static class DrawingTypes_
    {
        public static dynamic GetTSObject(DrawingTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.AttributeConfiguration.DrawingTypes").GetType();

            switch (dynEnum)
            {
				case DrawingTypes.UNKNOWN:
					return System.Enum.Parse(tsType, "UNKNOWN");
				case DrawingTypes.GA:
					return System.Enum.Parse(tsType, "GA");
				case DrawingTypes.Assembly:
					return System.Enum.Parse(tsType, "Assembly");
				case DrawingTypes.CastUnit:
					return System.Enum.Parse(tsType, "CastUnit");
				case DrawingTypes.SinglePart:
					return System.Enum.Parse(tsType, "SinglePart");
				case DrawingTypes.Wizard:
					return System.Enum.Parse(tsType, "Wizard");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DrawingTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
				return DrawingTypes.UNKNOWN;
			else if (tsEnumValue.Equals("GA", System.StringComparison.InvariantCulture))
				return DrawingTypes.GA;
			else if (tsEnumValue.Equals("Assembly", System.StringComparison.InvariantCulture))
				return DrawingTypes.Assembly;
			else if (tsEnumValue.Equals("CastUnit", System.StringComparison.InvariantCulture))
				return DrawingTypes.CastUnit;
			else if (tsEnumValue.Equals("SinglePart", System.StringComparison.InvariantCulture))
				return DrawingTypes.SinglePart;
			else if (tsEnumValue.Equals("Wizard", System.StringComparison.InvariantCulture))
				return DrawingTypes.Wizard;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class AttributeConfiguration_
    {
        public static dynamic GetTSObject(AttributeConfiguration dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static AttributeConfiguration FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.AttributeConfiguration)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AttributeConfigurationArray_
    {
        public static dynamic GetTSObject(AttributeConfiguration[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AttributeConfiguration_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AttributeConfiguration[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<AttributeConfiguration>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AttributeConfiguration_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    