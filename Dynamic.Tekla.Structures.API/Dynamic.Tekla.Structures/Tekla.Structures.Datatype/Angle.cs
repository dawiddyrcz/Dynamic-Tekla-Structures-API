/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public  class Angle 
    {

		public Dynamic.Tekla.Structures.Datatype.Angle.UnitType CurrentUnitType
		{
			get => Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.FromTSObject(teklaObject.CurrentUnitType);
			set { teklaObject.CurrentUnitType = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(value); }
		}

		public System.Int32 DecimalPlaces
		{
			get => teklaObject.DecimalPlaces;
			set { teklaObject.DecimalPlaces = value; }
		}

		public System.Double Degrees
		{
			get => teklaObject.Degrees;

		}

		public System.Double Radians
		{
			get => teklaObject.Radians;

		}

		public System.Double CurrentUnitValue
		{
			get => teklaObject.CurrentUnitValue;

		}

        

        internal dynamic teklaObject;

		public Angle() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Angle(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public static Dynamic.Tekla.Structures.Datatype.Angle FromDegrees(System.Double degrees)
		{
			var parameters = new object[1];
			parameters[0] = degrees;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "FromDegrees", parameters);
			return Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Datatype.Angle FromRadians(System.Double radians)
		{
			var parameters = new object[1];
			parameters[0] = radians;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "FromRadians", parameters);
			return Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Datatype.Angle FromCurrentUnit(System.Double angle)
		{
			var parameters = new object[1];
			parameters[0] = angle;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "FromCurrentUnit", parameters);
			return Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Datatype.Angle Parse(System.String text)
		{
			var parameters = new object[1];
			parameters[0] = text;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "Parse", parameters);
			return Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Datatype.Angle Parse(System.String text, System.IFormatProvider formatProvider)
		{
			var parameters = new object[2];
			parameters[0] = text;
			parameters[1] = formatProvider;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "Parse", parameters);
			return Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Datatype.Angle Parse(System.String text, System.IFormatProvider formatProvider, Dynamic.Tekla.Structures.Datatype.Angle.UnitType unitType)
		{
			var parameters = new object[3];
			parameters[0] = text;
			parameters[1] = formatProvider;
			parameters[2] = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(unitType);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "Parse", parameters);
			return Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(result);
		}

		public static System.Boolean TryParse(System.String text, out Dynamic.Tekla.Structures.Datatype.Angle resultt)
		{
			var parameters = new object[2];
			parameters[0] = text;
			resultt = new Dynamic.Tekla.Structures.Datatype.Angle();
			parameters[1] = Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(resultt);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "TryParse", parameters);
			resultt = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(parameters[1]);
			return result;
		}

		public static System.Boolean TryParse(System.String text, System.IFormatProvider formatProvider, out Dynamic.Tekla.Structures.Datatype.Angle resultt)
		{
			var parameters = new object[3];
			parameters[0] = text;
			parameters[1] = formatProvider;
			resultt = new Dynamic.Tekla.Structures.Datatype.Angle();
			parameters[2] = Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(resultt);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "TryParse", parameters);
			resultt = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(parameters[2]);
			return result;
		}

		public static System.Boolean TryParse(System.String text, System.IFormatProvider formatProvider, Dynamic.Tekla.Structures.Datatype.Angle.UnitType unitType, out Dynamic.Tekla.Structures.Datatype.Angle resultt)
		{
			var parameters = new object[4];
			parameters[0] = text;
			parameters[1] = formatProvider;
			parameters[2] = Dynamic.Tekla.Structures.Datatype.Angle.UnitType_.GetTSObject(unitType);
			resultt = new Dynamic.Tekla.Structures.Datatype.Angle();
			parameters[3] = Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(resultt);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Angle", "TryParse", parameters);
			resultt = Dynamic.Tekla.Structures.Datatype.Angle_.FromTSObject(parameters[3]);
			return result;
		}

		public System.Int32 CompareTo(Dynamic.Tekla.Structures.Datatype.Angle other)
		{
			return teklaObject.CompareTo(Dynamic.Tekla.Structures.Datatype.Angle_.GetTSObject(other));
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Angle_
    {
        public static dynamic GetTSObject(Angle dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Angle FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Angle_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Angle[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Angle>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Angle_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
