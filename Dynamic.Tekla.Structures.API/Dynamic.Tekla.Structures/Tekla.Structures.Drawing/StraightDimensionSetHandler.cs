/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class StraightDimensionSetHandler 
    {

        

        internal dynamic teklaObject;

		public StraightDimensionSetHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimensionSetHandler");
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection, System.Double Distance, Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes Attributes)
		{
			return Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(teklaObject.CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection), Distance, Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(Attributes)));
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection, System.Double Distance, System.Double LeftTagLineOffset, System.Double RightTagLineOffset, Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes Attributes)
		{
			return Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(teklaObject.CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection), Distance, LeftTagLineOffset, RightTagLineOffset, Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(Attributes)));
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection, System.Double Distance)
		{
			return Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(teklaObject.CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection), Distance));
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection, System.Double Distance, System.Double LeftTagLineOffset, System.Double RightTagLineOffset)
		{
			return Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(teklaObject.CreateDimensionSet(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection), Distance, LeftTagLineOffset, RightTagLineOffset));
		}





    }

    internal static class StraightDimensionSetHandler_
    {
        public static dynamic GetTSObject(StraightDimensionSetHandler dynObject)
        {
            return dynObject.teklaObject;
        }

        public static StraightDimensionSetHandler FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimensionSetHandler)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    