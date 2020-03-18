//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Solid
{

    public sealed class ISolid 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point MinimumPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(isolid.MinimumPoint);
			set { isolid.MinimumPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point MaximumPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(isolid.MaximumPoint);
			set { isolid.MaximumPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        internal dynamic isolid;
        
        private ISolid()
        {
            this.isolid =  TSActivator.CreateInstance("Tekla.Structures.Solid.ISolid");
        }

        internal ISolid(dynamic tsObject)
        {
            this.isolid = tsObject;
        }

		public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
			 => Dynamic.Tekla.Structures.Solid.FaceEnumerator_.FromTSObject(isolid.GetFaceEnumerator());

		public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
			 => Dynamic.Tekla.Structures.Solid.EdgeEnumerator_.FromTSObject(isolid.GetEdgeEnumerator());





    }

    internal static class ISolid_
    {
        public static dynamic GetTSObject(ISolid dynObject)
        {
            return dynObject.isolid;
        }

        public static ISolid FromTSObject(dynamic tsObject)
        {
            return new ISolid(tsObject);
        }
    }


}
    