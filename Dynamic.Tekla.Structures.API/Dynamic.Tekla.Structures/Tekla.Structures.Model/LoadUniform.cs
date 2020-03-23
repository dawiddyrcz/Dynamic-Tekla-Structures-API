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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LoadUniform(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LoadUniform)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadUniformArray_
    {
        public static dynamic GetTSObject(LoadUniform[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadUniform_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadUniform[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<LoadUniform>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadUniform_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
