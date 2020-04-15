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

    public  class LoadArea  : Dynamic.Tekla.Structures.Model.Load
    {


        public Dynamic.Tekla.Structures.Geometry3d.Point Position1
        {
            get
            {
                try
                {
                var value = teklaObject.Position1;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Position1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position1), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point Position2
        {
            get
            {
                try
                {
                var value = teklaObject.Position2;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position2), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Position2 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position2), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point Position3
        {
            get
            {
                try
                {
                var value = teklaObject.Position3;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position3), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Position3 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position3), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector P1
        {
            get
            {
                try
                {
                var value = teklaObject.P1;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.P1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P1), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector P2
        {
            get
            {
                try
                {
                var value = teklaObject.P2;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P2), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.P2 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P2), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector P3
        {
            get
            {
                try
                {
                var value = teklaObject.P3;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P3), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.P3 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P3), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector P4
        {
            get
            {
                try
                {
                var value = teklaObject.P4;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P4), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.P4 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P4), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum LoadForm
        {
            get
            {
                try
                {
                var value = teklaObject.LoadForm;
                var value_ = Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadForm), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum_.GetTSObject(value);
                teklaObject.LoadForm = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadForm), ex); 
                }
            }
        }

        public System.Double DistanceA
        {
            get
            {
                try
                {
                return teklaObject.DistanceA;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceA), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DistanceA = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceA), ex); 
                }
            }
        }
        

        

		public LoadArea()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadArea");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LoadArea(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum AreaLoadFormEnum
    {
			LOAD_FORM_AREA_PARALLELOGRAM,
			LOAD_FORM_AREA_TRIANGLE        
    }

    internal static class AreaLoadFormEnum_
    {
        public static dynamic GetTSObject(AreaLoadFormEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoadArea.AreaLoadFormEnum").GetType();

            switch (dynEnum)
            {
				case AreaLoadFormEnum.LOAD_FORM_AREA_PARALLELOGRAM:
					return System.Enum.Parse(tsType, "LOAD_FORM_AREA_PARALLELOGRAM");
				case AreaLoadFormEnum.LOAD_FORM_AREA_TRIANGLE:
					return System.Enum.Parse(tsType, "LOAD_FORM_AREA_TRIANGLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AreaLoadFormEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_FORM_AREA_PARALLELOGRAM", System.StringComparison.InvariantCulture))
				return AreaLoadFormEnum.LOAD_FORM_AREA_PARALLELOGRAM;
			else if (tsEnumValue.Equals("LOAD_FORM_AREA_TRIANGLE", System.StringComparison.InvariantCulture))
				return AreaLoadFormEnum.LOAD_FORM_AREA_TRIANGLE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoadArea_
    {
        public static dynamic GetTSObject(LoadArea dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoadArea FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LoadArea)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadAreaArray_
    {
        public static dynamic GetTSObject(LoadArea[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadArea_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadArea[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoadArea>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadArea_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
