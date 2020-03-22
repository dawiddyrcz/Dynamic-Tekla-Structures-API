/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class TeklaStructuresSettings 
    {

        

        internal dynamic teklaObject;

		public TeklaStructuresSettings()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresSettings");
		}

		public static System.Boolean GetAdvancedOption(System.String VariableName, System.Boolean Value)
		{
			var parameters = new object[2];
			parameters[0] = VariableName;
			parameters[1] = Value;
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", parameters);
		}

		public static System.Boolean GetAdvancedOption(System.String VariableName, System.Int32 Value)
		{
			var parameters = new object[2];
			parameters[0] = VariableName;
			parameters[1] = Value;
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", parameters);
		}

		public static System.Boolean GetAdvancedOption(System.String VariableName, System.String Value)
		{
			var parameters = new object[2];
			parameters[0] = VariableName;
			parameters[1] = Value;
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", parameters);
		}

		public static System.Boolean GetAdvancedOption(System.String VariableName, System.Double Value)
		{
			var parameters = new object[2];
			parameters[0] = VariableName;
			parameters[1] = Value;
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", parameters);
		}

		public static System.Boolean GetOptions(Dynamic.Tekla.Structures.ClashCheckOptions Options)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.ClashCheckOptions_.GetTSObject(Options);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetOptions", parameters);
		}

		public static System.Boolean SetOptions(Dynamic.Tekla.Structures.ClashCheckOptions Options)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.ClashCheckOptions_.GetTSObject(Options);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "SetOptions", parameters);
		}

		public static System.Boolean GetOptions(Dynamic.Tekla.Structures.ComponentOptions Options)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.ComponentOptions_.GetTSObject(Options);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetOptions", parameters);
		}

		public static System.Boolean SetOptions(Dynamic.Tekla.Structures.ComponentOptions Options)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.ComponentOptions_.GetTSObject(Options);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "SetOptions", parameters);
		}

		public static System.Boolean IsToolOptionOn(System.String toolOptionName)
		{
			var parameters = new object[1];
			parameters[0] = toolOptionName;
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "IsToolOptionOn", parameters);
		}

		public static System.Boolean IsPourEnabled()
		{
			var parameters = new object[0];
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "IsPourEnabled", parameters);
		}




    public  class InvalidPathCallback 
    {

        

        internal dynamic teklaObject;

		public InvalidPathCallback() {}
		public InvalidPathCallback(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresSettings.InvalidPathCallback", args);
		}

		public void Invoke(System.String advancedOption, System.String invalidString, System.String exceptionMessage)
		{
			teklaObject.Invoke(advancedOption, invalidString, exceptionMessage);
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class InvalidPathCallback_
    {
        public static dynamic GetTSObject(InvalidPathCallback dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidPathCallback FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.TeklaStructuresSettings.InvalidPathCallback)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class ToolOptionNames 
    {

        

        internal dynamic teklaObject;






    }

    internal static class ToolOptionNames_
    {
        public static dynamic GetTSObject(ToolOptionNames dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ToolOptionNames FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.TeklaStructuresSettings.ToolOptionNames)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class TeklaStructuresSettings_
    {
        public static dynamic GetTSObject(TeklaStructuresSettings dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TeklaStructuresSettings FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.TeklaStructuresSettings)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
