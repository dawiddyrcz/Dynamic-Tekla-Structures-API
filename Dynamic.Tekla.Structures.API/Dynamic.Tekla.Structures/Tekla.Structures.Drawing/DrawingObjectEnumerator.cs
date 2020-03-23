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

		}

        

        

		public DrawingObjectEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingObjectEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingObjectEnumeratorArray_
    {
        public static dynamic GetTSObject(DrawingObjectEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingObjectEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingObjectEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<DrawingObjectEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingObjectEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
