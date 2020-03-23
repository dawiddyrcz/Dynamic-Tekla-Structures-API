/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class Shell 
    {

        

        internal dynamic teklaObject;

		public Shell() {}

		public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.FaceEnumerator_.FromTSObject(teklaObject.GetFaceEnumerator());
		}

		public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.EdgeEnumerator_.FromTSObject(teklaObject.GetEdgeEnumerator());
		}





    }

    internal static class Shell_
    {
        public static dynamic GetTSObject(Shell dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Shell FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Solid.Shell)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
