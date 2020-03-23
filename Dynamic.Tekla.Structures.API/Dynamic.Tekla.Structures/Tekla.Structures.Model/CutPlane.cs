/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class CutPlane  : Dynamic.Tekla.Structures.Model.Boolean
    {

		public Dynamic.Tekla.Structures.Model.Plane Plane
		{
			get => Dynamic.Tekla.Structures.Model.Plane_.FromTSObject(teklaObject.Plane);
			set { teklaObject.Plane = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(value); }
		}

        

        

		public CutPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CutPlane");
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

    internal static class CutPlane_
    {
        public static dynamic GetTSObject(CutPlane dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CutPlane FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.CutPlane)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CutPlaneArray_
    {
        public static dynamic GetTSObject(CutPlane[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CutPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CutPlane[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CutPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CutPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
