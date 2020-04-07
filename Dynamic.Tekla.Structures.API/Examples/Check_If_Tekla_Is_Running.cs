/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using TS = Dynamic.Tekla.Structures;

namespace Examples
{
    public class Check_If_Tekla_Is_Running : ExampleBase
    {

        public override void Run()                      
        {
            if (TS.TeklaProcess.IsTeklaRunning())
            {
                Console.WriteLine("Tekla is running.\nVersion " + TS.TeklaProcess.TeklaFileVersion.ToString());
            }
            else
            {
                Console.WriteLine("Tekla is not running");
            }
        }
    }
}
