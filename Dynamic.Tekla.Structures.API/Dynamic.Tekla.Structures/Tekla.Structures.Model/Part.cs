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
			get => Dynamic.Tekla.Structures.Model.Profile_.FromTSObject(teklaObject.Profile);
			set { teklaObject.Profile = Dynamic.Tekla.Structures.Model.Profile_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => Dynamic.Tekla.Structures.Model.Material_.FromTSObject(teklaObject.Material);
			set { teklaObject.Material = Dynamic.Tekla.Structures.Model.Material_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => Dynamic.Tekla.Structures.Model.DeformingData_.FromTSObject(teklaObject.DeformingData);
			set { teklaObject.DeformingData = Dynamic.Tekla.Structures.Model.DeformingData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.PartNumber);
			set { teklaObject.PartNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.AssemblyNumber);
			set { teklaObject.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public System.String Finish
		{
			get => teklaObject.Finish;
			set { teklaObject.Finish = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get => Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(teklaObject.CastUnitType);
			set { teklaObject.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.GetTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => teklaObject.PourPhase;
			set { teklaObject.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value); }
		}

        

        


		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
		{
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
		{
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType)));
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
		{
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates)));
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
		}

		public System.String GetPartMark()
		{
			return teklaObject.GetPartMark();
		}

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
		{
			return teklaObject.GetCenterLine(withCutsFittings);
		}

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
		{
			return teklaObject.GetReferenceLine(withCutsFittings);
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetComponents());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetBooleans());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetBolts());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetWelds());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetReinforcements());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSurfaceTreatments());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSurfaceObjects());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetPours());
		}

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
		{
			return teklaObject.CompareTo(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(partToCompare));
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
		{
			return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetDSTVCoordinateSystem());
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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
    
