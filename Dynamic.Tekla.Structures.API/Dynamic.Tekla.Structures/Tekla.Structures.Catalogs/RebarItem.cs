/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class RebarItem 
    {

		public System.String Grade
		{
			get
			{
				try {
					return teklaObject.Grade;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade", ex); }
			}
			set
			{
				try {
					teklaObject.Grade = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade", ex); }
			}
		}

		public System.String Size
		{
			get
			{
				try {
					return teklaObject.Size;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size", ex); }
			}
			set
			{
				try {
					teklaObject.Size = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size", ex); }
			}
		}

		public System.String Usage
		{
			get
			{
				try {
					return teklaObject.Usage;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Usage", ex); }
			}
			set
			{
				try {
					teklaObject.Usage = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Usage", ex); }
			}
		}

		public System.Double BendRadius
		{
			get
			{
				try {
					return teklaObject.BendRadius;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendRadius", ex); }
			}
			set
			{
				try {
					teklaObject.BendRadius = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendRadius", ex); }
			}
		}

		public System.String Code
		{
			get
			{
				try {
					return teklaObject.Code;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Code", ex); }
			}
			set
			{
				try {
					teklaObject.Code = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Code", ex); }
			}
		}

		public System.Double NominalDiameter
		{
			get
			{
				try {
					return teklaObject.NominalDiameter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NominalDiameter", ex); }
			}
			set
			{
				try {
					teklaObject.NominalDiameter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NominalDiameter", ex); }
			}
		}

		public System.Double ActualDiameter
		{
			get
			{
				try {
					return teklaObject.ActualDiameter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualDiameter", ex); }
			}
			set
			{
				try {
					teklaObject.ActualDiameter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualDiameter", ex); }
			}
		}

		public System.Double WeightPerLenght
		{
			get
			{
				try {
					return teklaObject.WeightPerLenght;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeightPerLenght", ex); }
			}
			set
			{
				try {
					teklaObject.WeightPerLenght = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeightPerLenght", ex); }
			}
		}

		public System.Double CrossSectionArea
		{
			get
			{
				try {
					return teklaObject.CrossSectionArea;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossSectionArea", ex); }
			}
			set
			{
				try {
					teklaObject.CrossSectionArea = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossSectionArea", ex); }
			}
		}

		public System.Double HookRadius90Degrees
		{
			get
			{
				try {
					return teklaObject.HookRadius90Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius90Degrees", ex); }
			}
			set
			{
				try {
					teklaObject.HookRadius90Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius90Degrees", ex); }
			}
		}

		public System.Double HookLength90Degrees
		{
			get
			{
				try {
					return teklaObject.HookLength90Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength90Degrees", ex); }
			}
			set
			{
				try {
					teklaObject.HookLength90Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength90Degrees", ex); }
			}
		}

		public System.Double HookRadius135Degrees
		{
			get
			{
				try {
					return teklaObject.HookRadius135Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius135Degrees", ex); }
			}
			set
			{
				try {
					teklaObject.HookRadius135Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius135Degrees", ex); }
			}
		}

		public System.Double HookLength135Degrees
		{
			get
			{
				try {
					return teklaObject.HookLength135Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength135Degrees", ex); }
			}
			set
			{
				try {
					teklaObject.HookLength135Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength135Degrees", ex); }
			}
		}

		public System.Double HookRadius180Degrees
		{
			get
			{
				try {
					return teklaObject.HookRadius180Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius180Degrees", ex); }
			}
			set
			{
				try {
					teklaObject.HookRadius180Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius180Degrees", ex); }
			}
		}

		public System.Double HookLength180Degrees
		{
			get
			{
				try {
					return teklaObject.HookLength180Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength180Degrees", ex); }
			}
			set
			{
				try {
					teklaObject.HookLength180Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength180Degrees", ex); }
			}
		}

		public System.Double LapLength
		{
			get
			{
				try {
					return teklaObject.LapLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LapLength", ex); }
			}
			set
			{
				try {
					teklaObject.LapLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LapLength", ex); }
			}
		}

		public System.Double CrankStraightLength
		{
			get
			{
				try {
					return teklaObject.CrankStraightLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankStraightLength", ex); }
			}
			set
			{
				try {
					teklaObject.CrankStraightLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankStraightLength", ex); }
			}
		}

		public System.String CrankedLengthType
		{
			get
			{
				try {
					return teklaObject.CrankedLengthType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLengthType", ex); }
			}
			set
			{
				try {
					teklaObject.CrankedLengthType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLengthType", ex); }
			}
		}

		public System.Double CrankedLength
		{
			get
			{
				try {
					return teklaObject.CrankedLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLength", ex); }
			}
			set
			{
				try {
					teklaObject.CrankedLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLength", ex); }
			}
		}

		public System.Double CrankExtraOffset
		{
			get
			{
				try {
					return teklaObject.CrankExtraOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankExtraOffset", ex); }
			}
			set
			{
				try {
					teklaObject.CrankExtraOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankExtraOffset", ex); }
			}
		}

		public static System.String MAIN_USAGE
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Catalogs.RebarItem","MAIN_USAGE");

		}

		public static System.String TIE_STIRRUP_USAGE
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Catalogs.RebarItem","TIE_STIRRUP_USAGE");

		}

		public static System.String DIAGONAL_RATIO_STRING
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Catalogs.RebarItem","DIAGONAL_RATIO_STRING");

		}

		public static System.String DIAGONAL_DISTANCE_STRING
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Catalogs.RebarItem","DIAGONAL_DISTANCE_STRING");

		}

		public static System.String HORIZONTAL_RATIO_STRING
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Catalogs.RebarItem","HORIZONTAL_RATIO_STRING");

		}

		public static System.String HORIZONTAL_DISTANCE_STRING
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Catalogs.RebarItem","HORIZONTAL_DISTANCE_STRING");

		}

        

        internal dynamic teklaObject;

		public RebarItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.RebarItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean Select(
	System.String Grade,
	System.String Size,
	System.Double BendRadius
	)
{
	
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Grade, Size, BendRadius);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Select(
	System.String Grade,
	System.Double Diameter,
	System.Double BendRadius,
	System.Boolean UseNominalDiameter
	)
{
	
	
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Grade, Diameter, BendRadius, UseNominalDiameter);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Select(
	System.String Grade,
	System.String Size,
	System.String Usage
	)
{
	
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Grade, Size, Usage);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Select(
	System.String Grade,
	System.Double Diameter,
	System.String Usage,
	System.Boolean UseNominalDiameter
	)
{
	
	
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Grade, Diameter, Usage, UseNominalDiameter);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Select(
	System.String Grade,
	System.String Size
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Grade, Size);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Select(
	System.String Grade,
	System.Double NominalDiameter,
	System.Boolean UseNominalDiameter
	)
{
	
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Grade, NominalDiameter, UseNominalDiameter);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Export(
	ref System.String filename
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.Export(ref filename);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Export), ex);
    }
}






    }

    internal static class RebarItem_
    {
        public static dynamic GetTSObject(RebarItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.RebarItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarItemArray_
    {
        public static dynamic GetTSObject(RebarItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
