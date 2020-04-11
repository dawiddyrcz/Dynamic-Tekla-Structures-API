/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PluginPickerInput 
    {

        

        internal dynamic teklaObject;

		public PluginPickerInput()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PluginPickerInput");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PluginPickerInput(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PluginPickerInput(System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.PickerInput> inputs)
		{
			var args = new object[1];
			args[0] = inputs;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PluginPickerInput", args);
		}


public void Add(
	Dynamic.Tekla.Structures.Drawing.PickerInput input_
	)
{
	var input = Dynamic.Tekla.Structures.Drawing.PickerInput_.GetTSObject(input_);
    try
    {
        	teklaObject.Add(input);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Add), ex);
    }
}



public void AddRange(
	System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.PickerInput> inputs_
	)
{
	var inputs = ListConverter.ToTSObjects(inputs_);
    try
    {
        	teklaObject.AddRange(inputs);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddRange), ex);
    }
}






    }

    internal static class PluginPickerInput_
    {
        public static dynamic GetTSObject(PluginPickerInput dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PluginPickerInput FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PluginPickerInput)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PluginPickerInputArray_
    {
        public static dynamic GetTSObject(PluginPickerInput[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PluginPickerInput_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PluginPickerInput[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PluginPickerInput>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PluginPickerInput_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
