/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PolygonWeld  : Dynamic.Tekla.Structures.Model.BaseWeld
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
			set { teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

        

        

		public PolygonWeld()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolygonWeld");
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

		public System.Boolean GetLogicalWeld(ref Dynamic.Tekla.Structures.Model.LogicalWeld LogicalWeld)
		{
			return teklaObject.GetLogicalWeld(Dynamic.Tekla.Structures.Model.LogicalWeld_.GetTSObject(LogicalWeld));
		}





    }

    internal static class PolygonWeld_
    {
        public static dynamic GetTSObject(PolygonWeld dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PolygonWeld FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.PolygonWeld)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
