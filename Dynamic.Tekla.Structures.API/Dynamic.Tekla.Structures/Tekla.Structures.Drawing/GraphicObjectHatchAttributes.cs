/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class GraphicObjectHatchAttributes  : Dynamic.Tekla.Structures.Drawing.HatchAttributes
    {

		public System.Double OffsetX
		{
			get => teklaObject.OffsetX;
			set { teklaObject.OffsetX = value; }
		}

		public System.Double OffsetY
		{
			get => teklaObject.OffsetY;
			set { teklaObject.OffsetY = value; }
		}

        

        

		public GraphicObjectHatchAttributes() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GraphicObjectHatchAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class GraphicObjectHatchAttributes_
    {
        public static dynamic GetTSObject(GraphicObjectHatchAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GraphicObjectHatchAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.GraphicObjectHatchAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GraphicObjectHatchAttributesArray_
    {
        public static dynamic GetTSObject(GraphicObjectHatchAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GraphicObjectHatchAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GraphicObjectHatchAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<GraphicObjectHatchAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GraphicObjectHatchAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
