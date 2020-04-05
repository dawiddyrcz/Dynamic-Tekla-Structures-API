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
			get => teklaObject.Grade;
			set { teklaObject.Grade = value; }
		}

		public System.String Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public System.String Usage
		{
			get => teklaObject.Usage;
			set { teklaObject.Usage = value; }
		}

		public System.Double BendRadius
		{
			get => teklaObject.BendRadius;
			set { teklaObject.BendRadius = value; }
		}

		public System.String Code
		{
			get => teklaObject.Code;
			set { teklaObject.Code = value; }
		}

		public System.Double NominalDiameter
		{
			get => teklaObject.NominalDiameter;
			set { teklaObject.NominalDiameter = value; }
		}

		public System.Double ActualDiameter
		{
			get => teklaObject.ActualDiameter;
			set { teklaObject.ActualDiameter = value; }
		}

		public System.Double WeightPerLenght
		{
			get => teklaObject.WeightPerLenght;
			set { teklaObject.WeightPerLenght = value; }
		}

		public System.Double CrossSectionArea
		{
			get => teklaObject.CrossSectionArea;
			set { teklaObject.CrossSectionArea = value; }
		}

		public System.Double HookRadius90Degrees
		{
			get => teklaObject.HookRadius90Degrees;
			set { teklaObject.HookRadius90Degrees = value; }
		}

		public System.Double HookLength90Degrees
		{
			get => teklaObject.HookLength90Degrees;
			set { teklaObject.HookLength90Degrees = value; }
		}

		public System.Double HookRadius135Degrees
		{
			get => teklaObject.HookRadius135Degrees;
			set { teklaObject.HookRadius135Degrees = value; }
		}

		public System.Double HookLength135Degrees
		{
			get => teklaObject.HookLength135Degrees;
			set { teklaObject.HookLength135Degrees = value; }
		}

		public System.Double HookRadius180Degrees
		{
			get => teklaObject.HookRadius180Degrees;
			set { teklaObject.HookRadius180Degrees = value; }
		}

		public System.Double HookLength180Degrees
		{
			get => teklaObject.HookLength180Degrees;
			set { teklaObject.HookLength180Degrees = value; }
		}

		public System.Double LapLength
		{
			get => teklaObject.LapLength;
			set { teklaObject.LapLength = value; }
		}

		public System.Double CrankStraightLength
		{
			get => teklaObject.CrankStraightLength;
			set { teklaObject.CrankStraightLength = value; }
		}

		public System.String CrankedLengthType
		{
			get => teklaObject.CrankedLengthType;
			set { teklaObject.CrankedLengthType = value; }
		}

		public System.Double CrankedLength
		{
			get => teklaObject.CrankedLength;
			set { teklaObject.CrankedLength = value; }
		}

		public System.Double CrankExtraOffset
		{
			get => teklaObject.CrankExtraOffset;
			set { teklaObject.CrankExtraOffset = value; }
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

		public System.Boolean Select(System.String Grade, System.String Size, System.Double BendRadius)
		{
			try {
			return teklaObject.Select(Grade, Size, BendRadius);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.Double Diameter, System.Double BendRadius, System.Boolean UseNominalDiameter)
		{
			try {
			return teklaObject.Select(Grade, Diameter, BendRadius, UseNominalDiameter);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.String Size, System.String Usage)
		{
			try {
			return teklaObject.Select(Grade, Size, Usage);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.Double Diameter, System.String Usage, System.Boolean UseNominalDiameter)
		{
			try {
			return teklaObject.Select(Grade, Diameter, Usage, UseNominalDiameter);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.String Size)
		{
			try {
			return teklaObject.Select(Grade, Size);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.Double NominalDiameter, System.Boolean UseNominalDiameter)
		{
			try {
			return teklaObject.Select(Grade, NominalDiameter, UseNominalDiameter);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Export(ref System.String filename)
		{
			try {
			return teklaObject.Export(ref filename);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Export()"); }
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
    
