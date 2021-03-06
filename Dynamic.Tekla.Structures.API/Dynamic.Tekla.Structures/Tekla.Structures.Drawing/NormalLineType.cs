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

    public  class NormalLineType  : Dynamic.Tekla.Structures.Drawing.LineTypes
    {

        

        

		internal NormalLineType() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NormalLineType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


		public static System.Boolean operator ==(Dynamic.Tekla.Structures.Drawing.NormalLineType o1, Dynamic.Tekla.Structures.Drawing.NormalLineType o2)
		{
			if(System.Object.ReferenceEquals(o1, null)) return System.Object.ReferenceEquals(o2, null);
			var o1Tek = Dynamic.Tekla.Structures.Drawing.NormalLineType_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Drawing.NormalLineType_.GetTSObject(o2);
			return o1Tek == o2Tek;
		}
		public static System.Boolean operator !=(Dynamic.Tekla.Structures.Drawing.NormalLineType o1, Dynamic.Tekla.Structures.Drawing.NormalLineType o2)
		{
			return !(o1 == o2);
		}



    }

    internal static class NormalLineType_
    {
        public static dynamic GetTSObject(NormalLineType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static NormalLineType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NormalLineType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NormalLineType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<NormalLineType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NormalLineType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
