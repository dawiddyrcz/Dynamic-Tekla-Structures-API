/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures
{
    public static class ListOfListConverter
    {
        public static List<List<T>> FromTSObjects<T>(dynamic tsLists)
        {
            try
            {
                if (tsLists.Count.Equals(0))
                    return new List<List<T>>();

                var outputList = new List<List<T>>(tsLists.Count + 1);
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                foreach (var list in tsLists)
                {
                    var output = new List<T>();

                    foreach (var tsObject in list)
                    {
                        if (tsObject.GetType().ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
                        {
                            string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                            var converterType = assembly.GetType(converterName);
                            var parameters = new object[] { tsObject };
                            var fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);

                            output.Add((T)fromTSObjectMethod.Invoke(null, parameters));
                        }
                        else
                        {
                            output.Add((T)tsObject);
                        }
                    }

                    outputList.Add(output);
                }

                return outputList;
            }
            catch (Exception ex)
            {
                throw new DynamicAPIException("Error in method ListConverter.FromTSObjects() Input type: "
                                   + tsLists.GetType().ToString() + "Generic type: "+ nameof(T) 
                                   + " \n Internal error message: " + ex.Message, ex);
            }
        }
    }
    
}
