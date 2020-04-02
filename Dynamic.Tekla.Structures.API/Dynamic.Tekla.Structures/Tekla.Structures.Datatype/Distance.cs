/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public struct Distance
    {
			public System.String MILLIMETERS;
       
    }

    internal static class Distance_
    {
        public static dynamic GetTSObject(Distance dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Datatype.Distance");
			tsType.MILLIMETERS = dynStruct.MILLIMETERS;

            return tsType;
        }
    
        public static Distance FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new Distance();
			dynStruct.MILLIMETERS = tsStruct.MILLIMETERS;
 
            return dynStruct;
        }
    }

}
    