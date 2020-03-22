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
			get => Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.FromTSObject(teklaObject.Arrowhead);
			set { teklaObject.Arrowhead = Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.GetTSObject(value); }
		}

        

        






    }

    internal static class OpenGraphicObjectAttributes_
    {
        public static dynamic GetTSObject(OpenGraphicObjectAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static OpenGraphicObjectAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.OpenGraphicObject.OpenGraphicObjectAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class OpenGraphicObject_
    {
        public static dynamic GetTSObject(OpenGraphicObject dynObject)
        {
            return dynObject.teklaObject;
        }

        public static OpenGraphicObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.OpenGraphicObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
