//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class Polycurve 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(polycurve.StartPoint.GetTSObject());
			set { polycurve.StartPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(polycurve.EndPoint.GetTSObject());
			set { polycurve.EndPoint = value.GetTSObject(); }
		}

		public System.Double Length
		{
			get => polycurve.Length;
			set { polycurve.Length = value; }
		}

        

        dynamic polycurve;
        
        public Polycurve()
        {
            this.polycurve =  new Tekla.Structures.Geometry3d.Polycurve();
        }

        public Polycurve(dynamic tsObject)
        {
            this.polycurve = tsObject;
			this.StartPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(polycurve.StartPoint);
			this.EndPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(polycurve.EndPoint);
			this.Length = polycurve.Length;

        }


        public dynamic GetTSObject() => polycurve;

		public Dynamic.Tekla.Structures.Geometry3d.ICurve Clone()
			 => new Dynamic.Tekla.Structures.Geometry3d.ICurve(polycurve.Clone());

		public System.Boolean Equals(Dynamic.Tekla.Structures.Geometry3d.ICurve other)
			 => polycurve.Equals(other.GetTSObject());

		public System.Collections.Generic.IEnumerator<Dynamic.Tekla.Structures.Geometry3d.ICurve> GetEnumerator()
			 => polycurve.GetEnumerator();

		public System.Boolean Equals(System.Object obj)
			 => polycurve.Equals(obj);

		public System.Int32 GetHashCode()
			 => polycurve.GetHashCode();

		public System.Type GetType()
			 => polycurve.GetType();

		public System.String ToString()
			 => polycurve.ToString();





    }

}
    
