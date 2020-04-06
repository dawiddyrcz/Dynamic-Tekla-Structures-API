/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Solid 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point MinimumPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.MinimumPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point MaximumPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.MaximumPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumPoint"); }
			}
		}

        

        internal dynamic teklaObject;

		internal Solid() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Solid(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Collections.ArrayList Intersect(Dynamic.Tekla.Structures.Geometry3d.LineSegment line)
		{
			try {
			var result = teklaObject.Intersect(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(line));
			return TSActivator.ConvertArrayList(result);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Intersect()"); }
		}

		public System.Collections.ArrayList Intersect(Dynamic.Tekla.Structures.Geometry3d.Point point1, Dynamic.Tekla.Structures.Geometry3d.Point point2)
		{
			try {
			var result = teklaObject.Intersect(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point2));
			return TSActivator.ConvertArrayList(result);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Intersect()"); }
		}

		public System.Collections.ArrayList Intersect(Dynamic.Tekla.Structures.Geometry3d.Point point1, Dynamic.Tekla.Structures.Geometry3d.Point point2, Dynamic.Tekla.Structures.Geometry3d.Point point3)
		{
			try {
			var result = teklaObject.Intersect(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point2), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point3));
			return TSActivator.ConvertArrayList(result);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Intersect()"); }
		}

		public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
		{
			try {
			return Dynamic.Tekla.Structures.Solid.FaceEnumerator_.FromTSObject(teklaObject.GetFaceEnumerator());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetFaceEnumerator()"); }
		}

		public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
		{
			try {
			return Dynamic.Tekla.Structures.Solid.EdgeEnumerator_.FromTSObject(teklaObject.GetEdgeEnumerator());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetEdgeEnumerator()"); }
		}

		public Dynamic.Tekla.Structures.Solid.ShellEnumerator GetCutPart(Dynamic.Tekla.Structures.Model.Solid CuttingPart)
		{
			try {
			return Dynamic.Tekla.Structures.Solid.ShellEnumerator_.FromTSObject(teklaObject.GetCutPart(Dynamic.Tekla.Structures.Model.Solid_.GetTSObject(CuttingPart)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetCutPart()"); }
		}




    public enum SolidCreationTypeEnum
    {
			RAW,
			FITTED,
			NORMAL,
			HIGH_ACCURACY,
			PLANECUTTED,
			NORMAL_WITHOUT_EDGECHAMFERS,
			NORMAL_WITHOUT_WELDPREPS        
    }

    internal static class SolidCreationTypeEnum_
    {
        public static dynamic GetTSObject(SolidCreationTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Solid.SolidCreationTypeEnum").GetType();

            switch (dynEnum)
            {
				case SolidCreationTypeEnum.RAW:
					return System.Enum.Parse(tsType, "RAW");
				case SolidCreationTypeEnum.FITTED:
					return System.Enum.Parse(tsType, "FITTED");
				case SolidCreationTypeEnum.NORMAL:
					return System.Enum.Parse(tsType, "NORMAL");
				case SolidCreationTypeEnum.HIGH_ACCURACY:
					return System.Enum.Parse(tsType, "HIGH_ACCURACY");
				case SolidCreationTypeEnum.PLANECUTTED:
					return System.Enum.Parse(tsType, "PLANECUTTED");
				case SolidCreationTypeEnum.NORMAL_WITHOUT_EDGECHAMFERS:
					return System.Enum.Parse(tsType, "NORMAL_WITHOUT_EDGECHAMFERS");
				case SolidCreationTypeEnum.NORMAL_WITHOUT_WELDPREPS:
					return System.Enum.Parse(tsType, "NORMAL_WITHOUT_WELDPREPS");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SolidCreationTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("RAW", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.RAW;
			else if (tsEnumValue.Equals("FITTED", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.FITTED;
			else if (tsEnumValue.Equals("NORMAL", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.NORMAL;
			else if (tsEnumValue.Equals("HIGH_ACCURACY", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.HIGH_ACCURACY;
			else if (tsEnumValue.Equals("PLANECUTTED", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.PLANECUTTED;
			else if (tsEnumValue.Equals("NORMAL_WITHOUT_EDGECHAMFERS", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.NORMAL_WITHOUT_EDGECHAMFERS;
			else if (tsEnumValue.Equals("NORMAL_WITHOUT_WELDPREPS", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.NORMAL_WITHOUT_WELDPREPS;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Solid_
    {
        public static dynamic GetTSObject(Solid dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Solid FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Solid)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SolidArray_
    {
        public static dynamic GetTSObject(Solid[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Solid_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Solid[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Solid>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Solid_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
