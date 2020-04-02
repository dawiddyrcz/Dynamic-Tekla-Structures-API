/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public abstract class ProfileItem 
    {

		public Dynamic.Tekla.Structures.Catalogs.ProfileItem.ProfileItemTypeEnum ProfileItemType
		{
			get => Dynamic.Tekla.Structures.Catalogs.ProfileItem.ProfileItemTypeEnum_.FromTSObject(teklaObject.ProfileItemType);

		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItem.ProfileItemSubTypeEnum ProfileItemSubType
		{
			get => Dynamic.Tekla.Structures.Catalogs.ProfileItem.ProfileItemSubTypeEnum_.FromTSObject(teklaObject.ProfileItemSubType);
			set { teklaObject.ProfileItemSubType = Dynamic.Tekla.Structures.Catalogs.ProfileItem.ProfileItemSubTypeEnum_.GetTSObject(value); }
		}

		public System.Collections.ArrayList aProfileItemParameters
		{
			get => teklaObject.aProfileItemParameters;

		}

		public System.String ParameterString
		{
			get => teklaObject.ParameterString;

		}

		public System.Int32 NumberOfCrossSections
		{
			get => teklaObject.NumberOfCrossSections;

		}

		public System.Boolean IsSketchedUserParametric
		{
			get => teklaObject.IsSketchedUserParametric;

		}

		public System.Boolean IsMultiCrossSectionUserParametric
		{
			get => teklaObject.IsMultiCrossSectionUserParametric;

		}

        

        internal dynamic teklaObject;


		public System.Boolean IsProfileUserParametric()
		{
			return teklaObject.IsProfileUserParametric();
		}

		public System.Boolean IsProfileUserDefined()
		{
			return teklaObject.IsProfileUserDefined();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean ModifyProfileItemParameter(Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter value)
		{
			return teklaObject.ModifyProfileItemParameter(Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter_.GetTSObject(value));
		}

		public System.Boolean ModifyProfileItemAnalysisParameter(Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter value)
		{
			return teklaObject.ModifyProfileItemAnalysisParameter(Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter_.GetTSObject(value));
		}

		public System.Boolean ModifyProfileItemUserParameter(Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter value)
		{
			return teklaObject.ModifyProfileItemUserParameter(Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter_.GetTSObject(value));
		}

		public System.Boolean Export(ref System.String filename)
		{
			return teklaObject.Export(ref filename);
		}

		public Dynamic.Tekla.Structures.Catalogs.CrossSection GetCrossSection(System.Double RelativeLocation)
		{
			return Dynamic.Tekla.Structures.Catalogs.CrossSection_.FromTSObject(teklaObject.GetCrossSection(RelativeLocation));
		}




    public enum ProfileItemTypeEnum
    {
			PROFILE_UNKNOWN,
			PROFILE_I,
			PROFILE_FPL,
			PROFILE_Z,
			PROFILE_U,
			PROFILE_PL,
			PROFILE_D,
			PROFILE_PD,
			PROFILE_P,
			PROFILE_C,
			PROFILE_T,
			PROFILE_HK,
			PROFILE_HQ,
			PROFILE_ZZ,
			PROFILE_CC,
			PROFILE_CW,
			PROFILE_CU,
			PROFILE_EB,
			PROFILE_BF,
			PROFILE_SPD,
			PROFILE_EC,
			PROFILE_ED,
			PROFILE_EE,
			PROFILE_EF,
			PROFILE_EZ,
			PROFILE_EW,
			PROFILE_POLYGON_PLATE,
			PROFILE_SP,
			PROFILE_RCDL,
			PROFILE_RCXX,
			PROFILE_RCL,
			PROFILE_RCDX,
			PROFILE_RCX,
			PROFILE_USER_DEFINED,
			PROFILE_USER_PARAMETRIC,
			ALL_PROFILES        
    }

    internal static class ProfileItemTypeEnum_
    {
        public static dynamic GetTSObject(ProfileItemTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ProfileItem.ProfileItemTypeEnum").GetType();

            switch (dynEnum)
            {
				case ProfileItemTypeEnum.PROFILE_UNKNOWN:
					return System.Enum.Parse(tsType, "PROFILE_UNKNOWN");
				case ProfileItemTypeEnum.PROFILE_I:
					return System.Enum.Parse(tsType, "PROFILE_I");
				case ProfileItemTypeEnum.PROFILE_FPL:
					return System.Enum.Parse(tsType, "PROFILE_FPL");
				case ProfileItemTypeEnum.PROFILE_Z:
					return System.Enum.Parse(tsType, "PROFILE_Z");
				case ProfileItemTypeEnum.PROFILE_U:
					return System.Enum.Parse(tsType, "PROFILE_U");
				case ProfileItemTypeEnum.PROFILE_PL:
					return System.Enum.Parse(tsType, "PROFILE_PL");
				case ProfileItemTypeEnum.PROFILE_D:
					return System.Enum.Parse(tsType, "PROFILE_D");
				case ProfileItemTypeEnum.PROFILE_PD:
					return System.Enum.Parse(tsType, "PROFILE_PD");
				case ProfileItemTypeEnum.PROFILE_P:
					return System.Enum.Parse(tsType, "PROFILE_P");
				case ProfileItemTypeEnum.PROFILE_C:
					return System.Enum.Parse(tsType, "PROFILE_C");
				case ProfileItemTypeEnum.PROFILE_T:
					return System.Enum.Parse(tsType, "PROFILE_T");
				case ProfileItemTypeEnum.PROFILE_HK:
					return System.Enum.Parse(tsType, "PROFILE_HK");
				case ProfileItemTypeEnum.PROFILE_HQ:
					return System.Enum.Parse(tsType, "PROFILE_HQ");
				case ProfileItemTypeEnum.PROFILE_ZZ:
					return System.Enum.Parse(tsType, "PROFILE_ZZ");
				case ProfileItemTypeEnum.PROFILE_CC:
					return System.Enum.Parse(tsType, "PROFILE_CC");
				case ProfileItemTypeEnum.PROFILE_CW:
					return System.Enum.Parse(tsType, "PROFILE_CW");
				case ProfileItemTypeEnum.PROFILE_CU:
					return System.Enum.Parse(tsType, "PROFILE_CU");
				case ProfileItemTypeEnum.PROFILE_EB:
					return System.Enum.Parse(tsType, "PROFILE_EB");
				case ProfileItemTypeEnum.PROFILE_BF:
					return System.Enum.Parse(tsType, "PROFILE_BF");
				case ProfileItemTypeEnum.PROFILE_SPD:
					return System.Enum.Parse(tsType, "PROFILE_SPD");
				case ProfileItemTypeEnum.PROFILE_EC:
					return System.Enum.Parse(tsType, "PROFILE_EC");
				case ProfileItemTypeEnum.PROFILE_ED:
					return System.Enum.Parse(tsType, "PROFILE_ED");
				case ProfileItemTypeEnum.PROFILE_EE:
					return System.Enum.Parse(tsType, "PROFILE_EE");
				case ProfileItemTypeEnum.PROFILE_EF:
					return System.Enum.Parse(tsType, "PROFILE_EF");
				case ProfileItemTypeEnum.PROFILE_EZ:
					return System.Enum.Parse(tsType, "PROFILE_EZ");
				case ProfileItemTypeEnum.PROFILE_EW:
					return System.Enum.Parse(tsType, "PROFILE_EW");
				case ProfileItemTypeEnum.PROFILE_POLYGON_PLATE:
					return System.Enum.Parse(tsType, "PROFILE_POLYGON_PLATE");
				case ProfileItemTypeEnum.PROFILE_SP:
					return System.Enum.Parse(tsType, "PROFILE_SP");
				case ProfileItemTypeEnum.PROFILE_RCDL:
					return System.Enum.Parse(tsType, "PROFILE_RCDL");
				case ProfileItemTypeEnum.PROFILE_RCXX:
					return System.Enum.Parse(tsType, "PROFILE_RCXX");
				case ProfileItemTypeEnum.PROFILE_RCL:
					return System.Enum.Parse(tsType, "PROFILE_RCL");
				case ProfileItemTypeEnum.PROFILE_RCDX:
					return System.Enum.Parse(tsType, "PROFILE_RCDX");
				case ProfileItemTypeEnum.PROFILE_RCX:
					return System.Enum.Parse(tsType, "PROFILE_RCX");
				case ProfileItemTypeEnum.PROFILE_USER_DEFINED:
					return System.Enum.Parse(tsType, "PROFILE_USER_DEFINED");
				case ProfileItemTypeEnum.PROFILE_USER_PARAMETRIC:
					return System.Enum.Parse(tsType, "PROFILE_USER_PARAMETRIC");
				case ProfileItemTypeEnum.ALL_PROFILES:
					return System.Enum.Parse(tsType, "ALL_PROFILES");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ProfileItemTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PROFILE_UNKNOWN", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_UNKNOWN;
			else if (tsEnumValue.Equals("PROFILE_I", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_I;
			else if (tsEnumValue.Equals("PROFILE_FPL", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_FPL;
			else if (tsEnumValue.Equals("PROFILE_Z", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_Z;
			else if (tsEnumValue.Equals("PROFILE_U", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_U;
			else if (tsEnumValue.Equals("PROFILE_PL", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_PL;
			else if (tsEnumValue.Equals("PROFILE_D", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_D;
			else if (tsEnumValue.Equals("PROFILE_PD", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_PD;
			else if (tsEnumValue.Equals("PROFILE_P", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_P;
			else if (tsEnumValue.Equals("PROFILE_C", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_C;
			else if (tsEnumValue.Equals("PROFILE_T", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_T;
			else if (tsEnumValue.Equals("PROFILE_HK", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_HK;
			else if (tsEnumValue.Equals("PROFILE_HQ", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_HQ;
			else if (tsEnumValue.Equals("PROFILE_ZZ", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_ZZ;
			else if (tsEnumValue.Equals("PROFILE_CC", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_CC;
			else if (tsEnumValue.Equals("PROFILE_CW", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_CW;
			else if (tsEnumValue.Equals("PROFILE_CU", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_CU;
			else if (tsEnumValue.Equals("PROFILE_EB", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_EB;
			else if (tsEnumValue.Equals("PROFILE_BF", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_BF;
			else if (tsEnumValue.Equals("PROFILE_SPD", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_SPD;
			else if (tsEnumValue.Equals("PROFILE_EC", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_EC;
			else if (tsEnumValue.Equals("PROFILE_ED", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_ED;
			else if (tsEnumValue.Equals("PROFILE_EE", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_EE;
			else if (tsEnumValue.Equals("PROFILE_EF", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_EF;
			else if (tsEnumValue.Equals("PROFILE_EZ", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_EZ;
			else if (tsEnumValue.Equals("PROFILE_EW", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_EW;
			else if (tsEnumValue.Equals("PROFILE_POLYGON_PLATE", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_POLYGON_PLATE;
			else if (tsEnumValue.Equals("PROFILE_SP", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_SP;
			else if (tsEnumValue.Equals("PROFILE_RCDL", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_RCDL;
			else if (tsEnumValue.Equals("PROFILE_RCXX", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_RCXX;
			else if (tsEnumValue.Equals("PROFILE_RCL", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_RCL;
			else if (tsEnumValue.Equals("PROFILE_RCDX", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_RCDX;
			else if (tsEnumValue.Equals("PROFILE_RCX", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_RCX;
			else if (tsEnumValue.Equals("PROFILE_USER_DEFINED", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_USER_DEFINED;
			else if (tsEnumValue.Equals("PROFILE_USER_PARAMETRIC", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.PROFILE_USER_PARAMETRIC;
			else if (tsEnumValue.Equals("ALL_PROFILES", System.StringComparison.InvariantCulture))
				return ProfileItemTypeEnum.ALL_PROFILES;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ProfileItemSubTypeEnum
    {
			PROFILE_UNKNOWN_SUBTYPE,
			PROFILE_I_HOT_ROLLED,
			PROFILE_I_WELDED_SYMMETRICAL,
			PROFILE_I_WELDED_UNSYMMETRICAL,
			PROFILE_I_WELDED_SYMMETRICAL2,
			PROFILE_I_WELDED_UNSYMMETRICAL2,
			PROFILE_L_HOT_ROLLED,
			PROFILE_L_COLD_ROLLED,
			PROFILE_Z_COLD_ROLLED,
			PROFILE_U_HOT_ROLLED,
			PROFILE_U_COLD_ROLLED,
			PROFILE_PL_DEFAULT,
			PROFILE_D_CIRCULAR,
			PROFILE_D_ELLIPTICAL,
			PROFILE_PD_CIRCULAR,
			PROFILE_PD_ELLIPTICAL,
			PROFILE_PD_CIRCULAR_TAPERED,
			PROFILE_P_SQUARE,
			PROFILE_P_RECTANGULAR,
			PROFILE_P_ALTERING_HEIGHT,
			PROFILE_C_HOT_ROLLED,
			PROFILE_C_COLD_ROLLED,
			PROFILE_T_HOT_ROLLED,
			PROFILE_T_PARAMETRIC,
			PROFILE_HK_SYMMETRICAL,
			PROFILE_HK_UNSYMMETRICAL,
			PROFILE_HQ_CENTERED,
			PROFILE_HQ_NOT_CENTERED,
			PROFILE_ZZ_SYMMETRICAL,
			PROFILE_ZZ_NOT_SYMMETRICAL,
			PROFILE_CC_SYMMETRICAL,
			PROFILE_CC_NOT_SYMMETRICAL,
			PROFILE_CW_SYMMETRICAL,
			PROFILE_CW_UNSYMMETRICAL,
			PROFILE_CU_SYMMETRICAL,
			PROFILE_CU_NOT_SYMMETRICAL,
			PROFILE_EB_SYMMETRICAL,
			PROFILE_EB_NOT_SYMMETRICAL,
			PROFILE_BF_DEFAULT,
			PROFILE_SPD_CIRCULAR,
			PROFILE_SPD_ELLIPTICAL,
			PROFILE_SPD_CIRCULAR_TAPERED,
			PROFILE_EC_SYMMETRICAL,
			PROFILE_EC_NOT_SYMMETRICAL,
			PROFILE_ED_DEFAULT,
			PROFILE_EE_DEFAULT,
			PROFILE_EF_DEFAULT,
			PROFILE_EZ_DEFAULT,
			PROFILE_EW_DEFAULT,
			PROFILE_RCDL_SYMMETRICAL,
			PROFILE_RCDL_UNSYMMETRICAL,
			PROFILE_RCXX_DEFAULT,
			PROFILE_RCL_DEFAULT,
			PROFILE_RCDX_SYMMETRICAL,
			PROFILE_RCDX_UNSYMMETRICAL,
			PROFILE_RCDX_UNSYMMETRICAL2,
			PROFILE_RCX_DEFAULT        
    }

    internal static class ProfileItemSubTypeEnum_
    {
        public static dynamic GetTSObject(ProfileItemSubTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ProfileItem.ProfileItemSubTypeEnum").GetType();

            switch (dynEnum)
            {
				case ProfileItemSubTypeEnum.PROFILE_UNKNOWN_SUBTYPE:
					return System.Enum.Parse(tsType, "PROFILE_UNKNOWN_SUBTYPE");
				case ProfileItemSubTypeEnum.PROFILE_I_HOT_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_I_HOT_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_I_WELDED_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_I_WELDED_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_I_WELDED_UNSYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_I_WELDED_UNSYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_I_WELDED_SYMMETRICAL2:
					return System.Enum.Parse(tsType, "PROFILE_I_WELDED_SYMMETRICAL2");
				case ProfileItemSubTypeEnum.PROFILE_I_WELDED_UNSYMMETRICAL2:
					return System.Enum.Parse(tsType, "PROFILE_I_WELDED_UNSYMMETRICAL2");
				case ProfileItemSubTypeEnum.PROFILE_L_HOT_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_L_HOT_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_L_COLD_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_L_COLD_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_Z_COLD_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_Z_COLD_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_U_HOT_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_U_HOT_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_U_COLD_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_U_COLD_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_PL_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_PL_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_D_CIRCULAR:
					return System.Enum.Parse(tsType, "PROFILE_D_CIRCULAR");
				case ProfileItemSubTypeEnum.PROFILE_D_ELLIPTICAL:
					return System.Enum.Parse(tsType, "PROFILE_D_ELLIPTICAL");
				case ProfileItemSubTypeEnum.PROFILE_PD_CIRCULAR:
					return System.Enum.Parse(tsType, "PROFILE_PD_CIRCULAR");
				case ProfileItemSubTypeEnum.PROFILE_PD_ELLIPTICAL:
					return System.Enum.Parse(tsType, "PROFILE_PD_ELLIPTICAL");
				case ProfileItemSubTypeEnum.PROFILE_PD_CIRCULAR_TAPERED:
					return System.Enum.Parse(tsType, "PROFILE_PD_CIRCULAR_TAPERED");
				case ProfileItemSubTypeEnum.PROFILE_P_SQUARE:
					return System.Enum.Parse(tsType, "PROFILE_P_SQUARE");
				case ProfileItemSubTypeEnum.PROFILE_P_RECTANGULAR:
					return System.Enum.Parse(tsType, "PROFILE_P_RECTANGULAR");
				case ProfileItemSubTypeEnum.PROFILE_P_ALTERING_HEIGHT:
					return System.Enum.Parse(tsType, "PROFILE_P_ALTERING_HEIGHT");
				case ProfileItemSubTypeEnum.PROFILE_C_HOT_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_C_HOT_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_C_COLD_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_C_COLD_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_T_HOT_ROLLED:
					return System.Enum.Parse(tsType, "PROFILE_T_HOT_ROLLED");
				case ProfileItemSubTypeEnum.PROFILE_T_PARAMETRIC:
					return System.Enum.Parse(tsType, "PROFILE_T_PARAMETRIC");
				case ProfileItemSubTypeEnum.PROFILE_HK_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_HK_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_HK_UNSYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_HK_UNSYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_HQ_CENTERED:
					return System.Enum.Parse(tsType, "PROFILE_HQ_CENTERED");
				case ProfileItemSubTypeEnum.PROFILE_HQ_NOT_CENTERED:
					return System.Enum.Parse(tsType, "PROFILE_HQ_NOT_CENTERED");
				case ProfileItemSubTypeEnum.PROFILE_ZZ_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_ZZ_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_ZZ_NOT_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_ZZ_NOT_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_CC_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_CC_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_CC_NOT_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_CC_NOT_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_CW_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_CW_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_CW_UNSYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_CW_UNSYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_CU_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_CU_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_CU_NOT_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_CU_NOT_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_EB_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_EB_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_EB_NOT_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_EB_NOT_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_BF_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_BF_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_SPD_CIRCULAR:
					return System.Enum.Parse(tsType, "PROFILE_SPD_CIRCULAR");
				case ProfileItemSubTypeEnum.PROFILE_SPD_ELLIPTICAL:
					return System.Enum.Parse(tsType, "PROFILE_SPD_ELLIPTICAL");
				case ProfileItemSubTypeEnum.PROFILE_SPD_CIRCULAR_TAPERED:
					return System.Enum.Parse(tsType, "PROFILE_SPD_CIRCULAR_TAPERED");
				case ProfileItemSubTypeEnum.PROFILE_EC_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_EC_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_EC_NOT_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_EC_NOT_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_ED_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_ED_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_EE_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_EE_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_EF_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_EF_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_EZ_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_EZ_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_EW_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_EW_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_RCDL_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_RCDL_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_RCDL_UNSYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_RCDL_UNSYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_RCXX_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_RCXX_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_RCL_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_RCL_DEFAULT");
				case ProfileItemSubTypeEnum.PROFILE_RCDX_SYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_RCDX_SYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_RCDX_UNSYMMETRICAL:
					return System.Enum.Parse(tsType, "PROFILE_RCDX_UNSYMMETRICAL");
				case ProfileItemSubTypeEnum.PROFILE_RCDX_UNSYMMETRICAL2:
					return System.Enum.Parse(tsType, "PROFILE_RCDX_UNSYMMETRICAL2");
				case ProfileItemSubTypeEnum.PROFILE_RCX_DEFAULT:
					return System.Enum.Parse(tsType, "PROFILE_RCX_DEFAULT");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ProfileItemSubTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PROFILE_UNKNOWN_SUBTYPE", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_UNKNOWN_SUBTYPE;
			else if (tsEnumValue.Equals("PROFILE_I_HOT_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_I_HOT_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_I_WELDED_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_I_WELDED_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_I_WELDED_UNSYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_I_WELDED_UNSYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_I_WELDED_SYMMETRICAL2", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_I_WELDED_SYMMETRICAL2;
			else if (tsEnumValue.Equals("PROFILE_I_WELDED_UNSYMMETRICAL2", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_I_WELDED_UNSYMMETRICAL2;
			else if (tsEnumValue.Equals("PROFILE_L_HOT_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_L_HOT_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_L_COLD_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_L_COLD_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_Z_COLD_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_Z_COLD_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_U_HOT_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_U_HOT_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_U_COLD_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_U_COLD_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_PL_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_PL_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_D_CIRCULAR", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_D_CIRCULAR;
			else if (tsEnumValue.Equals("PROFILE_D_ELLIPTICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_D_ELLIPTICAL;
			else if (tsEnumValue.Equals("PROFILE_PD_CIRCULAR", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_PD_CIRCULAR;
			else if (tsEnumValue.Equals("PROFILE_PD_ELLIPTICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_PD_ELLIPTICAL;
			else if (tsEnumValue.Equals("PROFILE_PD_CIRCULAR_TAPERED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_PD_CIRCULAR_TAPERED;
			else if (tsEnumValue.Equals("PROFILE_P_SQUARE", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_P_SQUARE;
			else if (tsEnumValue.Equals("PROFILE_P_RECTANGULAR", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_P_RECTANGULAR;
			else if (tsEnumValue.Equals("PROFILE_P_ALTERING_HEIGHT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_P_ALTERING_HEIGHT;
			else if (tsEnumValue.Equals("PROFILE_C_HOT_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_C_HOT_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_C_COLD_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_C_COLD_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_T_HOT_ROLLED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_T_HOT_ROLLED;
			else if (tsEnumValue.Equals("PROFILE_T_PARAMETRIC", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_T_PARAMETRIC;
			else if (tsEnumValue.Equals("PROFILE_HK_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_HK_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_HK_UNSYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_HK_UNSYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_HQ_CENTERED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_HQ_CENTERED;
			else if (tsEnumValue.Equals("PROFILE_HQ_NOT_CENTERED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_HQ_NOT_CENTERED;
			else if (tsEnumValue.Equals("PROFILE_ZZ_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_ZZ_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_ZZ_NOT_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_ZZ_NOT_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_CC_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_CC_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_CC_NOT_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_CC_NOT_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_CW_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_CW_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_CW_UNSYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_CW_UNSYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_CU_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_CU_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_CU_NOT_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_CU_NOT_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_EB_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EB_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_EB_NOT_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EB_NOT_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_BF_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_BF_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_SPD_CIRCULAR", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_SPD_CIRCULAR;
			else if (tsEnumValue.Equals("PROFILE_SPD_ELLIPTICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_SPD_ELLIPTICAL;
			else if (tsEnumValue.Equals("PROFILE_SPD_CIRCULAR_TAPERED", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_SPD_CIRCULAR_TAPERED;
			else if (tsEnumValue.Equals("PROFILE_EC_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EC_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_EC_NOT_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EC_NOT_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_ED_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_ED_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_EE_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EE_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_EF_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EF_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_EZ_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EZ_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_EW_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_EW_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_RCDL_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCDL_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_RCDL_UNSYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCDL_UNSYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_RCXX_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCXX_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_RCL_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCL_DEFAULT;
			else if (tsEnumValue.Equals("PROFILE_RCDX_SYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCDX_SYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_RCDX_UNSYMMETRICAL", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCDX_UNSYMMETRICAL;
			else if (tsEnumValue.Equals("PROFILE_RCDX_UNSYMMETRICAL2", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCDX_UNSYMMETRICAL2;
			else if (tsEnumValue.Equals("PROFILE_RCX_DEFAULT", System.StringComparison.InvariantCulture))
				return ProfileItemSubTypeEnum.PROFILE_RCX_DEFAULT;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ProfileItem_
    {
        public static dynamic GetTSObject(ProfileItem dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ProfileItem FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.ProfileItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProfileItemArray_
    {
        public static dynamic GetTSObject(ProfileItem[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ProfileItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ProfileItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ProfileItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ProfileItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    