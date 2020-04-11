/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PolyBeam  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum Type
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Contour", ex); }
			}
			set
			{
				try {
				teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Contour", ex); }
			}
		}

        

        

		public PolyBeam()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolyBeam(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PolyBeam(Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum polyBeamType)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.GetTSObject(polyBeamType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam", args);
		}


public System.Boolean AddContourPoint(
	Dynamic.Tekla.Structures.Model.ContourPoint contourPoint_
	)
{
	var contourPoint = Dynamic.Tekla.Structures.Model.ContourPoint_.GetTSObject(contourPoint_);
    try
    {
        	var result = (System.Boolean) teklaObject.AddContourPoint(contourPoint);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddContourPoint), ex);
    }
}



public System.Collections.ArrayList GetPolybeamCoordinateSystems()
{

    try
    {
        	var result = teklaObject.GetPolybeamCoordinateSystems();

        	var _result = ArrayListConverter.FromTSObjects(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPolybeamCoordinateSystems), ex);
    }
}





    public enum PolyBeamTypeEnum
    {
			BEAM,
			PANEL,
			STRIP_FOOTING,
			COLUMN        
    }

    internal static class PolyBeamTypeEnum_
    {
        public static dynamic GetTSObject(PolyBeamTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum").GetType();

            switch (dynEnum)
            {
				case PolyBeamTypeEnum.BEAM:
					return System.Enum.Parse(tsType, "BEAM");
				case PolyBeamTypeEnum.PANEL:
					return System.Enum.Parse(tsType, "PANEL");
				case PolyBeamTypeEnum.STRIP_FOOTING:
					return System.Enum.Parse(tsType, "STRIP_FOOTING");
				case PolyBeamTypeEnum.COLUMN:
					return System.Enum.Parse(tsType, "COLUMN");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PolyBeamTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.BEAM;
			else if (tsEnumValue.Equals("PANEL", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.PANEL;
			else if (tsEnumValue.Equals("STRIP_FOOTING", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.STRIP_FOOTING;
			else if (tsEnumValue.Equals("COLUMN", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.COLUMN;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class PolyBeam_
    {
        public static dynamic GetTSObject(PolyBeam dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolyBeam FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PolyBeam)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolyBeamArray_
    {
        public static dynamic GetTSObject(PolyBeam[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolyBeam_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolyBeam[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolyBeam>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolyBeam_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
