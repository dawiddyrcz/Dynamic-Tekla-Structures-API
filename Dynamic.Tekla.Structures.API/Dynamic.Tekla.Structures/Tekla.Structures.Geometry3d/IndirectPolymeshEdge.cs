/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
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
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
