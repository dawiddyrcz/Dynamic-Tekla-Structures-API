/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public struct DistanceList
    {
       
    }

    internal static class DistanceList_
    {
        public static dynamic GetTSObject(DistanceList dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Datatype.DistanceList");

            return tsType;
        }
    
        public static DistanceList FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new DistanceList();
 
            return dynStruct;
        }
    }

}
    