/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CustomLineType  : Dynamic.Tekla.Structures.Drawing.LineTypes
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Description
		{
			get => teklaObject.Description;
			set { teklaObject.Description = value; }
		}

		public System.Collections.Generic.List<System.Double> LineDescription
		{
			get => teklaObject.LineDescription;
			set { teklaObject.LineDescription = value; }
		}

        

        

		public CustomLineType() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public static System.Boolean op_Equality(Dynamic.Tekla.Structures.Drawing.CustomLineType a, Dynamic.Tekla.Structures.Drawing.CustomLineType b)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(a);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(b);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.CustomLineType", "op_Equality", parameters);
			return result;
		}

		public static System.Boolean op_Inequality(Dynamic.Tekla.Structures.Drawing.CustomLineType a, Dynamic.Tekla.Structures.Drawing.CustomLineType b)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(a);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(b);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.CustomLineType", "op_Inequality", parameters);
			return result;
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class CustomLineType_
    {
        public static dynamic GetTSObject(CustomLineType dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomLineType FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CustomLineType)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    