/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class LineTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.LineTypes Custom(System.String CustomLineTypeName)
		{
			var parameters = new object[1];
			parameters[0] = CustomLineTypeName;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "Custom", parameters);
			return Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(result);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class LineTypes_
    {
        public static dynamic GetTSObject(LineTypes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static LineTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LineTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LineTypesArray_
    {
        public static dynamic GetTSObject(LineTypes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LineTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LineTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<LineTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LineTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
