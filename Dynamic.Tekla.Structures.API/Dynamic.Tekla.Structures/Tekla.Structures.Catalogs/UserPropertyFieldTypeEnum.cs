/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public enum UserPropertyFieldTypeEnum
    {
			FIELDTYPE_UNDEFINED,
			FIELDTYPE_NUMBER,
			FIELDTYPE_TEXT,
			FIELDTYPE_DISTANCE,
			FIELDTYPE_PROFILE,
			FIELDTYPE_MATERIAL,
			FIELDTYPE_TEXT_LIST_DISTANCE,
			FIELDTYPE_FILE_IN,
			FIELDTYPE_FILE_OUT,
			FIELDTYPE_BOLT_STANDARD,
			FIELDTYPE_BOLT_SIZE,
			FIELDTYPE_RATIO,
			FIELDTYPE_STRAIN,
			FIELDTYPE_ANGLE,
			FIELDTYPE_DEFORMATION,
			FIELDTYPE_DIMENSION,
			FIELDTYPE_RADIUSOFINERTIA,
			FIELDTYPE_AREA,
			FIELDTYPE_AREAPERLENGTH,
			FIELDTYPE_SECTIONMODULUS,
			FIELDTYPE_MOMENTOFINERTIA,
			FIELDTYPE_TORSIONCONSTANT,
			FIELDTYPE_WARPINGCONSTANT,
			FIELDTYPE_FORCE,
			FIELDTYPE_WEIGHT,
			FIELDTYPE_DISTRIBLOAD,
			FIELDTYPE_SPRINGCONSTANT,
			FIELDTYPE_SURFACELOAD,
			FIELDTYPE_STRENGTH,
			FIELDTYPE_MODULUS,
			FIELDTYPE_DENSITY,
			FIELDTYPE_MOMENT,
			FIELDTYPE_DISTRIBMOMENT,
			FIELDTYPE_ROTSPRINGCONST,
			FIELDTYPE_TEMPERATURE,
			FIELDTYPE_THERMDILATCOEFF,
			FIELDTYPE_ANALYSIS_RESTRAINT,
			FIELDTYPE_VOLUME,
			FIELDTYPE_REBAR_MAIN,
			FIELDTYPE_REBAR_STIRRUP,
			FIELDTYPE_DATE,
			FIELDTYPE_DATE_TIME_SEC,
			FIELDTYPE_DATE_TIME_MIN,
			FIELDTYPE_STUD_STANDARD,
			FIELDTYPE_STUD_SIZE,
			FIELDTYPE_STUD_LENGTH,
			FIELDTYPE_HOLE_TYPE,
			FIELDTYPE_HOLE_DIRECTION,
			FIELDTYPE_WELD_TYPE,
			FIELDTYPE_CHAMFER_TYPE,
			FIELDTYPE_WELDING_SITE,
			FIELDTYPE_FACTOR,
			FIELDTYPE_PART_NAME,
			FIELDTYPE_BOLT_TYPE,
			FIELDTYPE_COMPONENT_NAME,
			FIELDTYPE_REBAR_MESH,
			FIELDTYPE_USERDEFINED,
			FIELDTYPE_YES_NO,
			FIELDTYPE_COMPONENT_STANDARD_FILE,
			FIELDTYPE_REBAR_GRADE,
			FIELDTYPE_REBAR_RADIUS,
			FIELDTYPE_REBAR_SIZE,
			FIELDTYPE_HOOK_SHAPE,
			FIELDTYPE_CROSSBAR_POSITION        
    }

    internal static class UserPropertyFieldTypeEnum_
    {
        public static dynamic GetTSObject(UserPropertyFieldTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.UserPropertyFieldTypeEnum").GetType();

            switch (dynEnum)
            {
				case UserPropertyFieldTypeEnum.FIELDTYPE_UNDEFINED:
					return System.Enum.Parse(tsType, "FIELDTYPE_UNDEFINED");
				case UserPropertyFieldTypeEnum.FIELDTYPE_NUMBER:
					return System.Enum.Parse(tsType, "FIELDTYPE_NUMBER");
				case UserPropertyFieldTypeEnum.FIELDTYPE_TEXT:
					return System.Enum.Parse(tsType, "FIELDTYPE_TEXT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DISTANCE:
					return System.Enum.Parse(tsType, "FIELDTYPE_DISTANCE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_PROFILE:
					return System.Enum.Parse(tsType, "FIELDTYPE_PROFILE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_MATERIAL:
					return System.Enum.Parse(tsType, "FIELDTYPE_MATERIAL");
				case UserPropertyFieldTypeEnum.FIELDTYPE_TEXT_LIST_DISTANCE:
					return System.Enum.Parse(tsType, "FIELDTYPE_TEXT_LIST_DISTANCE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_FILE_IN:
					return System.Enum.Parse(tsType, "FIELDTYPE_FILE_IN");
				case UserPropertyFieldTypeEnum.FIELDTYPE_FILE_OUT:
					return System.Enum.Parse(tsType, "FIELDTYPE_FILE_OUT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_BOLT_STANDARD:
					return System.Enum.Parse(tsType, "FIELDTYPE_BOLT_STANDARD");
				case UserPropertyFieldTypeEnum.FIELDTYPE_BOLT_SIZE:
					return System.Enum.Parse(tsType, "FIELDTYPE_BOLT_SIZE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_RATIO:
					return System.Enum.Parse(tsType, "FIELDTYPE_RATIO");
				case UserPropertyFieldTypeEnum.FIELDTYPE_STRAIN:
					return System.Enum.Parse(tsType, "FIELDTYPE_STRAIN");
				case UserPropertyFieldTypeEnum.FIELDTYPE_ANGLE:
					return System.Enum.Parse(tsType, "FIELDTYPE_ANGLE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DEFORMATION:
					return System.Enum.Parse(tsType, "FIELDTYPE_DEFORMATION");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DIMENSION:
					return System.Enum.Parse(tsType, "FIELDTYPE_DIMENSION");
				case UserPropertyFieldTypeEnum.FIELDTYPE_RADIUSOFINERTIA:
					return System.Enum.Parse(tsType, "FIELDTYPE_RADIUSOFINERTIA");
				case UserPropertyFieldTypeEnum.FIELDTYPE_AREA:
					return System.Enum.Parse(tsType, "FIELDTYPE_AREA");
				case UserPropertyFieldTypeEnum.FIELDTYPE_AREAPERLENGTH:
					return System.Enum.Parse(tsType, "FIELDTYPE_AREAPERLENGTH");
				case UserPropertyFieldTypeEnum.FIELDTYPE_SECTIONMODULUS:
					return System.Enum.Parse(tsType, "FIELDTYPE_SECTIONMODULUS");
				case UserPropertyFieldTypeEnum.FIELDTYPE_MOMENTOFINERTIA:
					return System.Enum.Parse(tsType, "FIELDTYPE_MOMENTOFINERTIA");
				case UserPropertyFieldTypeEnum.FIELDTYPE_TORSIONCONSTANT:
					return System.Enum.Parse(tsType, "FIELDTYPE_TORSIONCONSTANT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_WARPINGCONSTANT:
					return System.Enum.Parse(tsType, "FIELDTYPE_WARPINGCONSTANT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_FORCE:
					return System.Enum.Parse(tsType, "FIELDTYPE_FORCE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_WEIGHT:
					return System.Enum.Parse(tsType, "FIELDTYPE_WEIGHT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DISTRIBLOAD:
					return System.Enum.Parse(tsType, "FIELDTYPE_DISTRIBLOAD");
				case UserPropertyFieldTypeEnum.FIELDTYPE_SPRINGCONSTANT:
					return System.Enum.Parse(tsType, "FIELDTYPE_SPRINGCONSTANT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_SURFACELOAD:
					return System.Enum.Parse(tsType, "FIELDTYPE_SURFACELOAD");
				case UserPropertyFieldTypeEnum.FIELDTYPE_STRENGTH:
					return System.Enum.Parse(tsType, "FIELDTYPE_STRENGTH");
				case UserPropertyFieldTypeEnum.FIELDTYPE_MODULUS:
					return System.Enum.Parse(tsType, "FIELDTYPE_MODULUS");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DENSITY:
					return System.Enum.Parse(tsType, "FIELDTYPE_DENSITY");
				case UserPropertyFieldTypeEnum.FIELDTYPE_MOMENT:
					return System.Enum.Parse(tsType, "FIELDTYPE_MOMENT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DISTRIBMOMENT:
					return System.Enum.Parse(tsType, "FIELDTYPE_DISTRIBMOMENT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_ROTSPRINGCONST:
					return System.Enum.Parse(tsType, "FIELDTYPE_ROTSPRINGCONST");
				case UserPropertyFieldTypeEnum.FIELDTYPE_TEMPERATURE:
					return System.Enum.Parse(tsType, "FIELDTYPE_TEMPERATURE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_THERMDILATCOEFF:
					return System.Enum.Parse(tsType, "FIELDTYPE_THERMDILATCOEFF");
				case UserPropertyFieldTypeEnum.FIELDTYPE_ANALYSIS_RESTRAINT:
					return System.Enum.Parse(tsType, "FIELDTYPE_ANALYSIS_RESTRAINT");
				case UserPropertyFieldTypeEnum.FIELDTYPE_VOLUME:
					return System.Enum.Parse(tsType, "FIELDTYPE_VOLUME");
				case UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_MAIN:
					return System.Enum.Parse(tsType, "FIELDTYPE_REBAR_MAIN");
				case UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_STIRRUP:
					return System.Enum.Parse(tsType, "FIELDTYPE_REBAR_STIRRUP");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DATE:
					return System.Enum.Parse(tsType, "FIELDTYPE_DATE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DATE_TIME_SEC:
					return System.Enum.Parse(tsType, "FIELDTYPE_DATE_TIME_SEC");
				case UserPropertyFieldTypeEnum.FIELDTYPE_DATE_TIME_MIN:
					return System.Enum.Parse(tsType, "FIELDTYPE_DATE_TIME_MIN");
				case UserPropertyFieldTypeEnum.FIELDTYPE_STUD_STANDARD:
					return System.Enum.Parse(tsType, "FIELDTYPE_STUD_STANDARD");
				case UserPropertyFieldTypeEnum.FIELDTYPE_STUD_SIZE:
					return System.Enum.Parse(tsType, "FIELDTYPE_STUD_SIZE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_STUD_LENGTH:
					return System.Enum.Parse(tsType, "FIELDTYPE_STUD_LENGTH");
				case UserPropertyFieldTypeEnum.FIELDTYPE_HOLE_TYPE:
					return System.Enum.Parse(tsType, "FIELDTYPE_HOLE_TYPE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_HOLE_DIRECTION:
					return System.Enum.Parse(tsType, "FIELDTYPE_HOLE_DIRECTION");
				case UserPropertyFieldTypeEnum.FIELDTYPE_WELD_TYPE:
					return System.Enum.Parse(tsType, "FIELDTYPE_WELD_TYPE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_CHAMFER_TYPE:
					return System.Enum.Parse(tsType, "FIELDTYPE_CHAMFER_TYPE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_WELDING_SITE:
					return System.Enum.Parse(tsType, "FIELDTYPE_WELDING_SITE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_FACTOR:
					return System.Enum.Parse(tsType, "FIELDTYPE_FACTOR");
				case UserPropertyFieldTypeEnum.FIELDTYPE_PART_NAME:
					return System.Enum.Parse(tsType, "FIELDTYPE_PART_NAME");
				case UserPropertyFieldTypeEnum.FIELDTYPE_BOLT_TYPE:
					return System.Enum.Parse(tsType, "FIELDTYPE_BOLT_TYPE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_COMPONENT_NAME:
					return System.Enum.Parse(tsType, "FIELDTYPE_COMPONENT_NAME");
				case UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_MESH:
					return System.Enum.Parse(tsType, "FIELDTYPE_REBAR_MESH");
				case UserPropertyFieldTypeEnum.FIELDTYPE_USERDEFINED:
					return System.Enum.Parse(tsType, "FIELDTYPE_USERDEFINED");
				case UserPropertyFieldTypeEnum.FIELDTYPE_YES_NO:
					return System.Enum.Parse(tsType, "FIELDTYPE_YES_NO");
				case UserPropertyFieldTypeEnum.FIELDTYPE_COMPONENT_STANDARD_FILE:
					return System.Enum.Parse(tsType, "FIELDTYPE_COMPONENT_STANDARD_FILE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_GRADE:
					return System.Enum.Parse(tsType, "FIELDTYPE_REBAR_GRADE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_RADIUS:
					return System.Enum.Parse(tsType, "FIELDTYPE_REBAR_RADIUS");
				case UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_SIZE:
					return System.Enum.Parse(tsType, "FIELDTYPE_REBAR_SIZE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_HOOK_SHAPE:
					return System.Enum.Parse(tsType, "FIELDTYPE_HOOK_SHAPE");
				case UserPropertyFieldTypeEnum.FIELDTYPE_CROSSBAR_POSITION:
					return System.Enum.Parse(tsType, "FIELDTYPE_CROSSBAR_POSITION");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static UserPropertyFieldTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("FIELDTYPE_UNDEFINED", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_UNDEFINED;
			else if (tsEnumValue.Equals("FIELDTYPE_NUMBER", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_NUMBER;
			else if (tsEnumValue.Equals("FIELDTYPE_TEXT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_TEXT;
			else if (tsEnumValue.Equals("FIELDTYPE_DISTANCE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DISTANCE;
			else if (tsEnumValue.Equals("FIELDTYPE_PROFILE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_PROFILE;
			else if (tsEnumValue.Equals("FIELDTYPE_MATERIAL", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_MATERIAL;
			else if (tsEnumValue.Equals("FIELDTYPE_TEXT_LIST_DISTANCE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_TEXT_LIST_DISTANCE;
			else if (tsEnumValue.Equals("FIELDTYPE_FILE_IN", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_FILE_IN;
			else if (tsEnumValue.Equals("FIELDTYPE_FILE_OUT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_FILE_OUT;
			else if (tsEnumValue.Equals("FIELDTYPE_BOLT_STANDARD", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_BOLT_STANDARD;
			else if (tsEnumValue.Equals("FIELDTYPE_BOLT_SIZE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_BOLT_SIZE;
			else if (tsEnumValue.Equals("FIELDTYPE_RATIO", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_RATIO;
			else if (tsEnumValue.Equals("FIELDTYPE_STRAIN", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_STRAIN;
			else if (tsEnumValue.Equals("FIELDTYPE_ANGLE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_ANGLE;
			else if (tsEnumValue.Equals("FIELDTYPE_DEFORMATION", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DEFORMATION;
			else if (tsEnumValue.Equals("FIELDTYPE_DIMENSION", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DIMENSION;
			else if (tsEnumValue.Equals("FIELDTYPE_RADIUSOFINERTIA", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_RADIUSOFINERTIA;
			else if (tsEnumValue.Equals("FIELDTYPE_AREA", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_AREA;
			else if (tsEnumValue.Equals("FIELDTYPE_AREAPERLENGTH", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_AREAPERLENGTH;
			else if (tsEnumValue.Equals("FIELDTYPE_SECTIONMODULUS", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_SECTIONMODULUS;
			else if (tsEnumValue.Equals("FIELDTYPE_MOMENTOFINERTIA", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_MOMENTOFINERTIA;
			else if (tsEnumValue.Equals("FIELDTYPE_TORSIONCONSTANT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_TORSIONCONSTANT;
			else if (tsEnumValue.Equals("FIELDTYPE_WARPINGCONSTANT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_WARPINGCONSTANT;
			else if (tsEnumValue.Equals("FIELDTYPE_FORCE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_FORCE;
			else if (tsEnumValue.Equals("FIELDTYPE_WEIGHT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_WEIGHT;
			else if (tsEnumValue.Equals("FIELDTYPE_DISTRIBLOAD", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DISTRIBLOAD;
			else if (tsEnumValue.Equals("FIELDTYPE_SPRINGCONSTANT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_SPRINGCONSTANT;
			else if (tsEnumValue.Equals("FIELDTYPE_SURFACELOAD", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_SURFACELOAD;
			else if (tsEnumValue.Equals("FIELDTYPE_STRENGTH", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_STRENGTH;
			else if (tsEnumValue.Equals("FIELDTYPE_MODULUS", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_MODULUS;
			else if (tsEnumValue.Equals("FIELDTYPE_DENSITY", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DENSITY;
			else if (tsEnumValue.Equals("FIELDTYPE_MOMENT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_MOMENT;
			else if (tsEnumValue.Equals("FIELDTYPE_DISTRIBMOMENT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DISTRIBMOMENT;
			else if (tsEnumValue.Equals("FIELDTYPE_ROTSPRINGCONST", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_ROTSPRINGCONST;
			else if (tsEnumValue.Equals("FIELDTYPE_TEMPERATURE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_TEMPERATURE;
			else if (tsEnumValue.Equals("FIELDTYPE_THERMDILATCOEFF", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_THERMDILATCOEFF;
			else if (tsEnumValue.Equals("FIELDTYPE_ANALYSIS_RESTRAINT", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_ANALYSIS_RESTRAINT;
			else if (tsEnumValue.Equals("FIELDTYPE_VOLUME", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_VOLUME;
			else if (tsEnumValue.Equals("FIELDTYPE_REBAR_MAIN", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_MAIN;
			else if (tsEnumValue.Equals("FIELDTYPE_REBAR_STIRRUP", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_STIRRUP;
			else if (tsEnumValue.Equals("FIELDTYPE_DATE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DATE;
			else if (tsEnumValue.Equals("FIELDTYPE_DATE_TIME_SEC", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DATE_TIME_SEC;
			else if (tsEnumValue.Equals("FIELDTYPE_DATE_TIME_MIN", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_DATE_TIME_MIN;
			else if (tsEnumValue.Equals("FIELDTYPE_STUD_STANDARD", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_STUD_STANDARD;
			else if (tsEnumValue.Equals("FIELDTYPE_STUD_SIZE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_STUD_SIZE;
			else if (tsEnumValue.Equals("FIELDTYPE_STUD_LENGTH", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_STUD_LENGTH;
			else if (tsEnumValue.Equals("FIELDTYPE_HOLE_TYPE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_HOLE_TYPE;
			else if (tsEnumValue.Equals("FIELDTYPE_HOLE_DIRECTION", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_HOLE_DIRECTION;
			else if (tsEnumValue.Equals("FIELDTYPE_WELD_TYPE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_WELD_TYPE;
			else if (tsEnumValue.Equals("FIELDTYPE_CHAMFER_TYPE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_CHAMFER_TYPE;
			else if (tsEnumValue.Equals("FIELDTYPE_WELDING_SITE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_WELDING_SITE;
			else if (tsEnumValue.Equals("FIELDTYPE_FACTOR", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_FACTOR;
			else if (tsEnumValue.Equals("FIELDTYPE_PART_NAME", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_PART_NAME;
			else if (tsEnumValue.Equals("FIELDTYPE_BOLT_TYPE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_BOLT_TYPE;
			else if (tsEnumValue.Equals("FIELDTYPE_COMPONENT_NAME", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_COMPONENT_NAME;
			else if (tsEnumValue.Equals("FIELDTYPE_REBAR_MESH", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_MESH;
			else if (tsEnumValue.Equals("FIELDTYPE_USERDEFINED", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_USERDEFINED;
			else if (tsEnumValue.Equals("FIELDTYPE_YES_NO", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_YES_NO;
			else if (tsEnumValue.Equals("FIELDTYPE_COMPONENT_STANDARD_FILE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_COMPONENT_STANDARD_FILE;
			else if (tsEnumValue.Equals("FIELDTYPE_REBAR_GRADE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_GRADE;
			else if (tsEnumValue.Equals("FIELDTYPE_REBAR_RADIUS", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_RADIUS;
			else if (tsEnumValue.Equals("FIELDTYPE_REBAR_SIZE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_REBAR_SIZE;
			else if (tsEnumValue.Equals("FIELDTYPE_HOOK_SHAPE", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_HOOK_SHAPE;
			else if (tsEnumValue.Equals("FIELDTYPE_CROSSBAR_POSITION", System.StringComparison.InvariantCulture))
				return UserPropertyFieldTypeEnum.FIELDTYPE_CROSSBAR_POSITION;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
