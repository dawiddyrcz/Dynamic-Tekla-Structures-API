/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BooleanPart  : Dynamic.Tekla.Structures.Model.Boolean
    {

		public Dynamic.Tekla.Structures.Model.BooleanPart.BooleanTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.BooleanPart.BooleanTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.BooleanPart.BooleanTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Part OperativePart
		{
			get => Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.OperativePart);
			set { teklaObject.OperativePart = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value); }
		}

		public static System.String BooleanOperativeClassName
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.BooleanPart","BooleanOperativeClassName");

		}

        

        

		public BooleanPart()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BooleanPart");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BooleanPart(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean SetOperativePart(Dynamic.Tekla.Structures.Model.Part Part)
		{
			return teklaObject.SetOperativePart(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(Part));
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




    public enum BooleanTypeEnum
    {
			BOOLEAN_ADD,
			BOOLEAN_CUT,
			BOOLEAN_WELDPREP        
    }

    internal static class BooleanTypeEnum_
    {
        public static dynamic GetTSObject(BooleanTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BooleanPart.BooleanTypeEnum").GetType();

            switch (dynEnum)
            {
				case BooleanTypeEnum.BOOLEAN_ADD:
					return System.Enum.Parse(tsType, "BOOLEAN_ADD");
				case BooleanTypeEnum.BOOLEAN_CUT:
					return System.Enum.Parse(tsType, "BOOLEAN_CUT");
				case BooleanTypeEnum.BOOLEAN_WELDPREP:
					return System.Enum.Parse(tsType, "BOOLEAN_WELDPREP");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BooleanTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BOOLEAN_ADD", System.StringComparison.InvariantCulture))
				return BooleanTypeEnum.BOOLEAN_ADD;
			else if (tsEnumValue.Equals("BOOLEAN_CUT", System.StringComparison.InvariantCulture))
				return BooleanTypeEnum.BOOLEAN_CUT;
			else if (tsEnumValue.Equals("BOOLEAN_WELDPREP", System.StringComparison.InvariantCulture))
				return BooleanTypeEnum.BOOLEAN_WELDPREP;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BooleanPart_
    {
        public static dynamic GetTSObject(BooleanPart dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static BooleanPart FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BooleanPart)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BooleanPartArray_
    {
        public static dynamic GetTSObject(BooleanPart[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BooleanPart_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BooleanPart[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<BooleanPart>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BooleanPart_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
