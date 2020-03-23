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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ViewMarkBasicSymbolAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicSymbolAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewMarkBasicSymbolAttributesArray_
    {
        public static dynamic GetTSObject(ViewMarkBasicSymbolAttributes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewMarkBasicSymbolAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewMarkBasicSymbolAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ViewMarkBasicSymbolAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewMarkBasicSymbolAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
