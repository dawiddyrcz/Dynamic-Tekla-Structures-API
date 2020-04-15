/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
using System;

namespace Dynamic.Tekla.Structures
{
    public class DynamicAPIException : Exception
    {
        public DynamicAPIException(string message) 
            : base (message + TeklaVersion())
        {

        }

        public DynamicAPIException(string message, Exception innerException) 
            :base(message + TeklaVersion(), innerException)
        {

        }

        public DynamicAPIException() : base()
        {

        }

        private static string TeklaVersion()
        {
            return "\nCurrent tekla version = " + TeklaProcess.TeklaFileVersion.ToString();
        }
    }
}
