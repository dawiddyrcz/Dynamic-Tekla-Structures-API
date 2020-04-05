/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PreferredSymbolPlacingTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PointPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredSymbolPlacingTypes", "PointPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase LeaderLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredSymbolPlacingTypes", "LeaderLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredSymbolPlacingTypes", "AlongLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}





    }

    internal static class PreferredSymbolPlacingTypes_
    {
        public static dynamic GetTSObject(PreferredSymbolPlacingTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PreferredSymbolPlacingTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PreferredSymbolPlacingTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PreferredSymbolPlacingTypesArray_
    {
        public static dynamic GetTSObject(PreferredSymbolPlacingTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PreferredSymbolPlacingTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PreferredSymbolPlacingTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PreferredSymbolPlacingTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PreferredSymbolPlacingTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
