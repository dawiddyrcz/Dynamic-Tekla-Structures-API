/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class LevelMark  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkType SubType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkType_.FromTSObject(teklaObject.SubType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SubType"); }
			}
			set
			{
				try {
				teklaObject.SubType = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SubType"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.InsertionPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InsertionPoint"); }
			}
			set
			{
				try {
				teklaObject.InsertionPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InsertionPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point BasePoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.BasePoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BasePoint"); }
			}
			set
			{
				try {
				teklaObject.BasePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BasePoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingBase Placing
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(teklaObject.Placing);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Placing"); }
			}
			set
			{
				try {
				teklaObject.Placing = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Placing"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable"); }
			}
			set
			{
				try {
				teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable"); }
			}
		}

		public Dynamic.Tekla.Structures.Identifier ModelObjectIdentifier
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.ModelObjectIdentifier);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelObjectIdentifier"); }
			}
			set
			{
				try {
				teklaObject.ModelObjectIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelObjectIdentifier"); }
			}
		}

        

        

		internal LevelMark() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LevelMark(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint, Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes Attributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint, Dynamic.Tekla.Structures.Drawing.ModelObject modelObject)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing, Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes Attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			args[4] = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing, Dynamic.Tekla.Structures.Drawing.ModelObject modelObject)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			args[4] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint, Dynamic.Tekla.Structures.Drawing.ModelObject modelObject, Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes Attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			args[4] = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}
		public LevelMark(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Geometry3d.Point BasePoint, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing, Dynamic.Tekla.Structures.Drawing.ModelObject modelObject, Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes Attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(BasePoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			args[4] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			args[5] = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark", args);
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetObjectAlignedBoundingBox());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetObjectAlignedBoundingBox()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAxisAlignedBoundingBox()"); }
		}

		public System.Boolean MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector MoveVector)
		{
			try {
			var result = teklaObject.MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(MoveVector));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("MoveObjectRelative()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetObjects()"); }
		}




    public enum LevelMarkType
    {
			NoArrowNoLeaderLine,
			ArrowWithoutLeaderLine,
			InclinedLeaderLine,
			OrthogonalLeaderLine        
    }

    internal static class LevelMarkType_
    {
        public static dynamic GetTSObject(LevelMarkType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark.LevelMarkType").GetType();

            switch (dynEnum)
            {
				case LevelMarkType.NoArrowNoLeaderLine:
					return System.Enum.Parse(tsType, "NoArrowNoLeaderLine");
				case LevelMarkType.ArrowWithoutLeaderLine:
					return System.Enum.Parse(tsType, "ArrowWithoutLeaderLine");
				case LevelMarkType.InclinedLeaderLine:
					return System.Enum.Parse(tsType, "InclinedLeaderLine");
				case LevelMarkType.OrthogonalLeaderLine:
					return System.Enum.Parse(tsType, "OrthogonalLeaderLine");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LevelMarkType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NoArrowNoLeaderLine", System.StringComparison.InvariantCulture))
				return LevelMarkType.NoArrowNoLeaderLine;
			else if (tsEnumValue.Equals("ArrowWithoutLeaderLine", System.StringComparison.InvariantCulture))
				return LevelMarkType.ArrowWithoutLeaderLine;
			else if (tsEnumValue.Equals("InclinedLeaderLine", System.StringComparison.InvariantCulture))
				return LevelMarkType.InclinedLeaderLine;
			else if (tsEnumValue.Equals("OrthogonalLeaderLine", System.StringComparison.InvariantCulture))
				return LevelMarkType.OrthogonalLeaderLine;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class LevelMarkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.String Prefix
		{
			get
			{
				try {
					return teklaObject.Prefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Prefix"); }
			}
			set
			{
				try {
					teklaObject.Prefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Prefix"); }
			}
		}

		public System.Boolean UsePositiveSignForPositiveLevels
		{
			get
			{
				try {
					return teklaObject.UsePositiveSignForPositiveLevels;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UsePositiveSignForPositiveLevels"); }
			}
			set
			{
				try {
					teklaObject.UsePositiveSignForPositiveLevels = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UsePositiveSignForPositiveLevels"); }
			}
		}

		public System.Boolean TextHidden
		{
			get
			{
				try {
					return teklaObject.TextHidden;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TextHidden"); }
			}
			set
			{
				try {
					teklaObject.TextHidden = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TextHidden"); }
			}
		}

		public System.String Postfix
		{
			get
			{
				try {
					return teklaObject.Postfix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Postfix"); }
			}
			set
			{
				try {
					teklaObject.Postfix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Postfix"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.UnitAttributes Unit
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.UnitAttributes_.FromTSObject(teklaObject.Unit);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Unit"); }
			}
			set
			{
				try {
				teklaObject.Unit = Dynamic.Tekla.Structures.Drawing.UnitAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Unit"); }
			}
		}

		public System.Boolean UseGrouping
		{
			get
			{
				try {
					return teklaObject.UseGrouping;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UseGrouping"); }
			}
			set
			{
				try {
					teklaObject.UseGrouping = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UseGrouping"); }
			}
		}

		public System.Double Angle
		{
			get
			{
				try {
					return teklaObject.Angle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle"); }
			}
			set
			{
				try {
					teklaObject.Angle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font"); }
			}
			set
			{
				try {
				teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame"); }
			}
			set
			{
				try {
				teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame"); }
			}
		}

		public System.Boolean TransparentBackground
		{
			get
			{
				try {
					return teklaObject.TransparentBackground;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TransparentBackground"); }
			}
			set
			{
				try {
					teklaObject.TransparentBackground = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TransparentBackground"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes ArrowHead
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.FromTSObject(teklaObject.ArrowHead);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArrowHead"); }
			}
			set
			{
				try {
				teklaObject.ArrowHead = Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArrowHead"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingAttributes PlacingAttributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PlacingAttributes_.FromTSObject(teklaObject.PlacingAttributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlacingAttributes"); }
			}
			set
			{
				try {
				teklaObject.PlacingAttributes = Dynamic.Tekla.Structures.Drawing.PlacingAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlacingAttributes"); }
			}
		}

        

        

		public LevelMarkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LevelMarkAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LevelMarkAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes", args);
		}





    }

    internal static class LevelMarkAttributes_
    {
        public static dynamic GetTSObject(LevelMarkAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LevelMarkAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LevelMarkAttributesArray_
    {
        public static dynamic GetTSObject(LevelMarkAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LevelMarkAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LevelMarkAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LevelMarkAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LevelMarkAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class LevelMark_
    {
        public static dynamic GetTSObject(LevelMark dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LevelMark FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LevelMark)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LevelMarkArray_
    {
        public static dynamic GetTSObject(LevelMark[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LevelMark_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LevelMark[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LevelMark>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LevelMark_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
