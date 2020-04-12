/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures
{
    internal static class IEnumerableConverter
    {
        //TODO list<dynamic>
        public static List<T> ToTSObjects<T>(IEnumerable<T> dynAPIObjects)
        {
            var enumerator = dynAPIObjects.GetEnumerator();
            var output = new List<T>();

            foreach (dynamic dynObject in dynAPIObjects)
            {
                output.Add(dynObject.teklaObject);
            }

            return output;
        }
    }
}
