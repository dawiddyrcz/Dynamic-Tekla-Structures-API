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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TeklaStructuresInfo(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public static System.String GetCurrentProgramVersion()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCurrentProgramVersion");
	return result;
}



public static System.String GetBuildNumber()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetBuildNumber");
	return result;
}



public static System.String GetRevisionDate()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetRevisionDate");
	return result;
}



public static System.String GetCopyRightText()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCopyRightText");
	return result;
}



public static System.String GetLocalAppDataFolder()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetLocalAppDataFolder");
	return result;
}



public static System.String GetCommonAppDataFolder()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCommonAppDataFolder");
	return result;
}



public static System.String GetFullTSRegistryKeyText()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetFullTSRegistryKeyText");
	return result;
}



public static System.String GetCurrentUser()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCurrentUser");
	return result;
}






    }

    internal static class TeklaStructuresInfo_
    {
        public static dynamic GetTSObject(TeklaStructuresInfo dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TeklaStructuresInfo FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresInfo)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TeklaStructuresInfoArray_
    {
        public static dynamic GetTSObject(TeklaStructuresInfo[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructuresInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructuresInfo[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TeklaStructuresInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructuresInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
