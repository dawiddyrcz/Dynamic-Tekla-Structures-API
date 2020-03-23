/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class VertexEnumerator 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Current
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Current);
			set { teklaObject.Current = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public VertexEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class VertexEnumerator_
    {
        public static dynamic GetTSObject(VertexEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static VertexEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Solid.VertexEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
