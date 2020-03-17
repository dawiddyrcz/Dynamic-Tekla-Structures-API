//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public sealed class IFC2X3_ParametricObject_UShapeProfile 
    {

		public System.Double Depth
		{
			get => ifc2x3_parametricobject_ushapeprofile.Depth;
			set { ifc2x3_parametricobject_ushapeprofile.Depth = value; }
		}

		public System.Double FlangeWidth
		{
			get => ifc2x3_parametricobject_ushapeprofile.FlangeWidth;
			set { ifc2x3_parametricobject_ushapeprofile.FlangeWidth = value; }
		}

		public System.Double WebThickness
		{
			get => ifc2x3_parametricobject_ushapeprofile.WebThickness;
			set { ifc2x3_parametricobject_ushapeprofile.WebThickness = value; }
		}

		public System.Double FlangeThickness
		{
			get => ifc2x3_parametricobject_ushapeprofile.FlangeThickness;
			set { ifc2x3_parametricobject_ushapeprofile.FlangeThickness = value; }
		}

		public System.Double FilletRadius
		{
			get => ifc2x3_parametricobject_ushapeprofile.FilletRadius;
			set { ifc2x3_parametricobject_ushapeprofile.FilletRadius = value; }
		}

		public System.Double EdgeRadius
		{
			get => ifc2x3_parametricobject_ushapeprofile.EdgeRadius;
			set { ifc2x3_parametricobject_ushapeprofile.EdgeRadius = value; }
		}

		public System.Double FlangeSlope
		{
			get => ifc2x3_parametricobject_ushapeprofile.FlangeSlope;
			set { ifc2x3_parametricobject_ushapeprofile.FlangeSlope = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(ifc2x3_parametricobject_ushapeprofile.Origin.GetTSObject());
			set { ifc2x3_parametricobject_ushapeprofile.Origin = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_ushapeprofile.xDir.GetTSObject());
			set { ifc2x3_parametricobject_ushapeprofile.xDir = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_ushapeprofile.Extrusion.GetTSObject());
			set { ifc2x3_parametricobject_ushapeprofile.Extrusion = value.GetTSObject(); }
		}

		public System.String ProfileName
		{
			get => ifc2x3_parametricobject_ushapeprofile.ProfileName;
			set { ifc2x3_parametricobject_ushapeprofile.ProfileName = value; }
		}

		public System.String Name
		{
			get => ifc2x3_parametricobject_ushapeprofile.Name;
			set { ifc2x3_parametricobject_ushapeprofile.Name = value; }
		}

		public System.String Description
		{
			get => ifc2x3_parametricobject_ushapeprofile.Description;
			set { ifc2x3_parametricobject_ushapeprofile.Description = value; }
		}

		public System.String ObjectType
		{
			get => ifc2x3_parametricobject_ushapeprofile.ObjectType;
			set { ifc2x3_parametricobject_ushapeprofile.ObjectType = value; }
		}

        

        dynamic ifc2x3_parametricobject_ushapeprofile;
        
        public IFC2X3_ParametricObject_UShapeProfile()
        {
            this.ifc2x3_parametricobject_ushapeprofile =  TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_UShapeProfile");
        }

        public IFC2X3_ParametricObject_UShapeProfile(dynamic tsObject)
        {
            this.ifc2x3_parametricobject_ushapeprofile = tsObject;
			this.Depth = ifc2x3_parametricobject_ushapeprofile.Depth;
			this.FlangeWidth = ifc2x3_parametricobject_ushapeprofile.FlangeWidth;
			this.WebThickness = ifc2x3_parametricobject_ushapeprofile.WebThickness;
			this.FlangeThickness = ifc2x3_parametricobject_ushapeprofile.FlangeThickness;
			this.FilletRadius = ifc2x3_parametricobject_ushapeprofile.FilletRadius;
			this.EdgeRadius = ifc2x3_parametricobject_ushapeprofile.EdgeRadius;
			this.FlangeSlope = ifc2x3_parametricobject_ushapeprofile.FlangeSlope;
			this.Origin = new Dynamic.Tekla.Structures.Geometry3d.Point(ifc2x3_parametricobject_ushapeprofile.Origin);
			this.xDir = new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_ushapeprofile.xDir);
			this.Extrusion = new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_ushapeprofile.Extrusion);
			this.ProfileName = ifc2x3_parametricobject_ushapeprofile.ProfileName;
			this.Name = ifc2x3_parametricobject_ushapeprofile.Name;
			this.Description = ifc2x3_parametricobject_ushapeprofile.Description;
			this.ObjectType = ifc2x3_parametricobject_ushapeprofile.ObjectType;

        }


        public dynamic GetTSObject() => ifc2x3_parametricobject_ushapeprofile;





    }

}
    
