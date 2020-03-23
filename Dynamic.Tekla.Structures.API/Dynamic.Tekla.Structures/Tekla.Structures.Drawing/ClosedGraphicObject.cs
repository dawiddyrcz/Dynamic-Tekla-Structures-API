/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ClosedGraphicObject  : Dynamic.Tekla.Structures.Drawing.GraphicObject
    {

        

        





    public abstract class ClosedGraphicObjectAttributes  : Dynamic.Tekla.Structures.Drawing.GraphicObject.GraphicObjectAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.GraphicObjectHatchAttributes Hatch
		{
			get => Dynamic.Tekla.Structures.Drawing.GraphicObjectHatchAttributes_.FromTSObject(teklaObject.Hatch);
			set { teklaObject.Hatch = Dynamic.Tekla.Structures.Drawing.GraphicObjectHatchAttributes_.GetTSObject(value); }
		}

		public System.Boolean BehindModelObjects
		{
			get => teklaObject.BehindModelObjects;
			set { teklaObject.BehindModelObjects = value; }
		}

        

        






    }

    internal static class ClosedGraphicObjectAttributes_
    {
        public static dynamic GetTSObject(ClosedGraphicObjectAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClosedGraphicObjectAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject.ClosedGraphicObjectAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClosedGraphicObjectAttributesArray_
    {
        public static dynamic GetTSObject(ClosedGraphicObjectAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClosedGraphicObjectAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClosedGraphicObjectAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ClosedGraphicObjectAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClosedGraphicObjectAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class ClosedGraphicObject_
    {
        public static dynamic GetTSObject(ClosedGraphicObject dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClosedGraphicObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClosedGraphicObjectArray_
    {
        public static dynamic GetTSObject(ClosedGraphicObject[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClosedGraphicObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClosedGraphicObject[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ClosedGraphicObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClosedGraphicObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
