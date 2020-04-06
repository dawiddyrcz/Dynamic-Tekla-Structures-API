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
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade"); }
			}
			set
			{
				try {
					teklaObject.Grade = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade"); }
			}
		}

		public System.String Size
		{
			get
			{
				try {
					return teklaObject.Size;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size"); }
			}
			set
			{
				try {
					teklaObject.Size = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size"); }
			}
		}

		public System.String Usage
		{
			get
			{
				try {
					return teklaObject.Usage;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Usage"); }
			}
			set
			{
				try {
					teklaObject.Usage = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Usage"); }
			}
		}

		public System.Double BendRadius
		{
			get
			{
				try {
					return teklaObject.BendRadius;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendRadius"); }
			}
			set
			{
				try {
					teklaObject.BendRadius = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendRadius"); }
			}
		}

		public System.String Code
		{
			get
			{
				try {
					return teklaObject.Code;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Code"); }
			}
			set
			{
				try {
					teklaObject.Code = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Code"); }
			}
		}

		public System.Double NominalDiameter
		{
			get
			{
				try {
					return teklaObject.NominalDiameter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NominalDiameter"); }
			}
			set
			{
				try {
					teklaObject.NominalDiameter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NominalDiameter"); }
			}
		}

		public System.Double ActualDiameter
		{
			get
			{
				try {
					return teklaObject.ActualDiameter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualDiameter"); }
			}
			set
			{
				try {
					teklaObject.ActualDiameter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualDiameter"); }
			}
		}

		public System.Double WeightPerLenght
		{
			get
			{
				try {
					return teklaObject.WeightPerLenght;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeightPerLenght"); }
			}
			set
			{
				try {
					teklaObject.WeightPerLenght = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeightPerLenght"); }
			}
		}

		public System.Double CrossSectionArea
		{
			get
			{
				try {
					return teklaObject.CrossSectionArea;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossSectionArea"); }
			}
			set
			{
				try {
					teklaObject.CrossSectionArea = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossSectionArea"); }
			}
		}

		public System.Double HookRadius90Degrees
		{
			get
			{
				try {
					return teklaObject.HookRadius90Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius90Degrees"); }
			}
			set
			{
				try {
					teklaObject.HookRadius90Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius90Degrees"); }
			}
		}

		public System.Double HookLength90Degrees
		{
			get
			{
				try {
					return teklaObject.HookLength90Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength90Degrees"); }
			}
			set
			{
				try {
					teklaObject.HookLength90Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength90Degrees"); }
			}
		}

		public System.Double HookRadius135Degrees
		{
			get
			{
				try {
					return teklaObject.HookRadius135Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius135Degrees"); }
			}
			set
			{
				try {
					teklaObject.HookRadius135Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius135Degrees"); }
			}
		}

		public System.Double HookLength135Degrees
		{
			get
			{
				try {
					return teklaObject.HookLength135Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength135Degrees"); }
			}
			set
			{
				try {
					teklaObject.HookLength135Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength135Degrees"); }
			}
		}

		public System.Double HookRadius180Degrees
		{
			get
			{
				try {
					return teklaObject.HookRadius180Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius180Degrees"); }
			}
			set
			{
				try {
					teklaObject.HookRadius180Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookRadius180Degrees"); }
			}
		}

		public System.Double HookLength180Degrees
		{
			get
			{
				try {
					return teklaObject.HookLength180Degrees;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength180Degrees"); }
			}
			set
			{
				try {
					teklaObject.HookLength180Degrees = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HookLength180Degrees"); }
			}
		}

		public System.Double LapLength
		{
			get
			{
				try {
					return teklaObject.LapLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LapLength"); }
			}
			set
			{
				try {
					teklaObject.LapLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LapLength"); }
			}
		}

		public System.Double CrankStraightLength
		{
			get
			{
				try {
					return teklaObject.CrankStraightLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankStraightLength"); }
			}
			set
			{
				try {
					teklaObject.CrankStraightLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankStraightLength"); }
			}
		}

		public System.String CrankedLengthType
		{
			get
			{
				try {
					return teklaObject.CrankedLengthType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLengthType"); }
			}
			set
			{
				try {
					teklaObject.CrankedLengthType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLengthType"); }
			}
		}

		public System.Double CrankedLength
		{
			get
			{
				try {
					return teklaObject.CrankedLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLength"); }
			}
			set
			{
				try {
					teklaObject.CrankedLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLength"); }
			}
		}

		public System.Double CrankExtraOffset
		{
			get
			{
				try {
					return teklaObject.CrankExtraOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankExtraOffset"); }
			}
			set
			{
				try {
					teklaObject.CrankExtraOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankExtraOffset"); }
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

		public System.Boolean Select(System.String Grade, System.String Size, System.Double BendRadius)
		{
			try {
			var result = teklaObject.Select(Grade, Size, BendRadius);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.Double Diameter, System.Double BendRadius, System.Boolean UseNominalDiameter)
		{
			try {
			var result = teklaObject.Select(Grade, Diameter, BendRadius, UseNominalDiameter);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.String Size, System.String Usage)
		{
			try {
			var result = teklaObject.Select(Grade, Size, Usage);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.Double Diameter, System.String Usage, System.Boolean UseNominalDiameter)
		{
			try {
			var result = teklaObject.Select(Grade, Diameter, Usage, UseNominalDiameter);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.String Size)
		{
			try {
			var result = teklaObject.Select(Grade, Size);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select(System.String Grade, System.Double NominalDiameter, System.Boolean UseNominalDiameter)
		{
			try {
			var result = teklaObject.Select(Grade, NominalDiameter, UseNominalDiameter);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Export(ref System.String filename)
		{
			try {
			var result = teklaObject.Export(ref filename);
			return result;
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
    
