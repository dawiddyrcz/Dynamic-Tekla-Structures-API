//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Assembly 
    {

		public System.String Name
		{
			get => assembly.Name;
			set { assembly.Name = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(assembly.AssemblyNumber);
			set { assembly.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => assembly.ModificationTime;
			set { assembly.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => assembly.IsUpToDate;
			set { assembly.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(assembly.Identifier);
			set { assembly.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic assembly;
        
        public Assembly()
        {
            this.assembly =  TSActivator.CreateInstance("Tekla.Structures.Model.Assembly");
        }

        internal Assembly(dynamic tsObject)
        {
            this.assembly = tsObject;
        }

		public Dynamic.Tekla.Structures.Model.ModelObject GetMainPart()
			 => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(assembly.GetMainPart());

		public System.Boolean SetMainPart(Dynamic.Tekla.Structures.Model.Part Part)
			 => assembly.SetMainPart(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(Part));

		public System.Collections.ArrayList GetSecondaries()
			 => assembly.GetSecondaries();

		public System.Boolean Add(Dynamic.Tekla.Structures.Model.IAssemblable Object)
			 => assembly.Add(Dynamic.Tekla.Structures.Model.IAssemblable_.GetTSObject(Object));

		public System.Boolean Add(System.Collections.ArrayList Assemblables)
			 => assembly.Add(Assemblables);

		public System.Boolean Remove(Dynamic.Tekla.Structures.Model.ModelObject Object)
			 => assembly.Remove(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object));

		public System.Boolean Insert()
			 => assembly.Insert();

		public System.Boolean Select()
			 => assembly.Select();

		public System.Boolean Modify()
			 => assembly.Modify();

		public System.Boolean Delete()
			 => assembly.Delete();

		public System.Boolean Add(Dynamic.Tekla.Structures.Model.Assembly Assembly)
			 => assembly.Add(Dynamic.Tekla.Structures.Model.Assembly_.GetTSObject(Assembly));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(assembly.GetAssembly());

		public System.Collections.ArrayList GetSubAssemblies()
			 => assembly.GetSubAssemblies();

		public Dynamic.Tekla.Structures.Model.Assembly.AssemblyTypeEnum GetAssemblyType()
			 => Dynamic.Tekla.Structures.Model.Assembly.AssemblyTypeEnum_.FromTSObject(assembly.GetAssemblyType());

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(assembly.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(assembly.GetFatherPourUnit());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Assembly AssemblyToCompare)
			 => assembly.CompareTo(Dynamic.Tekla.Structures.Model.Assembly_.GetTSObject(AssemblyToCompare));

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(assembly.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(assembly.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(assembly.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => assembly.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => assembly.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => assembly.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => assembly.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => assembly.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => assembly.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => assembly.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => assembly.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => assembly.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => assembly.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => assembly.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => assembly.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => assembly.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => assembly.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => assembly.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => assembly.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => assembly.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => assembly.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => assembly.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(assembly.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => assembly.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => assembly.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => assembly.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => assembly.CompareTo(obj);




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
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.AssemblyTypeEnum");

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
            return dynObject.assembly;
        }

        public static Assembly FromTSObject(dynamic tsObject)
        {
            return new Assembly(tsObject);
        }
    }


}
    