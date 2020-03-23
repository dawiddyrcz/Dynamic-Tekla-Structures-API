/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ConicalSurfaceNode  : Dynamic.Tekla.Structures.Model.BendSurfaceNode
    {

		public Dynamic.Tekla.Structures.Model.ConicalSurface Surface
		{
			get => Dynamic.Tekla.Structures.Model.ConicalSurface_.FromTSObject(teklaObject.Surface);
			set { teklaObject.Surface = Dynamic.Tekla.Structures.Model.ConicalSurface_.GetTSObject(value); }
		}

        

        

		public ConicalSurfaceNode() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ConicalSurfaceNode(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ConicalSurfaceNode(Dynamic.Tekla.Structures.Model.ConicalSurface surface)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.ConicalSurface_.GetTSObject(surface);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurfaceNode", args);
		}

		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
		{
			teklaObject.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));
		}





    }

    internal static class ConicalSurfaceNode_
    {
        public static dynamic GetTSObject(ConicalSurfaceNode dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ConicalSurfaceNode FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ConicalSurfaceNode)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ConicalSurfaceNodeArray_
    {
        public static dynamic GetTSObject(ConicalSurfaceNode[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ConicalSurfaceNode_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ConicalSurfaceNode[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ConicalSurfaceNode>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ConicalSurfaceNode_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
