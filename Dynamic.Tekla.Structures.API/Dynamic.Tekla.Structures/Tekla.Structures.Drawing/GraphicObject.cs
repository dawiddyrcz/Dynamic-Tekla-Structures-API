/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class GraphicObject  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get => Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
			set { teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value); }
		}

        

        





    public abstract class GraphicObjectAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
			set { teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

        

        






    }

    internal static class GraphicObjectAttributes_
    {
        public static dynamic GetTSObject(GraphicObjectAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GraphicObjectAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.GraphicObject.GraphicObjectAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GraphicObjectAttributesArray_
    {
        public static dynamic GetTSObject(GraphicObjectAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GraphicObjectAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GraphicObjectAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<GraphicObjectAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GraphicObjectAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class GraphicObject_
    {
        public static dynamic GetTSObject(GraphicObject dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GraphicObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.GraphicObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GraphicObjectArray_
    {
        public static dynamic GetTSObject(GraphicObject[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GraphicObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GraphicObject[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<GraphicObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GraphicObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
