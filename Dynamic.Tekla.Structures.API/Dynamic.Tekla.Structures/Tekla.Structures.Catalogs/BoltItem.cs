/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class BoltItem 
    {

		public System.String Standard
		{
			get => teklaObject.Standard;
			set { teklaObject.Standard = value; }
		}

		public Dynamic.Tekla.Structures.Catalogs.BoltItem.BoltItemTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Catalogs.BoltItem.BoltItemTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Catalogs.BoltItem.BoltItemTypeEnum_.GetTSObject(value); }
		}

		public System.Double Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public System.Collections.Generic.List<System.Double> Lengths
		{
			get => teklaObject.Lengths;

		}

        

        internal dynamic teklaObject;

		public BoltItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.BoltItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BoltItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean ExportBoltStandard(ref System.String filename)
		{
			return teklaObject.ExportBoltStandard(ref filename);
		}




    public enum BoltItemTypeEnum
    {
			BOLT_UNKNOWN,
			BOLT,
			STUD        
    }

    internal static class BoltItemTypeEnum_
    {
        public static dynamic GetTSObject(BoltItemTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.BoltItem.BoltItemTypeEnum").GetType();

            switch (dynEnum)
            {
				case BoltItemTypeEnum.BOLT_UNKNOWN:
					return System.Enum.Parse(tsType, "BOLT_UNKNOWN");
				case BoltItemTypeEnum.BOLT:
					return System.Enum.Parse(tsType, "BOLT");
				case BoltItemTypeEnum.STUD:
					return System.Enum.Parse(tsType, "STUD");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltItemTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BOLT_UNKNOWN", System.StringComparison.InvariantCulture))
				return BoltItemTypeEnum.BOLT_UNKNOWN;
			else if (tsEnumValue.Equals("BOLT", System.StringComparison.InvariantCulture))
				return BoltItemTypeEnum.BOLT;
			else if (tsEnumValue.Equals("STUD", System.StringComparison.InvariantCulture))
				return BoltItemTypeEnum.STUD;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BoltItem_
    {
        public static dynamic GetTSObject(BoltItem dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static BoltItem FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.BoltItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BoltItemArray_
    {
        public static dynamic GetTSObject(BoltItem[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BoltItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BoltItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<BoltItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BoltItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    