/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class VirtualFolder 
    {

		public System.String FolderName
		{
			get => teklaObject.FolderName;

		}

		public System.String FolderPath
		{
			get => teklaObject.FolderPath;

		}

        

        internal dynamic teklaObject;

		internal VirtualFolder() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public VirtualFolder(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public VirtualFolder(System.String folderPath, System.String searchPath)
		{
			var args = new object[2];
			args[0] = folderPath;
			args[1] = searchPath;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.VirtualFolder", args);
		}

		public System.String CreateWritableCopy(System.String filename)
		{
			return teklaObject.CreateWritableCopy(filename);
		}

		public System.String FindFile(System.String filename)
		{
			return teklaObject.FindFile(filename);
		}

		public System.String GetWritablePath(System.String filename)
		{
			return teklaObject.GetWritablePath(filename);
		}

		public System.Boolean IsWritable(System.String filename)
		{
			return teklaObject.IsWritable(filename);
		}





    }

    internal static class VirtualFolder_
    {
        public static dynamic GetTSObject(VirtualFolder dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static VirtualFolder FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.VirtualFolder)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class VirtualFolderArray_
    {
        public static dynamic GetTSObject(VirtualFolder[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(VirtualFolder_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static VirtualFolder[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<VirtualFolder>();
            foreach(var tsItem in tsArray)
            {
                list.Add(VirtualFolder_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
