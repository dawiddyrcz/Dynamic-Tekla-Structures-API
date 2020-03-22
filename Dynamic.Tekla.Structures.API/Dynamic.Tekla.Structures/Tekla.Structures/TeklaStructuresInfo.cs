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

		public System.String GetCurrentProgramVersion()
		{
			return teklaObject.GetCurrentProgramVersion();
		}

		public System.String GetBuildNumber()
		{
			return teklaObject.GetBuildNumber();
		}

		public System.String GetRevisionDate()
		{
			return teklaObject.GetRevisionDate();
		}

		public System.String GetCopyRightText()
		{
			return teklaObject.GetCopyRightText();
		}

		public System.String GetLocalAppDataFolder()
		{
			return teklaObject.GetLocalAppDataFolder();
		}

		public System.String GetCommonAppDataFolder()
		{
			return teklaObject.GetCommonAppDataFolder();
		}

		public System.String GetFullTSRegistryKeyText()
		{
			return teklaObject.GetFullTSRegistryKeyText();
		}

		public System.String GetCurrentUser()
		{
			return teklaObject.GetCurrentUser();
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
            var dynObject = (Tekla.Structures.TeklaStructuresInfo)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
