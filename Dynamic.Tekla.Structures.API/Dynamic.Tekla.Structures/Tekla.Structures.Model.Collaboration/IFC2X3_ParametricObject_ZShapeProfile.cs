//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_ZShapeProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double Depth
		{
			get => teklaObject.Depth;
			set { teklaObject.Depth = value; }
		}

		public System.Double FlangeWidth
		{
			get => teklaObject.FlangeWidth;
			set { teklaObject.FlangeWidth = value; }
		}

		public System.Double WebThickness
		{
			get => teklaObject.WebThickness;
			set { teklaObject.WebThickness = value; }
		}

		public System.Double FlangeThickness
		{
			get => teklaObject.FlangeThickness;
			set { teklaObject.FlangeThickness = value; }
		}

		public System.Double FilletRadius
		{
			get => teklaObject.FilletRadius;
			set { teklaObject.FilletRadius = value; }
		}

		public System.Double EdgeRadius
		{
			get => teklaObject.EdgeRadius;
			set { teklaObject.EdgeRadius = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
			set { teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.xDir);
			set { teklaObject.xDir = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Extrusion);
			set { teklaObject.Extrusion = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.String ProfileName
		{
			get => teklaObject.ProfileName;
			set { teklaObject.ProfileName = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Description
		{
			get => teklaObject.Description;
			set { teklaObject.Description = value; }
		}

		public System.String ObjectType
		{
			get => teklaObject.ObjectType;
			set { teklaObject.ObjectType = value; }
		}

        

        internal dynamic teklaObject;

		internal IFC2X3_ParametricObject_ZShapeProfile() {}





    }

    internal static class IFC2X3_ParametricObject_ZShapeProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_ZShapeProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_ZShapeProfile FromTSObject(dynamic tsObject)
        {
            return new IFC2X3_ParametricObject_ZShapeProfile() { teklaObject = tsObject };
        }
    }


}
    
