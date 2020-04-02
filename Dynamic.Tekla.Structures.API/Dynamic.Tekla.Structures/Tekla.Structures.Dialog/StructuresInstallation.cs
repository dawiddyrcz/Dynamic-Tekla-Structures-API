/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Dialog
{

    public  class StructuresInstallation 
    {

		public static System.String BinFolder
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Dialog.StructuresInstallation","BinFolder");

		}

		public static System.String InstallFolder
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Dialog.StructuresInstallation","InstallFolder");

		}

		public static System.String MessageFolder
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Dialog.StructuresInstallation","MessageFolder");

		}

        

        internal dynamic teklaObject;

		public StructuresInstallation()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Dialog.StructuresInstallation");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StructuresInstallation(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class StructuresInstallation_
    {
        public static dynamic GetTSObject(StructuresInstallation dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static StructuresInstallation FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Dialog.StructuresInstallation)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StructuresInstallationArray_
    {
        public static dynamic GetTSObject(StructuresInstallation[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StructuresInstallation_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StructuresInstallation[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<StructuresInstallation>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StructuresInstallation_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    