/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;

namespace Dynamic.Tekla.Structures
{
    public class DynamicAPINotFoundException : Exception
    {
        public DynamicAPINotFoundException(string message) 
            : base (message + TeklaVersion())
        {

        }

        public DynamicAPINotFoundException(string message, Exception innerException) 
            :base(message + TeklaVersion(), innerException)
        {

        }

        public DynamicAPINotFoundException() : base()
        {
        }

        private static string TeklaVersion()
        {
            return "\nCurrent tekla version = " + TeklaProcess.TeklaFileVersion.ToString();
        }

        public static DynamicAPINotFoundException CouldNotFindMethod(string methodName, Exception innerException)
        {
            return new DynamicAPINotFoundException("Could not find method " + methodName + " in current Tekla API", innerException);
        }

        public static DynamicAPINotFoundException CouldNotFindProperty(string propertyName, Exception innerException)
        {
            return new DynamicAPINotFoundException("Could not find property " + propertyName + " in current Tekla API", innerException);
        }
    }
}
