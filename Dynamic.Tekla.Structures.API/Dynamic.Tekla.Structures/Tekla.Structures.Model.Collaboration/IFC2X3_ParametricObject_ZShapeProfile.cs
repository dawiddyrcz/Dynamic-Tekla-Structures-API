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

        

        

		public IFC2X3_ParametricObject_ZShapeProfile() {}





    }

    internal static class IFC2X3_ParametricObject_ZShapeProfile_
    {
        public static dynamic GetTSObject(IFC2X3_ParametricObject_ZShapeProfile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IFC2X3_ParametricObject_ZShapeProfile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Collaboration.IFC2X3_ParametricObject_ZShapeProfile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
