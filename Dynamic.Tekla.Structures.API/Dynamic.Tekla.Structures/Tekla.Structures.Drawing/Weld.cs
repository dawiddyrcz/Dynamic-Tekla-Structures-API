/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Weld  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {


        public Dynamic.Tekla.Structures.Drawing.Weld.WeldAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.Weld.WeldAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.Weld.WeldAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.Weld.WeldAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
        }
        

        

		internal Weld() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Weld(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum Representation
    {
			Outline,
			Path        
    }

    internal static class Representation_
    {
        public static dynamic GetTSObject(Representation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Weld.Representation").GetType();

            switch (dynEnum)
            {
				case Representation.Outline:
					return System.Enum.Parse(tsType, "Outline");
				case Representation.Path:
					return System.Enum.Parse(tsType, "Path");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Representation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Outline", System.StringComparison.InvariantCulture))
				return Representation.Outline;
			else if (tsEnumValue.Equals("Path", System.StringComparison.InvariantCulture))
				return Representation.Path;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class WeldAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {


        public Dynamic.Tekla.Structures.Drawing.Weld.Representation Representation
        {
            get
            {
                try
                {
                var value = teklaObject.Representation;
                var value_ = Dynamic.Tekla.Structures.Drawing.Weld.Representation_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.Weld.Representation) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Representation), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.Weld.Representation_.GetTSObject(value);
                teklaObject.Representation = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Representation), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes VisibleLines
        {
            get
            {
                try
                {
                var value = teklaObject.VisibleLines;
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.LineTypeAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(VisibleLines), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
                teklaObject.VisibleLines = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(VisibleLines), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes HiddenLines
        {
            get
            {
                try
                {
                var value = teklaObject.HiddenLines;
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.LineTypeAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HiddenLines), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
                teklaObject.HiddenLines = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HiddenLines), ex); 
                }
            }
        }

        public System.Boolean DrawHiddenLines
        {
            get
            {
                try
                {
                return teklaObject.DrawHiddenLines;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawHiddenLines), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DrawHiddenLines = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawHiddenLines), ex); 
                }
            }
        }

        public System.Boolean DrawOwnHiddenLines
        {
            get
            {
                try
                {
                return teklaObject.DrawOwnHiddenLines;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawOwnHiddenLines), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DrawOwnHiddenLines = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawOwnHiddenLines), ex); 
                }
            }
        }

        public System.String CustomPresentation
        {
            get
            {
                try
                {
                return teklaObject.CustomPresentation;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CustomPresentation), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.CustomPresentation = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CustomPresentation), ex); 
                }
            }
        }
        

        

		public WeldAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Weld.WeldAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public WeldAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public WeldAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Weld.WeldAttributes", args);
		}





    }

    internal static class WeldAttributes_
    {
        public static dynamic GetTSObject(WeldAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static WeldAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Weld.WeldAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WeldAttributesArray_
    {
        public static dynamic GetTSObject(WeldAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WeldAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WeldAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<WeldAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WeldAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Weld_
    {
        public static dynamic GetTSObject(Weld dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Weld FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Weld)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WeldArray_
    {
        public static dynamic GetTSObject(Weld[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Weld_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Weld[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Weld>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Weld_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
