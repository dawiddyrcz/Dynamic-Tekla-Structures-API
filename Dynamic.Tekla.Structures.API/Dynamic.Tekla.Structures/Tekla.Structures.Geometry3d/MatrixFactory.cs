/*Copyright (C) Yury Isachenkov 2023
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

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class MatrixFactory 
    {

        

        internal dynamic teklaObject;



        public static Dynamic.Tekla.Structures.Geometry3d.Matrix Rotate(
			System.Double Angle,
			Dynamic.Tekla.Structures.Geometry3d.Vector Axis_)
        {
var Axis = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Axis_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "Rotate", Angle, Axis);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Geometry3d.Matrix ToCoordinateSystem(
			Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys_)
        {
            var CoordSys = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "ToCoordinateSystem", CoordSys);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Geometry3d.Matrix FromCoordinateSystem(
			Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys_)
        {
            var CoordSys = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "FromCoordinateSystem", CoordSys);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Geometry3d.Matrix ByCoordinateSystems(
			Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys1_,
			Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys2_)
        {
            var CoordSys1 = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys1_);
var CoordSys2 = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys2_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "ByCoordinateSystems", CoordSys1, CoordSys2);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
				return _result;
        }






    }

    internal static class MatrixFactory_
    {
        public static dynamic GetTSObject(MatrixFactory dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MatrixFactory FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.MatrixFactory)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MatrixFactoryArray_
    {
        public static dynamic GetTSObject(MatrixFactory[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MatrixFactory_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MatrixFactory[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MatrixFactory>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MatrixFactory_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
