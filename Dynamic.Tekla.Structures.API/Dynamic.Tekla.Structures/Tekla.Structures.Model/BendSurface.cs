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

    public abstract class BendSurface 
    {


        public System.Boolean InwardCurved
        {
            get
            {
                try
                {
                return teklaObject.InwardCurved;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InwardCurved), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Geometry3d.Line IntersectionLine
        {
            get
            {
                try
                {
                var value = teklaObject.IntersectionLine;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Line) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IntersectionLine), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal1
        {
            get
            {
                try
                {
                var value = teklaObject.EndFaceNormal1;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndFaceNormal1), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal2
        {
            get
            {
                try
                {
                var value = teklaObject.EndFaceNormal2;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndFaceNormal2), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Geometry3d.Line CenterLine
        {
            get
            {
                try
                {
                var value = teklaObject.CenterLine;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Line) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CenterLine), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(value);
                teklaObject.CenterLine = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CenterLine), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxis
        {
            get
            {
                try
                {
                var value = teklaObject.RotationAxis;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAxis), ex); 
                }
            }
            
        }

        public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary1
        {
            get
            {
                try
                {
                var value = teklaObject.LateralBoundary1;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.Point>(value);
                return (System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LateralBoundary1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.LateralBoundary1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LateralBoundary1), ex); 
                }
            }
        }

        public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary2
        {
            get
            {
                try
                {
                var value = teklaObject.LateralBoundary2;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.Point>(value);
                return (System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LateralBoundary2), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.LateralBoundary2 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LateralBoundary2), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary1
        {
            get
            {
                try
                {
                var value = teklaObject.SideBoundary1;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.LineSegment) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SideBoundary1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value);
                teklaObject.SideBoundary1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SideBoundary1), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary2
        {
            get
            {
                try
                {
                var value = teklaObject.SideBoundary2;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.LineSegment) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SideBoundary2), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value);
                teklaObject.SideBoundary2 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SideBoundary2), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;






    }

    internal static class BendSurface_
    {
        public static dynamic GetTSObject(BendSurface dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BendSurface FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BendSurface)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BendSurfaceArray_
    {
        public static dynamic GetTSObject(BendSurface[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BendSurface_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BendSurface[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BendSurface>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BendSurface_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
