/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class SurfaceTreatment  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.SurfaceTreatment.SurfaceTypeEnum Type
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.SurfaceTreatment.SurfaceTypeEnum_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Model.SurfaceTreatment.SurfaceTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.SurfaceTreatment.SurfaceColorEnum Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.SurfaceTreatment.SurfaceColorEnum_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Model.SurfaceTreatment.SurfaceColorEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
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

		public Dynamic.Tekla.Structures.Model.Contour Polygon
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Polygon);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon"); }
			}
			set
			{
				try {
				teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
			set
			{
				try {
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Part Father
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.Father);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
			set
			{
				try {
				teklaObject.Father = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
		}

		public System.Double Thickness
		{
			get
			{
				try {
					return teklaObject.Thickness;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Thickness"); }
			}
			set
			{
				try {
					teklaObject.Thickness = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Thickness"); }
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

		public System.Boolean CutByFatherBooleans
		{
			get
			{
				try {
					return teklaObject.CutByFatherBooleans;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutByFatherBooleans"); }
			}
			set
			{
				try {
					teklaObject.CutByFatherBooleans = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutByFatherBooleans"); }
			}
		}

		public System.String TypeName
		{
			get
			{
				try {
					return teklaObject.TypeName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TypeName"); }
			}
			set
			{
				try {
					teklaObject.TypeName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TypeName"); }
			}
		}

        

        

		public SurfaceTreatment()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceTreatment");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SurfaceTreatment(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum SurfaceTypeEnum
    {
			CONCRETE_FINISH,
			SPECIAL_MIX,
			TILE_SURFACE,
			STEEL_FINISH        
    }

    internal static class SurfaceTypeEnum_
    {
        public static dynamic GetTSObject(SurfaceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceTreatment.SurfaceTypeEnum").GetType();

            switch (dynEnum)
            {
				case SurfaceTypeEnum.CONCRETE_FINISH:
					return System.Enum.Parse(tsType, "CONCRETE_FINISH");
				case SurfaceTypeEnum.SPECIAL_MIX:
					return System.Enum.Parse(tsType, "SPECIAL_MIX");
				case SurfaceTypeEnum.TILE_SURFACE:
					return System.Enum.Parse(tsType, "TILE_SURFACE");
				case SurfaceTypeEnum.STEEL_FINISH:
					return System.Enum.Parse(tsType, "STEEL_FINISH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SurfaceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CONCRETE_FINISH", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.CONCRETE_FINISH;
			else if (tsEnumValue.Equals("SPECIAL_MIX", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.SPECIAL_MIX;
			else if (tsEnumValue.Equals("TILE_SURFACE", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.TILE_SURFACE;
			else if (tsEnumValue.Equals("STEEL_FINISH", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.STEEL_FINISH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum SurfaceColorEnum
    {
			WHITE,
			RED,
			GREEN,
			BLUE,
			CYAN,
			YELLOW,
			MAGENTA        
    }

    internal static class SurfaceColorEnum_
    {
        public static dynamic GetTSObject(SurfaceColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceTreatment.SurfaceColorEnum").GetType();

            switch (dynEnum)
            {
				case SurfaceColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case SurfaceColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case SurfaceColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case SurfaceColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case SurfaceColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case SurfaceColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case SurfaceColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SurfaceColorEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.MAGENTA;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class SurfaceTreatment_
    {
        public static dynamic GetTSObject(SurfaceTreatment dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SurfaceTreatment FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.SurfaceTreatment)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfaceTreatmentArray_
    {
        public static dynamic GetTSObject(SurfaceTreatment[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SurfaceTreatment_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SurfaceTreatment[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SurfaceTreatment>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SurfaceTreatment_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
