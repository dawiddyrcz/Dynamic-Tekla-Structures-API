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
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement Value
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.Value);
			set { teklaObject.Value = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes_.GetTSObject(value); }
		}

		public System.Double Distance
		{
			get => teklaObject.Distance;
			set { teklaObject.Distance = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpDirection);
			set { teklaObject.UpDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        

		public StraightDimension() {}
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

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBase GetDimensionSet()
		{
			return Dynamic.Tekla.Structures.Drawing.DimensionSetBase_.FromTSObject(teklaObject.GetDimensionSet());
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBase GetDimensionSet(System.Boolean Select)
		{
			return Dynamic.Tekla.Structures.Drawing.DimensionSetBase_.FromTSObject(teklaObject.GetDimensionSet(Select));
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}




    public  class StraightDimensionAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.ContainerElement MiddleLowerTag
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.MiddleLowerTag);
			set { teklaObject.MiddleLowerTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement DimensionValuePrefix
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.DimensionValuePrefix);
			set { teklaObject.DimensionValuePrefix = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement DimensionValuePostfix
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.DimensionValuePostfix);
			set { teklaObject.DimensionValuePostfix = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes Exaggeration
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.FromTSObject(teklaObject.Exaggeration);
			set { teklaObject.Exaggeration = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.GetTSObject(value); }
		}

        

        

		public StraightDimensionAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes");
		}

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class StraightDimensionAttributes_
    {
        public static dynamic GetTSObject(StraightDimensionAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static StraightDimensionAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimension.StraightDimensionAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StraightDimensionAttributesArray_
    {
        public static dynamic GetTSObject(StraightDimensionAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StraightDimensionAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StraightDimensionAttributes[] FromTSObject(dynamic[] tsArray)
        {
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
            return dynObject.teklaObject;
        }

        public static StraightDimension FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimension)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StraightDimensionArray_
    {
        public static dynamic GetTSObject(StraightDimension[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StraightDimension_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StraightDimension[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<StraightDimension>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StraightDimension_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
