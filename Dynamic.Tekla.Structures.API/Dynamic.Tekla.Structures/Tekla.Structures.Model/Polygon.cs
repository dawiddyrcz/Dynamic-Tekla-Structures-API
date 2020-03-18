//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Polygon 
    {

		public System.Collections.ArrayList Points
		{
			get => polygon.Points;
			set { polygon.Points = value; }
		}

        

        dynamic polygon;
        
        public Polygon()
        {
            this.polygon =  TSActivator.CreateInstance("Tekla.Structures.Model.Polygon");
        }

        public Polygon(dynamic tsObject)
        {
            this.polygon = tsObject;
        }

        internal dynamic GetTSObject() => polygon;





    }

}
    
