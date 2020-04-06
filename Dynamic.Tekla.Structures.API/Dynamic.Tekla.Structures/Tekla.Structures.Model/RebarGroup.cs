/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarGroup  : Dynamic.Tekla.Structures.Model.BaseRebarGroup
    {

		public System.Collections.ArrayList Polygons
		{
			get
			{
				try {
					return TSActivator.ConvertArrayList(teklaObject.Polygons);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygons"); }
			}
			set
			{
				try {
					teklaObject.Polygons = TSActivator.ConvertToTSArrayList(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygons"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum StirrupType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum_.FromTSObject(teklaObject.StirrupType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StirrupType"); }
			}
			set
			{
				try {
				teklaObject.StirrupType = Dynamic.Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StirrupType"); }
			}
		}

        

        

		public RebarGroup()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGroup");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarGroup(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum RebarGroupStirrupTypeEnum
    {
			STIRRUP_TYPE_POLYGONAL,
			STIRRUP_TYPE_SPIRAL,
			STIRRUP_TYPE_TAPERED_CURVED        
    }

    internal static class RebarGroupStirrupTypeEnum_
    {
        public static dynamic GetTSObject(RebarGroupStirrupTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_POLYGONAL:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_POLYGONAL");
				case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_SPIRAL");
				case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_TAPERED_CURVED:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_TAPERED_CURVED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarGroupStirrupTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("STIRRUP_TYPE_POLYGONAL", System.StringComparison.InvariantCulture))
				return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_POLYGONAL;
			else if (tsEnumValue.Equals("STIRRUP_TYPE_SPIRAL", System.StringComparison.InvariantCulture))
				return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL;
			else if (tsEnumValue.Equals("STIRRUP_TYPE_TAPERED_CURVED", System.StringComparison.InvariantCulture))
				return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_TAPERED_CURVED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarGroup_
    {
        public static dynamic GetTSObject(RebarGroup dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarGroup FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarGroup)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarGroupArray_
    {
        public static dynamic GetTSObject(RebarGroup[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarGroup[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
