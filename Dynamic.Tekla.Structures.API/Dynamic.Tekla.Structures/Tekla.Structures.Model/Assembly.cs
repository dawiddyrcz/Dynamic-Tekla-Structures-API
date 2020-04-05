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

        

        

		public Assembly()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Assembly");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Assembly(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Model.ModelObject GetMainPart()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.GetMainPart());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetMainPart()"); }
		}

		public System.Boolean SetMainPart(Dynamic.Tekla.Structures.Model.Part Part)
		{
			try {
			return teklaObject.SetMainPart(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(Part));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetMainPart()"); }
		}

		public System.Collections.ArrayList GetSecondaries()
		{
			try {
			return teklaObject.GetSecondaries();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSecondaries()"); }
		}

		public System.Boolean Add(Dynamic.Tekla.Structures.Model.IAssemblable Object)
		{
			try {
			return teklaObject.Add(Dynamic.Tekla.Structures.Model.IAssemblable_.GetTSObject(Object));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()"); }
		}

		public System.Boolean Add(System.Collections.ArrayList Assemblables)
		{
			try {
			return teklaObject.Add(Assemblables);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()"); }
		}

		public System.Boolean Remove(Dynamic.Tekla.Structures.Model.ModelObject Object)
		{
			try {
			return teklaObject.Remove(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Remove()"); }
		}

		public System.Boolean Add(Dynamic.Tekla.Structures.Model.Assembly Assembly)
		{
			try {
			return teklaObject.Add(Dynamic.Tekla.Structures.Model.Assembly_.GetTSObject(Assembly));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()"); }
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			try {
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAssembly()"); }
		}

		public System.Collections.ArrayList GetSubAssemblies()
		{
			try {
			return teklaObject.GetSubAssemblies();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSubAssemblies()"); }
		}

		public Dynamic.Tekla.Structures.Model.Assembly.AssemblyTypeEnum GetAssemblyType()
		{
			try {
			return Dynamic.Tekla.Structures.Model.Assembly.AssemblyTypeEnum_.FromTSObject(teklaObject.GetAssemblyType());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAssemblyType()"); }
		}

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
		{
			try {
			return Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(teklaObject.GetFatherPour());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetFatherPour()"); }
		}

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
		{
			try {
			return Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetFatherPourUnit()"); }
		}

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Assembly AssemblyToCompare)
		{
			try {
			return teklaObject.CompareTo(Dynamic.Tekla.Structures.Model.Assembly_.GetTSObject(AssemblyToCompare));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CompareTo()"); }
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Assembly_
    {
        public static dynamic GetTSObject(Assembly dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Assembly FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Assembly)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AssemblyArray_
    {
        public static dynamic GetTSObject(Assembly[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Assembly_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Assembly[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Assembly>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Assembly_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
