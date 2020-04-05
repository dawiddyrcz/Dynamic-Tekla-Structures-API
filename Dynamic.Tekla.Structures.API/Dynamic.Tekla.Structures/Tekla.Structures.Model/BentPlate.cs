/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BentPlate  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry Geometry
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(teklaObject.Geometry);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Geometry"); }
			}
			set
			{
				try {
				teklaObject.Geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Geometry"); }
			}
		}

		public System.Double Thickness
		{
			get
			{
				try {
					return teklaObject.Thickness;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Thickness"); }
			}

		}

        

        

		public BentPlate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlate");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BentPlate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum BendShape
    {
			Cylindrical,
			Conical        
    }

    internal static class BendShape_
    {
        public static dynamic GetTSObject(BendShape dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlate.BendShape").GetType();

            switch (dynEnum)
            {
				case BendShape.Cylindrical:
					return System.Enum.Parse(tsType, "Cylindrical");
				case BendShape.Conical:
					return System.Enum.Parse(tsType, "Conical");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BendShape FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Cylindrical", System.StringComparison.InvariantCulture))
				return BendShape.Cylindrical;
			else if (tsEnumValue.Equals("Conical", System.StringComparison.InvariantCulture))
				return BendShape.Conical;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BentPlate_
    {
        public static dynamic GetTSObject(BentPlate dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BentPlate FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BentPlate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BentPlateArray_
    {
        public static dynamic GetTSObject(BentPlate[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BentPlate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BentPlate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BentPlate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BentPlate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
