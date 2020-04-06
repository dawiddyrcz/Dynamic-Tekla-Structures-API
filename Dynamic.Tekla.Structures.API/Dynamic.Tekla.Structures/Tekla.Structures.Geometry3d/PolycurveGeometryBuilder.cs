/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class PolycurveGeometryBuilder 
    {

        

        internal dynamic teklaObject;

		public PolycurveGeometryBuilder()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolycurveGeometryBuilder");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolycurveGeometryBuilder(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PolycurveGeometryBuilder(Dynamic.Tekla.Structures.Geometry3d.Polycurve geometries)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(geometries);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolycurveGeometryBuilder", args);
		}

		public Dynamic.Tekla.Structures.Geometry3d.Polycurve GetPolycurve()
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(teklaObject.GetPolycurve());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPolycurve()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Append(Dynamic.Tekla.Structures.Geometry3d.Arc arc)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.Append(Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(arc)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Append()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Append(Dynamic.Tekla.Structures.Geometry3d.LineSegment segment)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.Append(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Append()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Append(Dynamic.Tekla.Structures.Geometry3d.Polycurve otherPolycurve)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.Append(Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(otherPolycurve)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Append()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendArc(Dynamic.Tekla.Structures.Geometry3d.Point middlePoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.AppendArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(middlePoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AppendArc()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendSegment(Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.AppendSegment(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AppendSegment()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.AppendTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AppendTangentArc()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendTangentSegment(System.Double length)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.AppendTangentSegment(length));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AppendTangentSegment()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Prepend(Dynamic.Tekla.Structures.Geometry3d.Arc arc)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.Prepend(Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(arc)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Prepend()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Prepend(Dynamic.Tekla.Structures.Geometry3d.LineSegment segment)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.Prepend(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Prepend()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependArc(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point middlePoint)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.PrependArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(middlePoint)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrependArc()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependSegment(Dynamic.Tekla.Structures.Geometry3d.Point startPoint)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.PrependSegment(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrependSegment()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point startPoint)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.PrependTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrependTangentArc()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependTangentSegment(System.Double length)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.PrependTangentSegment(length));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrependTangentSegment()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Replace(System.Int32 index, Dynamic.Tekla.Structures.Geometry3d.Arc arc)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.Replace(index, Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(arc)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Replace()", ex); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Replace(System.Int32 index, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment)
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(teklaObject.Replace(index, Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Replace()", ex); }
		}





    }

    internal static class PolycurveGeometryBuilder_
    {
        public static dynamic GetTSObject(PolycurveGeometryBuilder dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolycurveGeometryBuilder FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolycurveGeometryBuilderArray_
    {
        public static dynamic GetTSObject(PolycurveGeometryBuilder[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolycurveGeometryBuilder_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolycurveGeometryBuilder[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolycurveGeometryBuilder>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolycurveGeometryBuilder_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
