/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PlacingAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean IsFixed
		{
			get => teklaObject.IsFixed;
			set { teklaObject.IsFixed = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes PlacingDistance
		{
			get => Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.FromTSObject(teklaObject.PlacingDistance);
			set { teklaObject.PlacingDistance = Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes PlacingQuarter
		{
			get => Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes_.FromTSObject(teklaObject.PlacingQuarter);
			set { teklaObject.PlacingQuarter = Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes_.GetTSObject(value); }
		}

        

        

		public PlacingAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingAttributes");
		}
		public PlacingAttributes(System.Boolean IsFixed, Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes PlacingDistance, Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes PlacingQuarter)
		{
			var args = new object[3];
			args[0] = IsFixed;
			args[1] = Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.GetTSObject(PlacingDistance);
			args[2] = Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes_.GetTSObject(PlacingQuarter);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingAttributes", args);
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

    internal static class PlacingAttributes_
    {
        public static dynamic GetTSObject(PlacingAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlacingAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
