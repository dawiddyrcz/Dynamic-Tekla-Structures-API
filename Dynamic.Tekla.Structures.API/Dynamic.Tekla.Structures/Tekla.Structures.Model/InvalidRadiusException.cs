//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class InvalidRadiusException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public InvalidRadiusException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.InvalidRadiusException");
		}

		public System.Exception GetBaseException()
			 => teklaObject.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => teklaObject.GetObjectData(info, context);





    }

    internal static class InvalidRadiusException_
    {
        public static dynamic GetTSObject(InvalidRadiusException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidRadiusException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.InvalidRadiusException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
