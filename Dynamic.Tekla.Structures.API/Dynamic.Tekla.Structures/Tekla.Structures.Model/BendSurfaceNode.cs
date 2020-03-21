//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BendSurfaceNode 
    {

		public System.Boolean IsAutomatic
		{
			get => teklaObject.IsAutomatic;
			set { teklaObject.IsAutomatic = value; }
		}

		public Dynamic.Tekla.Structures.Model.BendSurface Surface
		{
			get => Dynamic.Tekla.Structures.Model.BendSurface_.FromTSObject(teklaObject.Surface);
			set { teklaObject.Surface = Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;


		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
			 => teklaObject.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));





    }

    internal static class BendSurfaceNode_
    {
        public static dynamic GetTSObject(BendSurfaceNode dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BendSurfaceNode FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BendSurfaceNode)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
