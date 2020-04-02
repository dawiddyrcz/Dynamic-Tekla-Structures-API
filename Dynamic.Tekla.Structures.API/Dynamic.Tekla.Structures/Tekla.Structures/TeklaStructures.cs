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

		public static Dynamic.Tekla.Structures.ICommonTasks CommonTasks
		{
			get => Dynamic.Tekla.Structures.ICommonTasks_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","CommonTasks"));

		}

		public static Dynamic.Tekla.Structures.Configuration Configuration
		{
			get => Dynamic.Tekla.Structures.Configuration_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","Configuration"));

		}

		public static Dynamic.Tekla.Structures.IConnection Connection
		{
			get => Dynamic.Tekla.Structures.IConnection_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","Connection"));

		}

		public static Dynamic.Tekla.Structures.IDrawing Drawing
		{
			get => Dynamic.Tekla.Structures.IDrawing_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","Drawing"));

		}

		public static Dynamic.Tekla.Structures.IEnvironment Environment
		{
			get => Dynamic.Tekla.Structures.IEnvironment_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","Environment"));

		}

		public static System.Boolean IsRunning
		{
			get => (System.Boolean) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","IsRunning");

		}

		public static Dynamic.Tekla.Structures.IMainWindow MainWindow
		{
			get => Dynamic.Tekla.Structures.IMainWindow_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","MainWindow"));

		}

		public static Dynamic.Tekla.Structures.IModel Model
		{
			get => Dynamic.Tekla.Structures.IModel_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","Model"));

		}

		public static Dynamic.Tekla.Structures.IRegistry Registry
		{
			get => Dynamic.Tekla.Structures.IRegistry_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","Registry"));

		}

		public static System.String Version
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructures","Version");

		}

        

        internal dynamic teklaObject;


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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static TeklaStructures FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructures_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructures[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<TeklaStructures>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructures_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
