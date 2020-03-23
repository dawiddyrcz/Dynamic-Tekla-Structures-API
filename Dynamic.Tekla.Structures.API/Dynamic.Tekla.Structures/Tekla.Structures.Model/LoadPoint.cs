/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadPoint  : Dynamic.Tekla.Structures.Model.Load
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Position
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.P);
			set { teklaObject.P = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Moment
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Moment);
			set { teklaObject.Moment = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        

		public LoadPoint()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadPoint");
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

    internal static class LoadPoint_
    {
        public static dynamic GetTSObject(LoadPoint dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LoadPoint FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.LoadPoint)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadPointArray_
    {
        public static dynamic GetTSObject(LoadPoint[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadPoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadPoint[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<LoadPoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadPoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
