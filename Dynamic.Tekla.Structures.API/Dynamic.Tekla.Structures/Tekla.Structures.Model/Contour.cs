//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class Contour 
    {

		public System.Collections.ArrayList ContourPoints
		{
			get => teklaObject.ContourPoints;
			set { teklaObject.ContourPoints = value; }
		}

        

        internal dynamic teklaObject;

		public Contour()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Contour");
		}

		public void AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint Point)
		{
			return teklaObject.AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint_.GetTSObject(Point));
		}

		public System.Boolean CalculatePolygon(out Dynamic.Tekla.Structures.Model.Polygon polygon)
		{
			return teklaObject.CalculatePolygon(Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(polygon));
		}





    }

    internal static class Contour_
    {
        public static dynamic GetTSObject(Contour dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Contour FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Contour)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
