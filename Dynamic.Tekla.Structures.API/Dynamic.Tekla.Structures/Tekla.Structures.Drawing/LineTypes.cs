/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class LineTypes 
    {

		public static Dynamic.Tekla.Structures.Drawing.LineTypes UndefinedLine
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","UndefinedLine"));

		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes SolidLine
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","SolidLine"));

		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes DashedLine
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","DashedLine"));

		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes SlashedLine
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","SlashedLine"));

		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes DashDot
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","DashDot"));

		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes DottedLine
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","DottedLine"));

		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes DashDoubleDot
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","DashDoubleDot"));

		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes SlashDash
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.LineTypes","SlashDash"));

		}

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.LineTypes Custom(System.String CustomLineTypeName)
		{
			var parameters = new object[1];
			parameters[0] = CustomLineTypeName;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "Custom", parameters);
			return Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(result);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			try {
			var result = teklaObject.IsEqual(ObjectToCompare);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsEqual()"); }
		}

		public System.Object Clone()
		{
			try {
			var result = teklaObject.Clone();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Clone()"); }
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
    
