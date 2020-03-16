//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class TeklaStructuresFiles 
    {

		public System.Collections.Generic.ListSystem.String<System.String> PropertyFileDirectories
		{
			get => teklastructuresfiles.PropertyFileDirectories;
			set { teklastructuresfiles.PropertyFileDirectories = value; }
		}

        

        dynamic teklastructuresfiles;
        
        public TeklaStructuresFiles()
        {
            this.teklastructuresfiles =  new Tekla.Structures.TeklaStructuresFiles();
        }

        public TeklaStructuresFiles(dynamic tsObject)
        {
            this.teklastructuresfiles = tsObject;
			this.PropertyFileDirectories = teklastructuresfiles.PropertyFileDirectories;

        }


        public dynamic GetTSObject() => teklastructuresfiles;

		public System.Collections.Generic.ListSystem.String<System.String> GetMultiDirectoryFileList(System.String fileExtension, System.Boolean fullpath)
			 => teklastructuresfiles.GetMultiDirectoryFileList(fileExtension, fullpath);

		public System.IO.FileInfo GetAttributeFile(System.String fileName)
			 => teklastructuresfiles.GetAttributeFile(fileName);

		public System.IO.FileInfo GetAttributeFile(System.Collections.Generic.ListSystem.String<System.String> searchDirectories, System.String fileName)
			 => teklastructuresfiles.GetAttributeFile(searchDirectories, fileName);

		public System.Boolean Equals(System.Object obj)
			 => teklastructuresfiles.Equals(obj);

		public System.Int32 GetHashCode()
			 => teklastructuresfiles.GetHashCode();

		public System.Type GetType()
			 => teklastructuresfiles.GetType();

		public System.String ToString()
			 => teklastructuresfiles.ToString();





    }

}
    
