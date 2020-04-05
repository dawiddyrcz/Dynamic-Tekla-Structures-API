/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class StraightDimension  : Dynamic.Tekla.Structures.Drawing.DimensionBase
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
			set
			{
				try {
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement Value
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.Value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value"); }
			}
			set
			{
				try {
				teklaObject.Value = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes_.GetTSObject(value);
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

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpDirection);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpDirection"); }
			}
			set
			{
				try {
				teklaObject.UpDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpDirection"); }
			}
		}

        

        

		internal StraightDimension() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StraightDimension(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public StraightDimension(Dynamic.Tekla.Structures.Drawing.ViewBase targetView, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Geometry3d.Vector upDirection, System.Double distance)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(targetView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(upDirection);
			args[4] = distance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimension", args);
		}
		public StraightDimension(Dynamic.Tekla.Structures.Drawing.ViewBase targetView, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Geometry3d.Vector upDirection, System.Double distance, Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(targetView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(upDirection);
			args[4] = distance;
			args[5] = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimension", args);
		}




    public  class StraightDimensionAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.ContainerElement MiddleLowerTag
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.MiddleLowerTag);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MiddleLowerTag"); }
			}
			set
			{
				try {
				teklaObject.MiddleLowerTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MiddleLowerTag"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement DimensionValuePrefix
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.DimensionValuePrefix);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionValuePrefix"); }
			}
			set
			{
				try {
				teklaObject.DimensionValuePrefix = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionValuePrefix"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement DimensionValuePostfix
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.DimensionValuePostfix);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionValuePostfix"); }
			}
			set
			{
				try {
				teklaObject.DimensionValuePostfix = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionValuePostfix"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes Exaggeration
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.FromTSObject(teklaObject.Exaggeration);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Exaggeration"); }
			}
			set
			{
				try {
				teklaObject.Exaggeration = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Exaggeration"); }
			}
		}

        

        

		public StraightDimensionAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StraightDimensionAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class StraightDimensionAttributes_
    {
        public static dynamic GetTSObject(StraightDimensionAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StraightDimensionAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StraightDimensionAttributesArray_
    {
        public static dynamic GetTSObject(StraightDimensionAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StraightDimensionAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StraightDimensionAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StraightDimensionAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StraightDimensionAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class StraightDimension_
    {
        public static dynamic GetTSObject(StraightDimension dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StraightDimension FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimension)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StraightDimensionArray_
    {
        public static dynamic GetTSObject(StraightDimension[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StraightDimension_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StraightDimension[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StraightDimension>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StraightDimension_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
