/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class FaceEnumerator 
    {

		public Dynamic.Tekla.Structures.Solid.Face Current
		{
			get => Dynamic.Tekla.Structures.Solid.Face_.FromTSObject(teklaObject.Current);
			set { teklaObject.Current = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public FaceEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class FaceEnumerator_
    {
        public static dynamic GetTSObject(FaceEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FaceEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Solid.FaceEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
