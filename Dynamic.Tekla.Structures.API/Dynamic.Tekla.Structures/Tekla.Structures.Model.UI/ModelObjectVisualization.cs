/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public abstract class ModelObjectVisualization 
    {

        

        internal dynamic teklaObject;


		public System.Boolean SetTemporaryStateForAll(Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			return teklaObject.SetTemporaryStateForAll(Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));
		}

		public System.Boolean SetTemporaryState(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects, Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			return teklaObject.SetTemporaryState(modelObjects, Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));
		}

		public System.Boolean SetTransparencyForAll(Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
		{
			return teklaObject.SetTransparencyForAll(Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency));
		}

		public System.Boolean SetTransparency(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
		{
			return teklaObject.SetTransparency(modelObjects, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency));
		}

		public System.Boolean SetTransparency(System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
		{
			return teklaObject.SetTransparency(identifiers, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency));
		}

		public System.Boolean SetTemporaryState(System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers, Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			return teklaObject.SetTemporaryState(identifiers, Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));
		}

		public System.Boolean GetRepresentation(Dynamic.Tekla.Structures.Model.ModelObject modelObject, ref Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			return teklaObject.GetRepresentation(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(modelObject), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));
		}

		public System.Boolean ClearAllTemporaryStates()
		{
			return teklaObject.ClearAllTemporaryStates();
		}





    }

    internal static class ModelObjectVisualization_
    {
        public static dynamic GetTSObject(ModelObjectVisualization dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelObjectVisualization FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.UI.ModelObjectVisualization)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
