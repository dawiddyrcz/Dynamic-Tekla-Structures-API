/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.History
{

    public struct ModifiedObjectInfo
    {
			public Dynamic.Tekla.Structures.Model.ModelObject ModelObject;
			public System.Boolean IsAttributeChanged;
			public System.Boolean IsModified;
			public System.Boolean IsCreated;
			public System.Boolean IsNumberingChanged;
       
    }

    internal static class ModifiedObjectInfo_
    {
        public static dynamic GetTSObject(ModifiedObjectInfo dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.History.ModifiedObjectInfo");
			tsType.ModelObject = dynStruct.ModelObject;
			tsType.IsAttributeChanged = dynStruct.IsAttributeChanged;
			tsType.IsModified = dynStruct.IsModified;
			tsType.IsCreated = dynStruct.IsCreated;
			tsType.IsNumberingChanged = dynStruct.IsNumberingChanged;

            return tsType;
        }
    
        public static ModifiedObjectInfo FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new ModifiedObjectInfo();
			dynStruct.ModelObject = tsStruct.ModelObject;
			dynStruct.IsAttributeChanged = tsStruct.IsAttributeChanged;
			dynStruct.IsModified = tsStruct.IsModified;
			dynStruct.IsCreated = tsStruct.IsCreated;
			dynStruct.IsNumberingChanged = tsStruct.IsNumberingChanged;
 
            return dynStruct;
        }
    }

}
    
