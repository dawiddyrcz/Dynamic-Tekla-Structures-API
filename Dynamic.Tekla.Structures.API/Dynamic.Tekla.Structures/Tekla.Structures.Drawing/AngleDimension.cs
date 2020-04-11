/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class AngleDimension  : Dynamic.Tekla.Structures.Drawing.DimensionBase
    {

		public Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
			set
			{
				try {
				teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point1", ex); }
			}
			set
			{
				try {
				teklaObject.Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point1", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point2", ex); }
			}
			set
			{
				try {
				teklaObject.Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point2", ex); }
			}
		}

		public System.Double Distance
		{
			get
			{
				try {
					return teklaObject.Distance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance", ex); }
			}
			set
			{
				try {
					teklaObject.Distance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance", ex); }
			}
		}

        

        

		internal AngleDimension() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public AngleDimension(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public AngleDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2, System.Double Distance)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2);
			args[4] = Distance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimension", args);
		}
		public AngleDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2, System.Double Distance, Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes Attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2);
			args[4] = Distance;
			args[5] = Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimension", args);
		}
		public AngleDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2, System.Double Distance)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2);
			args[4] = Distance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimension", args);
		}
		public AngleDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2, System.Double Distance, Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes Attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2);
			args[4] = Distance;
			args[5] = Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimension", args);
		}


public System.Double GetAngle()
{

    try
    {
        	var result = (System.Double) teklaObject.GetAngle();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAngle), ex);
    }
}






    }

    internal static class AngleDimension_
    {
        public static dynamic GetTSObject(AngleDimension dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static AngleDimension FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.AngleDimension)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AngleDimensionArray_
    {
        public static dynamic GetTSObject(AngleDimension[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AngleDimension_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AngleDimension[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<AngleDimension>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AngleDimension_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
