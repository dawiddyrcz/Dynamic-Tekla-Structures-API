/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PreferredMarkPlacingTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PointPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "PointPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLineOrWithLeaderLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongLineOrWithLeaderLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongPartCenteredPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongPartCenteredPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartAlongPartPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartAlongPartPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartAlongPartOrWithLeaderLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartAlongPartOrWithLeaderLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartHorizontalPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartHorizontalPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartHorizontalOrWithLeaderLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartHorizontalOrWithLeaderLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase LeaderLinePlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "LeaderLinePlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase LeaderLineAndParentObjectAlongPartPlacingType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "LeaderLineAndParentObjectAlongPartPlacingType");
	var _result = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
	return _result;
}






    }

    internal static class PreferredMarkPlacingTypes_
    {
        public static dynamic GetTSObject(PreferredMarkPlacingTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PreferredMarkPlacingTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PreferredMarkPlacingTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PreferredMarkPlacingTypesArray_
    {
        public static dynamic GetTSObject(PreferredMarkPlacingTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PreferredMarkPlacingTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PreferredMarkPlacingTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PreferredMarkPlacingTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PreferredMarkPlacingTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
