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

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetRelatedObjects(System.Type TypeFilter)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetRelatedObjects(TypeFilter));
		}





    }

    internal static class IRelatedObjects_
    {
        public static dynamic GetTSObject(IRelatedObjects dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IRelatedObjects FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.IRelatedObjects)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
