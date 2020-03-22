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
		public PluginPickerInput(System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.PickerInput> inputs)
		{
			var args = new object[1];
			args[0] = inputs;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PluginPickerInput", args);
		}

		public void Add(Dynamic.Tekla.Structures.Drawing.PickerInput input)
		{
			teklaObject.Add(Dynamic.Tekla.Structures.Drawing.PickerInput_.GetTSObject(input));
		}

		public void AddRange(System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.PickerInput> inputs)
		{
			teklaObject.AddRange(inputs);
		}





    }

    internal static class PluginPickerInput_
    {
        public static dynamic GetTSObject(PluginPickerInput dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PluginPickerInput FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PluginPickerInput)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
