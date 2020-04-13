/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures
{
    public static class ListConverter
    {
        //TODO check IList
        //TODO test if it works
        public static List<dynamic> ToTSObjects(dynamic dynAPIObjects)
        {
            try
            {
                if (dynAPIObjects.Count.Equals(0))
                    return new List<dynamic>();

                var output = new List<dynamic>(dynAPIObjects.Count + 1);
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                foreach (dynamic dynObject in dynAPIObjects)
                {
                    if (dynObject.GetType().ToString().StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
                    {
                        string converterName = dynObject.GetType().ToString() + "_";
                        var converterType = assembly.GetType(converterName);
                        var parameters = new object[] { dynObject };
                        var fromTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                        output.Add(fromTSObjectMethod.Invoke(null, parameters));
                    }
                    else
                    {
                        output.Add(dynObject);
                    }
                }

                return output;
            }
            catch (Exception ex)
            {
                throw new DynamicAPIException("Error in method ListConverter.ToTSObjects() Input type: "
                    + dynAPIObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
            }
        }

        public static List<T> FromTSObjects<T>(dynamic tsObjects)
        {
            try
            {
                if (tsObjects.Count.Equals(0))
                    return new List<T>();

                var output = new List<T>(tsObjects.Count + 1);
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                foreach (var tsObject in tsObjects)
                {
                    if (tsObject.GetType().ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
                    {
                        string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                        var converterType = assembly.GetType(converterName);
                        var parameters = new object[] { tsObject };
                        var fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);

                        output.Add((T)fromTSObjectMethod.Invoke(null, parameters));
                    }
                    //TODO list of lists
                    else
                    {
                        output.Add((T)tsObject);
                    }
                }
                return output;
            }
            catch (Exception ex)
            {
                throw new DynamicAPIException("Error in method ListConverter.FromTSObjects() Input type: "
                                   + tsObjects.GetType().ToString() + "Generic type: "+ nameof(T) 
                                   + " \n Internal error message: " + ex.Message, ex);
            }
        }
    }
    
}
