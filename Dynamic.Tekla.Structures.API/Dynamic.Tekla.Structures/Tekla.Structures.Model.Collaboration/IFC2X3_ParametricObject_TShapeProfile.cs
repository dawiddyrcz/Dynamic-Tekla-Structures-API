/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_TShapeProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double Depth
		{
			get => teklaObject.Depth;
			set { teklaObject.Depth = value; }
		}

		public System.Double FlangeWidth
		{
			get => teklaObject.FlangeWidth;
			set { teklaObject.FlangeWidth = value; }
		}

		public System.Double WebThickness
		{
			get => teklaObject.WebThickness;
			set { teklaObject.WebThickness = value; }
		}

		public System.Double FlangeThickness
		{
			get => teklaObject.FlangeThickness;
			set { teklaObject.FlangeThickness = value; }
		}

		public System.Double FilletRadius
		{
			get => teklaObject.FilletRadius;
			set { teklaObject.FilletRadius = value; }
		}

		public System.Double FlangeEdgeRadius
		{
			get => teklaObject.FlangeEdgeRadius;
			set { teklaObject.FlangeEdgeRadius = value; }
		}

		public System.Double WebEdgeRadius
		{
			get => teklaObject.WebEdgeRadius;
			set { teklaObject.WebEdgeRadius = value; }
		}

		public System.Double WebSlope
		{
			get => teklaObject.WebSlope;
			set { teklaObject.WebSlope = value; }
		}

		public System.Double FlangeSlope
		{
			get => teklaObject.FlangeSlope;
			set { teklaObject.FlangeSlope = value; }
		}

        

        

		public IFC2X3_ParametricObject_TShapeProfile() {}





    }

    internal static class IFC2X3_ParametricObject_TShapeProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_TShapeProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_TShapeProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_TShapeProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_TShapeProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_TShapeProfile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_TShapeProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_TShapeProfile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_TShapeProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_TShapeProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
