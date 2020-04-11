/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class MacroBuilder 
    {

        

        internal dynamic teklaObject;

		public MacroBuilder()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.MacroBuilder");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MacroBuilder(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public MacroBuilder(System.String script)
		{
			var args = new object[1];
			args[0] = script;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.MacroBuilder", args);
		}


public Dynamic.Tekla.Structures.MacroBuilder Activate(
	System.String dialog,
	System.String field
	)
{
	
	
    try
    {
        	var result = teklaObject.Activate(dialog, field);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Activate), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder Callback(
	System.String callback
	)
{
	
    try
    {
        	var result = teklaObject.Callback(callback);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Callback), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder Callback(
	System.String callback,
	System.String parameter
	)
{
	
	
    try
    {
        	var result = teklaObject.Callback(callback, parameter);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Callback), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder Callback(
	System.String callback,
	System.String parameter,
	System.String frame
	)
{
	
	
	
    try
    {
        	var result = teklaObject.Callback(callback, parameter, frame);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Callback), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder CheckValue(
	System.String name,
	System.Int32 value
	)
{
	
	
    try
    {
        	var result = teklaObject.CheckValue(name, value);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CheckValue), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder CommandEnd()
{

    try
    {
        	var result = teklaObject.CommandEnd();

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommandEnd), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder CommandStart(
	System.String command,
	System.String parameter,
	System.String frame
	)
{
	
	
	
    try
    {
        	var result = teklaObject.CommandStart(command, parameter, frame);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommandStart), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder FileSelection(
	System.String[] items
	)
{
	
    try
    {
        	var result = teklaObject.FileSelection(items);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(FileSelection), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder ListSelect(
	System.String dialog,
	System.String field,
	System.String[] items
	)
{
	
	
	
    try
    {
        	var result = teklaObject.ListSelect(dialog, field, items);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ListSelect), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder ModalDialog(
	System.Int32 value
	)
{
	
    try
    {
        	var result = teklaObject.ModalDialog(value);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModalDialog), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder MouseDown(
	System.String frame,
	System.String subframe,
	System.Int32 x,
	System.Int32 y,
	System.Int32 modifier
	)
{
	
	
	
	
	
    try
    {
        	var result = teklaObject.MouseDown(frame, subframe, x, y, modifier);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MouseDown), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder MouseUp(
	System.String frame,
	System.String subframe,
	System.Int32 x,
	System.Int32 y,
	System.Int32 modifier
	)
{
	
	
	
	
	
    try
    {
        	var result = teklaObject.MouseUp(frame, subframe, x, y, modifier);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MouseUp), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder PushButton(
	System.String button,
	System.String frame
	)
{
	
	
    try
    {
        	var result = teklaObject.PushButton(button, frame);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PushButton), ex);
    }
}



public void Run()
{

    try
    {
        	teklaObject.Run();

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Run), ex);
    }
}



public void Run(
	Dynamic.Tekla.Structures.IConnection connection_
	)
{
	var connection = Dynamic.Tekla.Structures.IConnection_.GetTSObject(connection_);
    try
    {
        	teklaObject.Run(connection);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Run), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder TabChange(
	System.String dialog,
	System.String field,
	System.String item
	)
{
	
	
	
    try
    {
        	var result = teklaObject.TabChange(dialog, field, item);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(TabChange), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder TableSelect(
	System.String dialog,
	System.String field,
	System.Int32[] items
	)
{
	
	
	
    try
    {
        	var result = teklaObject.TableSelect(dialog, field, items);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(TableSelect), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder TreeSelect(
	System.String dialog,
	System.String field,
	System.String rowstring
	)
{
	
	
	
    try
    {
        	var result = teklaObject.TreeSelect(dialog, field, rowstring);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(TreeSelect), ex);
    }
}



public Dynamic.Tekla.Structures.MacroBuilder ValueChange(
	System.String dialog,
	System.String field,
	System.String data
	)
{
	
	
	
    try
    {
        	var result = teklaObject.ValueChange(dialog, field, data);

        	var _result = Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ValueChange), ex);
    }
}






    }

    internal static class MacroBuilder_
    {
        public static dynamic GetTSObject(MacroBuilder dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MacroBuilder FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.MacroBuilder)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MacroBuilderArray_
    {
        public static dynamic GetTSObject(MacroBuilder[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MacroBuilder_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MacroBuilder[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MacroBuilder>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MacroBuilder_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
