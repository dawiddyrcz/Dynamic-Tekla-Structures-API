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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.FatherId);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FatherId"); }
			}
			set
			{
				try {
				teklaObject.FatherId = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FatherId"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(teklaObject.Spanning);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spanning"); }
			}
			set
			{
				try {
				teklaObject.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spanning"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.PrimaryAxisDirection);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrimaryAxisDirection"); }
			}
			set
			{
				try {
				teklaObject.PrimaryAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrimaryAxisDirection"); }
			}
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get
			{
				try {
					return teklaObject.AutomaticPrimaryAxisWeight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutomaticPrimaryAxisWeight"); }
			}
			set
			{
				try {
					teklaObject.AutomaticPrimaryAxisWeight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutomaticPrimaryAxisWeight"); }
			}
		}

		public System.Double Weight
		{
			get
			{
				try {
					return teklaObject.Weight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Weight"); }
			}
			set
			{
				try {
					teklaObject.Weight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Weight"); }
			}
		}

		public System.Double LoadDispersionAngle
		{
			get
			{
				try {
					return teklaObject.LoadDispersionAngle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadDispersionAngle"); }
			}
			set
			{
				try {
					teklaObject.LoadDispersionAngle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadDispersionAngle"); }
			}
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get
			{
				try {
					return teklaObject.CreateFixedSupportConditionsAutomatically;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreateFixedSupportConditionsAutomatically"); }
			}
			set
			{
				try {
					teklaObject.CreateFixedSupportConditionsAutomatically = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreateFixedSupportConditionsAutomatically"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum LoadAttachment
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(teklaObject.LoadAttachment);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadAttachment"); }
			}
			set
			{
				try {
				teklaObject.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadAttachment"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(teklaObject.PartNames);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartNames"); }
			}
			set
			{
				try {
				teklaObject.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartNames"); }
			}
		}

		public System.String PartFilter
		{
			get
			{
				try {
					return teklaObject.PartFilter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartFilter"); }
			}
			set
			{
				try {
					teklaObject.PartFilter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartFilter"); }
			}
		}

		public System.Double BoundingBoxDx
		{
			get
			{
				try {
					return teklaObject.BoundingBoxDx;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBoxDx"); }
			}
			set
			{
				try {
					teklaObject.BoundingBoxDx = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBoxDx"); }
			}
		}

		public System.Double BoundingBoxDy
		{
			get
			{
				try {
					return teklaObject.BoundingBoxDy;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBoxDy"); }
			}
			set
			{
				try {
					teklaObject.BoundingBoxDy = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBoxDy"); }
			}
		}

		public System.Double BoundingBoxDz
		{
			get
			{
				try {
					return teklaObject.BoundingBoxDz;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBoxDz"); }
			}
			set
			{
				try {
					teklaObject.BoundingBoxDz = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBoxDz"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup Group
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.LoadGroup_.FromTSObject(teklaObject.Group);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Group"); }
			}
			set
			{
				try {
				teklaObject.Group = Dynamic.Tekla.Structures.Model.LoadGroup_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Group"); }
			}
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Load_
    {
        public static dynamic GetTSObject(Load dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Load FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Load)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadArray_
    {
        public static dynamic GetTSObject(Load[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Load_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Load[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Load>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Load_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
