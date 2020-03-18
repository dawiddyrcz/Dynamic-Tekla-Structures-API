//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public sealed class IFC2X3_ParametricObject_RectangleHollowProfile 
    {

		public System.Double XDim
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.XDim;
			set { ifc2x3_parametricobject_rectanglehollowprofile.XDim = value; }
		}

		public System.Double YDim
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.YDim;
			set { ifc2x3_parametricobject_rectanglehollowprofile.YDim = value; }
		}

		public System.Double WallThickness
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.WallThickness;
			set { ifc2x3_parametricobject_rectanglehollowprofile.WallThickness = value; }
		}

		public System.Double InnerFilletRadius
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.InnerFilletRadius;
			set { ifc2x3_parametricobject_rectanglehollowprofile.InnerFilletRadius = value; }
		}

		public System.Double OuterFilletRadius
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.OuterFilletRadius;
			set { ifc2x3_parametricobject_rectanglehollowprofile.OuterFilletRadius = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(ifc2x3_parametricobject_rectanglehollowprofile.Origin);
			set { ifc2x3_parametricobject_rectanglehollowprofile.Origin = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_rectanglehollowprofile.xDir);
			set { ifc2x3_parametricobject_rectanglehollowprofile.xDir = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(ifc2x3_parametricobject_rectanglehollowprofile.Extrusion);
			set { ifc2x3_parametricobject_rectanglehollowprofile.Extrusion = value.GetTSObject(); }
		}

		public System.String ProfileName
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.ProfileName;
			set { ifc2x3_parametricobject_rectanglehollowprofile.ProfileName = value; }
		}

		public System.String Name
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.Name;
			set { ifc2x3_parametricobject_rectanglehollowprofile.Name = value; }
		}

		public System.String Description
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.Description;
			set { ifc2x3_parametricobject_rectanglehollowprofile.Description = value; }
		}

		public System.String ObjectType
		{
			get => ifc2x3_parametricobject_rectanglehollowprofile.ObjectType;
			set { ifc2x3_parametricobject_rectanglehollowprofile.ObjectType = value; }
		}

        

        dynamic ifc2x3_parametricobject_rectanglehollowprofile;
        
        public IFC2X3_ParametricObject_RectangleHollowProfile()
        {
            this.ifc2x3_parametricobject_rectanglehollowprofile =  TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_RectangleHollowProfile");
        }

        public IFC2X3_ParametricObject_RectangleHollowProfile(dynamic tsObject)
        {
            this.ifc2x3_parametricobject_rectanglehollowprofile = tsObject;
        }

        internal dynamic GetTSObject() => ifc2x3_parametricobject_rectanglehollowprofile;





    }

}
    
