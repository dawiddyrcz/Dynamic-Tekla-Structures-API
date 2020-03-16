//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class TeklaStructuresVariables 
    {

        

        dynamic teklastructuresvariables;
        
        public TeklaStructuresVariables()
        {
            this.teklastructuresvariables =  new Tekla.Structures.TeklaStructuresVariables();
        }

        public TeklaStructuresVariables(dynamic tsObject)
        {
            this.teklastructuresvariables = tsObject;

        }


        public dynamic GetTSObject() => teklastructuresvariables;

		public void Add(System.String key)
			 => teklastructuresvariables.Add(key);

		public System.String Get(System.String key)
			 => teklastructuresvariables.Get(key);

		public System.Boolean ContainsVariable(System.String key)
			 => teklastructuresvariables.ContainsVariable(key);





    }

}
    
