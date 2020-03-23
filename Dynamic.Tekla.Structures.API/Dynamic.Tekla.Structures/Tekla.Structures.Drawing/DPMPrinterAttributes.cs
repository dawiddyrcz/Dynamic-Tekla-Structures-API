/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DPMPrinterAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.DotPrintOutputType OutputType
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintOutputType_.FromTSObject(teklaObject.OutputType);
			set { teklaObject.OutputType = Dynamic.Tekla.Structures.Drawing.DotPrintOutputType_.GetTSObject(value); }
		}

		public System.String PrinterName
		{
			get => teklaObject.PrinterName;
			set { teklaObject.PrinterName = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintPaperSize PaperSize
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintPaperSize_.FromTSObject(teklaObject.PaperSize);
			set { teklaObject.PaperSize = Dynamic.Tekla.Structures.Drawing.DotPrintPaperSize_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintScalingType ScalingMethod
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.FromTSObject(teklaObject.ScalingMethod);
			set { teklaObject.ScalingMethod = Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.GetTSObject(value); }
		}

		public System.Double ScaleFactor
		{
			get => teklaObject.ScaleFactor;
			set { teklaObject.ScaleFactor = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType Orientation
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType_.FromTSObject(teklaObject.Orientation);
			set { teklaObject.Orientation = Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType_.GetTSObject(value); }
		}

		public System.Int32 NumberOfCopies
		{
			get => teklaObject.NumberOfCopies;
			set { teklaObject.NumberOfCopies = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintColor ColorMode
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintColor_.FromTSObject(teklaObject.ColorMode);
			set { teklaObject.ColorMode = Dynamic.Tekla.Structures.Drawing.DotPrintColor_.GetTSObject(value); }
		}

		public System.String OutputFileName
		{
			get => teklaObject.OutputFileName;
			set { teklaObject.OutputFileName = value; }
		}

		public System.Boolean OpenFileWhenFinished
		{
			get => teklaObject.OpenFileWhenFinished;
			set { teklaObject.OpenFileWhenFinished = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintToMultipleSheet PrintToMultipleSheet
		{
			get => Dynamic.Tekla.Structures.Drawing.DotPrintToMultipleSheet_.FromTSObject(teklaObject.PrintToMultipleSheet);
			set { teklaObject.PrintToMultipleSheet = Dynamic.Tekla.Structures.Drawing.DotPrintToMultipleSheet_.GetTSObject(value); }
		}

        

        

		public DPMPrinterAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DPMPrinterAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DPMPrinterAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class DPMPrinterAttributes_
    {
        public static dynamic GetTSObject(DPMPrinterAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DPMPrinterAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DPMPrinterAttributesArray_
    {
        public static dynamic GetTSObject(DPMPrinterAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DPMPrinterAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DPMPrinterAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<DPMPrinterAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DPMPrinterAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
