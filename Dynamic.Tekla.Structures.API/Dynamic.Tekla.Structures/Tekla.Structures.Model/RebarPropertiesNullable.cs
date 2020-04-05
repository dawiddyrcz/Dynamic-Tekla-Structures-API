/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarPropertiesNullable 
    {

		public System.String Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public System.String Grade
		{
			get => teklaObject.Grade;
			set { teklaObject.Grade = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Nullable<System.Int32> Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeriesNullable NumberingSeries
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeriesNullable_.FromTSObject(teklaObject.NumberingSeries);
			set { teklaObject.NumberingSeries = Dynamic.Tekla.Structures.Model.NumberingSeriesNullable_.GetTSObject(value); }
		}

		public System.Nullable<System.Double> BendingRadius
		{
			get => teklaObject.BendingRadius;
			set { teklaObject.BendingRadius = value; }
		}

        

        internal dynamic teklaObject;

		public RebarPropertiesNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertiesNullable");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarPropertiesNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RebarPropertiesNullable_
    {
        public static dynamic GetTSObject(RebarPropertiesNullable dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarPropertiesNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarPropertiesNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarPropertiesNullableArray_
    {
        public static dynamic GetTSObject(RebarPropertiesNullable[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarPropertiesNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarPropertiesNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarPropertiesNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarPropertiesNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
