/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class ParametricObject_CustomProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

        

        

		public ParametricObject_CustomProfile() {}





    }

    internal static class ParametricObject_CustomProfile_
    {
        public static dynamic GetTSObject(ParametricObject_CustomProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ParametricObject_CustomProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.ParametricObject_CustomProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ParametricObject_CustomProfileArray_
    {
        public static dynamic GetTSObject(ParametricObject_CustomProfile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ParametricObject_CustomProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ParametricObject_CustomProfile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ParametricObject_CustomProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ParametricObject_CustomProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
