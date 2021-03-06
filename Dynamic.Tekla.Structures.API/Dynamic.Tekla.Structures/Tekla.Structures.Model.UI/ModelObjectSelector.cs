/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ModelObjectSelector 
    {

        

        internal dynamic teklaObject;

		public ModelObjectSelector()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ModelObjectSelector");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelObjectSelector(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


        public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSelectedObjects()
        {
            
            try
            {
                var result = teklaObject.GetSelectedObjects();
            
                var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSelectedObjects), ex);
            }
        }



        public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjectsByBoundingBox(
			Dynamic.Tekla.Structures.Geometry3d.Point MinPoint_,
			Dynamic.Tekla.Structures.Geometry3d.Point MaxPoint_,
			Dynamic.Tekla.Structures.Model.UI.View View_)
        {
            var MinPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MinPoint_);
var MaxPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MaxPoint_);
var View = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(View_);
            try
            {
                var result = teklaObject.GetObjectsByBoundingBox(MinPoint, MaxPoint, View);
            
                var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjectsByBoundingBox), ex);
            }
        }



        public System.Boolean Select(
			System.Collections.ArrayList ModelObjects_)
        {
            var ModelObjects = ArrayListConverter.ToTSObjects(ModelObjects_);
            try
            {
                var result = (System.Boolean) teklaObject.Select(ModelObjects);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
            }
        }



        public System.Boolean Select(
			System.Collections.ArrayList ModelObjects_,
			System.Boolean ShowDimensions)
        {
            var ModelObjects = ArrayListConverter.ToTSObjects(ModelObjects_);
            try
            {
                var result = (System.Boolean) teklaObject.Select(ModelObjects, ShowDimensions);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
            }
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

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ModelObjectSelector)System.Activator.CreateInstance(type, parameters);
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
    
