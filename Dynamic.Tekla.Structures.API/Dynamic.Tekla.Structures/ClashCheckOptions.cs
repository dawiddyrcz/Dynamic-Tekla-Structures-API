//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class ClashCheckOptions 
    {

		public System.Double BoltHeadDiameter
		{
			get => clashcheckoptions.BoltHeadDiameter;
			set { clashcheckoptions.BoltHeadDiameter = value; }
		}

		public System.Double NutThickness
		{
			get => clashcheckoptions.NutThickness;
			set { clashcheckoptions.NutThickness = value; }
		}

        

        dynamic clashcheckoptions;
        
        public ClashCheckOptions()
        {
            this.clashcheckoptions =  new Tekla.Structures.ClashCheckOptions();
        }

        public ClashCheckOptions(dynamic tsObject)
        {
            this.clashcheckoptions = tsObject;
			this.BoltHeadDiameter = clashcheckoptions.BoltHeadDiameter;
			this.NutThickness = clashcheckoptions.NutThickness;

        }


        public dynamic GetTSObject() => clashcheckoptions;





    }

}
    
