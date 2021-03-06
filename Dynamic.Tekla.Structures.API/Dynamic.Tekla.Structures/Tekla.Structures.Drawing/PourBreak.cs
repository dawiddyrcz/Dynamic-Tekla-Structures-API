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

    public  class PourBreak  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {


        public Dynamic.Tekla.Structures.Drawing.PourBreak.PourBreakAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.PourBreak.PourBreakAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.PourBreak.PourBreakAttributes) value_;
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
                var value_ = Dynamic.Tekla.Structures.Drawing.PourBreak.PourBreakAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
        }
        

        

		internal PourBreak() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PourBreak(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public  class PourBreakAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {


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
        

        

		public PourBreakAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PourBreak.PourBreakAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PourBreakAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PourBreakAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PourBreak.PourBreakAttributes", args);
		}





    }

    internal static class PourBreakAttributes_
    {
        public static dynamic GetTSObject(PourBreakAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourBreakAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PourBreak.PourBreakAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourBreakAttributesArray_
    {
        public static dynamic GetTSObject(PourBreakAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourBreakAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourBreakAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourBreakAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourBreakAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class PourBreak_
    {
        public static dynamic GetTSObject(PourBreak dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourBreak FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PourBreak)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourBreakArray_
    {
        public static dynamic GetTSObject(PourBreak[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourBreak_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourBreak[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourBreak>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourBreak_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
