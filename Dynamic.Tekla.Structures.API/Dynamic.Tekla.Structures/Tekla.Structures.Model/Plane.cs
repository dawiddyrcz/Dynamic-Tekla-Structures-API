/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class Plane 
    {


        public Dynamic.Tekla.Structures.Geometry3d.Point Origin
        {
            get
            {
                try
                {
                var value = teklaObject.Origin;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Origin = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector AxisX
        {
            get
            {
                try
                {
                var value = teklaObject.AxisX;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisX), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.AxisX = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisX), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector AxisY
        {
            get
            {
                try
                {
                var value = teklaObject.AxisY;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisY), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.AxisY = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisY), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public Plane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Plane");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Plane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class Plane_
    {
        public static dynamic GetTSObject(Plane dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Plane FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Plane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlaneArray_
    {
        public static dynamic GetTSObject(Plane[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Plane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Plane[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Plane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Plane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
