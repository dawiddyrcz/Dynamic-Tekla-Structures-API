//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class ModelObjectVisualization 
    {

        

        internal dynamic modelobjectvisualization;
        
        private ModelObjectVisualization()
        {
            this.modelobjectvisualization =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.ModelObjectVisualization");
        }

        internal ModelObjectVisualization(dynamic tsObject)
        {
            this.modelobjectvisualization = tsObject;
        }

		public System.Boolean SetTemporaryStateForAll(Dynamic.Tekla.Structures.Model.UI.Color color)
			 => modelobjectvisualization.SetTemporaryStateForAll(Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));

		public System.Boolean SetTemporaryState(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects, Dynamic.Tekla.Structures.Model.UI.Color color)
			 => modelobjectvisualization.SetTemporaryState(modelObjects, Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));

		public System.Boolean SetTransparencyForAll(Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
			 => modelobjectvisualization.SetTransparencyForAll(Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency));

		public System.Boolean SetTransparency(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
			 => modelobjectvisualization.SetTransparency(modelObjects, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency));

		public System.Boolean SetTransparency(System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
			 => modelobjectvisualization.SetTransparency(identifiers, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency));

		public System.Boolean SetTemporaryState(System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers, Dynamic.Tekla.Structures.Model.UI.Color color)
			 => modelobjectvisualization.SetTemporaryState(identifiers, Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));

		public System.Boolean GetRepresentation(Dynamic.Tekla.Structures.Model.ModelObject modelObject, Dynamic.Tekla.Structures.Model.UI.Color color)
			 => modelobjectvisualization.GetRepresentation(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(modelObject), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color));

		public System.Boolean ClearAllTemporaryStates()
			 => modelobjectvisualization.ClearAllTemporaryStates();





    }

    internal static class ModelObjectVisualization_
    {
        public static dynamic GetTSObject(ModelObjectVisualization dynObject)
        {
            return dynObject.modelobjectvisualization;
        }

        public static ModelObjectVisualization FromTSObject(dynamic tsObject)
        {
            return new ModelObjectVisualization(tsObject);
        }
    }


}
    