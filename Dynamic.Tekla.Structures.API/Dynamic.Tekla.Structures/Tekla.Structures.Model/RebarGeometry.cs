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

    public  class RebarGeometry 
    {


        public Dynamic.Tekla.Structures.Geometry3d.PolyLine Shape
        {
            get
            {
                try
                {
                var value = teklaObject.Shape;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.PolyLine) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shape), ex); 
                }
            }
            
        }

        public System.Double Diameter
        {
            get
            {
                try
                {
                return teklaObject.Diameter;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Diameter), ex); 
                }
            }
            
        }

        public System.Collections.ArrayList BendingRadiuses
        {
            get
            {
                try
                {
                var value = teklaObject.BendingRadiuses;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BendingRadiuses), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal RebarGeometry() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarGeometry(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RebarGeometry_
    {
        public static dynamic GetTSObject(RebarGeometry dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarGeometry FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarGeometry)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarGeometryArray_
    {
        public static dynamic GetTSObject(RebarGeometry[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarGeometry_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarGeometry[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarGeometry>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarGeometry_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
