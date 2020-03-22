/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public abstract class ISolid 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point MinimumPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.MinimumPoint);
			set { teklaObject.MinimumPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point MaximumPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.MaximumPoint);
			set { teklaObject.MaximumPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.FaceEnumerator_.FromTSObject(teklaObject.GetFaceEnumerator());
		}

		public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.EdgeEnumerator_.FromTSObject(teklaObject.GetEdgeEnumerator());
		}





    }

    internal static class ISolid_
    {
        public static dynamic GetTSObject(ISolid dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ISolid FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Solid.ISolid)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
