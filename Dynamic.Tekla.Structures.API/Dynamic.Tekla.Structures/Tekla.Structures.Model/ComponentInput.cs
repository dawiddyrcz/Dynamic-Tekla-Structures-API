/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ComponentInput 
    {

		public System.Int32 Count
		{
			get => teklaObject.Count;
			set { teklaObject.Count = value; }
		}

		public System.Boolean IsSynchronized
		{
			get => teklaObject.IsSynchronized;
			set { teklaObject.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => teklaObject.SyncRoot;
			set { teklaObject.SyncRoot = value; }
		}

        

        internal dynamic teklaObject;

		public ComponentInput()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ComponentInput");
		}

		public System.Boolean AddOneInputPosition(Dynamic.Tekla.Structures.Geometry3d.Point P)
		{
			return teklaObject.AddOneInputPosition(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P));
		}

		public System.Boolean AddTwoInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point Position1, Dynamic.Tekla.Structures.Geometry3d.Point Position2)
		{
			return teklaObject.AddTwoInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Position1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Position2));
		}

		public System.Boolean AddInputPolygon(Dynamic.Tekla.Structures.Model.Polygon P)
		{
			return teklaObject.AddInputPolygon(Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(P));
		}

		public System.Boolean AddInputObject(Dynamic.Tekla.Structures.Model.ModelObject M)
		{
			return teklaObject.AddInputObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M));
		}

		public System.Boolean AddInputObjects(System.Collections.ArrayList Objects)
		{
			return teklaObject.AddInputObjects(Objects);
		}

		public void CopyTo(System.Array array, System.Int32 index)
		{
			teklaObject.CopyTo(array, index);
		}





    }

    internal static class ComponentInput_
    {
        public static dynamic GetTSObject(ComponentInput dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ComponentInput FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ComponentInput)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
