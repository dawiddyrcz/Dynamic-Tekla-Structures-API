/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_LShapeProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double Depth
		{
			get => teklaObject.Depth;
			set { teklaObject.Depth = value; }
		}

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public System.Double Thickness
		{
			get => teklaObject.Thickness;
			set { teklaObject.Thickness = value; }
		}

		public System.Double FilletRadius
		{
			get => teklaObject.FilletRadius;
			set { teklaObject.FilletRadius = value; }
		}

		public System.Double EdgeRadius
		{
			get => teklaObject.EdgeRadius;
			set { teklaObject.EdgeRadius = value; }
		}

		public System.Double LegSlope
		{
			get => teklaObject.LegSlope;
			set { teklaObject.LegSlope = value; }
		}

        

        

		public IFC2X3_ParametricObject_LShapeProfile() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public IFC2X3_ParametricObject_LShapeProfile(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class IFC2X3_ParametricObject_LShapeProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_LShapeProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_LShapeProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_LShapeProfile)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_LShapeProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_LShapeProfile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_LShapeProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_LShapeProfile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_LShapeProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_LShapeProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
