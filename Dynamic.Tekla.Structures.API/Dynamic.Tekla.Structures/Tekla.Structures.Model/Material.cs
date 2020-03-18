//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Material 
    {

		public System.String MaterialString
		{
			get => material.MaterialString;
			set { material.MaterialString = value; }
		}

        

        dynamic material;
        
        public Material()
        {
            this.material =  TSActivator.CreateInstance("Tekla.Structures.Model.Material");
        }

        public Material(dynamic tsObject)
        {
            this.material = tsObject;
        }

        internal dynamic GetTSObject() => material;





    }

}
    
