/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ModelObjectSelector 
    {

        

        internal dynamic teklaObject;

		internal ModelObjectSelector() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelObjectSelector(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAllObjects()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetAllObjects());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAllObjectsWithType(Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetAllObjectsWithType(Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjectsByBoundingBox(Dynamic.Tekla.Structures.Geometry3d.Point MinPoint, Dynamic.Tekla.Structures.Geometry3d.Point MaxPoint)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetObjectsByBoundingBox(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MinPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MaxPoint)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetEnumerator()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetEnumerator());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjectsByFilterName(System.String FilterName)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetObjectsByFilterName(FilterName));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetFilteredObjectsWithType(Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum, System.String FilterName)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetFilteredObjectsWithType(Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum), FilterName));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjectsByFilter(Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetObjectsByFilter(Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression)));
		}





    }

    internal static class ModelObjectSelector_
    {
        public static dynamic GetTSObject(ModelObjectSelector dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelObjectSelector FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ModelObjectSelector)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelObjectSelectorArray_
    {
        public static dynamic GetTSObject(ModelObjectSelector[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelObjectSelector_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelObjectSelector[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelObjectSelector>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelObjectSelector_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
