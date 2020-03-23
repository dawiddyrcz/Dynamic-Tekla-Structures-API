/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_RectangleHollowProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double XDim
		{
			get => teklaObject.XDim;
			set { teklaObject.XDim = value; }
		}

		public System.Double YDim
		{
			get => teklaObject.YDim;
			set { teklaObject.YDim = value; }
		}

		public System.Double WallThickness
		{
			get => teklaObject.WallThickness;
			set { teklaObject.WallThickness = value; }
		}

		public System.Double InnerFilletRadius
		{
			get => teklaObject.InnerFilletRadius;
			set { teklaObject.InnerFilletRadius = value; }
		}

		public System.Double OuterFilletRadius
		{
			get => teklaObject.OuterFilletRadius;
			set { teklaObject.OuterFilletRadius = value; }
		}

        

        

		public IFC2X3_ParametricObject_RectangleHollowProfile() {}





    }

    internal static class IFC2X3_ParametricObject_RectangleHollowProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleHollowProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_RectangleHollowProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_RectangleHollowProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_RectangleHollowProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleHollowProfile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_RectangleHollowProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_RectangleHollowProfile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_RectangleHollowProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_RectangleHollowProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
