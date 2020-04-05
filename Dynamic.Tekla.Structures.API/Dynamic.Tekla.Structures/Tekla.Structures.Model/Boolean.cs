/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class Boolean  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Father);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
			set
			{
				try {
				teklaObject.Father = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
		}

        

        






    }

    internal static class Boolean_
    {
        public static dynamic GetTSObject(Boolean dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Boolean FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Boolean)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BooleanArray_
    {
        public static dynamic GetTSObject(Boolean[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Boolean_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Boolean[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Boolean>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Boolean_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
