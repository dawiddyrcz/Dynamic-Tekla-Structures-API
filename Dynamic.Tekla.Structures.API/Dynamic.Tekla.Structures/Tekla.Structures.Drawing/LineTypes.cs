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

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.LineTypes Custom(System.String CustomLineTypeName)
		{
			var parameters = new object[1];
			parameters[0] = CustomLineTypeName;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "Custom", parameters);
			return Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.LineTypes op_Explicit(System.Int32 value)
		{
			var parameters = new object[1];
			parameters[0] = value;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "op_Explicit", parameters);
			return Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(result);
		}

		public static System.Int32 op_Explicit(Dynamic.Tekla.Structures.Drawing.LineTypes lineType)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(lineType);
			var result = (System.Int32) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "op_Explicit", parameters);
			return result;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public static System.Boolean op_Equality(Dynamic.Tekla.Structures.Drawing.LineTypes a, Dynamic.Tekla.Structures.Drawing.LineTypes b)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(a);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(b);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "op_Equality", parameters);
			return result;
		}

		public static System.Boolean op_Inequality(Dynamic.Tekla.Structures.Drawing.LineTypes a, Dynamic.Tekla.Structures.Drawing.LineTypes b)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(a);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(b);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.LineTypes", "op_Inequality", parameters);
			return result;
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class LineTypes_
    {
        public static dynamic GetTSObject(LineTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LineTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.LineTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
