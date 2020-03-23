/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class CircleRebarGroup  : Dynamic.Tekla.Structures.Model.BaseRebarGroup
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
			set { teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.CircleRebarGroup.CircleRebarGroupStirrupTypeEnum StirrupType
		{
			get => Dynamic.Tekla.Structures.Model.CircleRebarGroup.CircleRebarGroupStirrupTypeEnum_.FromTSObject(teklaObject.StirrupType);
			set { teklaObject.StirrupType = Dynamic.Tekla.Structures.Model.CircleRebarGroup.CircleRebarGroupStirrupTypeEnum_.GetTSObject(value); }
		}

        

        

		public CircleRebarGroup()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CircleRebarGroup");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CircleRebarGroup(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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




    public enum CircleRebarGroupStirrupTypeEnum
    {
			STIRRUP_TYPE_CIRCLE,
			STIRRUP_TYPE_SPIRAL        
    }

    internal static class CircleRebarGroupStirrupTypeEnum_
    {
        public static dynamic GetTSObject(CircleRebarGroupStirrupTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.CircleRebarGroup.CircleRebarGroupStirrupTypeEnum").GetType();

            switch (dynEnum)
            {
				case CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_CIRCLE:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_CIRCLE");
				case CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_SPIRAL");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CircleRebarGroupStirrupTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("STIRRUP_TYPE_CIRCLE", System.StringComparison.InvariantCulture))
				return CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_CIRCLE;
			else if (tsEnumValue.Equals("STIRRUP_TYPE_SPIRAL", System.StringComparison.InvariantCulture))
				return CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class CircleRebarGroup_
    {
        public static dynamic GetTSObject(CircleRebarGroup dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CircleRebarGroup FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.CircleRebarGroup)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CircleRebarGroupArray_
    {
        public static dynamic GetTSObject(CircleRebarGroup[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CircleRebarGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CircleRebarGroup[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CircleRebarGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CircleRebarGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
