/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CurvedDimensionOrthogonal  : Dynamic.Tekla.Structures.Drawing.CurvedDimensionBase
    {


        public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
        }
        

        

		internal CurvedDimensionOrthogonal() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CurvedDimensionOrthogonal(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CurvedDimensionOrthogonal(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint, System.Double Distance, Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes Attributes)
		{
			var args = new object[8];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3);
			args[4] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			args[5] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			args[6] = Distance;
			args[7] = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionOrthogonal", args);
		}
		public CurvedDimensionOrthogonal(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint, System.Double Distance)
		{
			var args = new object[7];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3);
			args[4] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			args[5] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			args[6] = Distance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionOrthogonal", args);
		}





    }

    internal static class CurvedDimensionOrthogonal_
    {
        public static dynamic GetTSObject(CurvedDimensionOrthogonal dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedDimensionOrthogonal FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionOrthogonal)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionOrthogonalArray_
    {
        public static dynamic GetTSObject(CurvedDimensionOrthogonal[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionOrthogonal_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionOrthogonal[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedDimensionOrthogonal>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionOrthogonal_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
