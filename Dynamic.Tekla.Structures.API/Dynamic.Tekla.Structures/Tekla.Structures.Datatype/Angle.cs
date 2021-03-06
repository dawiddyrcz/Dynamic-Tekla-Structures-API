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

namespace Dynamic.Tekla.Structures.Datatype
{

    public  class Angle 
    {


        public static Dynamic.Tekla.Structures.Datatype.Angle.UnitType CurrentUnitType
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Datatype.Angle", "CurrentUnitType");
                var value_ = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Datatype.Angle.UnitType) value_;
            }
            set
            {
                var value_ = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(value);
                PropertyInvoker.SetStaticPropertyOrFieldValue("Tekla.Structures.Datatype.Angle", "CurrentUnitType", value_);
            }
        }
        public static System.Int32 DecimalPlaces
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Datatype.Angle", "DecimalPlaces");
                return (System.Int32) value;
            }
            set
            {
                var value_ = value;
                PropertyInvoker.SetStaticPropertyOrFieldValue("Tekla.Structures.Datatype.Angle", "DecimalPlaces", value_);
            }
        }
        public System.Double Degrees
        {
            get
            {
                try
                {
                return teklaObject.Degrees;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Degrees), ex); 
                }
            }
            
        }

        public System.Double Radians
        {
            get
            {
                try
                {
                return teklaObject.Radians;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radians), ex); 
                }
            }
            
        }

        public System.Double CurrentUnitValue
        {
            get
            {
                try
                {
                return teklaObject.CurrentUnitValue;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CurrentUnitValue), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal Angle() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Angle(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


        public static Dynamic.Tekla.Structures.Datatype.Angle FromDegrees(
			System.Double degrees)
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "FromDegrees", degrees);
            var _result = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Datatype.Angle FromRadians(
			System.Double radians)
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "FromRadians", radians);
            var _result = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Datatype.Angle FromCurrentUnit(
			System.Double angle)
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "FromCurrentUnit", angle);
            var _result = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Datatype.Angle Parse(
			System.String text)
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "Parse", text);
            var _result = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Datatype.Angle Parse(
			System.String text,
			System.IFormatProvider formatProvider)
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "Parse", text, formatProvider);
            var _result = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Datatype.Angle Parse(
			System.String text,
			System.IFormatProvider formatProvider,
			Dynamic.Tekla.Structures.Datatype.Angle.UnitType unitType_)
        {
var unitType = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(unitType_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "Parse", text, formatProvider, unitType);
            var _result = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
				return _result;
        }



        public static System.Boolean TryParse(
			System.String text,
			out Dynamic.Tekla.Structures.Datatype.Angle presult_)
        {
var presult = Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(null);
            var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "TryParse", text, ref presult);
            presult_ = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(presult);
            return result;
        }



        public static System.Boolean TryParse(
			System.String text,
			System.IFormatProvider formatProvider,
			out Dynamic.Tekla.Structures.Datatype.Angle presult_)
        {
var presult = Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(null);
            var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "TryParse", text, formatProvider, ref presult);
            presult_ = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(presult);
            return result;
        }



        public static System.Boolean TryParse(
			System.String text,
			System.IFormatProvider formatProvider,
			Dynamic.Tekla.Structures.Datatype.Angle.UnitType unitType_,
			out Dynamic.Tekla.Structures.Datatype.Angle presult_)
        {
var unitType = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(unitType_);
var presult = Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(null);
            var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "TryParse", text, formatProvider, unitType, ref presult);
            presult_ = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(presult);
            return result;
        }



        public System.Int32 CompareTo(
			Dynamic.Tekla.Structures.Datatype.Angle other_)
        {
            var other = Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(other_);
            try
            {
                var result = (System.Int32) teklaObject.CompareTo(other);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CompareTo), ex);
            }
        }





    public enum UnitType
    {
			Degrees,
			Radians        
    }

    internal static class UnitType_
    {
        public static dynamic GetTSObject(UnitType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Datatype.Angle.UnitType").GetType();

            switch (dynEnum)
            {
				case UnitType.Degrees:
					return System.Enum.Parse(tsType, "Degrees");
				case UnitType.Radians:
					return System.Enum.Parse(tsType, "Radians");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static UnitType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Degrees", System.StringComparison.InvariantCulture))
				return UnitType.Degrees;
			else if (tsEnumValue.Equals("Radians", System.StringComparison.InvariantCulture))
				return UnitType.Radians;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Angle_
    {
        public static dynamic GetTSObject(Angle dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Angle FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.Angle)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AngleArray_
    {
        public static dynamic GetTSObject(Angle[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Angle_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Angle[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Angle>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Angle_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
