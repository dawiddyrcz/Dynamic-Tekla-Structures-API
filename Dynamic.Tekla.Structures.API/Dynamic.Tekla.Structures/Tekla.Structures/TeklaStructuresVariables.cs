/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class TeklaStructuresVariables 
    {

        

        internal dynamic teklaObject;


		public static void Add(System.String key)
		{
			var parameters = new object[1];
			parameters[0] = key;
			TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresVariables", "Add", parameters);
		}

		public static System.String Get(System.String key)
		{
			var parameters = new object[1];
			parameters[0] = key;
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresVariables", "Get", parameters);
			return result;
		}

		public static System.Boolean ContainsVariable(System.String key)
		{
			var parameters = new object[1];
			parameters[0] = key;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresVariables", "ContainsVariable", parameters);
			return result;
		}





    }

    internal static class TeklaStructuresVariables_
    {
        public static dynamic GetTSObject(TeklaStructuresVariables dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TeklaStructuresVariables FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.TeklaStructuresVariables)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
