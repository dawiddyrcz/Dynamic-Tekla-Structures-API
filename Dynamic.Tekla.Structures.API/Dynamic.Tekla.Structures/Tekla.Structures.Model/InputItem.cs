/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class InputItem 
    {

        

        internal dynamic teklaObject;

		public InputItem() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public InputItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Model.InputItem.InputTypeEnum GetInputType()
		{
			return Dynamic.Tekla.Structures.Model.InputItem.InputTypeEnum_.FromTSObject(teklaObject.GetInputType());
		}

		public System.Object GetData()
		{
			return teklaObject.GetData();
		}




    public enum InputTypeEnum
    {
			INPUT_1_POINT,
			INPUT_2_POINTS,
			INPUT_POLYGON,
			INPUT_1_OBJECT,
			INPUT_N_OBJECTS        
    }

    internal static class InputTypeEnum_
    {
        public static dynamic GetTSObject(InputTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.InputItem.InputTypeEnum").GetType();

            switch (dynEnum)
            {
				case InputTypeEnum.INPUT_1_POINT:
					return System.Enum.Parse(tsType, "INPUT_1_POINT");
				case InputTypeEnum.INPUT_2_POINTS:
					return System.Enum.Parse(tsType, "INPUT_2_POINTS");
				case InputTypeEnum.INPUT_POLYGON:
					return System.Enum.Parse(tsType, "INPUT_POLYGON");
				case InputTypeEnum.INPUT_1_OBJECT:
					return System.Enum.Parse(tsType, "INPUT_1_OBJECT");
				case InputTypeEnum.INPUT_N_OBJECTS:
					return System.Enum.Parse(tsType, "INPUT_N_OBJECTS");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static InputTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("INPUT_1_POINT", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_1_POINT;
			else if (tsEnumValue.Equals("INPUT_2_POINTS", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_2_POINTS;
			else if (tsEnumValue.Equals("INPUT_POLYGON", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_POLYGON;
			else if (tsEnumValue.Equals("INPUT_1_OBJECT", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_1_OBJECT;
			else if (tsEnumValue.Equals("INPUT_N_OBJECTS", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_N_OBJECTS;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class InputItem_
    {
        public static dynamic GetTSObject(InputItem dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InputItem FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.InputItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InputItemArray_
    {
        public static dynamic GetTSObject(InputItem[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InputItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InputItem[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<InputItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InputItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
