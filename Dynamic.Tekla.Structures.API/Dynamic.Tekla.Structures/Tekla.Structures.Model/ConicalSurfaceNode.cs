/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class ConicalSurfaceNode  : Dynamic.Tekla.Structures.Model.BendSurfaceNode
    {


        public Dynamic.Tekla.Structures.Model.ConicalSurface Surface
        {
            get
            {
                try
                {
                var value = teklaObject.Surface;
                var value_ = Dynamic.Tekla.Structures.Model.ConicalSurface_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.ConicalSurface) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Surface), ex); 
                }
            }
            
        }
        

        

		internal ConicalSurfaceNode() {}
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





    }

    internal static class ConicalSurfaceNode_
    {
        public static dynamic GetTSObject(ConicalSurfaceNode dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ConicalSurfaceNode FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ConicalSurfaceNode_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ConicalSurfaceNode[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ConicalSurfaceNode>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ConicalSurfaceNode_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
