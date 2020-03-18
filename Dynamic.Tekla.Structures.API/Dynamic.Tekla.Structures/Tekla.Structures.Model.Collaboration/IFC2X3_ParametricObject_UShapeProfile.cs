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
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(ifc2x3_parametricobject_ushapeprofile.Origin);
			set { ifc2x3_parametricobject_ushapeprofile.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(ifc2x3_parametricobject_ushapeprofile.xDir);
			set { ifc2x3_parametricobject_ushapeprofile.xDir = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(ifc2x3_parametricobject_ushapeprofile.Extrusion);
			set { ifc2x3_parametricobject_ushapeprofile.Extrusion = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
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

        

        internal dynamic ifc2x3_parametricobject_ushapeprofile;
        
        public IFC2X3_ParametricObject_UShapeProfile()
        {
            this.ifc2x3_parametricobject_ushapeprofile =  TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_UShapeProfile");
        }

        internal IFC2X3_ParametricObject_UShapeProfile(dynamic tsObject)
        {
            this.ifc2x3_parametricobject_ushapeprofile = tsObject;
        }





    }

    internal static class IFC2X3_ParametricObject_UShapeProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_UShapeProfile dynObject)
        {
            return dynObject.ifc2x3_parametricobject_ushapeprofile;
        }

        public static IFC2X3_ParametricObject_UShapeProfile FromTSObject(dynamic tsObject)
        {
            return new IFC2X3_ParametricObject_UShapeProfile(tsObject);
        }
    }


}
    
