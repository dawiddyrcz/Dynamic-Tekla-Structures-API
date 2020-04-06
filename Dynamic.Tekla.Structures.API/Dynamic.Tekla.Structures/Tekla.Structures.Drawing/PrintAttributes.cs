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
			get
			{
				try {
					return teklaObject.PrinterInstance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrinterInstance", ex); }
			}
			set
			{
				try {
					teklaObject.PrinterInstance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrinterInstance", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DotPrintScalingType ScalingType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.FromTSObject(teklaObject.ScalingType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScalingType", ex); }
			}
			set
			{
				try {
				teklaObject.ScalingType = Dynamic.Tekla.Structures.Drawing.DotPrintScalingType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScalingType", ex); }
			}
		}

		public System.Double Scale
		{
			get
			{
				try {
					return teklaObject.Scale;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scale", ex); }
			}
			set
			{
				try {
					teklaObject.Scale = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scale", ex); }
			}
		}

		public System.Boolean PrintToMultipleSheet
		{
			get
			{
				try {
					return teklaObject.PrintToMultipleSheet;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrintToMultipleSheet", ex); }
			}
			set
			{
				try {
					teklaObject.PrintToMultipleSheet = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrintToMultipleSheet", ex); }
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

		public Dynamic.Tekla.Structures.Drawing.DotPrintAreaType PrintArea
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DotPrintAreaType_.FromTSObject(teklaObject.PrintArea);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrintArea", ex); }
			}
			set
			{
				try {
				teklaObject.PrintArea = Dynamic.Tekla.Structures.Drawing.DotPrintAreaType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrintArea", ex); }
			}
		}

        

        

		public PrintAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PrintAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PrintAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class PrintAttributes_
    {
        public static dynamic GetTSObject(PrintAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PrintAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PrintAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PrintAttributesArray_
    {
        public static dynamic GetTSObject(PrintAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PrintAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PrintAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PrintAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PrintAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
