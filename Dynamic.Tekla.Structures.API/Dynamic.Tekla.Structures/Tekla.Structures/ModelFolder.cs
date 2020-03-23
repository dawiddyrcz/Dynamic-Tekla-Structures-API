/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class ModelFolder  : Dynamic.Tekla.Structures.VirtualFolder
    {

		public Dynamic.Tekla.Structures.VirtualFolder AttributesFolder
		{
			get => Dynamic.Tekla.Structures.VirtualFolder_.FromTSObject(teklaObject.AttributesFolder);

		}

		public Dynamic.Tekla.Structures.VirtualFolder DrawingsFolder
		{
			get => Dynamic.Tekla.Structures.VirtualFolder_.FromTSObject(teklaObject.DrawingsFolder);

		}

        

        

		public ModelFolder() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelFolder(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelFolder(System.String folderPath, System.String searchPath)
		{
			var args = new object[2];
			args[0] = folderPath;
			args[1] = searchPath;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.ModelFolder", args);
		}

		public static System.Boolean ContainsModelDatabase(System.String modelFolder)
		{
			var parameters = new object[1];
			parameters[0] = modelFolder;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.ModelFolder", "ContainsModelDatabase", parameters);
			return result;
		}





    }

    internal static class ModelFolder_
    {
        public static dynamic GetTSObject(ModelFolder dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelFolder FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.ModelFolder)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelFolderArray_
    {
        public static dynamic GetTSObject(ModelFolder[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelFolder_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelFolder[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ModelFolder>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelFolder_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
