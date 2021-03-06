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

    public abstract class BendSurfaceNode 
    {


        public System.Boolean IsAutomatic
        {
            get
            {
                try
                {
                return teklaObject.IsAutomatic;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsAutomatic), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Model.BendSurface Surface
        {
            get
            {
                try
                {
                var value = teklaObject.Surface;
                var value_ = Dynamic.Tekla.Structures.Model.BendSurface_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.BendSurface) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Surface), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(value);
                teklaObject.Surface = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Surface), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;



        public void AcceptVisitor(
			Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor_)
        {
            var visitor = Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor_);
            try
            {
                teklaObject.AcceptVisitor(visitor);
            
                
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AcceptVisitor), ex);
            }
        }






    }

    internal static class BendSurfaceNode_
    {
        public static dynamic GetTSObject(BendSurfaceNode dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BendSurfaceNode FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BendSurfaceNode_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BendSurfaceNode[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BendSurfaceNode>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BendSurfaceNode_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
