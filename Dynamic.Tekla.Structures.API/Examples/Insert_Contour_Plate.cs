/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSM = Dynamic.Tekla.Structures.Model;
using T3D = Dynamic.Tekla.Structures.Geometry3d;
using System.Collections;

namespace Examples
{
    public class Insert_Contour_Plate :ExampleBase
    {
        public override void Run()
        {
            var p1 = new T3D.Point(0, 0, 0);
            var p2 = new T3D.Point(0, 0, 5000);
            var p3 = new T3D.Point(0, 5000, 6000);
            var p4 = new T3D.Point(0, 7000, 0);

            var contour = new TSM.Contour();
            contour.ContourPoints = new ArrayList()
            {
                new TSM.ContourPoint(p1, new TSM.Chamfer()),
                new TSM.ContourPoint(p2, new TSM.Chamfer()),
                new TSM.ContourPoint(p3, new TSM.Chamfer()),
                new TSM.ContourPoint(p4, new TSM.Chamfer()),
            };

            var contourPlate = new TSM.ContourPlate();
            contourPlate.Contour = contour;
            contourPlate.Profile.ProfileString = "500";
            contourPlate.Material.MaterialString = "S235JR";

            contourPlate.Insert();

            new TSM.Model().CommitChanges();

            var reportPropertiesNames = new ArrayList()
            {
                "WEIGHT",
                "AREA",
                "LENGTH"
            };

            var hashTable = new Hashtable();
            contourPlate.GetDoubleReportProperties(reportPropertiesNames, ref hashTable);

            Console.WriteLine("Contour plate inserterd. Id: " + contourPlate.Identifier.ID);
            Console.WriteLine("Report properties:");

            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine($"Report property: {key} = {hashTable[key]}");
            }
        }
    }
}
