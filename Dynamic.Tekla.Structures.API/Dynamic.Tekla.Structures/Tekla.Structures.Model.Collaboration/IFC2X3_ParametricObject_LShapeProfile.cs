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
			get
			{
				try {
					return teklaObject.Depth;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Depth"); }
			}

		}

		public System.Double Width
		{
			get
			{
				try {
					return teklaObject.Width;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width"); }
			}

		}

		public System.Double Thickness
		{
			get
			{
				try {
					return teklaObject.Thickness;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Thickness"); }
			}

		}

		public System.Double FilletRadius
		{
			get
			{
				try {
					return teklaObject.FilletRadius;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FilletRadius"); }
			}

		}

		public System.Double EdgeRadius
		{
			get
			{
				try {
					return teklaObject.EdgeRadius;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EdgeRadius"); }
			}

		}

		public System.Double LegSlope
		{
			get
			{
				try {
					return teklaObject.LegSlope;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LegSlope"); }
			}

		}

        

        

		internal IFC2X3_ParametricObject_LShapeProfile() {}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_LShapeProfile FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_LShapeProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_LShapeProfile[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_LShapeProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_LShapeProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
