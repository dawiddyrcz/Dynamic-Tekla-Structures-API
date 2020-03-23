/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Fitting  : Dynamic.Tekla.Structures.Model.Boolean
    {

		public Dynamic.Tekla.Structures.Model.Plane Plane
		{
			get => Dynamic.Tekla.Structures.Model.Plane_.FromTSObject(teklaObject.Plane);
			set { teklaObject.Plane = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(value); }
		}

        

        

		public Fitting()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Fitting");
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}





    }

    internal static class Fitting_
    {
        public static dynamic GetTSObject(Fitting dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Fitting FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Fitting)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FittingArray_
    {
        public static dynamic GetTSObject(Fitting[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Fitting_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Fitting[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Fitting>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Fitting_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
