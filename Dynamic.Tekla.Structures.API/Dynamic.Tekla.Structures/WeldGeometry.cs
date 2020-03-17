//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Welding
{

    public sealed class WeldGeometry 
    {

		public Dynamic.Tekla.Structures.Model.Welding.WeldSeamPositionEnum Position
		{
			get => Dynamic.Tekla.Structures.Model.Welding.WeldSeamPositionEnum_.FromTSObject(weldgeometry.Position);
			set { weldgeometry.Position = Dynamic.Tekla.Structures.Model.Welding.WeldSeamPositionEnum_.FromTSObject(value); }
		}

		public System.Collections.ArrayList Polygons
		{
			get => weldgeometry.Polygons;
			set { weldgeometry.Polygons = value; }
		}

        

        dynamic weldgeometry;
        
        public WeldGeometry()
        {
            this.weldgeometry =  TSActivator.CreateInstance("Tekla.Structures.Model.Welding.WeldGeometry");
        }

        public WeldGeometry(dynamic tsObject)
        {
            this.weldgeometry = tsObject;
			this.Position = Dynamic.Tekla.Structures.Model.Welding.WeldSeamPositionEnum_.FromTSObject(weldgeometry.Position);
			this.Polygons = weldgeometry.Polygons;

        }


        public dynamic GetTSObject() => weldgeometry;





    }

}
    
