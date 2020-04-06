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
        //TODO bug: gdy się robi pick point w rysunkach to wywala RuntimeBinderException PickPoint(string prompt)
        //TODO bug result System.Tuple
        //TODO bug: GetAllObjects(System.Type Type)

        //System.InvalidCastException: 'Nie można rzutować obiektu typu 'Dynamic.Tekla.Structures.Drawing.ContainerView' na typ 'Tekla.Structures.Drawing.DrawingObject'.'

        //TODO obejrzeć wszystkie klasy

        //TODO readme
        //TODO nuget package

        //TODO project with unit tests
        //TODO test model
        //TODO exception in Drawing enumerator
        //TODO op_explicit operator
        //TODO add info in license informaing that you have to have Tekla Structures Software

        [STAThread]
        static void Main(string[] args)
        {
            StaticFieldsOrProperties();
            InsertBeam();
            //Thread.Sleep(1);
            // OpenDrawingAndInsertLine();
            // Events();
            OperatorOverload();

            Console.WriteLine("end");
            Console.ReadKey();
        }

        private static void OperatorOverload()
        {
            var p1 = new Point(0, 0, 0);
            var p2 = new Point(1000, 0, 0);

            var p3 = p1 + p2;
            Console.WriteLine(p3.X);
        }

        private static void StaticFieldsOrProperties()
        {
            Console.WriteLine(BaseComponent.PLUGIN_OBJECT_NUMBER);
            Console.WriteLine(Dynamic.Tekla.Structures.Dialog.MainWindow.Frame.Handle);
            TSD.DrawingEnumeratorBase.AutoFetch = true;
        }

        private static void Events()
        {
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                var modelEvents = new Events();
                modelEvents.SelectionChange += () =>Console.WriteLine("SelectionChange");
                //modelEvents.ModelObjectChanged += (x) => Console.WriteLine("ModelObjectChanged: " + x.Count);
                modelEvents.ClashCheckDone += (x) => Console.WriteLine("ClashCheckDone");
                modelEvents.ClashDetected += (x) => Console.WriteLine("ClashDetected");
                modelEvents.ModelSave += () => Console.WriteLine("ModelSave");
               // modelEvents.Interrupted += () => Console.WriteLine("Interrupted");
                modelEvents.Numbering += () => Console.WriteLine("Numbering");
                modelEvents.TeklaStructuresExit += () => Console.WriteLine("TeklaStructuresExit");
                modelEvents.Register();

                var drawingEvents = new TSD.Events();
               // drawingEvents.DrawingChanged += () => Console.WriteLine("DrawingChanged");
                drawingEvents.DrawingDeleted += () => Console.WriteLine("DrawingDeleted");
                drawingEvents.DrawingInserted += () => Console.WriteLine("DrawingInserted");
                drawingEvents.DrawingStatusChanged += () => Console.WriteLine("DrawingStatusChanged");
                //drawingEvents.DrawingUpdated += (x, y) => Console.WriteLine("DrawingUpdated");
                drawingEvents.Register();

                var drawingUIEvents = new TSD.UI.Events();
                drawingUIEvents.DrawingEditorClosed += () => Console.WriteLine("DrawingEditorClosed");
                drawingUIEvents.DrawingEditorOpened += () => Console.WriteLine("DrawingEditorOpened");
                drawingUIEvents.DrawingListSelectionChanged += () => Console.WriteLine("DrawingListSelectionChanged");
                drawingUIEvents.DrawingLoaded += () => Console.WriteLine("DrawingLoaded");
                //drawingUIEvents.Interrupted += () => Console.WriteLine("DrawingInterrupted");
                drawingUIEvents.SelectionChange += () => Console.WriteLine("DrawingSelectionChange");
                drawingUIEvents.Register();


                while (true)
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("Waiting");
                }
            });
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

        private static void InsertBeam()
        {
            Console.WriteLine("started test");
            var model = new Model();
            Console.WriteLine(model.GetInfo().ModelPath);


            var p1 = new Point(0, 0, 0);
            var p2 = new Point(5000, 5000, 5000);
            //p1.X = 0;
            //p1.Y = 0;
            //p1.Z = 0;

            //p2.X = 5000;
            //p2.Y = 5000;
            //p2.Z = 5000;

            //p2.Translate(5000, 5000, 5000);

            // beam.StartPoint = p1;
            // beam.EndPoint = p2;

            var beam = new Beam(p1, p2);
            beam.Material.MaterialString = "S235JR";
            beam.Profile.ProfileString = "HEB300";

            beam.Insert();

            model.CommitChanges();

            beam.GetPhase(out Phase phase);
            Console.WriteLine("Phase: " + phase.PhaseNumber);

            double weight = 0;
            beam.GetReportProperty("WEIGHT", ref weight);

            Console.WriteLine("Weight: " + weight);

            //var result = Dynamic.Tekla.Structures.Model.Operations.Operation.DisplayPrompt("Hello static method");
            //Console.WriteLine("Result from static method = "+result);

            //var result2 = Dynamic.Tekla.Structures.Model.Operations.Operation.CalculatePourUnits();
            //Console.WriteLine("Result from static method2 = " + result2);

            //var result3 = Dynamic.Tekla.Structures.Model.Operations.Operation.CopyObject(beam, new Vector(5000, 0, 0));
            //Console.WriteLine("Result from static method3 = " + result3.Identifier.ID);

            string value = String.Empty;
            var result4 = Dynamic.Tekla.Structures.TeklaStructuresSettings.GetAdvancedOption("XS_MACRO_DIRECTORY", ref value);
            Console.WriteLine("Macro directory: " + value + " result: " + result4);

            //var phases = model.GetPhases();
            //foreach (var phase in phases)
            //{

            //}

            //Console.WriteLine("Objects");
            //var objects = model.GetModelObjectSelector().GetAllObjects();

            //while (objects.MoveNext())
            //{
            //    Console.WriteLine(objects.Current.Identifier.ID);

            //    if (objects.Current is Beam b)
            //    {
            //        Console.WriteLine(b.Name);
            //        Console.WriteLine(b.StartPoint.ToString());
            //        Console.WriteLine(b.EndPoint.ToString());
            //        Console.WriteLine(b.Profile.ProfileString);
            //    }
            //}


            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("Beams:");
            //var beams = model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM);

            //while (beams.MoveNext())
            //{
            //    Console.WriteLine(beams.Current.Identifier.ID);
            //}
        }
    }
}
