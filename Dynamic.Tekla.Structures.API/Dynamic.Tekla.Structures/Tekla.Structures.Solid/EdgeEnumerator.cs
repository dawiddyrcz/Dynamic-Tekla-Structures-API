//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Solid
{

    public sealed class EdgeEnumerator 
    {

		public System.Object Current
		{
			get => edgeenumerator.Current;
			set { edgeenumerator.Current = value; }
		}

        

        dynamic edgeenumerator;
        
        public EdgeEnumerator()
        {
            this.edgeenumerator =  TSActivator.CreateInstance("Tekla.Structures.Solid.EdgeEnumerator");
        }

        public EdgeEnumerator(dynamic tsObject)
        {
            this.edgeenumerator = tsObject;
        }

        internal dynamic GetTSObject() => edgeenumerator;

		public System.Boolean MoveNext()
			 => edgeenumerator.MoveNext();

		public void Reset()
			 => edgeenumerator.Reset();





    }

}
    
