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
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Profile"); }
			}
			set
			{
				try {
				teklaObject.Profile = Dynamic.Tekla.Structures.Model.Profile_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Profile"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Material_.FromTSObject(teklaObject.Material);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Material"); }
			}
			set
			{
				try {
				teklaObject.Material = Dynamic.Tekla.Structures.Model.Material_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Material"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.DeformingData_.FromTSObject(teklaObject.DeformingData);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DeformingData"); }
			}
			set
			{
				try {
				teklaObject.DeformingData = Dynamic.Tekla.Structures.Model.DeformingData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DeformingData"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.PartNumber);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartNumber"); }
			}
			set
			{
				try {
				teklaObject.PartNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartNumber"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.AssemblyNumber);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyNumber"); }
			}
			set
			{
				try {
				teklaObject.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AssemblyNumber"); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public System.String Class
		{
			get
			{
				try {
					return teklaObject.Class;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class"); }
			}
			set
			{
				try {
					teklaObject.Class = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class"); }
			}
		}

		public System.String Finish
		{
			get
			{
				try {
					return teklaObject.Finish;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Finish"); }
			}
			set
			{
				try {
					teklaObject.Finish = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Finish"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(teklaObject.CastUnitType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CastUnitType"); }
			}
			set
			{
				try {
				teklaObject.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CastUnitType"); }
			}
		}

		public System.Int32 PourPhase
		{
			get
			{
				try {
					return teklaObject.PourPhase;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourPhase"); }
			}
			set
			{
				try {
					teklaObject.PourPhase = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourPhase"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position"); }
			}
			set
			{
				try {
				teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position"); }
			}
		}

        

        


		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
		{
			try {
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSolid()"); }
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
		{
			try {
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSolid()"); }
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
		{
			try {
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSolid()"); }
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			try {
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAssembly()"); }
		}

		public System.String GetPartMark()
		{
			try {
			return teklaObject.GetPartMark();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPartMark()"); }
		}

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
		{
			try {
			return teklaObject.GetCenterLine(withCutsFittings);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetCenterLine()"); }
		}

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
		{
			try {
			return teklaObject.GetReferenceLine(withCutsFittings);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetReferenceLine()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetComponents());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetComponents()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetBooleans());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetBooleans()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetBolts());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetBolts()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetWelds());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetWelds()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetReinforcements());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetReinforcements()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSurfaceTreatments());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSurfaceTreatments()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSurfaceObjects());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSurfaceObjects()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetPours());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPours()"); }
		}

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
		{
			try {
			return teklaObject.CompareTo(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(partToCompare));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CompareTo()"); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetDSTVCoordinateSystem());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDSTVCoordinateSystem()"); }
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
    
