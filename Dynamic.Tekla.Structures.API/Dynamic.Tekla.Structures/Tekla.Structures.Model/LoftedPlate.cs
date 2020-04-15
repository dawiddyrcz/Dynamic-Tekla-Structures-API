/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class LoftedPlate  : Dynamic.Tekla.Structures.Model.Part
    {


        public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.ICurve> BaseCurves
        {
            get
            {
                try
                {
                var value = teklaObject.BaseCurves;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.ICurve>(value);
                return (System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.ICurve>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BaseCurves), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.BaseCurves = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BaseCurves), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum FaceType
        {
            get
            {
                try
                {
                var value = teklaObject.FaceType;
                var value_ = Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FaceType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum_.GetTSObject(value);
                teklaObject.FaceType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FaceType), ex); 
                }
            }
        }
        

        

		public LoftedPlate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlate");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LoftedPlate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum LoftedPlateFaceTypeEnum
    {
			Perpendicular,
			BoundedByCurvePlanes        
    }

    internal static class LoftedPlateFaceTypeEnum_
    {
        public static dynamic GetTSObject(LoftedPlateFaceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum").GetType();

            switch (dynEnum)
            {
				case LoftedPlateFaceTypeEnum.Perpendicular:
					return System.Enum.Parse(tsType, "Perpendicular");
				case LoftedPlateFaceTypeEnum.BoundedByCurvePlanes:
					return System.Enum.Parse(tsType, "BoundedByCurvePlanes");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoftedPlateFaceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Perpendicular", System.StringComparison.InvariantCulture))
				return LoftedPlateFaceTypeEnum.Perpendicular;
			else if (tsEnumValue.Equals("BoundedByCurvePlanes", System.StringComparison.InvariantCulture))
				return LoftedPlateFaceTypeEnum.BoundedByCurvePlanes;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoftedPlate_
    {
        public static dynamic GetTSObject(LoftedPlate dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoftedPlate FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LoftedPlate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoftedPlateArray_
    {
        public static dynamic GetTSObject(LoftedPlate[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoftedPlate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoftedPlate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoftedPlate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoftedPlate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
