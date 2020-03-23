/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarThreadingDataNullable 
    {

		public System.String ThreadingType
		{
			get => teklaObject.ThreadingType;
			set { teklaObject.ThreadingType = value; }
		}

		public System.Nullable<System.Double> Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public System.Nullable<System.Double> ExtraFabricationLength
		{
			get => teklaObject.ExtraFabricationLength;
			set { teklaObject.ExtraFabricationLength = value; }
		}

        

        internal dynamic teklaObject;

		public RebarThreadingDataNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarThreadingDataNullable");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarThreadingDataNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RebarThreadingDataNullable_
    {
        public static dynamic GetTSObject(RebarThreadingDataNullable dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static RebarThreadingDataNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarThreadingDataNullableArray_
    {
        public static dynamic GetTSObject(RebarThreadingDataNullable[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarThreadingDataNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarThreadingDataNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<RebarThreadingDataNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarThreadingDataNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
