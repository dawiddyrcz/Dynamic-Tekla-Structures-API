/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.History
{

    public struct ModificationInfo
    {
			public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Modified;
			public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Deleted;
			public System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.Model.History.ModifiedObjectInfo> ModifiedWithInfo;
       
    }

    internal static class ModificationInfo_
    {
        public static dynamic GetTSObject(ModificationInfo dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.History.ModificationInfo");
			tsType.Modified = dynStruct.Modified;
			tsType.Deleted = dynStruct.Deleted;
			tsType.ModifiedWithInfo = dynStruct.ModifiedWithInfo;

            return tsType;
        }
    
        public static ModificationInfo FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new ModificationInfo();
			dynStruct.Modified = tsStruct.Modified;
			dynStruct.Deleted = tsStruct.Deleted;
			dynStruct.ModifiedWithInfo = tsStruct.ModifiedWithInfo;
 
            return dynStruct;
        }
    }

}
    
