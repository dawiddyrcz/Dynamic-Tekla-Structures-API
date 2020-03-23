/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_CircleHollowProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
		}

		public System.Double WallThickness
		{
			get => teklaObject.WallThickness;
			set { teklaObject.WallThickness = value; }
		}

        

        

		public IFC2X3_ParametricObject_CircleHollowProfile() {}





    }

    internal static class IFC2X3_ParametricObject_CircleHollowProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_CircleHollowProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_CircleHollowProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_CircleHollowProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_CircleHollowProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_CircleHollowProfile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_CircleHollowProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_CircleHollowProfile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_CircleHollowProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_CircleHollowProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
