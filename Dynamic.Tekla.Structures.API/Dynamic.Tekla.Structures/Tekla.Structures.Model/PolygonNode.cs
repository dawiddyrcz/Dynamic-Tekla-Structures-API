/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PolygonNode 
    {

		public System.Boolean IsAutomatic
		{
			get => teklaObject.IsAutomatic;
			set { teklaObject.IsAutomatic = value; }
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get => Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
			set { teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public PolygonNode() {}
		public PolygonNode(Dynamic.Tekla.Structures.Model.Contour contour, System.Boolean isAutomaticNode)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(contour);
			args[1] = isAutomaticNode;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolygonNode", args);
		}

		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
		{
			teklaObject.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));
		}





    }

    internal static class PolygonNode_
    {
        public static dynamic GetTSObject(PolygonNode dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PolygonNode FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.PolygonNode)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
