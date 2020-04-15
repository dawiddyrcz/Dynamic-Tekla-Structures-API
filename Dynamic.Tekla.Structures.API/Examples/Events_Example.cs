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
using TSM = Dynamic.Tekla.Structures.Model;
using TSD = Dynamic.Tekla.Structures.Drawing;

namespace Examples
{
    public class Events_Example : ExampleBase
    {
        public override void Run()
        {
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                //Register model events
                var modelEvents = new TSM.Events();
                modelEvents.SelectionChange += () => Console.WriteLine("SelectionChange");
                modelEvents.ClashCheckDone += (x) => Console.WriteLine("ClashCheckDone");
                modelEvents.ClashDetected += (x) => Console.WriteLine("ClashDetected");
                modelEvents.ModelSave += () => Console.WriteLine("ModelSave");
                modelEvents.Numbering += () => Console.WriteLine("Numbering");
                modelEvents.TeklaStructuresExit += () => Console.WriteLine("TeklaStructuresExit");

                //This events are not present in official old tekla api versions
                if (Dynamic.Tekla.Structures.TeklaProcess.TeklaFileVersion.Major >= 2018)
                {
                    modelEvents.ModelObjectChanged += (x) => Console.WriteLine("ModelObjectChanged: " + x.Count);
                    modelEvents.Interrupted += () => Console.WriteLine("Interrupted");
                }
                
                modelEvents.Register();

                //Register drawing events
                var drawingEvents = new TSD.Events();
                drawingEvents.DrawingDeleted += () => Console.WriteLine("DrawingDeleted");
                drawingEvents.DrawingInserted += () => Console.WriteLine("DrawingInserted");
                drawingEvents.DrawingStatusChanged += () => Console.WriteLine("DrawingStatusChanged");

                //This events are not present in official old tekla api versions
                if (Dynamic.Tekla.Structures.TeklaProcess.TeklaFileVersion.Major >= 2019)
                {
                    drawingEvents.DrawingUpdated += (x, y) => Console.WriteLine("DrawingUpdated");
                    drawingEvents.DrawingChanged += () => Console.WriteLine("DrawingChanged");
                }
                
                drawingEvents.Register();

                //Register drawing UI events
                var drawingUIEvents = new TSD.UI.Events();
                drawingUIEvents.DrawingEditorClosed += () => Console.WriteLine("DrawingEditorClosed");
                drawingUIEvents.DrawingEditorOpened += () => Console.WriteLine("DrawingEditorOpened");
                drawingUIEvents.DrawingListSelectionChanged += () => Console.WriteLine("DrawingListSelectionChanged");
                drawingUIEvents.DrawingLoaded += () => Console.WriteLine("DrawingLoaded");
                drawingUIEvents.SelectionChange += () => Console.WriteLine("DrawingSelectionChange");

                //This events are not present in official old tekla api versions
                if (Dynamic.Tekla.Structures.TeklaProcess.TeklaFileVersion.Major >= 2018)
                {
                    drawingUIEvents.Interrupted += () => Console.WriteLine("DrawingInterrupted");
                }

                drawingUIEvents.Register();

                Console.WriteLine("Events are now registered. Do something in model. Do not close console");
                Console.WriteLine();

                while (true)
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Waiting for any event....");
                }
            });

            Console.ReadKey();
        }
    }
}
