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
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.Current);
			}
		}

        

        

		internal DrawingEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class DrawingEnumerator_
    {
        public static dynamic GetTSObject(DrawingEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingEnumeratorArray_
    {
        public static dynamic GetTSObject(DrawingEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DrawingEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
