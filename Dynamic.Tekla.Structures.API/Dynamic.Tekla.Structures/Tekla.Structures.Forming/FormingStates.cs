//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Forming
{

    public sealed class FormingStates 
    {

		public Dynamic.Tekla.Structures.Forming.DeformingType Deforming
		{
			get => Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(formingstates.Deforming);
			set { formingstates.Deforming = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Forming.FoldingType Folding
		{
			get => Dynamic.Tekla.Structures.Forming.FoldingType_.FromTSObject(formingstates.Folding);
			set { formingstates.Folding = Dynamic.Tekla.Structures.Forming.FoldingType_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Forming.WrappingType Wrapping
		{
			get => Dynamic.Tekla.Structures.Forming.WrappingType_.FromTSObject(formingstates.Wrapping);
			set { formingstates.Wrapping = Dynamic.Tekla.Structures.Forming.WrappingType_.FromTSObject(value); }
		}

        

        dynamic formingstates;
        
        public FormingStates()
        {
            this.formingstates =  TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates");
        }

        public FormingStates(dynamic tsObject)
        {
            this.formingstates = tsObject;
        }

        internal dynamic GetTSObject() => formingstates;

		public System.Object Clone()
			 => formingstates.Clone();





    }

}
    
