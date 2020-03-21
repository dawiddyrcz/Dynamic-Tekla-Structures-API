//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Solid
{

    public  class Shell 
    {

        

        internal dynamic teklaObject;

		public Shell() {}

		public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
			 => Dynamic.Tekla.Structures.Solid.FaceEnumerator_.FromTSObject(teklaObject.GetFaceEnumerator());

		public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
			 => Dynamic.Tekla.Structures.Solid.EdgeEnumerator_.FromTSObject(teklaObject.GetEdgeEnumerator());





    }

    internal static class Shell_
    {
        public static dynamic GetTSObject(Shell dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Shell FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Solid.Shell)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
