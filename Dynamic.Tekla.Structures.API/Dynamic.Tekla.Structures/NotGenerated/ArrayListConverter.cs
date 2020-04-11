﻿/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections;

namespace Dynamic.Tekla.Structures
{
    internal static class ArrayListConverter
    {
        //TODO sprawdzić wszystkie wystąpienia 
        public static ArrayList ToTSObjects(ArrayList dynAPIObjects)
        {
            if (dynAPIObjects.Count.Equals(0))
                return new ArrayList();

            var output = new ArrayList(dynAPIObjects.Count + 1);

            foreach (dynamic dynObject in dynAPIObjects)
            {
                output.Add(dynObject.teklaObject);
            }
            return output;
        }

        public static ArrayList FromTSObjects(ArrayList tsObjects)
        {
            if (tsObjects.Count.Equals(0))
                return new ArrayList();

            var output = new ArrayList(tsObjects.Count + 1);
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            foreach (var tsObject in tsObjects)
            {
                string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                var converterType = assembly.GetType(converterName);
                var parameters = new object[] { tsObject };
                var fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);

                output.Add(fromTSObjectMethod.Invoke(null, parameters));
            }
            return output;
        }
    }
}