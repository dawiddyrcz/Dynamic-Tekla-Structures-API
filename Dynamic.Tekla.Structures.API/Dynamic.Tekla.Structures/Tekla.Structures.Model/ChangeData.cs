/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ChangeData 
    {

		public Dynamic.Tekla.Structures.Model.ModelObject Object
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Object);

		}

		public Dynamic.Tekla.Structures.Model.ChangeData.ChangeTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.ChangeData.ChangeTypeEnum_.FromTSObject(teklaObject.Type);

		}

        

        internal dynamic teklaObject;

		public ChangeData()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ChangeData");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ChangeData(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum ChangeTypeEnum
    {
			OBJECT_INSERT,
			OBJECT_MODIFY,
			OBJECT_DELETE,
			USERPROPERTY_CHANGED        
    }

    internal static class ChangeTypeEnum_
    {
        public static dynamic GetTSObject(ChangeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ChangeData.ChangeTypeEnum").GetType();

            switch (dynEnum)
            {
				case ChangeTypeEnum.OBJECT_INSERT:
					return System.Enum.Parse(tsType, "OBJECT_INSERT");
				case ChangeTypeEnum.OBJECT_MODIFY:
					return System.Enum.Parse(tsType, "OBJECT_MODIFY");
				case ChangeTypeEnum.OBJECT_DELETE:
					return System.Enum.Parse(tsType, "OBJECT_DELETE");
				case ChangeTypeEnum.USERPROPERTY_CHANGED:
					return System.Enum.Parse(tsType, "USERPROPERTY_CHANGED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ChangeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("OBJECT_INSERT", System.StringComparison.InvariantCulture))
				return ChangeTypeEnum.OBJECT_INSERT;
			else if (tsEnumValue.Equals("OBJECT_MODIFY", System.StringComparison.InvariantCulture))
				return ChangeTypeEnum.OBJECT_MODIFY;
			else if (tsEnumValue.Equals("OBJECT_DELETE", System.StringComparison.InvariantCulture))
				return ChangeTypeEnum.OBJECT_DELETE;
			else if (tsEnumValue.Equals("USERPROPERTY_CHANGED", System.StringComparison.InvariantCulture))
				return ChangeTypeEnum.USERPROPERTY_CHANGED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ChangeData_
    {
        public static dynamic GetTSObject(ChangeData dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ChangeData FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ChangeData)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ChangeDataArray_
    {
        public static dynamic GetTSObject(ChangeData[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ChangeData_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ChangeData[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ChangeData>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ChangeData_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
