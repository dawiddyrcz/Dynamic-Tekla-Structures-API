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
using TSD = Dynamic.Tekla.Structures.Drawing;

namespace Examples
{
    public class Print_Drawing_Names : ExampleBase
    {
        public override void Run()
        {
            var dh = new TSD.DrawingHandler();
            dh.CloseActiveDrawing(false);

            Console.WriteLine("Getting drawings from the model...");
            var drawings = dh.GetDrawings();

            if (drawings.GetSize().Equals(0))
                Console.WriteLine("There is no drawing in the opened model");
            else
                Console.WriteLine("There are {0} drawings. Printing first 10...\n\n", drawings.GetSize());

            int i = 1;
            while (drawings.MoveNext())
            {
                var drawing = drawings.Current as TSD.Drawing;

                Console.WriteLine(i + " Mark: {4}, Name: {0}, Title1: {1}, Title2: {2}, Title3 {3}", 
                    drawing.Name, drawing.Title1, drawing.Title2, drawing.Title3, drawing.Mark);

                if (i.Equals(10)) break;
                i++;
            }
        }
    }
}
