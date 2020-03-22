/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PlacingQuarterAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean TopLeft
		{
			get => teklaObject.TopLeft;
			set { teklaObject.TopLeft = value; }
		}

		public System.Boolean TopRight
		{
			get => teklaObject.TopRight;
			set { teklaObject.TopRight = value; }
		}

		public System.Boolean BottomLeft
		{
			get => teklaObject.BottomLeft;
			set { teklaObject.BottomLeft = value; }
		}

		public System.Boolean BottomRight
		{
			get => teklaObject.BottomRight;
			set { teklaObject.BottomRight = value; }
		}

        

        

		public PlacingQuarterAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingQuarterAttributes");
		}
		public PlacingQuarterAttributes(System.Boolean TopLeft, System.Boolean TopRight, System.Boolean BottomLeft, System.Boolean BottomRight)
		{
			var args = new object[4];
			args[0] = TopLeft;
			args[1] = TopRight;
			args[2] = BottomLeft;
			args[3] = BottomRight;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingQuarterAttributes", args);
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

    internal static class PlacingQuarterAttributes_
    {
        public static dynamic GetTSObject(PlacingQuarterAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlacingQuarterAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PlacingQuarterAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
