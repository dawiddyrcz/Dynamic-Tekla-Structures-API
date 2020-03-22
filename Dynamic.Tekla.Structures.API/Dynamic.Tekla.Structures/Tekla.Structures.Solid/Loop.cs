/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class Loop 
    {

        

        internal dynamic teklaObject;

		public Loop() {}

		public Dynamic.Tekla.Structures.Solid.VertexEnumerator GetVertexEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.VertexEnumerator_.FromTSObject(teklaObject.GetVertexEnumerator());
		}





    }

    internal static class Loop_
    {
        public static dynamic GetTSObject(Loop dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Loop FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Solid.Loop)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
