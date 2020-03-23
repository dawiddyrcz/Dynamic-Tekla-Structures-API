/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarHookDataNullable 
    {

		public System.Nullable<Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum> Shape
		{
			get => teklaObject.Shape;
			set { teklaObject.Shape = value; }
		}

		public System.Nullable<System.Double> Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public System.Nullable<System.Double> Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
		}

		public System.Nullable<System.Double> Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public System.Nullable<System.Double> Rotation
		{
			get => teklaObject.Rotation;
			set { teklaObject.Rotation = value; }
		}

        

        internal dynamic teklaObject;

		public RebarHookDataNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookDataNullable");
		}





    }

    internal static class RebarHookDataNullable_
    {
        public static dynamic GetTSObject(RebarHookDataNullable dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarHookDataNullable FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.RebarHookDataNullable)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarHookDataNullableArray_
    {
        public static dynamic GetTSObject(RebarHookDataNullable[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarHookDataNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarHookDataNullable[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RebarHookDataNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarHookDataNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
