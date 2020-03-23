/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PrintAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.String PrinterInstance
		{
			get => teklaObject.PrinterInstance;
			set { teklaObject.PrinterInstance = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintScalingType ScalingType
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.FromTSObject(teklaObject.ScalingType);
			set { teklaObject.ScalingType = Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.GetTSObject(value); }
		}

		public System.Double Scale
		{
			get => teklaObject.Scale;
			set { teklaObject.Scale = value; }
		}

		public System.Boolean PrintToMultipleSheet
		{
			get => teklaObject.PrintToMultipleSheet;
			set { teklaObject.PrintToMultipleSheet = value; }
		}

		public System.Int32 NumberOfCopies
		{
			get => teklaObject.NumberOfCopies;
			set { teklaObject.NumberOfCopies = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType Orientation
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType_.FromTSObject(teklaObject.Orientation);
			set { teklaObject.Orientation = Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintAreaType PrintArea
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintAreaType_.FromTSObject(teklaObject.PrintArea);
			set { teklaObject.PrintArea = Dynamic.Tekla.Structures.Drawing.DotPrintAreaType_.GetTSObject(value); }
		}

        

        

		public PrintAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PrintAttributes");
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PrintAttributes_
    {
        public static dynamic GetTSObject(PrintAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PrintAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.PrintAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    