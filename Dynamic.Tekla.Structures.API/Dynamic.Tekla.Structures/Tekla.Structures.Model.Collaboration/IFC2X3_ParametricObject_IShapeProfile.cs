/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_IShapeProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double OverallWidth
		{
			get => teklaObject.OverallWidth;
			set { teklaObject.OverallWidth = value; }
		}

		public System.Double OverallDepth
		{
			get => teklaObject.OverallDepth;
			set { teklaObject.OverallDepth = value; }
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

        

        

		public IFC2X3_ParametricObject_IShapeProfile() {}





    }

    internal static class IFC2X3_ParametricObject_IShapeProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_IShapeProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_IShapeProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_IShapeProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_IShapeProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_IShapeProfile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_IShapeProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_IShapeProfile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_IShapeProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_IShapeProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
