/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class NormalLineType  : Dynamic.Tekla.Structures.Drawing.LineTypes
    {

        

        

		public NormalLineType() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NormalLineType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public static System.Boolean op_Equality(Dynamic.Tekla.Structures.Drawing.NormalLineType a, Dynamic.Tekla.Structures.Drawing.NormalLineType b)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.NormalLineType_.GetTSObject(a);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.NormalLineType_.GetTSObject(b);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.NormalLineType", "op_Equality", parameters);
			return result;
		}

		public static System.Boolean op_Inequality(Dynamic.Tekla.Structures.Drawing.NormalLineType a, Dynamic.Tekla.Structures.Drawing.NormalLineType b)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.NormalLineType_.GetTSObject(a);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.NormalLineType_.GetTSObject(b);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.NormalLineType", "op_Inequality", parameters);
			return result;
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class NormalLineType_
    {
        public static dynamic GetTSObject(NormalLineType dynObject)
        {
            return dynObject.teklaObject;
        }

        public static NormalLineType FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.NormalLineType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NormalLineTypeArray_
    {
        public static dynamic GetTSObject(NormalLineType[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NormalLineType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NormalLineType[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<NormalLineType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NormalLineType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
