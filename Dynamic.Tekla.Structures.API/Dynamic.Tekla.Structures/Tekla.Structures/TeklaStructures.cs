/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class TeklaStructures 
    {

		public Dynamic.Tekla.Structures.ICommonTasks CommonTasks
		{
			get => Dynamic.Tekla.Structures.ICommonTasks_.FromTSObject(teklaObject.CommonTasks);

		}

		public Dynamic.Tekla.Structures.Configuration Configuration
		{
			get => Dynamic.Tekla.Structures.Configuration_.FromTSObject(teklaObject.Configuration);

		}

		public Dynamic.Tekla.Structures.IConnection Connection
		{
			get => Dynamic.Tekla.Structures.IConnection_.FromTSObject(teklaObject.Connection);

		}

		public Dynamic.Tekla.Structures.IDrawing Drawing
		{
			get => Dynamic.Tekla.Structures.IDrawing_.FromTSObject(teklaObject.Drawing);

		}

		public Dynamic.Tekla.Structures.IEnvironment Environment
		{
			get => Dynamic.Tekla.Structures.IEnvironment_.FromTSObject(teklaObject.Environment);

		}

		public System.Boolean IsRunning
		{
			get => teklaObject.IsRunning;

		}

		public Dynamic.Tekla.Structures.IMainWindow MainWindow
		{
			get => Dynamic.Tekla.Structures.IMainWindow_.FromTSObject(teklaObject.MainWindow);

		}

		public Dynamic.Tekla.Structures.IModel Model
		{
			get => Dynamic.Tekla.Structures.IModel_.FromTSObject(teklaObject.Model);

		}

		public Dynamic.Tekla.Structures.IRegistry Registry
		{
			get => Dynamic.Tekla.Structures.IRegistry_.FromTSObject(teklaObject.Registry);

		}

		public System.String Version
		{
			get => teklaObject.Version;

		}

        

        internal dynamic teklaObject;


		public static void add_Closed(System.EventHandler value)
		{
			var parameters = new object[1];
			parameters[0] = value;
			TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructures", "add_Closed", parameters);
		}

		public static void remove_Closed(System.EventHandler value)
		{
			var parameters = new object[1];
			parameters[0] = value;
			TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructures", "remove_Closed", parameters);
		}

		public static System.Boolean Connect()
		{
			var parameters = new object[0];
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructures", "Connect", parameters);
			return result;
		}

		public static void Disconnect()
		{
			var parameters = new object[0];
			TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructures", "Disconnect", parameters);
		}

		public static void ExecuteScript(System.String script)
		{
			var parameters = new object[1];
			parameters[0] = script;
			TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructures", "ExecuteScript", parameters);
		}





    }

    internal static class TeklaStructures_
    {
        public static dynamic GetTSObject(TeklaStructures dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TeklaStructures FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.TeklaStructures)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TeklaStructuresArray_
    {
        public static dynamic GetTSObject(TeklaStructures[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructures_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructures[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<TeklaStructures>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructures_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
