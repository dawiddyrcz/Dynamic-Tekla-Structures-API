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

namespace Examples
{
    public class Model_Object_Enumerator : ExampleBase
    {
        public override void Run()
        {
            var model = new TSM.Model();
            var modelObjectSelector = model.GetModelObjectSelector();
            TSM.ModelObjectEnumerator.AutoFetch = true;

            Console.WriteLine("Getting all objects from opened model");
            var allObjects = modelObjectSelector.GetAllObjects();
            allObjects.SelectInstances = false;

            Console.WriteLine(nameof(allObjects) + " cout: " + allObjects.GetSize());

            for (int i = 0; i < 20 && allObjects.MoveNext(); i++)
            {
                allObjects.Current.GetPhase(out TSM.Phase phase);
                Console.WriteLine(allObjects.Current.GetType()+"\tPhase number: " + phase.PhaseNumber);
            }

            Console.WriteLine();
            Console.WriteLine("Getting beams from opened model");
            var beams = modelObjectSelector.GetAllObjectsWithType(TSM.ModelObject.ModelObjectEnum.BEAM);

            Console.WriteLine(nameof(beams) + " cout: " + beams.GetSize());

            for (int i = 0; i < 20 && beams.MoveNext(); i++)
            {
                var beam = beams.Current as TSM.Beam;
                Console.WriteLine(beams.Current.GetType() + "\tProfile: " + beam.Profile.ProfileString);
            }
        }
    }
}
