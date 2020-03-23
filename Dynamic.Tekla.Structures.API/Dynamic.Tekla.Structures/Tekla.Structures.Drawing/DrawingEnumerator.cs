/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DrawingEnumerator  : Dynamic.Tekla.Structures.Drawing.DrawingEnumeratorBase
    {

		public Dynamic.Tekla.Structures.Drawing.Drawing Current
		{
			get => Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.Current);
			set { teklaObject.Current = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(value); }
		}

        

        

		public DrawingEnumerator() {}





    }

    internal static class DrawingEnumerator_
    {
        public static dynamic GetTSObject(DrawingEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingEnumeratorArray_
    {
        public static dynamic GetTSObject(DrawingEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<DrawingEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
