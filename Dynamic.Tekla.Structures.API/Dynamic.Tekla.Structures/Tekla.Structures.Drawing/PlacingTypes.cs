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

    public abstract class PlacingTypes 
    {

        

        internal dynamic teklaObject;



        public static Dynamic.Tekla.Structures.Drawing.PlacingBase AlongLinePlacing(
			Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
			Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_)
        {
            var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "AlongLinePlacing", StartPoint, EndPoint);
            var _result = Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Drawing.PlacingBase BaseLinePlacing(
			Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
			Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_)
        {
            var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "BaseLinePlacing", StartPoint, EndPoint);
            var _result = Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Drawing.PlacingBase LeaderLinePlacing(
			Dynamic.Tekla.Structures.Geometry3d.Point LeaderLineStartPoint_)
        {
            var LeaderLineStartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(LeaderLineStartPoint_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "LeaderLinePlacing", LeaderLineStartPoint);
            var _result = Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Drawing.PlacingBase PointPlacing()
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "PointPlacing");
            var _result = Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
				return _result;
        }






    }

    internal static class PlacingTypes_
    {
        public static dynamic GetTSObject(PlacingTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PlacingTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlacingTypesArray_
    {
        public static dynamic GetTSObject(PlacingTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlacingTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlacingTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PlacingTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlacingTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
