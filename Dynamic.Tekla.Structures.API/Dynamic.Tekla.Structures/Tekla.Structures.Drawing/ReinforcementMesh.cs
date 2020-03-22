/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReinforcementMesh  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementMeshAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementMeshAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementMeshAttributes_.GetTSObject(value); }
		}

		public System.Double ReinforcementCustomPositionLongitudinal
		{
			get => teklaObject.ReinforcementCustomPositionLongitudinal;
			set { teklaObject.ReinforcementCustomPositionLongitudinal = value; }
		}

		public System.Double ReinforcementCustomPositionCrossing
		{
			get => teklaObject.ReinforcementCustomPositionCrossing;
			set { teklaObject.ReinforcementCustomPositionCrossing = value; }
		}

        

        

		public ReinforcementMesh() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementMesh_
    {
        public static dynamic GetTSObject(ReinforcementMesh dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementMesh FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.ReinforcementMesh)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
