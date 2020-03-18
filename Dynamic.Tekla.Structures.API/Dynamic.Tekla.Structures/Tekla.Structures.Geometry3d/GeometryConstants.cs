//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class GeometryConstants 
    {

        

        internal dynamic geometryconstants;
        
        public GeometryConstants()
        {
            this.geometryconstants =  TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometryConstants");
        }

        internal GeometryConstants(dynamic tsObject)
        {
            this.geometryconstants = tsObject;
        }





    }

    internal static class GeometryConstants_
    {
        public static dynamic GetTSObject(GeometryConstants dynObject)
        {
            return dynObject.geometryconstants;
        }

        public static GeometryConstants FromTSObject(dynamic tsObject)
        {
            return new GeometryConstants(tsObject);
        }
    }


}
    