//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class ContourPoint  : Dynamic.Tekla.Structures.Geometry3d.Point
    {

		public Dynamic.Tekla.Structures.Model.Chamfer Chamfer
		{
			get => Dynamic.Tekla.Structures.Model.Chamfer_.FromTSObject(teklaObject.Chamfer);
			set { teklaObject.Chamfer = Dynamic.Tekla.Structures.Model.Chamfer_.GetTSObject(value); }
		}

        

        

		public ContourPoint()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPoint");
		}
		public ContourPoint(Dynamic.Tekla.Structures.Geometry3d.Point P, Dynamic.Tekla.Structures.Model.Chamfer C)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P);
			args[1] = Dynamic.Tekla.Structures.Model.Chamfer_.GetTSObject(C);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPoint", args);
		}

		public void SetPoint(Dynamic.Tekla.Structures.Geometry3d.Point P)
		{
			teklaObject.SetPoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P));
		}





    }

    internal static class ContourPoint_
    {
        public static dynamic GetTSObject(ContourPoint dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ContourPoint FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ContourPoint)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
