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


		public static System.Boolean SetTemporaryStateForAll(Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTemporaryStateForAll", parameters);
		}

		public static System.Boolean SetTemporaryState(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects, Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			var parameters = new object[2];
			parameters[0] = modelObjects;
			parameters[1] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTemporaryState", parameters);
		}

		public static System.Boolean SetTransparencyForAll(Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTransparencyForAll", parameters);
		}

		public static System.Boolean SetTransparency(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
		{
			var parameters = new object[2];
			parameters[0] = modelObjects;
			parameters[1] = Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTransparency", parameters);
		}

		public static System.Boolean SetTransparency(System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers, Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency)
		{
			var parameters = new object[2];
			parameters[0] = identifiers;
			parameters[1] = Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTransparency", parameters);
		}

		public static System.Boolean SetTemporaryState(System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers, Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			var parameters = new object[2];
			parameters[0] = identifiers;
			parameters[1] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTemporaryState", parameters);
		}

		public static System.Boolean GetRepresentation(Dynamic.Tekla.Structures.Model.ModelObject modelObject, Dynamic.Tekla.Structures.Model.UI.Color color)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(modelObject);
			parameters[1] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "GetRepresentation", parameters);
		}

		public static System.Boolean ClearAllTemporaryStates()
		{
			var parameters = new object[0];
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "ClearAllTemporaryStates", parameters);
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
    
