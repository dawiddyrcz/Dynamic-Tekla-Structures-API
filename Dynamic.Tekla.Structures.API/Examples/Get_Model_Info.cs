﻿/*Copyright (C) Dawid Dyrcz 2020
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
using TSM = Dynamic.Tekla.Structures.Model;

namespace Examples
{
    public class Get_Model_Info : ExampleBase
    {

        public override void Run()
        {
            var model = new TSM.Model();
            var info = model.GetInfo();

            Console.WriteLine("ModelName:\t" + info.ModelName);
            Console.WriteLine("ModelPath:\t" + info.ModelPath);
            Console.WriteLine("CurrentPhase:\t" + info.CurrentPhase);
        }
    }
}
