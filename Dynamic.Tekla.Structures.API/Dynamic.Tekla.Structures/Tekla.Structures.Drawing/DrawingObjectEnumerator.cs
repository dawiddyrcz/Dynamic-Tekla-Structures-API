/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DrawingObjectEnumerator  : Dynamic.Tekla.Structures.Drawing.DrawingEnumeratorBase
    {

		public Dynamic.Tekla.Structures.Drawing.DrawingObject Current
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(teklaObject.Current);
			set { teklaObject.Current = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(value); }
		}

        

        

		public DrawingObjectEnumerator() {}





    }

    internal static class DrawingObjectEnumerator_
    {
        public static dynamic GetTSObject(DrawingObjectEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingObjectEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.DrawingObjectEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
