/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PlacingDistanceAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Double SearchMargin
		{
			get => teklaObject.SearchMargin;
			set { teklaObject.SearchMargin = value; }
		}

		public System.Double MinimalDistance
		{
			get => teklaObject.MinimalDistance;
			set { teklaObject.MinimalDistance = value; }
		}

		public System.Double MaximalDistance
		{
			get => teklaObject.MaximalDistance;
			set { teklaObject.MaximalDistance = value; }
		}

        

        

		public PlacingDistanceAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDistanceAttributes");
		}
		public PlacingDistanceAttributes(System.Double searchMargin, System.Double minimalDistance)
		{
			var args = new object[2];
			args[0] = searchMargin;
			args[1] = minimalDistance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDistanceAttributes", args);
		}
		public PlacingDistanceAttributes(System.Double searchMargin, System.Double minimalDistance, System.Double maximalDistance)
		{
			var args = new object[3];
			args[0] = searchMargin;
			args[1] = minimalDistance;
			args[2] = maximalDistance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDistanceAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class PlacingDistanceAttributes_
    {
        public static dynamic GetTSObject(PlacingDistanceAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlacingDistanceAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PlacingDistanceAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
