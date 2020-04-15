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
using System.Collections;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures
{
    internal static class IEnumerableConverter
    {
        //TODO test
        public static dynamic ToTSObjects(dynamic dynAPIObjects)
        {
            try
            {
                var output = new List<dynamic>();
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                foreach (dynamic dynObject in dynAPIObjects)
                {
                    if (dynObject.GetType().ToString().StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
                    {
                        string converterName = dynObject.GetType().ToString() + "_";
                        var converterType = assembly.GetType(converterName);
                        var parameters = new object[] { dynObject };
                        var getTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                        output.Add(getTSObjectMethod.Invoke(null, parameters));
                    }
                    else if (typeof(IEnumerable).IsAssignableFrom(dynObject.GetType()))
                    {
                        output.Add(ToTSObjects(dynObject));
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
                throw new DynamicAPIException("Error in method IEnumerableConverter.ToTSObjects() Input type: "
                                                                    + dynAPIObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
            }
        }

        public static List<T> FromTSObjects<T>(dynamic tsObjects)
        {
            try
            {
                var output = new List<T>();
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
                    else
                    {
                        output.Add((T)tsObject);
                    }
                }
                return output;
            }
            catch (Exception ex)
            {
                throw new DynamicAPIException("Error in method IEnumerableConverter.FromTSObjects() Input type: "
                                                                      + tsObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
            }
        }
    }
}
