//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class PlateIntersectsWithIntersectionLineException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public PlateIntersectsWithIntersectionLineException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PlateIntersectsWithIntersectionLineException");
		}





    }

    internal static class PlateIntersectsWithIntersectionLineException_
    {
        public static dynamic GetTSObject(PlateIntersectsWithIntersectionLineException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlateIntersectsWithIntersectionLineException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.PlateIntersectsWithIntersectionLineException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
