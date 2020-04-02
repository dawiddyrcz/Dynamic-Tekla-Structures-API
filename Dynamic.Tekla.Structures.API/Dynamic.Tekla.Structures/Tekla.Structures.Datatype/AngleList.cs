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


		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle> Parse(System.String text)
		{
			var parameters = new object[1];
			parameters[0] = text;
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle>) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.AngleList", "Parse", parameters);
			return result;
		}

		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle> Parse(System.String text, System.IFormatProvider formatProvider)
		{
			var parameters = new object[2];
			parameters[0] = text;
			parameters[1] = formatProvider;
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle>) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.AngleList", "Parse", parameters);
			return result;
		}

		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle> Parse(System.String text, System.IFormatProvider formatProvider, Dynamic.Tekla.Structures.Datatype.Angle.UnitType unitType)
		{
			var parameters = new object[3];
			parameters[0] = text;
			parameters[1] = formatProvider;
			parameters[2] = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(unitType);
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Datatype.Angle>) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.AngleList", "Parse", parameters);
			return result;
		}





    }

    internal static class AngleList_
    {
        public static dynamic GetTSObject(AngleList dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static AngleList FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AngleList_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AngleList[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<AngleList>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AngleList_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    