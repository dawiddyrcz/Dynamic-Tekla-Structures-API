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

    public abstract class LineTypes 
    {


        public static Dynamic.Tekla.Structures.Drawing.LineTypes UndefinedLine
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "UndefinedLine");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }
        public static Dynamic.Tekla.Structures.Drawing.LineTypes SolidLine
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "SolidLine");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }
        public static Dynamic.Tekla.Structures.Drawing.LineTypes DashedLine
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "DashedLine");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }
        public static Dynamic.Tekla.Structures.Drawing.LineTypes SlashedLine
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "SlashedLine");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }
        public static Dynamic.Tekla.Structures.Drawing.LineTypes DashDot
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "DashDot");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }
        public static Dynamic.Tekla.Structures.Drawing.LineTypes DottedLine
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "DottedLine");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }
        public static Dynamic.Tekla.Structures.Drawing.LineTypes DashDoubleDot
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "DashDoubleDot");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }
        public static Dynamic.Tekla.Structures.Drawing.LineTypes SlashDash
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes", "SlashDash");
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
            }
            
        }        

        internal dynamic teklaObject;



        public static Dynamic.Tekla.Structures.Drawing.LineTypes Custom(
			System.String CustomLineTypeName)
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "Custom", CustomLineTypeName);
            var _result = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(result);
				return _result;
        }



        public System.Boolean IsEqual(
			System.Object ObjectToCompare)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.IsEqual(ObjectToCompare);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsEqual), ex);
            }
        }



        public System.Object Clone()
        {
            
            try
            {
                var result = (System.Object) teklaObject.Clone();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Clone), ex);
            }
        }



		public static System.Boolean operator ==(Dynamic.Tekla.Structures.Drawing.LineTypes o1, Dynamic.Tekla.Structures.Drawing.LineTypes o2)
		{
			if(System.Object.ReferenceEquals(o1, null)) return System.Object.ReferenceEquals(o2, null);
			var o1Tek = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(o2);
			return o1Tek == o2Tek;
		}
		public static System.Boolean operator !=(Dynamic.Tekla.Structures.Drawing.LineTypes o1, Dynamic.Tekla.Structures.Drawing.LineTypes o2)
		{
			return !(o1 == o2);
		}



    }

    internal static class LineTypes_
    {
        public static dynamic GetTSObject(LineTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LineTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LineTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LineTypesArray_
    {
        public static dynamic GetTSObject(LineTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LineTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LineTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LineTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LineTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
