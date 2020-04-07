/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using System;
using System.Threading;
using Dynamic.Tekla.Structures.Geometry3d;
using Dynamic.Tekla.Structures.Model;
using TSD = Dynamic.Tekla.Structures.Drawing;

namespace TestConsoleApp
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
             OpenDrawingAndInsertLine();

            Console.WriteLine("end");
            Console.ReadKey();
        }
        
        private static void OpenDrawingAndInsertLine()
        {
            var dh = new TSD.DrawingHandler();
            dh.CloseActiveDrawing(false);
            var drawings = dh.GetDrawings();

            while (drawings.MoveNext())
            {
                var drawing = drawings.Current as TSD.Drawing;
                Console.WriteLine("Name: {0}, Title1: {1}, Title2: {2}, Title3 {3}", drawing.Name, drawing.Title1, drawing.Title2, drawing.Title3);

                dh.SetActiveDrawing(drawing);

                var p1 = new Point(0, 0, 0);
                var p2 = new Point(200, 200, 0);
                var line = new TSD.Line(drawing.GetSheet(), p1, p2);
                line.Attributes = new TSD.Line.LineAttributes("standard");
                line.Insert();
                drawing.CommitChanges();

                break;
            }

            dh.CloseActiveDrawing(false);
        }



    }
}
