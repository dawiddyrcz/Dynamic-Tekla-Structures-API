/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public abstract class ReferenceModelObjectAttribute 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
			set { teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.xDir);
			set { teklaObject.xDir = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Extrusion);
			set { teklaObject.Extrusion = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.String ProfileName
		{
			get => teklaObject.ProfileName;
			set { teklaObject.ProfileName = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Description
		{
			get => teklaObject.Description;
			set { teklaObject.Description = value; }
		}

		public System.String ObjectType
		{
			get => teklaObject.ObjectType;
			set { teklaObject.ObjectType = value; }
		}

        

        internal dynamic teklaObject;





    public enum AttributeTypeEnum
    {
			ATTRIBUTETYPE_INVALID,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CSHAPEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEHOLLOWPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ELLIPSEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ISHAPEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_LSHAPEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEHOLLOWPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_TSHAPEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_USHAPEPROFILE,
			ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ZSHAPEPROFILE,
			ATTRIBUTETYPE_PARAMETRICOBJECT_CUSTOMPROFILE,
			ATTRIBUTETYPE_PARAMETRICOBJECT_OBB        
    }

    internal static class AttributeTypeEnum_
    {
        public static dynamic GetTSObject(AttributeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute.AttributeTypeEnum").GetType();

            switch (dynEnum)
            {
				case AttributeTypeEnum.ATTRIBUTETYPE_INVALID:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_INVALID");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CSHAPEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CSHAPEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEHOLLOWPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEHOLLOWPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ELLIPSEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ELLIPSEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ISHAPEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ISHAPEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_LSHAPEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_LSHAPEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEHOLLOWPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEHOLLOWPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_TSHAPEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_TSHAPEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_USHAPEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_USHAPEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ZSHAPEPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ZSHAPEPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_PARAMETRICOBJECT_CUSTOMPROFILE:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_PARAMETRICOBJECT_CUSTOMPROFILE");
				case AttributeTypeEnum.ATTRIBUTETYPE_PARAMETRICOBJECT_OBB:
					return System.Enum.Parse(tsType, "ATTRIBUTETYPE_PARAMETRICOBJECT_OBB");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AttributeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ATTRIBUTETYPE_INVALID", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_INVALID;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CSHAPEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CSHAPEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEHOLLOWPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEHOLLOWPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_CIRCLEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ELLIPSEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ELLIPSEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ISHAPEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ISHAPEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_LSHAPEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_LSHAPEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEHOLLOWPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEHOLLOWPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_RECTANGLEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_TSHAPEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_TSHAPEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_USHAPEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_USHAPEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ZSHAPEPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_IFC2X3_PARAMETRICOBJECT_ZSHAPEPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_PARAMETRICOBJECT_CUSTOMPROFILE", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_PARAMETRICOBJECT_CUSTOMPROFILE;
			else if (tsEnumValue.Equals("ATTRIBUTETYPE_PARAMETRICOBJECT_OBB", System.StringComparison.InvariantCulture))
				return AttributeTypeEnum.ATTRIBUTETYPE_PARAMETRICOBJECT_OBB;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ReferenceModelObjectAttribute_
    {
        public static dynamic GetTSObject(ReferenceModelObjectAttribute dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReferenceModelObjectAttribute FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelObjectAttributeArray_
    {
        public static dynamic GetTSObject(ReferenceModelObjectAttribute[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModelObjectAttribute_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModelObjectAttribute[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReferenceModelObjectAttribute>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModelObjectAttribute_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
