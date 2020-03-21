//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class IFC2X3_ParametricObject_CircleProfile  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public System.Double Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
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

		public IFC2X3_ParametricObject_CircleProfile() {}





    }

    internal static class IFC2X3_ParametricObject_CircleProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_CircleProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_CircleProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_CircleProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
