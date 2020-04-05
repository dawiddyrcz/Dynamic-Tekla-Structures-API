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
			get
			{
				try {
					return teklaObject.XDim;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("XDim"); }
			}

		}

		public System.Double YDim
		{
			get
			{
				try {
					return teklaObject.YDim;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("YDim"); }
			}

		}

        

        

		internal IFC2X3_ParametricObject_RectangleProfile() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public IFC2X3_ParametricObject_RectangleProfile(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class IFC2X3_ParametricObject_RectangleProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleProfile dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_RectangleProfile FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_RectangleProfile)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_RectangleProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleProfile[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_RectangleProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_RectangleProfile[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_RectangleProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_RectangleProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
