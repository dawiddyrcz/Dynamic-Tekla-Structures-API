//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Solid
{

    public sealed class ShellEnumerator 
    {

		public System.Object Current
		{
			get => shellenumerator.Current;
			set { shellenumerator.Current = value; }
		}

        

        dynamic shellenumerator;
        
        public ShellEnumerator()
        {
            this.shellenumerator =  TSActivator.CreateInstance("Tekla.Structures.Solid.ShellEnumerator");
        }

        public ShellEnumerator(dynamic tsObject)
        {
            this.shellenumerator = tsObject;
			this.Current = shellenumerator.Current;

        }


        public dynamic GetTSObject() => shellenumerator;

		public System.Boolean MoveNext()
			 => shellenumerator.MoveNext();

		public void Reset()
			 => shellenumerator.Reset();





    }

}
    
