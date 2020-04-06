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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintOutputType_.FromTSObject(teklaObject.OutputType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputType", ex); }
			}
			set
			{
				try {
				teklaObject.OutputType = Dynamic.Tekla.Structures.Drawing.DotPrintOutputType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputType", ex); }
			}
		}

		public System.String PrinterName
		{
			get
			{
				try {
					return teklaObject.PrinterName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrinterName", ex); }
			}
			set
			{
				try {
					teklaObject.PrinterName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrinterName", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintPaperSize PaperSize
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintPaperSize_.FromTSObject(teklaObject.PaperSize);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PaperSize", ex); }
			}
			set
			{
				try {
				teklaObject.PaperSize = Dynamic.Tekla.Structures.Drawing.DotPrintPaperSize_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PaperSize", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintScalingType ScalingMethod
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.FromTSObject(teklaObject.ScalingMethod);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScalingMethod", ex); }
			}
			set
			{
				try {
				teklaObject.ScalingMethod = Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScalingMethod", ex); }
			}
		}

		public System.Double ScaleFactor
		{
			get
			{
				try {
					return teklaObject.ScaleFactor;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScaleFactor", ex); }
			}
			set
			{
				try {
					teklaObject.ScaleFactor = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScaleFactor", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType Orientation
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType_.FromTSObject(teklaObject.Orientation);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Orientation", ex); }
			}
			set
			{
				try {
				teklaObject.Orientation = Dynamic.Tekla.Structures.Drawing.DotPrintOrientationType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Orientation", ex); }
			}
		}

		public System.Int32 NumberOfCopies
		{
			get
			{
				try {
					return teklaObject.NumberOfCopies;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NumberOfCopies", ex); }
			}
			set
			{
				try {
					teklaObject.NumberOfCopies = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NumberOfCopies", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintColor ColorMode
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintColor_.FromTSObject(teklaObject.ColorMode);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ColorMode", ex); }
			}
			set
			{
				try {
				teklaObject.ColorMode = Dynamic.Tekla.Structures.Drawing.DotPrintColor_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ColorMode", ex); }
			}
		}

		public System.String OutputFileName
		{
			get
			{
				try {
					return teklaObject.OutputFileName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputFileName", ex); }
			}
			set
			{
				try {
					teklaObject.OutputFileName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputFileName", ex); }
			}
		}

		public System.Boolean OpenFileWhenFinished
		{
			get
			{
				try {
					return teklaObject.OpenFileWhenFinished;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OpenFileWhenFinished", ex); }
			}
			set
			{
				try {
					teklaObject.OpenFileWhenFinished = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OpenFileWhenFinished", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintToMultipleSheet PrintToMultipleSheet
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintToMultipleSheet_.FromTSObject(teklaObject.PrintToMultipleSheet);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrintToMultipleSheet", ex); }
			}
			set
			{
				try {
				teklaObject.PrintToMultipleSheet = Dynamic.Tekla.Structures.Drawing.DotPrintToMultipleSheet_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrintToMultipleSheet", ex); }
			}
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





    }

    internal static class DPMPrinterAttributes_
    {
        public static dynamic GetTSObject(DPMPrinterAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DPMPrinterAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DPMPrinterAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DPMPrinterAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DPMPrinterAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DPMPrinterAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
