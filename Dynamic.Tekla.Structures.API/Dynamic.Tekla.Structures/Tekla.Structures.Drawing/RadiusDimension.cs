/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class RadiusDimension  : Dynamic.Tekla.Structures.Drawing.DimensionBase
    {

		public Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
		}

		public System.Double Distance
		{
			get
			{
				try {
					return teklaObject.Distance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance"); }
			}
			set
			{
				try {
					teklaObject.Distance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint1"); }
			}
			set
			{
				try {
				teklaObject.ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint1"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint2"); }
			}
			set
			{
				try {
				teklaObject.ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint2"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint3);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint3"); }
			}
			set
			{
				try {
				teklaObject.ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcPoint3"); }
			}
		}

        

        

		internal RadiusDimension() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RadiusDimension(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public RadiusDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, System.Double Distance)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3);
			args[4] = Distance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.RadiusDimension", args);
		}
		public RadiusDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, System.Double Distance, Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes Attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3);
			args[4] = Distance;
			args[5] = Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.RadiusDimension", args);
		}





    }

    internal static class RadiusDimension_
    {
        public static dynamic GetTSObject(RadiusDimension dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RadiusDimension FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.RadiusDimension)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RadiusDimensionArray_
    {
        public static dynamic GetTSObject(RadiusDimension[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RadiusDimension_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RadiusDimension[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RadiusDimension>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RadiusDimension_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
