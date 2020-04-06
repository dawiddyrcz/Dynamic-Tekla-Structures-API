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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.PolymeshEdgeTypeEnum_.FromTSObject(teklaObject.EdgeType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EdgeType", ex); }
			}
			set
			{
				try {
				teklaObject.EdgeType = Dynamic.Tekla.Structures.Geometry3d.PolymeshEdgeTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EdgeType", ex); }
			}
		}

		public System.Int32 StartPoint
		{
			get
			{
				try {
					return teklaObject.StartPoint;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint", ex); }
			}
			set
			{
				try {
					teklaObject.StartPoint = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint", ex); }
			}
		}

		public System.Int32 EndPoint
		{
			get
			{
				try {
					return teklaObject.EndPoint;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint", ex); }
			}
			set
			{
				try {
					teklaObject.EndPoint = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint", ex); }
			}
		}

		public System.Int32 ShellIndex
		{
			get
			{
				try {
					return teklaObject.ShellIndex;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShellIndex", ex); }
			}
			set
			{
				try {
					teklaObject.ShellIndex = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShellIndex", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public IndirectPolymeshEdge()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.IndirectPolymeshEdge");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public IndirectPolymeshEdge(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class IndirectPolymeshEdge_
    {
        public static dynamic GetTSObject(IndirectPolymeshEdge dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IndirectPolymeshEdge FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IndirectPolymeshEdgeArray_
    {
        public static dynamic GetTSObject(IndirectPolymeshEdge[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IndirectPolymeshEdge_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IndirectPolymeshEdge[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IndirectPolymeshEdge>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IndirectPolymeshEdge_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
