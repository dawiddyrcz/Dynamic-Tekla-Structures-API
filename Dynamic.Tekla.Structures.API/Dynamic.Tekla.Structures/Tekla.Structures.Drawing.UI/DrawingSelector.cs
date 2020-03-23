/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.UI
{

    public  class DrawingSelector 
    {

        

        internal dynamic teklaObject;

		public DrawingSelector() {}

		public Dynamic.Tekla.Structures.Drawing.DrawingEnumerator GetSelected()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingEnumerator_.FromTSObject(teklaObject.GetSelected());
		}





    }

    internal static class DrawingSelector_
    {
        public static dynamic GetTSObject(DrawingSelector dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingSelector FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.DrawingSelector)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingSelectorArray_
    {
        public static dynamic GetTSObject(DrawingSelector[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingSelector_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingSelector[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<DrawingSelector>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingSelector_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
