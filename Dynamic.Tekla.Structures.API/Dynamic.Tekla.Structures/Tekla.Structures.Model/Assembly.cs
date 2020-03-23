/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Assembly  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.AssemblyNumber);
			set { teklaObject.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

        

        

		public Assembly()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Assembly");
		}

		public Dynamic.Tekla.Structures.Model.ModelObject GetMainPart()
		{
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.GetMainPart());
		}

		public System.Boolean SetMainPart(Dynamic.Tekla.Structures.Model.Part Part)
		{
			return teklaObject.SetMainPart(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(Part));
		}

		public System.Collections.ArrayList GetSecondaries()
		{
			return teklaObject.GetSecondaries();
		}

		public System.Boolean Add(Dynamic.Tekla.Structures.Model.IAssemblable Object)
		{
			return teklaObject.Add(Dynamic.Tekla.Structures.Model.IAssemblable_.GetTSObject(Object));
		}

		public System.Boolean Add(System.Collections.ArrayList Assemblables)
		{
			return teklaObject.Add(Assemblables);
		}

		public System.Boolean Remove(Dynamic.Tekla.Structures.Model.ModelObject Object)
		{
			return teklaObject.Remove(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object));
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Add(Dynamic.Tekla.Structures.Model.Assembly Assembly)
		{
			return teklaObject.Add(Dynamic.Tekla.Structures.Model.Assembly_.GetTSObject(Assembly));
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
		}

		public System.Collections.ArrayList GetSubAssemblies()
		{
			return teklaObject.GetSubAssemblies();
		}

		public Dynamic.Tekla.Structures.Model.Assembly.AssemblyTypeEnum GetAssemblyType()
		{
			return Dynamic.Tekla.Structures.Model.Assembly.AssemblyTypeEnum_.FromTSObject(teklaObject.GetAssemblyType());
		}

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
		{
			return Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(teklaObject.GetFatherPour());
		}

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
		{
			return Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());
		}

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Assembly AssemblyToCompare)
		{
			return teklaObject.CompareTo(Dynamic.Tekla.Structures.Model.Assembly_.GetTSObject(AssemblyToCompare));
		}




    public enum AssemblyTypeEnum
    {
			STEEL_ASSEMBLY,
			PRECAST_ASSEMBLY,
			IN_SITU_ASSEMBLY,
			TIMBER_ASSEMBLY,
			UNKNOWN_ASSEMBLY        
    }

    internal static class AssemblyTypeEnum_
    {
        public static dynamic GetTSObject(AssemblyTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Assembly.AssemblyTypeEnum").GetType();

            switch (dynEnum)
            {
				case AssemblyTypeEnum.STEEL_ASSEMBLY:
					return System.Enum.Parse(tsType, "STEEL_ASSEMBLY");
				case AssemblyTypeEnum.PRECAST_ASSEMBLY:
					return System.Enum.Parse(tsType, "PRECAST_ASSEMBLY");
				case AssemblyTypeEnum.IN_SITU_ASSEMBLY:
					return System.Enum.Parse(tsType, "IN_SITU_ASSEMBLY");
				case AssemblyTypeEnum.TIMBER_ASSEMBLY:
					return System.Enum.Parse(tsType, "TIMBER_ASSEMBLY");
				case AssemblyTypeEnum.UNKNOWN_ASSEMBLY:
					return System.Enum.Parse(tsType, "UNKNOWN_ASSEMBLY");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AssemblyTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("STEEL_ASSEMBLY", System.StringComparison.InvariantCulture))
				return AssemblyTypeEnum.STEEL_ASSEMBLY;
			else if (tsEnumValue.Equals("PRECAST_ASSEMBLY", System.StringComparison.InvariantCulture))
				return AssemblyTypeEnum.PRECAST_ASSEMBLY;
			else if (tsEnumValue.Equals("IN_SITU_ASSEMBLY", System.StringComparison.InvariantCulture))
				return AssemblyTypeEnum.IN_SITU_ASSEMBLY;
			else if (tsEnumValue.Equals("TIMBER_ASSEMBLY", System.StringComparison.InvariantCulture))
				return AssemblyTypeEnum.TIMBER_ASSEMBLY;
			else if (tsEnumValue.Equals("UNKNOWN_ASSEMBLY", System.StringComparison.InvariantCulture))
				return AssemblyTypeEnum.UNKNOWN_ASSEMBLY;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Assembly_
    {
        public static dynamic GetTSObject(Assembly dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Assembly FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Assembly)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
