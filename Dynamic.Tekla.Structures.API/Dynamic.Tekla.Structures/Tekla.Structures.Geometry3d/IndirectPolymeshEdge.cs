//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class IndirectPolymeshEdge 
    {

		public Dynamic.Tekla.Structures.Geometry3d.PolymeshEdgeTypeEnum EdgeType
		{
			get => Dynamic.Tekla.Structures.Geometry3d.PolymeshEdgeTypeEnum_.FromTSObject(teklaObject.EdgeType);
			set { teklaObject.EdgeType = Dynamic.Tekla.Structures.Geometry3d.PolymeshEdgeTypeEnum_.GetTSObject(value); }
		}

		public System.Int32 StartPoint
		{
			get => teklaObject.StartPoint;
			set { teklaObject.StartPoint = value; }
		}

		public System.Int32 EndPoint
		{
			get => teklaObject.EndPoint;
			set { teklaObject.EndPoint = value; }
		}

		public System.Int32 ShellIndex
		{
			get => teklaObject.ShellIndex;
			set { teklaObject.ShellIndex = value; }
		}

        

        internal dynamic teklaObject;

		public IndirectPolymeshEdge()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.IndirectPolymeshEdge");
		}





    }

    internal static class IndirectPolymeshEdge_
    {
        public static dynamic GetTSObject(IndirectPolymeshEdge dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IndirectPolymeshEdge FromTSObject(dynamic tsObject)
        {
            return new IndirectPolymeshEdge() { teklaObject = tsObject };
        }
    }


}
    
