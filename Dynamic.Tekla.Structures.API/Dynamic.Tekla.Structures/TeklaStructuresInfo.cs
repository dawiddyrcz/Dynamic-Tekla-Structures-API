//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class TeklaStructuresInfo 
    {

        

        dynamic teklastructuresinfo;
        
        public TeklaStructuresInfo()
        {
            this.teklastructuresinfo =  new Tekla.Structures.TeklaStructuresInfo();
        }

        public TeklaStructuresInfo(dynamic tsObject)
        {
            this.teklastructuresinfo = tsObject;

        }


        public dynamic GetTSObject() => teklastructuresinfo;

		public System.String GetCurrentProgramVersion()
			 => teklastructuresinfo.GetCurrentProgramVersion();

		public System.String GetBuildNumber()
			 => teklastructuresinfo.GetBuildNumber();

		public System.String GetRevisionDate()
			 => teklastructuresinfo.GetRevisionDate();

		public System.String GetCopyRightText()
			 => teklastructuresinfo.GetCopyRightText();

		public System.String GetLocalAppDataFolder()
			 => teklastructuresinfo.GetLocalAppDataFolder();

		public System.String GetCommonAppDataFolder()
			 => teklastructuresinfo.GetCommonAppDataFolder();

		public System.String GetFullTSRegistryKeyText()
			 => teklastructuresinfo.GetFullTSRegistryKeyText();

		public System.String GetCurrentUser()
			 => teklastructuresinfo.GetCurrentUser();

		public System.Boolean Equals(System.Object obj)
			 => teklastructuresinfo.Equals(obj);

		public System.Int32 GetHashCode()
			 => teklastructuresinfo.GetHashCode();

		public System.Type GetType()
			 => teklastructuresinfo.GetType();

		public System.String ToString()
			 => teklastructuresinfo.ToString();





    }

}
    
