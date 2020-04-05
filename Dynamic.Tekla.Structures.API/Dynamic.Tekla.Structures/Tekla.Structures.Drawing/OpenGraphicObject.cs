/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class OpenGraphicObject  : Dynamic.Tekla.Structures.Drawing.GraphicObject
    {

        

        





    public abstract class OpenGraphicObjectAttributes  : Dynamic.Tekla.Structures.Drawing.GraphicObject.GraphicObjectAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes Arrowhead
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.FromTSObject(teklaObject.Arrowhead);
			}
			set
			{
				teklaObject.Arrowhead = Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.GetTSObject(value);
			}
		}

        

        






    }

    internal static class OpenGraphicObjectAttributes_
    {
        public static dynamic GetTSObject(OpenGraphicObjectAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static OpenGraphicObjectAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.OpenGraphicObject.OpenGraphicObjectAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class OpenGraphicObjectAttributesArray_
    {
        public static dynamic GetTSObject(OpenGraphicObjectAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(OpenGraphicObjectAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static OpenGraphicObjectAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<OpenGraphicObjectAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(OpenGraphicObjectAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class OpenGraphicObject_
    {
        public static dynamic GetTSObject(OpenGraphicObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static OpenGraphicObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.OpenGraphicObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class OpenGraphicObjectArray_
    {
        public static dynamic GetTSObject(OpenGraphicObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(OpenGraphicObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static OpenGraphicObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<OpenGraphicObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(OpenGraphicObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
