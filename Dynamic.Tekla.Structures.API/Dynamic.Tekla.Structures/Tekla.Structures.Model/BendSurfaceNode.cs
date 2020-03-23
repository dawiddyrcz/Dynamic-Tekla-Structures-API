/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BendSurfaceNode 
    {

		public System.Boolean IsAutomatic
		{
			get => teklaObject.IsAutomatic;

		}

		public Dynamic.Tekla.Structures.Model.BendSurface Surface
		{
			get => Dynamic.Tekla.Structures.Model.BendSurface_.FromTSObject(teklaObject.Surface);
			set { teklaObject.Surface = Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;


		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
		{
			teklaObject.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));
		}





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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BendSurfaceNode)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BendSurfaceNodeArray_
    {
        public static dynamic GetTSObject(BendSurfaceNode[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BendSurfaceNode_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BendSurfaceNode[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<BendSurfaceNode>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BendSurfaceNode_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
