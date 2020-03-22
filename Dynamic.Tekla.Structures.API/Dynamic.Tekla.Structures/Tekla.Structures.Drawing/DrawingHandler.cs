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

        

        internal dynamic teklaObject;

		public DrawingHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingHandler");
		}

		public System.Boolean GetConnectionStatus()
		{
			return teklaObject.GetConnectionStatus();
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
			return Dynamic.Tekla.Structures.Drawing.DrawingEnumerator_.FromTSObject(teklaObject.GetDrawings());
		}

		public Dynamic.Tekla.Structures.Drawing.UI.DrawingSelector GetDrawingSelector()
		{
			return Dynamic.Tekla.Structures.Drawing.UI.DrawingSelector_.FromTSObject(teklaObject.GetDrawingSelector());
		}

		public Dynamic.Tekla.Structures.Drawing.UI.DrawingObjectSelector GetDrawingObjectSelector()
		{
			return Dynamic.Tekla.Structures.Drawing.UI.DrawingObjectSelector_.FromTSObject(teklaObject.GetDrawingObjectSelector());
		}

		public Dynamic.Tekla.Structures.Drawing.UI.Picker GetPicker()
		{
			return Dynamic.Tekla.Structures.Drawing.UI.Picker_.FromTSObject(teklaObject.GetPicker());
		}

		public Dynamic.Tekla.Structures.Drawing.Drawing GetActiveDrawing()
		{
			return Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.GetActiveDrawing());
		}

		public System.Boolean SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			return teklaObject.SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
		}

		public System.Boolean SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, System.Boolean showDrawing)
		{
			return teklaObject.SetActiveDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), showDrawing);
		}

		public System.Boolean SaveActiveDrawing()
		{
			return teklaObject.SaveActiveDrawing();
		}

		public System.Boolean CloseActiveDrawing()
		{
			return teklaObject.CloseActiveDrawing();
		}

		public System.Boolean CloseActiveDrawing(System.Boolean save)
		{
			return teklaObject.CloseActiveDrawing(save);
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.PrintAttributes printAttributes)
		{
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.PrintAttributes_.GetTSObject(printAttributes));
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.PrintAttributes printAttributes, System.String fileName)
		{
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.PrintAttributes_.GetTSObject(printAttributes), fileName);
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes)
		{
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes));
		}

		public System.Boolean PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes, System.String outputFile)
		{
			return teklaObject.PrintDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes), outputFile);
		}

		public System.Boolean PrintDrawings(System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.Drawing> drawings, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes)
		{
			return teklaObject.PrintDrawings(drawings, Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes));
		}

		public System.Boolean UpdateDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			return teklaObject.UpdateDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
		}

		public System.Boolean IssueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			return teklaObject.IssueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
		}

		public System.Boolean UnissueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			return teklaObject.UnissueDrawing(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> GetModelObjectIdentifiers(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			return teklaObject.GetModelObjectIdentifiers(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class DrawingHandler_
    {
        public static dynamic GetTSObject(DrawingHandler dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingHandler FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.DrawingHandler)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
