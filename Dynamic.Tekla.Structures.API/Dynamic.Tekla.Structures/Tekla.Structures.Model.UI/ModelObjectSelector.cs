/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ModelObjectSelector 
    {

        

        internal dynamic teklaObject;

		public ModelObjectSelector()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ModelObjectSelector");
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSelectedObjects()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSelectedObjects());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjectsByBoundingBox(Dynamic.Tekla.Structures.Geometry3d.Point MinPoint, Dynamic.Tekla.Structures.Geometry3d.Point MaxPoint, Dynamic.Tekla.Structures.Model.UI.View View)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetObjectsByBoundingBox(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MinPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MaxPoint), Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(View)));
		}

		public System.Boolean Select(System.Collections.ArrayList ModelObjects)
		{
			return teklaObject.Select(ModelObjects);
		}

		public System.Boolean Select(System.Collections.ArrayList ModelObjects, System.Boolean ShowDimensions)
		{
			return teklaObject.Select(ModelObjects, ShowDimensions);
		}





    }

    internal static class ModelObjectSelector_
    {
        public static dynamic GetTSObject(ModelObjectSelector dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelObjectSelector FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.UI.ModelObjectSelector)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
