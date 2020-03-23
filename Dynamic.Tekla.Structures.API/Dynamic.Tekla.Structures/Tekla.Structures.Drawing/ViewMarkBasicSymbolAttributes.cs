/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ViewMarkBasicSymbolAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Double Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.MarkSymbolShape Shape
		{
			get => Dynamic.Tekla.Structures.Drawing.MarkSymbolShape_.FromTSObject(teklaObject.Shape);
			set { teklaObject.Shape = Dynamic.Tekla.Structures.Drawing.MarkSymbolShape_.GetTSObject(value); }
		}

        

        


		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ViewMarkBasicSymbolAttributes_
    {
        public static dynamic GetTSObject(ViewMarkBasicSymbolAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ViewMarkBasicSymbolAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicSymbolAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
