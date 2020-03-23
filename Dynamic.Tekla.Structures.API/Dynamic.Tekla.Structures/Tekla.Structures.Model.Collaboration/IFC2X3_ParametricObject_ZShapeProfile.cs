/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_ZShapeProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double Depth
		{
			get => teklaObject.Depth;

		}

		public System.Double FlangeWidth
		{
			get => teklaObject.FlangeWidth;

		}

		public System.Double WebThickness
		{
			get => teklaObject.WebThickness;

		}

		public System.Double FlangeThickness
		{
			get => teklaObject.FlangeThickness;

		}

		public System.Double FilletRadius
		{
			get => teklaObject.FilletRadius;

		}

		public System.Double EdgeRadius
		{
			get => teklaObject.EdgeRadius;

		}

        

        

		public IFC2X3_ParametricObject_ZShapeProfile() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public IFC2X3_ParametricObject_ZShapeProfile(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class IFC2X3_ParametricObject_ZShapeProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_ZShapeProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_ZShapeProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_ZShapeProfile)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_ZShapeProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_ZShapeProfile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_ZShapeProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_ZShapeProfile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_ZShapeProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_ZShapeProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
