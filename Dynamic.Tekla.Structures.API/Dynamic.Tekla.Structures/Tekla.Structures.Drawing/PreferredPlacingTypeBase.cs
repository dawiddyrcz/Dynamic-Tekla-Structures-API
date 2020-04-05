/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PreferredPlacingTypeBase 
    {

        

        internal dynamic teklaObject;






    }

    internal static class PreferredPlacingTypeBase_
    {
        public static dynamic GetTSObject(PreferredPlacingTypeBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PreferredPlacingTypeBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PreferredPlacingTypeBaseArray_
    {
        public static dynamic GetTSObject(PreferredPlacingTypeBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PreferredPlacingTypeBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PreferredPlacingTypeBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PreferredPlacingTypeBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PreferredPlacingTypeBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
