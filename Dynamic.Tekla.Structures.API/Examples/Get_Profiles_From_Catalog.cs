/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using System;
using TSC = Dynamic.Tekla.Structures.Catalogs;

namespace Examples
{
    public class Get_Profiles_From_Catalog : ExampleBase
    {
        public override void Run()
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
                Console.WriteLine(profileItemEnumerator.Current.GetCrossSection(0).Profile.Name);
                i++;
                if (i == 500) break;
            }
            Console.WriteLine("Printed first 500 profiles from catalog");
        }
    }
}
