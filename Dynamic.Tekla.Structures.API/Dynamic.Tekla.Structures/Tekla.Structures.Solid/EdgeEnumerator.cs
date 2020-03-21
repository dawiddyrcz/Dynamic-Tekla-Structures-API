//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Solid
{

    public  class EdgeEnumerator 
    {

		public System.Object Current
		{
			get => teklaObject.Current;
			set { teklaObject.Current = value; }
		}

        

        internal dynamic teklaObject;

		public EdgeEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class EdgeEnumerator_
    {
        public static dynamic GetTSObject(EdgeEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static EdgeEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Solid.EdgeEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
