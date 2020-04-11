/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class Part  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Profile_.FromTSObject(teklaObject.Profile);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Profile", ex); }
			}
			set
			{
				try {
				teklaObject.Profile = Dynamic.Tekla.Structures.Model.Profile_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Profile", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Material_.FromTSObject(teklaObject.Material);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Material", ex); }
			}
			set
			{
				try {
				teklaObject.Material = Dynamic.Tekla.Structures.Model.Material_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Material", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.DeformingData_.FromTSObject(teklaObject.DeformingData);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DeformingData", ex); }
			}
			set
			{
				try {
				teklaObject.DeformingData = Dynamic.Tekla.Structures.Model.DeformingData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DeformingData", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.PartNumber);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartNumber", ex); }
			}
			set
			{
				try {
				teklaObject.PartNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartNumber", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.AssemblyNumber);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyNumber", ex); }
			}
			set
			{
				try {
				teklaObject.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyNumber", ex); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public System.String Class
		{
			get
			{
				try {
					return teklaObject.Class;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class", ex); }
			}
			set
			{
				try {
					teklaObject.Class = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class", ex); }
			}
		}

		public System.String Finish
		{
			get
			{
				try {
					return teklaObject.Finish;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Finish", ex); }
			}
			set
			{
				try {
					teklaObject.Finish = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Finish", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(teklaObject.CastUnitType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CastUnitType", ex); }
			}
			set
			{
				try {
				teklaObject.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CastUnitType", ex); }
			}
		}

		public System.Int32 PourPhase
		{
			get
			{
				try {
					return teklaObject.PourPhase;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourPhase", ex); }
			}
			set
			{
				try {
					teklaObject.PourPhase = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourPhase", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position", ex); }
			}
			set
			{
				try {
				teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position", ex); }
			}
		}

        

        



public Dynamic.Tekla.Structures.Model.Solid GetSolid()
{

    try
    {
        	var result = teklaObject.GetSolid();

        	var _result = Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
    }
}



public Dynamic.Tekla.Structures.Model.Solid GetSolid(
	Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType_
	)
{
	var solidCreationType = Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType_);
    try
    {
        	var result = teklaObject.GetSolid(solidCreationType);

        	var _result = Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
    }
}



public Dynamic.Tekla.Structures.Model.Solid GetSolid(
	Dynamic.Tekla.Structures.Forming.FormingStates formingStates_
	)
{
	var formingStates = Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates_);
    try
    {
        	var result = teklaObject.GetSolid(formingStates);

        	var _result = Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
    }
}



public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
{

    try
    {
        	var result = teklaObject.GetAssembly();

        	var _result = Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAssembly), ex);
    }
}



public System.String GetPartMark()
{

    try
    {
        	var result = (System.String) teklaObject.GetPartMark();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPartMark), ex);
    }
}



public System.Collections.ArrayList GetCenterLine(
	System.Boolean withCutsFittings
	)
{
	
    try
    {
        	var result = teklaObject.GetCenterLine(withCutsFittings);

        	var _result = ArrayListConverter.FromTSObjects(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCenterLine), ex);
    }
}



public System.Collections.ArrayList GetReferenceLine(
	System.Boolean withCutsFittings
	)
{
	
    try
    {
        	var result = teklaObject.GetReferenceLine(withCutsFittings);

        	var _result = ArrayListConverter.FromTSObjects(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReferenceLine), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
{

    try
    {
        	var result = teklaObject.GetComponents();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetComponents), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
{

    try
    {
        	var result = teklaObject.GetBooleans();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBooleans), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
{

    try
    {
        	var result = teklaObject.GetBolts();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBolts), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
{

    try
    {
        	var result = teklaObject.GetWelds();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetWelds), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
{

    try
    {
        	var result = teklaObject.GetReinforcements();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReinforcements), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
{

    try
    {
        	var result = teklaObject.GetSurfaceTreatments();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSurfaceTreatments), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
{

    try
    {
        	var result = teklaObject.GetSurfaceObjects();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSurfaceObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
{

    try
    {
        	var result = teklaObject.GetPours();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPours), ex);
    }
}



public System.Boolean CompareTo(
	Dynamic.Tekla.Structures.Model.Part partToCompare_
	)
{
	var partToCompare = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(partToCompare_);
    try
    {
        	var result = (System.Boolean) teklaObject.CompareTo(partToCompare);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CompareTo), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
{

    try
    {
        	var result = teklaObject.GetDSTVCoordinateSystem();

        	var _result = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDSTVCoordinateSystem), ex);
    }
}





    public enum CastUnitTypeEnum
    {
			PRECAST,
			CAST_IN_PLACE        
    }

    internal static class CastUnitTypeEnum_
    {
        public static dynamic GetTSObject(CastUnitTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Part.CastUnitTypeEnum").GetType();

            switch (dynEnum)
            {
				case CastUnitTypeEnum.PRECAST:
					return System.Enum.Parse(tsType, "PRECAST");
				case CastUnitTypeEnum.CAST_IN_PLACE:
					return System.Enum.Parse(tsType, "CAST_IN_PLACE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CastUnitTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PRECAST", System.StringComparison.InvariantCulture))
				return CastUnitTypeEnum.PRECAST;
			else if (tsEnumValue.Equals("CAST_IN_PLACE", System.StringComparison.InvariantCulture))
				return CastUnitTypeEnum.CAST_IN_PLACE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Part_
    {
        public static dynamic GetTSObject(Part dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Part FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Part)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PartArray_
    {
        public static dynamic GetTSObject(Part[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Part_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Part[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Part>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Part_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
