/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using TSM = Dynamic.Tekla.Structures.Model;
using T3D = Dynamic.Tekla.Structures.Geometry3d;
using System.Collections;

namespace Examples
{
    public class Insert_Beam_In_Model : ExampleBase
    {

        public override void Run()
        {
            //Crate beam
            var beam = new TSM.Beam();
            beam.Material.MaterialString = "S235JR";
            beam.Profile.ProfileString = "HEB300";
            beam.StartPoint = new T3D.Point(0, 0, 0);
            beam.EndPoint = new T3D.Point(5000, 5000, 5000);
            beam.Class = "2";
            beam.Name = "Hello beam";
            beam.Insert();

            //Commit changes in model
            var model = new TSM.Model();
            model.CommitChanges();

            //Show beam identifiers
            Console.WriteLine("Beam inserted");
            Console.WriteLine("Beam name:\t" + beam.Name);
            Console.WriteLine("Beam id:\t" + beam.Identifier.ID);
            Console.WriteLine("Beam guid:\t" + beam.Identifier.GUID);

            //Get phase
            beam.GetPhase(out TSM.Phase phase);
            Console.WriteLine("Beam phase:\t" + phase.PhaseNumber);

            //Check weight
            double weight = 0;
            beam.GetReportProperty("WEIGHT", ref weight);
            Console.WriteLine("Beam weight:\t" + weight);

            //Check profile
            string profile = "";
            beam.GetReportProperty("PROFILE", ref profile);
            Console.WriteLine("Beam profile:\t" + weight);
            
            //Select beam
            var selector = new TSM.UI.ModelObjectSelector();
            selector.Select(new ArrayList() { beam });

        }
    }
}
