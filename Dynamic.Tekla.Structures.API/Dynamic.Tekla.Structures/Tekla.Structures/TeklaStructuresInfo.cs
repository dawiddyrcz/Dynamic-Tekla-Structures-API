//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

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
			 => teklaObject.GetCurrentProgramVersion();

		public System.String GetBuildNumber()
			 => teklaObject.GetBuildNumber();

		public System.String GetRevisionDate()
			 => teklaObject.GetRevisionDate();

		public System.String GetCopyRightText()
			 => teklaObject.GetCopyRightText();

		public System.String GetLocalAppDataFolder()
			 => teklaObject.GetLocalAppDataFolder();

		public System.String GetCommonAppDataFolder()
			 => teklaObject.GetCommonAppDataFolder();

		public System.String GetFullTSRegistryKeyText()
			 => teklaObject.GetFullTSRegistryKeyText();

		public System.String GetCurrentUser()
			 => teklaObject.GetCurrentUser();





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
    
