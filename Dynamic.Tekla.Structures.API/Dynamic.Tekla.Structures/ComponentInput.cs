//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ComponentInput 
    {

		public System.Int32 Count
		{
			get => componentinput.Count;
			set { componentinput.Count = value; }
		}

		public System.Boolean IsSynchronized
		{
			get => componentinput.IsSynchronized;
			set { componentinput.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => componentinput.SyncRoot;
			set { componentinput.SyncRoot = value; }
		}

        

        dynamic componentinput;
        
        public ComponentInput()
        {
            this.componentinput =  new Tekla.Structures.Model.ComponentInput();
        }

        public ComponentInput(dynamic tsObject)
        {
            this.componentinput = tsObject;
			this.Count = componentinput.Count;
			this.IsSynchronized = componentinput.IsSynchronized;
			this.SyncRoot = componentinput.SyncRoot;

        }


        public dynamic GetTSObject() => componentinput;

		public System.Boolean AddOneInputPosition(Dynamic.Tekla.Structures.Geometry3d.Point P)
			 => componentinput.AddOneInputPosition(P.GetTSObject());

		public System.Boolean AddTwoInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point Position1, Dynamic.Tekla.Structures.Geometry3d.Point Position2)
			 => componentinput.AddTwoInputPositions(Position1.GetTSObject(), Position2.GetTSObject());

		public System.Boolean AddInputPolygon(Dynamic.Tekla.Structures.Model.Polygon P)
			 => componentinput.AddInputPolygon(P.GetTSObject());

		public System.Boolean AddInputObject(Dynamic.Tekla.Structures.Model.ModelObject M)
			 => componentinput.AddInputObject(M.GetTSObject());

		public System.Boolean AddInputObjects(System.Collections.ArrayList Objects)
			 => componentinput.AddInputObjects(Objects);

		public void CopyTo(System.Array array, System.Int32 index)
			 => componentinput.CopyTo(array, index);

		public System.Collections.IEnumerator GetEnumerator()
			 => componentinput.GetEnumerator();

		public System.Boolean Equals(System.Object obj)
			 => componentinput.Equals(obj);

		public System.Int32 GetHashCode()
			 => componentinput.GetHashCode();

		public System.Type GetType()
			 => componentinput.GetType();

		public System.String ToString()
			 => componentinput.ToString();





    }

}
    
