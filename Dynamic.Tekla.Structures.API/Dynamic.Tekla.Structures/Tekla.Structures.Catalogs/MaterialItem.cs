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
			get
			{
				try {
					return teklaObject.MaterialName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaterialName"); }
			}
			set
			{
				try {
					teklaObject.MaterialName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaterialName"); }
			}
		}

		public System.String AliasName1
		{
			get
			{
				try {
					return teklaObject.AliasName1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AliasName1"); }
			}
			set
			{
				try {
					teklaObject.AliasName1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AliasName1"); }
			}
		}

		public System.String AliasName2
		{
			get
			{
				try {
					return teklaObject.AliasName2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AliasName2"); }
			}
			set
			{
				try {
					teklaObject.AliasName2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AliasName2"); }
			}
		}

		public System.String AliasName3
		{
			get
			{
				try {
					return teklaObject.AliasName3;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AliasName3"); }
			}
			set
			{
				try {
					teklaObject.AliasName3 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AliasName3"); }
			}
		}

		public Dynamic.Tekla.Structures.Catalogs.MaterialItem.MaterialItemTypeEnum Type
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.MaterialItem.MaterialItemTypeEnum_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Catalogs.MaterialItem.MaterialItemTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
		}

		public System.Double ProfileDensity
		{
			get
			{
				try {
					return teklaObject.ProfileDensity;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProfileDensity"); }
			}
			set
			{
				try {
					teklaObject.ProfileDensity = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProfileDensity"); }
			}
		}

		public System.Double PlateDensity
		{
			get
			{
				try {
					return teklaObject.PlateDensity;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlateDensity"); }
			}
			set
			{
				try {
					teklaObject.PlateDensity = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlateDensity"); }
			}
		}

		public System.Double ModulusOfElasticity
		{
			get
			{
				try {
					return teklaObject.ModulusOfElasticity;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModulusOfElasticity"); }
			}
			set
			{
				try {
					teklaObject.ModulusOfElasticity = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModulusOfElasticity"); }
			}
		}

		public System.Double PoissonsRatio
		{
			get
			{
				try {
					return teklaObject.PoissonsRatio;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PoissonsRatio"); }
			}
			set
			{
				try {
					teklaObject.PoissonsRatio = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PoissonsRatio"); }
			}
		}

		public System.Double ThermalDilatation
		{
			get
			{
				try {
					return teklaObject.ThermalDilatation;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ThermalDilatation"); }
			}
			set
			{
				try {
					teklaObject.ThermalDilatation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ThermalDilatation"); }
			}
		}

		public System.Int32 DesignCode
		{
			get
			{
				try {
					return teklaObject.DesignCode;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DesignCode"); }
			}
			set
			{
				try {
					teklaObject.DesignCode = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DesignCode"); }
			}
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
			try {
			var result = teklaObject.Select(materialName);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select()
		{
			try {
			var result = teklaObject.Select();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Insert()
		{
			try {
			var result = teklaObject.Insert();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()"); }
		}

		public System.Boolean Modify()
		{
			try {
			var result = teklaObject.Modify();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
		}

		public System.Boolean Delete()
		{
			try {
			var result = teklaObject.Delete();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()"); }
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class MaterialItem_
    {
        public static dynamic GetTSObject(MaterialItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MaterialItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MaterialItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MaterialItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MaterialItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MaterialItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
