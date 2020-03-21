﻿using System;
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
        //TODO dodać takie same konstruktory jak są oryginalnie bo nie mogę zrobić noweg punktu
        //ProgramConfigurationEnum ma zduplikowane wartości
        
        static void Main(string[] args)
        {
            Console.WriteLine("started test");
            var model = new Model();
            Console.WriteLine(model.GetInfo().ModelPath);

            var beam = new Beam();
            beam.Material.MaterialString = "S235JR";
            beam.Profile.ProfileString = "HEB300";

            var p1 = new Point(0,0,0);
            var p2 = new Point(5000,5000,5000);
            //p1.X = 0;
            //p1.Y = 0;
            //p1.Z = 0;

            //p2.X = 5000;
            //p2.Y = 5000;
            //p2.Z = 5000;

            //p2.Translate(5000, 5000, 5000);

            beam.StartPoint = p1;
            beam.EndPoint = p2;

            beam.Insert();

            model.CommitChanges();


            Console.WriteLine("Objects");
            var objects = model.GetModelObjectSelector().GetAllObjects();

            while (objects.MoveNext())
            {
                Console.WriteLine(objects.Current.Identifier.ID);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Beams:");
            var beams = model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM);

            while (beams.MoveNext())
            {
                Console.WriteLine(beams.Current.Identifier.ID);
            }

            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
