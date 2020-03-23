/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadUniform  : Dynamic.Tekla.Structures.Model.Load
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
			set { teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.P1);
			set { teklaObject.P1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Double DistanceA
		{
			get => teklaObject.DistanceA;
			set { teklaObject.DistanceA = value; }
		}

        

        

		public LoadUniform()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadUniform");
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

    internal static class LoadUniform_
    {
        public static dynamic GetTSObject(LoadUniform dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LoadUniform FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.LoadUniform)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
