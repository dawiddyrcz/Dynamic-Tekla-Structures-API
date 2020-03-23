/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PlacingBase 
    {

        

        internal dynamic teklaObject;


		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PlacingBase_
    {
        public static dynamic GetTSObject(PlacingBase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlacingBase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlacingBaseArray_
    {
        public static dynamic GetTSObject(PlacingBase[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlacingBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlacingBase[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PlacingBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlacingBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
