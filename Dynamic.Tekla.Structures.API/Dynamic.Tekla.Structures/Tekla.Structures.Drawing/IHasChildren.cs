/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class IHasChildren 
    {

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects(System.Type[] TypeFilter)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects(TypeFilter));
		}





    }

    internal static class IHasChildren_
    {
        public static dynamic GetTSObject(IHasChildren dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IHasChildren FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.IHasChildren)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IHasChildrenArray_
    {
        public static dynamic GetTSObject(IHasChildren[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IHasChildren_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IHasChildren[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IHasChildren>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IHasChildren_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
