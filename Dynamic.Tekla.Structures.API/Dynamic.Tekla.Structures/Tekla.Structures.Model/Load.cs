/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class Load  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Identifier FatherId
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.FatherId);
			set { teklaObject.FatherId = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(teklaObject.Spanning);
			set { teklaObject.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.PrimaryAxisDirection);
			set { teklaObject.PrimaryAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get => teklaObject.AutomaticPrimaryAxisWeight;
			set { teklaObject.AutomaticPrimaryAxisWeight = value; }
		}

		public System.Double Weight
		{
			get => teklaObject.Weight;
			set { teklaObject.Weight = value; }
		}

		public System.Double LoadDispersionAngle
		{
			get => teklaObject.LoadDispersionAngle;
			set { teklaObject.LoadDispersionAngle = value; }
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get => teklaObject.CreateFixedSupportConditionsAutomatically;
			set { teklaObject.CreateFixedSupportConditionsAutomatically = value; }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum LoadAttachment
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(teklaObject.LoadAttachment);
			set { teklaObject.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(teklaObject.PartNames);
			set { teklaObject.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.GetTSObject(value); }
		}

		public System.String PartFilter
		{
			get => teklaObject.PartFilter;
			set { teklaObject.PartFilter = value; }
		}

		public System.Double BoundingBoxDx
		{
			get => teklaObject.BoundingBoxDx;
			set { teklaObject.BoundingBoxDx = value; }
		}

		public System.Double BoundingBoxDy
		{
			get => teklaObject.BoundingBoxDy;
			set { teklaObject.BoundingBoxDy = value; }
		}

		public System.Double BoundingBoxDz
		{
			get => teklaObject.BoundingBoxDz;
			set { teklaObject.BoundingBoxDz = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup Group
		{
			get => Dynamic.Tekla.Structures.Model.LoadGroup_.FromTSObject(teklaObject.Group);
			set { teklaObject.Group = Dynamic.Tekla.Structures.Model.LoadGroup_.GetTSObject(value); }
		}

        

        





    public enum LoadSpanningEnum
    {
			LOAD_SPANNING_SINGLE,
			LOAD_SPANNING_DOUBLE        
    }

    internal static class LoadSpanningEnum_
    {
        public static dynamic GetTSObject(LoadSpanningEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Load.LoadSpanningEnum").GetType();

            switch (dynEnum)
            {
				case LoadSpanningEnum.LOAD_SPANNING_SINGLE:
					return System.Enum.Parse(tsType, "LOAD_SPANNING_SINGLE");
				case LoadSpanningEnum.LOAD_SPANNING_DOUBLE:
					return System.Enum.Parse(tsType, "LOAD_SPANNING_DOUBLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoadSpanningEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_SPANNING_SINGLE", System.StringComparison.InvariantCulture))
				return LoadSpanningEnum.LOAD_SPANNING_SINGLE;
			else if (tsEnumValue.Equals("LOAD_SPANNING_DOUBLE", System.StringComparison.InvariantCulture))
				return LoadSpanningEnum.LOAD_SPANNING_DOUBLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LoadAttachmentEnum
    {
			LOAD_ATTACHMENT_ATTACH_TO_MEMBER,
			LOAD_ATTACHMENT_DONT_ATTACH        
    }

    internal static class LoadAttachmentEnum_
    {
        public static dynamic GetTSObject(LoadAttachmentEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Load.LoadAttachmentEnum").GetType();

            switch (dynEnum)
            {
				case LoadAttachmentEnum.LOAD_ATTACHMENT_ATTACH_TO_MEMBER:
					return System.Enum.Parse(tsType, "LOAD_ATTACHMENT_ATTACH_TO_MEMBER");
				case LoadAttachmentEnum.LOAD_ATTACHMENT_DONT_ATTACH:
					return System.Enum.Parse(tsType, "LOAD_ATTACHMENT_DONT_ATTACH");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoadAttachmentEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_ATTACHMENT_ATTACH_TO_MEMBER", System.StringComparison.InvariantCulture))
				return LoadAttachmentEnum.LOAD_ATTACHMENT_ATTACH_TO_MEMBER;
			else if (tsEnumValue.Equals("LOAD_ATTACHMENT_DONT_ATTACH", System.StringComparison.InvariantCulture))
				return LoadAttachmentEnum.LOAD_ATTACHMENT_DONT_ATTACH;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LoadPartNamesEnum
    {
			LOAD_PART_NAMES_EXCLUDE,
			LOAD_PART_NAMES_INCLUDE        
    }

    internal static class LoadPartNamesEnum_
    {
        public static dynamic GetTSObject(LoadPartNamesEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Load.LoadPartNamesEnum").GetType();

            switch (dynEnum)
            {
				case LoadPartNamesEnum.LOAD_PART_NAMES_EXCLUDE:
					return System.Enum.Parse(tsType, "LOAD_PART_NAMES_EXCLUDE");
				case LoadPartNamesEnum.LOAD_PART_NAMES_INCLUDE:
					return System.Enum.Parse(tsType, "LOAD_PART_NAMES_INCLUDE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoadPartNamesEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_PART_NAMES_EXCLUDE", System.StringComparison.InvariantCulture))
				return LoadPartNamesEnum.LOAD_PART_NAMES_EXCLUDE;
			else if (tsEnumValue.Equals("LOAD_PART_NAMES_INCLUDE", System.StringComparison.InvariantCulture))
				return LoadPartNamesEnum.LOAD_PART_NAMES_INCLUDE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Load_
    {
        public static dynamic GetTSObject(Load dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Load FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Load)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
