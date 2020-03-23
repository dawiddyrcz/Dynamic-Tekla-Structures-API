/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_RectangleProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
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

        

        

		public IFC2X3_ParametricObject_RectangleProfile() {}





    }

    internal static class IFC2X3_ParametricObject_RectangleProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_RectangleProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_RectangleProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
