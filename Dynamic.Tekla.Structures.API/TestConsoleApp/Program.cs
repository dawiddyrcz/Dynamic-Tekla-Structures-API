using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamic.Tekla.Structures;
using Dynamic.Tekla.Structures.Geometry3d;
using Dynamic.Tekla.Structures.Model;

namespace TestConsoleApp
{
    class Program
    {
        //TODO wyrzucic przypisywanie properties z konstruktora numer 2
        //TODO dodać takie same konstruktory jak są oryginalnie bo nie mogę zrobić noweg punktu

        static void Main(string[] args)
        {
            Console.WriteLine("started test");
            var model = new Model();
            Console.WriteLine(model.GetInfo().ModelPath);

            var beam = new Beam();
            beam.Material.MaterialString = "S235JR";
            beam.Profile.ProfileString = "HEB300";

            var p1 = new Point();
            var p2 = new Point();

            p2.Translate(5000, 5000, 5000);

            beam.StartPoint = p1;
            beam.EndPoint = p2;

            beam.Insert();

            model.CommitChanges();


            //var objects = model.

            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
