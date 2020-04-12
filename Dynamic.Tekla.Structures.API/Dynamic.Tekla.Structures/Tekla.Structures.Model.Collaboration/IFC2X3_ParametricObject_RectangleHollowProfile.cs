/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_RectangleHollowProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double XDim
		{
			get
			{
				try {
					return teklaObject.XDim;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("XDim", ex); }
			}

		}

		public System.Double YDim
		{
			get
			{
				try {
					return teklaObject.YDim;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("YDim", ex); }
			}

		}

		public System.Double WallThickness
		{
			get
			{
				try {
					return teklaObject.WallThickness;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WallThickness", ex); }
			}

		}

		public System.Double InnerFilletRadius
		{
			get
			{
				try {
					return teklaObject.InnerFilletRadius;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InnerFilletRadius", ex); }
			}

		}

		public System.Double OuterFilletRadius
		{
			get
			{
				try {
					return teklaObject.OuterFilletRadius;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OuterFilletRadius", ex); }
			}

		}

        

        

		internal IFC2X3_ParametricObject_RectangleHollowProfile() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public IFC2X3_ParametricObject_RectangleHollowProfile(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class IFC2X3_ParametricObject_RectangleHollowProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleHollowProfile dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_RectangleHollowProfile FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_RectangleHollowProfile)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IFC2X3_ParametricObject_RectangleHollowProfileArray_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleHollowProfile[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IFC2X3_ParametricObject_RectangleHollowProfile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IFC2X3_ParametricObject_RectangleHollowProfile[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IFC2X3_ParametricObject_RectangleHollowProfile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IFC2X3_ParametricObject_RectangleHollowProfile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
