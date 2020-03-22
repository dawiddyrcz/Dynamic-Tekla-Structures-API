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

		public System.Int32 Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeriesNullable NumberingSeries
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeriesNullable_.FromTSObject(teklaObject.NumberingSeries);
			set { teklaObject.NumberingSeries = Dynamic.Tekla.Structures.Model.NumberingSeriesNullable_.GetTSObject(value); }
		}

		public System.Double BendingRadius
		{
			get => teklaObject.BendingRadius;
			set { teklaObject.BendingRadius = value; }
		}

        

        internal dynamic teklaObject;

		public RebarPropertiesNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertiesNullable");
		}





    }

    internal static class RebarPropertiesNullable_
    {
        public static dynamic GetTSObject(RebarPropertiesNullable dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarPropertiesNullable FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.RebarPropertiesNullable)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
