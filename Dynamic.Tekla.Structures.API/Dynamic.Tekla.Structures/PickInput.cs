//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class PickInput 
    {

		public System.Int32 Count
		{
			get => pickinput.Count;
			set { pickinput.Count = value; }
		}

		public System.Boolean IsSynchronized
		{
			get => pickinput.IsSynchronized;
			set { pickinput.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => pickinput.SyncRoot;
			set { pickinput.SyncRoot = value; }
		}

        

        dynamic pickinput;
        
        public PickInput()
        {
            this.pickinput =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.PickInput");
        }

        public PickInput(dynamic tsObject)
        {
            this.pickinput = tsObject;
			this.Count = pickinput.Count;
			this.IsSynchronized = pickinput.IsSynchronized;
			this.SyncRoot = pickinput.SyncRoot;

        }


        public dynamic GetTSObject() => pickinput;

		public void CopyTo(System.Array array, System.Int32 index)
			 => pickinput.CopyTo(array, index);





    }

}
    
