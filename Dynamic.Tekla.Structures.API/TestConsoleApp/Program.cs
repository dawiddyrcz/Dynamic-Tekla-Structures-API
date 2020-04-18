/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using System;
using System.Threading;
using System.Reflection;
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
            Console.WriteLine("Start");
            //TODO big problem with assembly loading. When trying to run program without visual studio it cant see tekla

            var file = @"E:\Program Files\Tekla Structures\2019.1\nt\bin\plugins\Tekla.Structures.Drawing.dll";
            //var file = @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Tekla.Structures.Drawing\v4.0_2019.1.0.0__2f04dbe497b71114\Tekla.Structures.Drawing.dll";

            var assembly = System.Reflection.Assembly.LoadFrom(file);
           // var assembly = System.Reflection.Assembly.LoadFile(file);

            var typeee = assembly.GetType("Tekla.Structures.Drawing.DrawingHandler");

            //dynamic instance = Activator.CreateInstance(typeee);
            dynamic instance = Activator.CreateComInstanceFrom("Tekla.Structures.Drawing.dll", "Tekla.Structures.Drawing.DrawingHandler").Unwrap();

            instance.CloseActiveDrawing(false);

            Console.WriteLine("end");
            Console.ReadKey();
            return;
            

            //OpenDrawingAndInsertLine();

            // DateTime? nullDate = null;
            // DateTime? notNullDate = new DateTime();

            System.Nullable<DateTime> nullDate = new DateTime(2016, 12, 20);
            nullDate = null;
            System.Nullable<DateTime> notNullDate = new DateTime(2016,12,20);

            var hasVal1 = nullDate.HasValue;
            var hasVal2 = notNullDate.HasValue;

            var val1 = nullDate.GetValueOrDefault();
            var val2 = notNullDate.Value;

            var type = notNullDate.GetType();


            var nType = typeof(System.Nullable<>);
           nType =  nType.MakeGenericType(typeof(DateTime));

            dynamic nDateTimeObject = Activator.CreateInstance(nType);

            //nDateTimeObject.HasValue = true;
            nDateTimeObject = new DateTime(2020, 01, 01);

            Console.WriteLine("end");
            Console.ReadKey();
        }
        
        //private static void ConvertNullable(dynamic)

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
