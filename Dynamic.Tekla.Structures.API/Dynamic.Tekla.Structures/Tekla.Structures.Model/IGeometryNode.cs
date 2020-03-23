/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class IGeometryNode 
    {

		public System.Boolean IsAutomatic
		{
			get => teklaObject.IsAutomatic;
			set { teklaObject.IsAutomatic = value; }
		}

        

        internal dynamic teklaObject;


		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
		{
			teklaObject.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));
		}





    }

    internal static class IGeometryNode_
    {
        public static dynamic GetTSObject(IGeometryNode dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IGeometryNode FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.IGeometryNode)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IGeometryNodeArray_
    {
        public static dynamic GetTSObject(IGeometryNode[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IGeometryNode_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IGeometryNode[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IGeometryNode>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IGeometryNode_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
