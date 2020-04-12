/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System.Collections;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures
{
    internal static class IEnumerableConverter
    {
        //TODO test
        public static List<dynamic> ToTSObjects(IEnumerable dynAPIObjects)
        {
            var enumerator = dynAPIObjects.GetEnumerator();
            var output = new List<dynamic>();

            foreach (dynamic dynObject in dynAPIObjects)
            {
                if (dynObject.GetType().ToString().StartsWith("Dynamic.Tekla.Structures."))
                    output.Add(dynObject.teklaObject);
                else if (typeof(IEnumerable).IsAssignableFrom(dynObject.GetType()))
                    output.Add(ToTSObjects(dynObject));
                else
                    output.Add(dynObject);

            }

            return output;
        }

        public static List<T> FromTSObjects<T>(dynamic tsObjects)
        {
            var output = new List<T>();            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            foreach (var tsObject in tsObjects)
            {
                if (tsObject.GetType().ToString().StartsWith("Tekla.Structures."))
                {
                    string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                    var converterType = assembly.GetType(converterName);
                    var parameters = new object[] { tsObject };
                    var fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);

                    output.Add((T)fromTSObjectMethod.Invoke(null, parameters));
                }
                else if (typeof(IEnumerable).IsAssignableFrom(tsObject.GetType()))
                    output.Add(FromTSObjects(tsObject));
                else
                    output.Add((T)tsObject);
            }
            return output;
        }
    }
}
