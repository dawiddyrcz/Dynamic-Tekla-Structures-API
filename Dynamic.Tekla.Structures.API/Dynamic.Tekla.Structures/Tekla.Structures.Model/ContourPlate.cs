/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ContourPlate  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum Type
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Contour"); }
			}
			set
			{
				try {
				teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Contour"); }
			}
		}

        

        

		public ContourPlate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPlate");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ContourPlate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint contourPoint)
		{
			try {
			var result = teklaObject.AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint_.GetTSObject(contourPoint));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddContourPoint()"); }
		}




    public enum ContourPlateTypeEnum
    {
			UNKNOWN,
			PLATE,
			SLAB        
    }

    internal static class ContourPlateTypeEnum_
    {
        public static dynamic GetTSObject(ContourPlateTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum").GetType();

            switch (dynEnum)
            {
				case ContourPlateTypeEnum.UNKNOWN:
					return System.Enum.Parse(tsType, "UNKNOWN");
				case ContourPlateTypeEnum.PLATE:
					return System.Enum.Parse(tsType, "PLATE");
				case ContourPlateTypeEnum.SLAB:
					return System.Enum.Parse(tsType, "SLAB");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ContourPlateTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
				return ContourPlateTypeEnum.UNKNOWN;
			else if (tsEnumValue.Equals("PLATE", System.StringComparison.InvariantCulture))
				return ContourPlateTypeEnum.PLATE;
			else if (tsEnumValue.Equals("SLAB", System.StringComparison.InvariantCulture))
				return ContourPlateTypeEnum.SLAB;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ContourPlate_
    {
        public static dynamic GetTSObject(ContourPlate dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ContourPlate FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ContourPlate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ContourPlateArray_
    {
        public static dynamic GetTSObject(ContourPlate[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ContourPlate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ContourPlate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ContourPlate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ContourPlate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
