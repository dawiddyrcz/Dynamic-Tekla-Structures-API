//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public sealed class ParametricObject_CustomProfile 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parametricobject_customprofile.Origin);
			set { parametricobject_customprofile.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector xDir
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(parametricobject_customprofile.xDir);
			set { parametricobject_customprofile.xDir = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Extrusion
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(parametricobject_customprofile.Extrusion);
			set { parametricobject_customprofile.Extrusion = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.String ProfileName
		{
			get => parametricobject_customprofile.ProfileName;
			set { parametricobject_customprofile.ProfileName = value; }
		}

		public System.String Name
		{
			get => parametricobject_customprofile.Name;
			set { parametricobject_customprofile.Name = value; }
		}

		public System.String Description
		{
			get => parametricobject_customprofile.Description;
			set { parametricobject_customprofile.Description = value; }
		}

		public System.String ObjectType
		{
			get => parametricobject_customprofile.ObjectType;
			set { parametricobject_customprofile.ObjectType = value; }
		}

        

        internal dynamic parametricobject_customprofile;
        
        public ParametricObject_CustomProfile()
        {
            this.parametricobject_customprofile =  TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.ParametricObject_CustomProfile");
        }

        internal ParametricObject_CustomProfile(dynamic tsObject)
        {
            this.parametricobject_customprofile = tsObject;
        }





    }

    internal static class ParametricObject_CustomProfile_
    {
        public static dynamic GetTSObject(ParametricObject_CustomProfile dynObject)
        {
            return dynObject.parametricobject_customprofile;
        }

        public static ParametricObject_CustomProfile FromTSObject(dynamic tsObject)
        {
            return new ParametricObject_CustomProfile(tsObject);
        }
    }


}
    