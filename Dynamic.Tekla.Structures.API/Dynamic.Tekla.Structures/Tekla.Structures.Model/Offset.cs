/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Offset 
    {

		public System.Double Dx
		{
			get => teklaObject.Dx;
			set { teklaObject.Dx = value; }
		}

		public System.Double Dy
		{
			get => teklaObject.Dy;
			set { teklaObject.Dy = value; }
		}

		public System.Double Dz
		{
			get => teklaObject.Dz;
			set { teklaObject.Dz = value; }
		}

        

        internal dynamic teklaObject;

		public Offset()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Offset");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Offset(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class Offset_
    {
        public static dynamic GetTSObject(Offset dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Offset FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Offset)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class OffsetArray_
    {
        public static dynamic GetTSObject(Offset[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Offset_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Offset[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Offset>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Offset_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
