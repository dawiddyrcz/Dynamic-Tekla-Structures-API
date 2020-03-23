/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class IRelatedObjects 
    {

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetRelatedObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetRelatedObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetRelatedObjects(System.Type[] TypeFilter)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetRelatedObjects(TypeFilter));
		}





    }

    internal static class IRelatedObjects_
    {
        public static dynamic GetTSObject(IRelatedObjects dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static IRelatedObjects FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.IRelatedObjects)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IRelatedObjectsArray_
    {
        public static dynamic GetTSObject(IRelatedObjects[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IRelatedObjects_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IRelatedObjects[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<IRelatedObjects>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IRelatedObjects_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
