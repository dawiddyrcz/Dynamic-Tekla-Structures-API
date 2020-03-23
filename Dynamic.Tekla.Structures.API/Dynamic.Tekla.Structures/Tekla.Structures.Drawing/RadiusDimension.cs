/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class RadiusDimension  : Dynamic.Tekla.Structures.Drawing.DimensionBase
    {

		public Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes_.GetTSObject(value); }
		}

		public System.Double Distance
		{
			get => teklaObject.Distance;
			set { teklaObject.Distance = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint1);
			set { teklaObject.ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint2);
			set { teklaObject.ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcPoint3);
			set { teklaObject.ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public RadiusDimension() {}
		public RadiusDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, System.Double Distance)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3);
			args[4] = Distance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.RadiusDimension", args);
		}
		public RadiusDimension(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, System.Double Distance, Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes Attributes)
		{
			var args = new object[6];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3);
			args[4] = Distance;
			args[5] = Dynamic.Tekla.Structures.Drawing.RadiusDimensionAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.RadiusDimension", args);
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBase GetDimensionSet()
		{
			return Dynamic.Tekla.Structures.Drawing.DimensionSetBase_.FromTSObject(teklaObject.GetDimensionSet());
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBase GetDimensionSet(System.Boolean Select)
		{
			return Dynamic.Tekla.Structures.Drawing.DimensionSetBase_.FromTSObject(teklaObject.GetDimensionSet(Select));
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}





    }

    internal static class RadiusDimension_
    {
        public static dynamic GetTSObject(RadiusDimension dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RadiusDimension FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.RadiusDimension)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    