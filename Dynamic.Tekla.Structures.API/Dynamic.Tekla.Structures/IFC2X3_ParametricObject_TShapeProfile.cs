//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public sealed class IFC2X3_ParametricObject_TShapeProfile 
    {

		public System.Double Depth
		{
			get => ifc2x3_parametricobject_tshapeprofile.Depth;
			set { ifc2x3_parametricobject_tshapeprofile.Depth = value; }
		}

		public System.Double FlangeWidth
		{
			get => ifc2x3_parametricobject_tshapeprofile.FlangeWidth;
			set { ifc2x3_parametricobject_tshapeprofile.FlangeWidth = value; }
		}

		public System.Double WebThickness
		{
			get => ifc2x3_parametricobject_tshapeprofile.WebThickness;
			set { ifc2x3_parametricobject_tshapeprofile.WebThickness = value; }
		}

		public System.Double FlangeThickness
		{
			get => ifc2x3_parametricobject_tshapeprofile.FlangeThickness;
			set { ifc2x3_parametricobject_tshapeprofile.FlangeThickness = value; }
		}

		public System.Double FilletRadius
		{
			get => ifc2x3_parametricobject_tshapeprofile.FilletRadius;
			set { ifc2x3_parametricobject_tshapeprofile.FilletRadius = value; }
		}

		public System.Double FlangeEdgeRadius
		{
			get => ifc2x3_parametricobject_tshapeprofile.FlangeEdgeRadius;
			set { ifc2x3_parametricobject_tshapeprofile.FlangeEdgeRadius = value; }
		}

		public System.Double WebEdgeRadius
		{
			get => ifc2x3_parametricobject_tshapeprofile.WebEdgeRadius;
			set { ifc2x3_parametricobject_tshapeprofile.WebEdgeRadius = value; }
		}

		public System.Double WebSlope
		{
			get => ifc2x3_parametricobject_tshapeprofile.WebSlope;
			set { ifc2x3_parametricobject_tshapeprofile.WebSlope = value; }
		}

		public System.Double FlangeSlope
		{
			get => ifc2x3_parametricobject_tshapeprofile.FlangeSlope;
			set { ifc2x3_parametricobject_tshapeprofile.FlangeSlope = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(ifc2x3_parametricobject_tshapeprofile.Origin.GetTSObject());
			set { ifc2x3_parametricobject_tshapeprofile.Origin = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_tshapeprofile.xDir.GetTSObject());
			set { ifc2x3_parametricobject_tshapeprofile.xDir = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_tshapeprofile.Extrusion.GetTSObject());
			set { ifc2x3_parametricobject_tshapeprofile.Extrusion = value.GetTSObject(); }
		}

		public System.String ProfileName
		{
			get => ifc2x3_parametricobject_tshapeprofile.ProfileName;
			set { ifc2x3_parametricobject_tshapeprofile.ProfileName = value; }
		}

		public System.String Name
		{
			get => ifc2x3_parametricobject_tshapeprofile.Name;
			set { ifc2x3_parametricobject_tshapeprofile.Name = value; }
		}

		public System.String Description
		{
			get => ifc2x3_parametricobject_tshapeprofile.Description;
			set { ifc2x3_parametricobject_tshapeprofile.Description = value; }
		}

		public System.String ObjectType
		{
			get => ifc2x3_parametricobject_tshapeprofile.ObjectType;
			set { ifc2x3_parametricobject_tshapeprofile.ObjectType = value; }
		}

        

        dynamic ifc2x3_parametricobject_tshapeprofile;
        
        public IFC2X3_ParametricObject_TShapeProfile()
        {
            this.ifc2x3_parametricobject_tshapeprofile =  new Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_TShapeProfile();
        }

        public IFC2X3_ParametricObject_TShapeProfile(dynamic tsObject)
        {
            this.ifc2x3_parametricobject_tshapeprofile = tsObject;
			this.Depth = ifc2x3_parametricobject_tshapeprofile.Depth;
			this.FlangeWidth = ifc2x3_parametricobject_tshapeprofile.FlangeWidth;
			this.WebThickness = ifc2x3_parametricobject_tshapeprofile.WebThickness;
			this.FlangeThickness = ifc2x3_parametricobject_tshapeprofile.FlangeThickness;
			this.FilletRadius = ifc2x3_parametricobject_tshapeprofile.FilletRadius;
			this.FlangeEdgeRadius = ifc2x3_parametricobject_tshapeprofile.FlangeEdgeRadius;
			this.WebEdgeRadius = ifc2x3_parametricobject_tshapeprofile.WebEdgeRadius;
			this.WebSlope = ifc2x3_parametricobject_tshapeprofile.WebSlope;
			this.FlangeSlope = ifc2x3_parametricobject_tshapeprofile.FlangeSlope;
			this.Origin = new Dynamic.Tekla.Structures.Geometry3d.Point(ifc2x3_parametricobject_tshapeprofile.Origin);
			this.xDir = new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_tshapeprofile.xDir);
			this.Extrusion = new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_tshapeprofile.Extrusion);
			this.ProfileName = ifc2x3_parametricobject_tshapeprofile.ProfileName;
			this.Name = ifc2x3_parametricobject_tshapeprofile.Name;
			this.Description = ifc2x3_parametricobject_tshapeprofile.Description;
			this.ObjectType = ifc2x3_parametricobject_tshapeprofile.ObjectType;

        }


        public dynamic GetTSObject() => ifc2x3_parametricobject_tshapeprofile;





    }

}
    
