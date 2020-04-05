/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ModelObjectEnumerator 
    {

		public System.Boolean SelectInstances
		{
			get => teklaObject.SelectInstances;
			set { teklaObject.SelectInstances = value; }
		}

		public static System.Boolean AutoFetch
		{
			get => (System.Boolean) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.ModelObjectEnumerator","AutoFetch");
			set { TSActivator.Set_StaticPropertyOrFieldValue("Tekla.Structures.Model.ModelObjectEnumerator","AutoFetch", value); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Current
		{
			get
			{
				 return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Current);
			}
		}

        

        internal dynamic teklaObject;

		internal ModelObjectEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelObjectEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean MoveNext()
		{
			try {
			return teklaObject.MoveNext();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("MoveNext()"); }
		}

		public void Reset()
		{
			try {
			teklaObject.Reset();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Reset()"); }
		}

		public System.Int32 GetSize()
		{
			try {
			return teklaObject.GetSize();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSize()"); }
		}




    public enum EnumeratorTypeEnum
    {
			ALL_SELECTED,
			ALL_OBJECTS,
			MODELOBJECT_CHILDREN,
			BY_FILTER_NAME,
			CONNECTED_COMPONENTS,
			BY_BOUNDING_BOX,
			ALL_OBJECTS_WITH_TYPE,
			REFERENCE_MODEL_OBJECTS,
			MODELOBJECT_FATHERS,
			CONNECTED_DEPENDENCIES,
			TASKS_OF_SELECTED_OBJECTS,
			MODIFIED_OBJECTS_AFTER_STAMP,
			FILTERED_OBJECTS_WITH_TYPE,
			DELETED_OBJECTS_AFTER_STAMP,
			ALL_PRESELECTED,
			BY_BOUNDING_BOX_AND_VIEW,
			CONVERTED_FROM_REFERENCE_MODEL,
			ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP,
			NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP,
			CREATED_OBJECTS_AFTER_STAMP,
			MODIFIED_OBJECTS_BY_FILTER_NAME,
			PHASE_MODIFIED_OBJECTS_AFTER_STAMP,
			OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP        
    }

    internal static class EnumeratorTypeEnum_
    {
        public static dynamic GetTSObject(EnumeratorTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ModelObjectEnumerator.EnumeratorTypeEnum").GetType();

            switch (dynEnum)
            {
				case EnumeratorTypeEnum.ALL_SELECTED:
					return System.Enum.Parse(tsType, "ALL_SELECTED");
				case EnumeratorTypeEnum.ALL_OBJECTS:
					return System.Enum.Parse(tsType, "ALL_OBJECTS");
				case EnumeratorTypeEnum.MODELOBJECT_CHILDREN:
					return System.Enum.Parse(tsType, "MODELOBJECT_CHILDREN");
				case EnumeratorTypeEnum.BY_FILTER_NAME:
					return System.Enum.Parse(tsType, "BY_FILTER_NAME");
				case EnumeratorTypeEnum.CONNECTED_COMPONENTS:
					return System.Enum.Parse(tsType, "CONNECTED_COMPONENTS");
				case EnumeratorTypeEnum.BY_BOUNDING_BOX:
					return System.Enum.Parse(tsType, "BY_BOUNDING_BOX");
				case EnumeratorTypeEnum.ALL_OBJECTS_WITH_TYPE:
					return System.Enum.Parse(tsType, "ALL_OBJECTS_WITH_TYPE");
				case EnumeratorTypeEnum.REFERENCE_MODEL_OBJECTS:
					return System.Enum.Parse(tsType, "REFERENCE_MODEL_OBJECTS");
				case EnumeratorTypeEnum.MODELOBJECT_FATHERS:
					return System.Enum.Parse(tsType, "MODELOBJECT_FATHERS");
				case EnumeratorTypeEnum.CONNECTED_DEPENDENCIES:
					return System.Enum.Parse(tsType, "CONNECTED_DEPENDENCIES");
				case EnumeratorTypeEnum.TASKS_OF_SELECTED_OBJECTS:
					return System.Enum.Parse(tsType, "TASKS_OF_SELECTED_OBJECTS");
				case EnumeratorTypeEnum.MODIFIED_OBJECTS_AFTER_STAMP:
					return System.Enum.Parse(tsType, "MODIFIED_OBJECTS_AFTER_STAMP");
				case EnumeratorTypeEnum.FILTERED_OBJECTS_WITH_TYPE:
					return System.Enum.Parse(tsType, "FILTERED_OBJECTS_WITH_TYPE");
				case EnumeratorTypeEnum.DELETED_OBJECTS_AFTER_STAMP:
					return System.Enum.Parse(tsType, "DELETED_OBJECTS_AFTER_STAMP");
				case EnumeratorTypeEnum.ALL_PRESELECTED:
					return System.Enum.Parse(tsType, "ALL_PRESELECTED");
				case EnumeratorTypeEnum.BY_BOUNDING_BOX_AND_VIEW:
					return System.Enum.Parse(tsType, "BY_BOUNDING_BOX_AND_VIEW");
				case EnumeratorTypeEnum.CONVERTED_FROM_REFERENCE_MODEL:
					return System.Enum.Parse(tsType, "CONVERTED_FROM_REFERENCE_MODEL");
				case EnumeratorTypeEnum.ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP:
					return System.Enum.Parse(tsType, "ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP");
				case EnumeratorTypeEnum.NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP:
					return System.Enum.Parse(tsType, "NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP");
				case EnumeratorTypeEnum.CREATED_OBJECTS_AFTER_STAMP:
					return System.Enum.Parse(tsType, "CREATED_OBJECTS_AFTER_STAMP");
				case EnumeratorTypeEnum.MODIFIED_OBJECTS_BY_FILTER_NAME:
					return System.Enum.Parse(tsType, "MODIFIED_OBJECTS_BY_FILTER_NAME");
				case EnumeratorTypeEnum.PHASE_MODIFIED_OBJECTS_AFTER_STAMP:
					return System.Enum.Parse(tsType, "PHASE_MODIFIED_OBJECTS_AFTER_STAMP");
				case EnumeratorTypeEnum.OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP:
					return System.Enum.Parse(tsType, "OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EnumeratorTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ALL_SELECTED", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.ALL_SELECTED;
			else if (tsEnumValue.Equals("ALL_OBJECTS", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.ALL_OBJECTS;
			else if (tsEnumValue.Equals("MODELOBJECT_CHILDREN", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.MODELOBJECT_CHILDREN;
			else if (tsEnumValue.Equals("BY_FILTER_NAME", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.BY_FILTER_NAME;
			else if (tsEnumValue.Equals("CONNECTED_COMPONENTS", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.CONNECTED_COMPONENTS;
			else if (tsEnumValue.Equals("BY_BOUNDING_BOX", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.BY_BOUNDING_BOX;
			else if (tsEnumValue.Equals("ALL_OBJECTS_WITH_TYPE", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.ALL_OBJECTS_WITH_TYPE;
			else if (tsEnumValue.Equals("REFERENCE_MODEL_OBJECTS", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.REFERENCE_MODEL_OBJECTS;
			else if (tsEnumValue.Equals("MODELOBJECT_FATHERS", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.MODELOBJECT_FATHERS;
			else if (tsEnumValue.Equals("CONNECTED_DEPENDENCIES", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.CONNECTED_DEPENDENCIES;
			else if (tsEnumValue.Equals("TASKS_OF_SELECTED_OBJECTS", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.TASKS_OF_SELECTED_OBJECTS;
			else if (tsEnumValue.Equals("MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.MODIFIED_OBJECTS_AFTER_STAMP;
			else if (tsEnumValue.Equals("FILTERED_OBJECTS_WITH_TYPE", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.FILTERED_OBJECTS_WITH_TYPE;
			else if (tsEnumValue.Equals("DELETED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.DELETED_OBJECTS_AFTER_STAMP;
			else if (tsEnumValue.Equals("ALL_PRESELECTED", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.ALL_PRESELECTED;
			else if (tsEnumValue.Equals("BY_BOUNDING_BOX_AND_VIEW", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.BY_BOUNDING_BOX_AND_VIEW;
			else if (tsEnumValue.Equals("CONVERTED_FROM_REFERENCE_MODEL", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.CONVERTED_FROM_REFERENCE_MODEL;
			else if (tsEnumValue.Equals("ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP;
			else if (tsEnumValue.Equals("NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP;
			else if (tsEnumValue.Equals("CREATED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.CREATED_OBJECTS_AFTER_STAMP;
			else if (tsEnumValue.Equals("MODIFIED_OBJECTS_BY_FILTER_NAME", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.MODIFIED_OBJECTS_BY_FILTER_NAME;
			else if (tsEnumValue.Equals("PHASE_MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.PHASE_MODIFIED_OBJECTS_AFTER_STAMP;
			else if (tsEnumValue.Equals("OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP", System.StringComparison.InvariantCulture))
				return EnumeratorTypeEnum.OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ModelObjectEnumerator_
    {
        public static dynamic GetTSObject(ModelObjectEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelObjectEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ModelObjectEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelObjectEnumeratorArray_
    {
        public static dynamic GetTSObject(ModelObjectEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelObjectEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelObjectEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelObjectEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelObjectEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
