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
			get
			{
				try {
					return teklaObject.PropertyFileDirectories;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PropertyFileDirectories", ex); }
			}
			set
			{
				try {
					teklaObject.PropertyFileDirectories = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PropertyFileDirectories", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal TeklaStructuresFiles() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TeklaStructuresFiles(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TeklaStructuresFiles(System.String modelpath)
		{
			var args = new object[1];
			args[0] = modelpath;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresFiles", args);
		}


public System.Collections.Generic.List<System.String> GetMultiDirectoryFileList(
	System.String fileExtension,
	System.Boolean fullpath
	)
{
	
	
    try
    {
        	var result = (System.Collections.Generic.List<System.String>) teklaObject.GetMultiDirectoryFileList(fileExtension, fullpath);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMultiDirectoryFileList), ex);
    }
}



public System.IO.FileInfo GetAttributeFile(
	System.String fileName
	)
{
	
    try
    {
        	var result = (System.IO.FileInfo) teklaObject.GetAttributeFile(fileName);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAttributeFile), ex);
    }
}



public System.IO.FileInfo GetAttributeFile(
	System.Collections.Generic.List<System.String> searchDirectories,
	System.String fileName
	)
{
	
	
    try
    {
        	var result = (System.IO.FileInfo) teklaObject.GetAttributeFile(searchDirectories, fileName);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAttributeFile), ex);
    }
}






    }

    internal static class TeklaStructuresFiles_
    {
        public static dynamic GetTSObject(TeklaStructuresFiles dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TeklaStructuresFiles FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresFiles)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TeklaStructuresFilesArray_
    {
        public static dynamic GetTSObject(TeklaStructuresFiles[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructuresFiles_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructuresFiles[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TeklaStructuresFiles>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructuresFiles_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
