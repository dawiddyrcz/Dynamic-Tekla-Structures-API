/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DrawingHandler 
    {

		public static Dynamic.Tekla.Structures.Drawing.DrawingHandler Instance
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingHandler_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.DrawingHandler","Instance"));

		}

        

        internal dynamic teklaObject;

		public DrawingHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingHandler");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean GetConnectionStatus()
		{
			try {
			return teklaObject.GetConnectionStatus();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetConnectionStatus()"); }
		}

		public static Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum SetMessageExecutionStatus(Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum mode)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum_.GetTSObject(mode);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.DrawingHandler", "SetMessageExecutionStatus", parameters);
			return Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum GetMessageExecutionStatus()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.DrawingHandler", "GetMessageExecutionStatus", parameters);
			return Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum_.FromTSObject(result);
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingEnumerator GetDrawings()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingEnumerator_.FromTSObject(teklaObject.GetDrawings());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDrawings()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.UI.DrawingSelector GetDrawingSelector()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.UI.DrawingSelector_.FromTSObject(teklaObject.GetDrawingSelector());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDrawingSelector()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.UI.DrawingObjectSelector GetDrawingObjectSelector()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.UI.DrawingObjectSelector_.FromTSObject(teklaObject.GetDrawingObjectSelector());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDrawingObjectSelector()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.UI.Picker GetPicker()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.UI.Picker_.FromTSObject(teklaObject.GetPicker());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPicker()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.Drawing GetActiveDrawing()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.GetActiveDrawing());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetActiveDrawing()"); }
		}

		public System.Boolean SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			try {
			return teklaObject.SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetActiveDrawing()"); }
		}

		public System.Boolean SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, System.Boolean showDrawing)
		{
			try {
			return teklaObject.SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), showDrawing);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetActiveDrawing()"); }
		}

		public System.Boolean SaveActiveDrawing()
		{
			try {
			return teklaObject.SaveActiveDrawing();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SaveActiveDrawing()"); }
		}

		public System.Boolean CloseActiveDrawing()
		{
			try {
			return teklaObject.CloseActiveDrawing();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CloseActiveDrawing()"); }
		}

		public System.Boolean CloseActiveDrawing(System.Boolean save)
		{
			try {
			return teklaObject.CloseActiveDrawing(save);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CloseActiveDrawing()"); }
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.PrintAttributes printAttributes)
		{
			try {
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.PrintAttributes_.GetTSObject(printAttributes));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrintDrawing()"); }
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.PrintAttributes printAttributes, System.String fileName)
		{
			try {
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.PrintAttributes_.GetTSObject(printAttributes), fileName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrintDrawing()"); }
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes)
		{
			try {
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrintDrawing()"); }
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes, System.String outputFile)
		{
			try {
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes), outputFile);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrintDrawing()"); }
		}

		public System.Boolean PrintDrawings(System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.Drawing> drawings, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes)
		{
			try {
			return teklaObject.PrintDrawings(drawings, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PrintDrawings()"); }
		}

		public System.Boolean UpdateDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			try {
			return teklaObject.UpdateDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("UpdateDrawing()"); }
		}

		public System.Boolean IssueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			try {
			return teklaObject.IssueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IssueDrawing()"); }
		}

		public System.Boolean UnissueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			try {
			return teklaObject.UnissueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("UnissueDrawing()"); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> GetModelObjectIdentifiers(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			try {
			return teklaObject.GetModelObjectIdentifiers(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetModelObjectIdentifiers()"); }
		}




    public enum MessageExecutionModeEnum
    {
			INSTANT,
			BY_COMMIT        
    }

    internal static class MessageExecutionModeEnum_
    {
        public static dynamic GetTSObject(MessageExecutionModeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum").GetType();

            switch (dynEnum)
            {
				case MessageExecutionModeEnum.INSTANT:
					return System.Enum.Parse(tsType, "INSTANT");
				case MessageExecutionModeEnum.BY_COMMIT:
					return System.Enum.Parse(tsType, "BY_COMMIT");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static MessageExecutionModeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("INSTANT", System.StringComparison.InvariantCulture))
				return MessageExecutionModeEnum.INSTANT;
			else if (tsEnumValue.Equals("BY_COMMIT", System.StringComparison.InvariantCulture))
				return MessageExecutionModeEnum.BY_COMMIT;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class DrawingHandler_
    {
        public static dynamic GetTSObject(DrawingHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingHandlerArray_
    {
        public static dynamic GetTSObject(DrawingHandler[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DrawingHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
