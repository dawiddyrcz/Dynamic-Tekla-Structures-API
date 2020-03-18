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

        

        internal dynamic shellenumerator;
        
        public ShellEnumerator()
        {
            this.shellenumerator =  TSActivator.CreateInstance("Tekla.Structures.Solid.ShellEnumerator");
        }

        internal ShellEnumerator(dynamic tsObject)
        {
            this.shellenumerator = tsObject;
        }

		public System.Boolean MoveNext()
			 => shellenumerator.MoveNext();

		public void Reset()
			 => shellenumerator.Reset();





    }

    internal static class ShellEnumerator_
    {
        public static dynamic GetTSObject(ShellEnumerator dynObject)
        {
            return dynObject.shellenumerator;
        }

        public static ShellEnumerator FromTSObject(dynamic tsObject)
        {
            return new ShellEnumerator(tsObject);
        }
    }


}
    