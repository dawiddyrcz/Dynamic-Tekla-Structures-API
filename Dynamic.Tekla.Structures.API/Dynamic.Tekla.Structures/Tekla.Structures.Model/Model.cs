//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Model 
    {

        

        dynamic model;
        
        public Model()
        {
            this.model =  TSActivator.CreateInstance("Tekla.Structures.Model.Model");
        }

        public Model(dynamic tsObject)
        {
            this.model = tsObject;
        }

        internal dynamic GetTSObject() => model;

		public System.Boolean GetConnectionStatus()
			 => model.GetConnectionStatus();

		public Dynamic.Tekla.Structures.Model.ModelInfo GetInfo()
			 => new Dynamic.Tekla.Structures.Model.ModelInfo(model.GetInfo());

		public Dynamic.Tekla.Structures.Model.ProjectInfo GetProjectInfo()
			 => new Dynamic.Tekla.Structures.Model.ProjectInfo(model.GetProjectInfo());

		public Dynamic.Tekla.Structures.Model.PhaseCollection GetPhases()
			 => new Dynamic.Tekla.Structures.Model.PhaseCollection(model.GetPhases());

		public Dynamic.Tekla.Structures.Model.ModelObjectSelector GetModelObjectSelector()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectSelector(model.GetModelObjectSelector());

		public Dynamic.Tekla.Structures.Model.ModelObject SelectModelObject(Dynamic.Tekla.Structures.Identifier ID)
			 => new Dynamic.Tekla.Structures.Model.ModelObject(model.SelectModelObject(ID.GetTSObject()));

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> FetchModelObjects(System.Collections.Generic.List<System.String> Guids, System.Boolean SelectInstances)
			 => model.FetchModelObjects(Guids, SelectInstances);

		public Dynamic.Tekla.Structures.Identifier GetIdentifierByGUID(System.String guid)
			 => new Dynamic.Tekla.Structures.Identifier(model.GetIdentifierByGUID(guid));

		public System.String GetGUIDByIdentifier(Dynamic.Tekla.Structures.Identifier identifier)
			 => model.GetGUIDByIdentifier(identifier.GetTSObject());

		public System.Boolean CommitChanges()
			 => model.CommitChanges();

		public System.Boolean CommitChanges(System.String Message)
			 => model.CommitChanges(Message);

		public Dynamic.Tekla.Structures.Model.WorkPlaneHandler GetWorkPlaneHandler()
			 => new Dynamic.Tekla.Structures.Model.WorkPlaneHandler(model.GetWorkPlaneHandler());

		public Dynamic.Tekla.Structures.Model.ClashCheckHandler GetClashCheckHandler()
			 => new Dynamic.Tekla.Structures.Model.ClashCheckHandler(model.GetClashCheckHandler());





    }

}
    
