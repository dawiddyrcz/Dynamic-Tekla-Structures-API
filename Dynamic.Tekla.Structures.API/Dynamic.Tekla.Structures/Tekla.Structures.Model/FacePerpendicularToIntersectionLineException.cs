//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class FacePerpendicularToIntersectionLineException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public FacePerpendicularToIntersectionLineException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.FacePerpendicularToIntersectionLineException");
		}





    }

    internal static class FacePerpendicularToIntersectionLineException_
    {
        public static dynamic GetTSObject(FacePerpendicularToIntersectionLineException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacePerpendicularToIntersectionLineException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.FacePerpendicularToIntersectionLineException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
