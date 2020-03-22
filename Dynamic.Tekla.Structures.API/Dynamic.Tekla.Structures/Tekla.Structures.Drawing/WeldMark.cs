/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class WeldMark  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Identifier ModelIdentifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.ModelIdentifier);
			set { teklaObject.ModelIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.InsertionPoint);
			set { teklaObject.InsertionPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get => Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
			set { teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value); }
		}

        

        

		public WeldMark() {}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetObjectAlignedBoundingBox());
		}

		public System.Boolean MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector MoveVector)
		{
			return teklaObject.MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(MoveVector));
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects(System.Type TypeFilter)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects(TypeFilter));
		}




    public  class SeamVisibilityAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean ShowPrefix
		{
			get => teklaObject.ShowPrefix;
			set { teklaObject.ShowPrefix = value; }
		}

		public System.Boolean ShowSize
		{
			get => teklaObject.ShowSize;
			set { teklaObject.ShowSize = value; }
		}

		public System.Boolean ShowType
		{
			get => teklaObject.ShowType;
			set { teklaObject.ShowType = value; }
		}

		public System.Boolean ShowAngle
		{
			get => teklaObject.ShowAngle;
			set { teklaObject.ShowAngle = value; }
		}

		public System.Boolean ShowContour
		{
			get => teklaObject.ShowContour;
			set { teklaObject.ShowContour = value; }
		}

		public System.Boolean ShowFinish
		{
			get => teklaObject.ShowFinish;
			set { teklaObject.ShowFinish = value; }
		}

		public System.Boolean ShowLength
		{
			get => teklaObject.ShowLength;
			set { teklaObject.ShowLength = value; }
		}

		public System.Boolean ShowPitch
		{
			get => teklaObject.ShowPitch;
			set { teklaObject.ShowPitch = value; }
		}

		public System.Boolean ShowEffectiveThroat
		{
			get => teklaObject.ShowEffectiveThroat;
			set { teklaObject.ShowEffectiveThroat = value; }
		}

		public System.Boolean ShowRootOpening
		{
			get => teklaObject.ShowRootOpening;
			set { teklaObject.ShowRootOpening = value; }
		}

        

        

		public SeamVisibilityAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes");
		}
		public SeamVisibilityAttributes(System.Boolean showPrefix, System.Boolean showSize, System.Boolean showType, System.Boolean showAngle, System.Boolean showContour, System.Boolean showFinish, System.Boolean showLength, System.Boolean showPitch, System.Boolean showEffectiveThroat, System.Boolean showRootOpening)
		{
			var args = new object[10];
			args[0] = showPrefix;
			args[1] = showSize;
			args[2] = showType;
			args[3] = showAngle;
			args[4] = showContour;
			args[5] = showFinish;
			args[6] = showLength;
			args[7] = showPitch;
			args[8] = showEffectiveThroat;
			args[9] = showRootOpening;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class SeamVisibilityAttributes_
    {
        public static dynamic GetTSObject(SeamVisibilityAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SeamVisibilityAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class WeldMarkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.Boolean ShowWeldNumber
		{
			get => teklaObject.ShowWeldNumber;
			set { teklaObject.ShowWeldNumber = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes SeamAbove
		{
			get => Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.FromTSObject(teklaObject.SeamAbove);
			set { teklaObject.SeamAbove = Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes SeamBelow
		{
			get => Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.FromTSObject(teklaObject.SeamBelow);
			set { teklaObject.SeamBelow = Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.GetTSObject(value); }
		}

		public System.Boolean ShowReferenceText
		{
			get => teklaObject.ShowReferenceText;
			set { teklaObject.ShowReferenceText = value; }
		}

		public System.Boolean ShowEdgeAround
		{
			get => teklaObject.ShowEdgeAround;
			set { teklaObject.ShowEdgeAround = value; }
		}

		public System.Boolean ShowWorkshopSite
		{
			get => teklaObject.ShowWorkshopSite;
			set { teklaObject.ShowWorkshopSite = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public System.Boolean TransparentBackground
		{
			get => teklaObject.TransparentBackground;
			set { teklaObject.TransparentBackground = value; }
		}

		public System.String CustomPresentation
		{
			get => teklaObject.CustomPresentation;
			set { teklaObject.CustomPresentation = value; }
		}

        

        

		public WeldMarkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes");
		}
		public WeldMarkAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes", args);
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

    internal static class WeldMarkAttributes_
    {
        public static dynamic GetTSObject(WeldMarkAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static WeldMarkAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class WeldMark_
    {
        public static dynamic GetTSObject(WeldMark dynObject)
        {
            return dynObject.teklaObject;
        }

        public static WeldMark FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.WeldMark)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
