//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ChangeData 
    {

		public Dynamic.Tekla.Structures.Model.ModelObject Object
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(changedata.Object.GetTSObject());
			set { changedata.Object = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.ChangeData.ChangeTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.ChangeData.ChangeTypeEnum_.FromTSObject(changedata.Type);
			set { changedata.Type = Dynamic.Tekla.Structures.Model.ChangeData.ChangeTypeEnum_.FromTSObject(value); }
		}

        

        dynamic changedata;
        
        public ChangeData()
        {
            this.changedata =  new Tekla.Structures.Model.ChangeData();
        }

        public ChangeData(dynamic tsObject)
        {
            this.changedata = tsObject;
			this.Object = new Dynamic.Tekla.Structures.Model.ModelObject(changedata.Object);
			this.Type = Dynamic.Tekla.Structures.Model.ChangeData.ChangeTypeEnum_.FromTSObject(changedata.Type);

        }


        public dynamic GetTSObject() => changedata;

		public System.Boolean Equals(System.Object obj)
			 => changedata.Equals(obj);

		public System.Int32 GetHashCode()
			 => changedata.GetHashCode();

		public System.Type GetType()
			 => changedata.GetType();

		public System.String ToString()
			 => changedata.ToString();




    public enum ChangeTypeEnum
    {
			OBJECT_INSERT,
			OBJECT_MODIFY,
			OBJECT_DELETE,
			USERPROPERTY_CHANGED        
    }

    public static class ChangeTypeEnum_
    {
        public static dynamic GetTSObject(ChangeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ChangeTypeEnum");

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

}
    
