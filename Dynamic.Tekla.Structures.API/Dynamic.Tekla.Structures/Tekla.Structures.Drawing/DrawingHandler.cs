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

    try
    {
        	var result = teklaObject.GetConnectionStatus();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetConnectionStatus), ex);
    }
}



public static Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum SetMessageExecutionStatus(
	Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum mode_
	)
{
	var mode = Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum_.GetTSObject(mode_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.DrawingHandler", "SetMessageExecutionStatus", mode);
	var _result = Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum GetMessageExecutionStatus()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.DrawingHandler", "GetMessageExecutionStatus");
	var _result = Dynamic.Tekla.Structures.Drawing.DrawingHandler.MessageExecutionModeEnum_.FromTSObject(result);
	return _result;
}



public Dynamic.Tekla.Structures.Drawing.DrawingEnumerator GetDrawings()
{

    try
    {
        	var result = teklaObject.GetDrawings();

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDrawings), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.UI.DrawingSelector GetDrawingSelector()
{

    try
    {
        	var result = teklaObject.GetDrawingSelector();

        	var _result = Dynamic.Tekla.Structures.Drawing.UI.DrawingSelector_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDrawingSelector), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.UI.DrawingObjectSelector GetDrawingObjectSelector()
{

    try
    {
        	var result = teklaObject.GetDrawingObjectSelector();

        	var _result = Dynamic.Tekla.Structures.Drawing.UI.DrawingObjectSelector_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDrawingObjectSelector), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.UI.Picker GetPicker()
{

    try
    {
        	var result = teklaObject.GetPicker();

        	var _result = Dynamic.Tekla.Structures.Drawing.UI.Picker_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPicker), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.Drawing GetActiveDrawing()
{

    try
    {
        	var result = teklaObject.GetActiveDrawing();

        	var _result = Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetActiveDrawing), ex);
    }
}



public System.Boolean SetActiveDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
    try
    {
        	var result = teklaObject.SetActiveDrawing(drawing);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetActiveDrawing), ex);
    }
}



public System.Boolean SetActiveDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_,
	System.Boolean showDrawing
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
	
    try
    {
        	var result = teklaObject.SetActiveDrawing(drawing, showDrawing);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetActiveDrawing), ex);
    }
}



public System.Boolean SaveActiveDrawing()
{

    try
    {
        	var result = teklaObject.SaveActiveDrawing();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SaveActiveDrawing), ex);
    }
}



public System.Boolean CloseActiveDrawing()
{

    try
    {
        	var result = teklaObject.CloseActiveDrawing();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CloseActiveDrawing), ex);
    }
}



public System.Boolean CloseActiveDrawing(
	System.Boolean save
	)
{
	
    try
    {
        	var result = teklaObject.CloseActiveDrawing(save);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CloseActiveDrawing), ex);
    }
}



public System.Boolean PrintDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_,
	Dynamic.Tekla.Structures.Drawing.PrintAttributes printAttributes_
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
	var printAttributes = Dynamic.Tekla.Structures.Drawing.PrintAttributes_.GetTSObject(printAttributes_);
    try
    {
        	var result = teklaObject.PrintDrawing(drawing, printAttributes);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PrintDrawing), ex);
    }
}



public System.Boolean PrintDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_,
	Dynamic.Tekla.Structures.Drawing.PrintAttributes printAttributes_,
	System.String fileName
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
	var printAttributes = Dynamic.Tekla.Structures.Drawing.PrintAttributes_.GetTSObject(printAttributes_);
	
    try
    {
        	var result = teklaObject.PrintDrawing(drawing, printAttributes, fileName);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PrintDrawing), ex);
    }
}



public System.Boolean PrintDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_,
	Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes_
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
	var printAttributes = Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes_);
    try
    {
        	var result = teklaObject.PrintDrawing(drawing, printAttributes);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PrintDrawing), ex);
    }
}



public System.Boolean PrintDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_,
	Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes_,
	System.String outputFile
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
	var printAttributes = Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes_);
	
    try
    {
        	var result = teklaObject.PrintDrawing(drawing, printAttributes, outputFile);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PrintDrawing), ex);
    }
}



public System.Boolean PrintDrawings(
	System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.Drawing> drawings_,
	Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes printAttributes_
	)
{
	var drawings = IEnumerableConverter.ToTSObjects<System.Collections.Generic.List<Tekla.Structures.Drawing.Drawing>>(drawings_);
	var printAttributes = Dynamic.Tekla.Structures.Drawing.DPMPrinterAttributes_.GetTSObject(printAttributes_);
    try
    {
        	var result = teklaObject.PrintDrawings(drawings, printAttributes);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PrintDrawings), ex);
    }
}



public System.Boolean UpdateDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
    try
    {
        	var result = teklaObject.UpdateDrawing(drawing);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(UpdateDrawing), ex);
    }
}



public System.Boolean IssueDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
    try
    {
        	var result = teklaObject.IssueDrawing(drawing);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IssueDrawing), ex);
    }
}



public System.Boolean UnissueDrawing(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
    try
    {
        	var result = teklaObject.UnissueDrawing(drawing);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(UnissueDrawing), ex);
    }
}



public System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> GetModelObjectIdentifiers(
	Dynamic.Tekla.Structures.Drawing.Drawing drawing_
	)
{
	var drawing = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing_);
    try
    {
        	var result = teklaObject.GetModelObjectIdentifiers(drawing);

        	var _result = IEnumerableConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier>>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetModelObjectIdentifiers), ex);
    }
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
    
