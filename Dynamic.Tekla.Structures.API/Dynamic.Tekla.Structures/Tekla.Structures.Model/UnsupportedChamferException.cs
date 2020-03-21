//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class UnsupportedChamferException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public UnsupportedChamferException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UnsupportedChamferException");
		}





    }

    internal static class UnsupportedChamferException_
    {
        public static dynamic GetTSObject(UnsupportedChamferException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static UnsupportedChamferException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.UnsupportedChamferException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
