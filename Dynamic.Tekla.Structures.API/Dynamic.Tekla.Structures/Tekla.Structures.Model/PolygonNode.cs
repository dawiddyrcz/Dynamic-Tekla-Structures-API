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
			get
			{
				 return Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
			}
			set
			{
				teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value);
			}
		}

        

        internal dynamic teklaObject;

		internal PolygonNode() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolygonNode(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PolygonNode(Dynamic.Tekla.Structures.Model.Contour contour, System.Boolean isAutomaticNode)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(contour);
			args[1] = isAutomaticNode;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolygonNode", args);
		}

		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
		{
			try {
			teklaObject.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AcceptVisitor()"); }
		}





    }

    internal static class PolygonNode_
    {
        public static dynamic GetTSObject(PolygonNode dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolygonNode FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PolygonNode)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolygonNodeArray_
    {
        public static dynamic GetTSObject(PolygonNode[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolygonNode_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolygonNode[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolygonNode>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolygonNode_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
