/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class MaterialItem 
    {

		public System.String MaterialName
		{
			get => teklaObject.MaterialName;
			set { teklaObject.MaterialName = value; }
		}

		public System.String AliasName1
		{
			get => teklaObject.AliasName1;
			set { teklaObject.AliasName1 = value; }
		}

		public System.String AliasName2
		{
			get => teklaObject.AliasName2;
			set { teklaObject.AliasName2 = value; }
		}

		public System.String AliasName3
		{
			get => teklaObject.AliasName3;
			set { teklaObject.AliasName3 = value; }
		}

		public Dynamic.Tekla.Structures.Catalogs.MaterialItem.MaterialItemTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Catalogs.MaterialItem.MaterialItemTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Catalogs.MaterialItem.MaterialItemTypeEnum_.GetTSObject(value); }
		}

		public System.Double ProfileDensity
		{
			get => teklaObject.ProfileDensity;
			set { teklaObject.ProfileDensity = value; }
		}

		public System.Double PlateDensity
		{
			get => teklaObject.PlateDensity;
			set { teklaObject.PlateDensity = value; }
		}

		public System.Double ModulusOfElasticity
		{
			get => teklaObject.ModulusOfElasticity;
			set { teklaObject.ModulusOfElasticity = value; }
		}

		public System.Double PoissonsRatio
		{
			get => teklaObject.PoissonsRatio;
			set { teklaObject.PoissonsRatio = value; }
		}

		public System.Double ThermalDilatation
		{
			get => teklaObject.ThermalDilatation;
			set { teklaObject.ThermalDilatation = value; }
		}

		public System.Int32 DesignCode
		{
			get => teklaObject.DesignCode;
			set { teklaObject.DesignCode = value; }
		}

        

        internal dynamic teklaObject;

		public MaterialItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.MaterialItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MaterialItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public static System.Int32 MaterialNameMaxLength()
		{
			var parameters = new object[0];
			var result = (System.Int32) TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.MaterialItem", "MaterialNameMaxLength", parameters);
			return result;
		}

		public System.Boolean Select(System.String materialName)
		{
			return teklaObject.Select(materialName);
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Export(ref System.String filename)
		{
			return teklaObject.Export(ref filename);
		}




    public enum MaterialItemTypeEnum
    {
			MATERIAL_UNKNOWN,
			MATERIAL_STEEL,
			MATERIAL_CONCRETE,
			MATERIAL_TIMBER,
			MATERIAL_MISC,
			MATERIAL_REBAR,
			MATERIAL_REBAR_MESH        
    }

    internal static class MaterialItemTypeEnum_
    {
        public static dynamic GetTSObject(MaterialItemTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.MaterialItem.MaterialItemTypeEnum").GetType();

            switch (dynEnum)
            {
				case MaterialItemTypeEnum.MATERIAL_UNKNOWN:
					return System.Enum.Parse(tsType, "MATERIAL_UNKNOWN");
				case MaterialItemTypeEnum.MATERIAL_STEEL:
					return System.Enum.Parse(tsType, "MATERIAL_STEEL");
				case MaterialItemTypeEnum.MATERIAL_CONCRETE:
					return System.Enum.Parse(tsType, "MATERIAL_CONCRETE");
				case MaterialItemTypeEnum.MATERIAL_TIMBER:
					return System.Enum.Parse(tsType, "MATERIAL_TIMBER");
				case MaterialItemTypeEnum.MATERIAL_MISC:
					return System.Enum.Parse(tsType, "MATERIAL_MISC");
				case MaterialItemTypeEnum.MATERIAL_REBAR:
					return System.Enum.Parse(tsType, "MATERIAL_REBAR");
				case MaterialItemTypeEnum.MATERIAL_REBAR_MESH:
					return System.Enum.Parse(tsType, "MATERIAL_REBAR_MESH");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static MaterialItemTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("MATERIAL_UNKNOWN", System.StringComparison.InvariantCulture))
				return MaterialItemTypeEnum.MATERIAL_UNKNOWN;
			else if (tsEnumValue.Equals("MATERIAL_STEEL", System.StringComparison.InvariantCulture))
				return MaterialItemTypeEnum.MATERIAL_STEEL;
			else if (tsEnumValue.Equals("MATERIAL_CONCRETE", System.StringComparison.InvariantCulture))
				return MaterialItemTypeEnum.MATERIAL_CONCRETE;
			else if (tsEnumValue.Equals("MATERIAL_TIMBER", System.StringComparison.InvariantCulture))
				return MaterialItemTypeEnum.MATERIAL_TIMBER;
			else if (tsEnumValue.Equals("MATERIAL_MISC", System.StringComparison.InvariantCulture))
				return MaterialItemTypeEnum.MATERIAL_MISC;
			else if (tsEnumValue.Equals("MATERIAL_REBAR", System.StringComparison.InvariantCulture))
				return MaterialItemTypeEnum.MATERIAL_REBAR;
			else if (tsEnumValue.Equals("MATERIAL_REBAR_MESH", System.StringComparison.InvariantCulture))
				return MaterialItemTypeEnum.MATERIAL_REBAR_MESH;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class MaterialItem_
    {
        public static dynamic GetTSObject(MaterialItem dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static MaterialItem FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.MaterialItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MaterialItemArray_
    {
        public static dynamic GetTSObject(MaterialItem[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MaterialItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MaterialItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<MaterialItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MaterialItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
