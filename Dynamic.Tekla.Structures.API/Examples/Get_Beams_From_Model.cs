/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using System;
using TSM = Dynamic.Tekla.Structures.Model;

namespace Examples
{
    public class Get_Beams_From_Model :ExampleBase
    {
        public override void Run()
        {
            var model = new TSM.Model();
            TSM.ModelObjectEnumerator.AutoFetch = true;
            var beams = model.GetModelObjectSelector().GetAllObjectsWithType(new Type[] { typeof(TSM.Beam) });

            int i = 0;
            while (beams.MoveNext())
            {
                var beam = beams.Current as TSM.Beam;

                Console.WriteLine("Beam: ");
                Console.WriteLine(beam.Name);
                Console.WriteLine(beam.Profile.ProfileString);
                Console.WriteLine(beam.StartPoint);
                Console.WriteLine();
                i++;
                if (i == 5) break;
            }
        }
    }
}
