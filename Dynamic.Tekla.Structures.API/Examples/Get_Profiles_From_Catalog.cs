/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using System;
using TSC = Dynamic.Tekla.Structures.Catalogs;
using TS = Dynamic.Tekla.Structures;

namespace Examples
{
    public class Get_Profiles_From_Catalog : ExampleBase
    {
        public override void Run()
        {
            try
            {
                var catalogHandler = new TSC.CatalogHandler();
                var profileItemEnumerator = catalogHandler.GetLibraryProfileItems();

                int i = 0;
                while (profileItemEnumerator.MoveNext())
                {
                    Console.Write(profileItemEnumerator.Current.ProfileItemType);
                    Console.Write("\t");
                    Console.Write(profileItemEnumerator.Current.ParameterString);
                    Console.Write("\t");

                    //Crosssection is avaiable from version 2019 of Tekla Structures
                    if (TS.TeklaProcess.TeklaFileVersion.Major >= 2019)
                        Console.WriteLine(profileItemEnumerator.Current.GetCrossSection(0).Profile.Name); 

                    i++;
                    if (i == 500) break;
                }

                if (profileItemEnumerator.GetSize() == 0)
                {
                    Console.WriteLine("There are no profiles. Open tekla and load any model");
                    return;
                }

                Console.WriteLine("Printed first 500 profiles from catalog");
               
                //Crosssection is avaiable from version 2019 of Tekla Structures
                if (TS.TeklaProcess.TeklaFileVersion.Major >= 2019)
                {
                    Console.WriteLine();                    
                    var crossSection = profileItemEnumerator.Current.GetCrossSection(0);
                    var outerPoints = crossSection.OuterSurfacePoints;
                    var listOfListOfInnerPoints = crossSection.InnerSurfacePoints;

                    Console.WriteLine("Outer points for profile: " + crossSection.Profile.Name);
                    foreach (var point in outerPoints)
                    {
                        Console.WriteLine($"Point: {point.X} {point.Y} {point.Z}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Inner points:");
                    foreach (var list in listOfListOfInnerPoints)
                    {
                        Console.WriteLine("List:");
                        foreach (var point in list)
                        {
                            Console.WriteLine($"\tPoint: {point.X} {point.Y} {point.Z}");
                        }
                    }
                }
            }
            catch (TS.DynamicAPITeklaNotRunningException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
