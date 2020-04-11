/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PreferredTextPlacingTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PointPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "PointPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase LeaderLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "LeaderLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "AlongLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase BaseLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "BaseLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase BaseLineWithArrowAtStartPointPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "BaseLineWithArrowAtStartPointPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase BaseLineWithArrowAtEndPointPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "BaseLineWithArrowAtEndPointPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}






    }

    internal static class PreferredTextPlacingTypes_
    {
        public static dynamic GetTSObject(PreferredTextPlacingTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PreferredTextPlacingTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PreferredTextPlacingTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PreferredTextPlacingTypesArray_
    {
        public static dynamic GetTSObject(PreferredTextPlacingTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PreferredTextPlacingTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PreferredTextPlacingTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PreferredTextPlacingTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PreferredTextPlacingTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
