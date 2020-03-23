/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ClashCheckHandler 
    {

        

        internal dynamic teklaObject;

		public ClashCheckHandler() {}

		public System.Boolean RunClashCheck()
		{
			return teklaObject.RunClashCheck();
		}

		public System.Boolean StopClashCheck()
		{
			return teklaObject.StopClashCheck();
		}

		public System.Collections.ArrayList GetIntersectionBoundingBoxes(Dynamic.Tekla.Structures.Identifier ID1, Dynamic.Tekla.Structures.Identifier ID2)
		{
			return teklaObject.GetIntersectionBoundingBoxes(Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID1), Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID2));
		}





    }

    internal static class ClashCheckHandler_
    {
        public static dynamic GetTSObject(ClashCheckHandler dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClashCheckHandler FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.ClashCheckHandler)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
