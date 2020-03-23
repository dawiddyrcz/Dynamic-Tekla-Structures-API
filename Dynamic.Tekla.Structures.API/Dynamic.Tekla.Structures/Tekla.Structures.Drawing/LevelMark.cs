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
			get => Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkType_.FromTSObject(teklaObject.SubType);
			set { teklaObject.SubType = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.InsertionPoint);
			set { teklaObject.InsertionPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point BasePoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.BasePoint);
			set { teklaObject.BasePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingBase Placing
		{
			get => Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(teklaObject.Placing);
			set { teklaObject.Placing = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get => Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
			set { teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Identifier ModelObjectIdentifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.ModelObjectIdentifier);
			set { teklaObject.ModelObjectIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        

		public LevelMark() {}
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

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetObjectAlignedBoundingBox());
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
		}

		public System.Boolean MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector MoveVector)
		{
			return teklaObject.MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(MoveVector));
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects(System.Type[] TypeFilter)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects(TypeFilter));
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class LevelMarkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.String Prefix
		{
			get => teklaObject.Prefix;
			set { teklaObject.Prefix = value; }
		}

		public System.Boolean UsePositiveSignForPositiveLevels
		{
			get => teklaObject.UsePositiveSignForPositiveLevels;
			set { teklaObject.UsePositiveSignForPositiveLevels = value; }
		}

		public System.Boolean TextHidden
		{
			get => teklaObject.TextHidden;
			set { teklaObject.TextHidden = value; }
		}

		public System.String Postfix
		{
			get => teklaObject.Postfix;
			set { teklaObject.Postfix = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.UnitAttributes Unit
		{
			get => Dynamic.Tekla.Structures.Drawing.UnitAttributes_.FromTSObject(teklaObject.Unit);
			set { teklaObject.Unit = Dynamic.Tekla.Structures.Drawing.UnitAttributes_.GetTSObject(value); }
		}

		public System.Boolean UseGrouping
		{
			get => teklaObject.UseGrouping;
			set { teklaObject.UseGrouping = value; }
		}

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get => Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
			set { teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value); }
		}

		public System.Boolean TransparentBackground
		{
			get => teklaObject.TransparentBackground;
			set { teklaObject.TransparentBackground = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes ArrowHead
		{
			get => Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.FromTSObject(teklaObject.ArrowHead);
			set { teklaObject.ArrowHead = Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingAttributes PlacingAttributes
		{
			get => Dynamic.Tekla.Structures.Drawing.PlacingAttributes_.FromTSObject(teklaObject.PlacingAttributes);
			set { teklaObject.PlacingAttributes = Dynamic.Tekla.Structures.Drawing.PlacingAttributes_.GetTSObject(value); }
		}

        

        

		public LevelMarkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes");
		}
		public LevelMarkAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes", args);
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

    internal static class LevelMarkAttributes_
    {
        public static dynamic GetTSObject(LevelMarkAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LevelMarkAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.LevelMark.LevelMarkAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class LevelMark_
    {
        public static dynamic GetTSObject(LevelMark dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LevelMark FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.LevelMark)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
