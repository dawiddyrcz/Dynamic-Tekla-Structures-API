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

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class AlongLinePlacing  : Dynamic.Tekla.Structures.Drawing.PlacingBase
    {


        public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
        {
            get
            {
                try
                {
                var value = teklaObject.StartPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.StartPoint = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
        {
            get
            {
                try
                {
                var value = teklaObject.EndPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.EndPoint = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex); 
                }
            }
        }
        

        

		internal AlongLinePlacing() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public AlongLinePlacing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public AlongLinePlacing(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AlongLinePlacing", args);
		}





    }

    internal static class AlongLinePlacing_
    {
        public static dynamic GetTSObject(AlongLinePlacing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static AlongLinePlacing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.AlongLinePlacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AlongLinePlacingArray_
    {
        public static dynamic GetTSObject(AlongLinePlacing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AlongLinePlacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AlongLinePlacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<AlongLinePlacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AlongLinePlacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
