//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public sealed class IFC2X3_ParametricObject_RectangleProfile 
    {

		public System.Double XDim
		{
			get => ifc2x3_parametricobject_rectangleprofile.XDim;
			set { ifc2x3_parametricobject_rectangleprofile.XDim = value; }
		}

		public System.Double YDim
		{
			get => ifc2x3_parametricobject_rectangleprofile.YDim;
			set { ifc2x3_parametricobject_rectangleprofile.YDim = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(ifc2x3_parametricobject_rectangleprofile.Origin);
			set { ifc2x3_parametricobject_rectangleprofile.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(ifc2x3_parametricobject_rectangleprofile.xDir);
			set { ifc2x3_parametricobject_rectangleprofile.xDir = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(ifc2x3_parametricobject_rectangleprofile.Extrusion);
			set { ifc2x3_parametricobject_rectangleprofile.Extrusion = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.String ProfileName
		{
			get => ifc2x3_parametricobject_rectangleprofile.ProfileName;
			set { ifc2x3_parametricobject_rectangleprofile.ProfileName = value; }
		}

		public System.String Name
		{
			get => ifc2x3_parametricobject_rectangleprofile.Name;
			set { ifc2x3_parametricobject_rectangleprofile.Name = value; }
		}

		public System.String Description
		{
			get => ifc2x3_parametricobject_rectangleprofile.Description;
			set { ifc2x3_parametricobject_rectangleprofile.Description = value; }
		}

		public System.String ObjectType
		{
			get => ifc2x3_parametricobject_rectangleprofile.ObjectType;
			set { ifc2x3_parametricobject_rectangleprofile.ObjectType = value; }
		}

        

        internal dynamic ifc2x3_parametricobject_rectangleprofile;
        
        public IFC2X3_ParametricObject_RectangleProfile()
        {
            this.ifc2x3_parametricobject_rectangleprofile =  TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_RectangleProfile");
        }

        internal IFC2X3_ParametricObject_RectangleProfile(dynamic tsObject)
        {
            this.ifc2x3_parametricobject_rectangleprofile = tsObject;
        }





    }

    internal static class IFC2X3_ParametricObject_RectangleProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_RectangleProfile dynObject)
        {
            return dynObject.ifc2x3_parametricobject_rectangleprofile;
        }

        public static IFC2X3_ParametricObject_RectangleProfile FromTSObject(dynamic tsObject)
        {
            return new IFC2X3_ParametricObject_RectangleProfile(tsObject);
        }
    }


}
    