using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dynamic.Tekla.Structures;
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
            //InsertBeam();
            //OpenDrawingAndInsertLine();

            Events();

            

            Console.WriteLine("end");
            Console.ReadKey();
        }

        private static void Events()
        {
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                var events = new Events();
                events.Register();

                events.SelectionChange += () =>
                {
                    Console.WriteLine("selectionnn change");
                };

                events.ModelObjectChanged += (x) =>
                {
                    Console.WriteLine("ModelObject changed: " + x.Count);
                };

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
