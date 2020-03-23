/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class TeklaStructuresInfo 
    {

        

        internal dynamic teklaObject;

		public TeklaStructuresInfo()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresInfo");
		}

		public static System.String GetCurrentProgramVersion()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCurrentProgramVersion", parameters);
			return result;
		}

		public static System.String GetBuildNumber()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetBuildNumber", parameters);
			return result;
		}

		public static System.String GetRevisionDate()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetRevisionDate", parameters);
			return result;
		}

		public static System.String GetCopyRightText()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCopyRightText", parameters);
			return result;
		}

		public static System.String GetLocalAppDataFolder()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetLocalAppDataFolder", parameters);
			return result;
		}

		public static System.String GetCommonAppDataFolder()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCommonAppDataFolder", parameters);
			return result;
		}

		public static System.String GetFullTSRegistryKeyText()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetFullTSRegistryKeyText", parameters);
			return result;
		}

		public static System.String GetCurrentUser()
		{
			var parameters = new object[0];
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCurrentUser", parameters);
			return result;
		}





    }

    internal static class TeklaStructuresInfo_
    {
        public static dynamic GetTSObject(TeklaStructuresInfo dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TeklaStructuresInfo FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresInfo)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
