//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ModelObjectEnumerator 
    {

		public System.Boolean SelectInstances
		{
			get => modelobjectenumerator.SelectInstances;
			set { modelobjectenumerator.SelectInstances = value; }
		}

		public System.Boolean AutoFetch
		{
			get => modelobjectenumerator.AutoFetch;
			set { modelobjectenumerator.AutoFetch = value; }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Current
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(modelobjectenumerator.Current);
			set { modelobjectenumerator.Current = value.GetTSObject(); }
		}

        

        dynamic modelobjectenumerator;
        
        public ModelObjectEnumerator()
        {
            this.modelobjectenumerator =  TSActivator.CreateInstance("Tekla.Structures.Model.ModelObjectEnumerator");
        }

        public ModelObjectEnumerator(dynamic tsObject)
        {
            this.modelobjectenumerator = tsObject;
        }

        internal dynamic GetTSObject() => modelobjectenumerator;

		public System.Boolean MoveNext()
			 => modelobjectenumerator.MoveNext();

		public void Reset()
			 => modelobjectenumerator.Reset();

		public System.Int32 GetSize()
			 => modelobjectenumerator.GetSize();




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

    public static class EnumeratorTypeEnum_
    {
        public static dynamic GetTSObject(EnumeratorTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.EnumeratorTypeEnum");

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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
