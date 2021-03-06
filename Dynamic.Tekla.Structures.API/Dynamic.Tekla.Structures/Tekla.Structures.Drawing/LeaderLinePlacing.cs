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

    public  class LeaderLinePlacing  : Dynamic.Tekla.Structures.Drawing.PlacingBase
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
        

        

		internal LeaderLinePlacing() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LeaderLinePlacing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LeaderLinePlacing(Dynamic.Tekla.Structures.Geometry3d.Point LeaderLineStartPoint)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(LeaderLineStartPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LeaderLinePlacing", args);
		}





    }

    internal static class LeaderLinePlacing_
    {
        public static dynamic GetTSObject(LeaderLinePlacing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LeaderLinePlacing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LeaderLinePlacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LeaderLinePlacingArray_
    {
        public static dynamic GetTSObject(LeaderLinePlacing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LeaderLinePlacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LeaderLinePlacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LeaderLinePlacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LeaderLinePlacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
