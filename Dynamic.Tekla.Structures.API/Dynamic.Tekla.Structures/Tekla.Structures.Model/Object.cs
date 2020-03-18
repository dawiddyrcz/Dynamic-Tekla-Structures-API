//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Object 
    {

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(@object.Identifier);
			set { @object.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic @object;
        
        private Object()
        {
            this.@object =  TSActivator.CreateInstance("Tekla.Structures.Model.Object");
        }

        internal Object(dynamic tsObject)
        {
            this.@object = tsObject;
        }





    }

    internal static class Object_
    {
        public static dynamic GetTSObject(Object dynObject)
        {
            return dynObject.@object;
        }

        public static Object FromTSObject(dynamic tsObject)
        {
            return new Object(tsObject);
        }
    }


}
    