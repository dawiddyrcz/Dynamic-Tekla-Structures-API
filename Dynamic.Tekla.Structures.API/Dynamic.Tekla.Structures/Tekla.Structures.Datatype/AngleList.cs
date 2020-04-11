/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public abstract class AngleList 
    {

        

        internal dynamic teklaObject;



public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle> Parse(
	System.String text
	)
{
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.AngleList", "Parse", text);
	var _result = IEnumerableConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle>>(result);
	return _result;
}



public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle> Parse(
	System.String text,
	System.IFormatProvider formatProvider_
	)
{
	
	var formatProvider = ObjectConverter.ToTSObject(formatProvider_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.AngleList", "Parse", text, formatProvider);
	var _result = IEnumerableConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle>>(result);
	return _result;
}



public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle> Parse(
	System.String text,
	System.IFormatProvider formatProvider_,
	Dynamic.Tekla.Structures.Datatype.Angle.UnitType unitType_
	)
{
	
	var formatProvider = ObjectConverter.ToTSObject(formatProvider_);
	var unitType = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(unitType_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.AngleList", "Parse", text, formatProvider, unitType);
	var _result = IEnumerableConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle>>(result);
	return _result;
}






    }

    internal static class AngleList_
    {
        public static dynamic GetTSObject(AngleList dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static AngleList FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.AngleList)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AngleListArray_
    {
        public static dynamic GetTSObject(AngleList[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AngleList_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AngleList[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<AngleList>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AngleList_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
