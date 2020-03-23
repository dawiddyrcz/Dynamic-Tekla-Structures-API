/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class TeklaStructuresFiles 
    {

		public System.Collections.Generic.List<System.String> PropertyFileDirectories
		{
			get => teklaObject.PropertyFileDirectories;
			set { teklaObject.PropertyFileDirectories = value; }
		}

        

        internal dynamic teklaObject;

		public TeklaStructuresFiles() {}
		public TeklaStructuresFiles(System.String modelpath)
		{
			var args = new object[1];
			args[0] = modelpath;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresFiles", args);
		}

		public System.Collections.Generic.List<System.String> GetMultiDirectoryFileList(System.String fileExtension, System.Boolean fullpath)
		{
			return teklaObject.GetMultiDirectoryFileList(fileExtension, fullpath);
		}

		public System.IO.FileInfo GetAttributeFile(System.String fileName)
		{
			return teklaObject.GetAttributeFile(fileName);
		}

		public System.IO.FileInfo GetAttributeFile(System.Collections.Generic.List<System.String> searchDirectories, System.String fileName)
		{
			return teklaObject.GetAttributeFile(searchDirectories, fileName);
		}





    }

    internal static class TeklaStructuresFiles_
    {
        public static dynamic GetTSObject(TeklaStructuresFiles dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TeklaStructuresFiles FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresFiles)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TeklaStructuresFilesArray_
    {
        public static dynamic GetTSObject(TeklaStructuresFiles[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructuresFiles_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructuresFiles[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<TeklaStructuresFiles>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructuresFiles_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
