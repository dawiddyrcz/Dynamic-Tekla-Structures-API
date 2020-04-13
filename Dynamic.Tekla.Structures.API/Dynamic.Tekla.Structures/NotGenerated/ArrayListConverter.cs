/*Copyright (C) Dawid Dyrcz 2020
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
        public static ArrayList ToTSObjects(ArrayList dynAPIObjects)
        {
            try
            {
                if (dynAPIObjects.Count.Equals(0))
                    return new ArrayList();

                var output = new ArrayList(dynAPIObjects.Count);
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                foreach (dynamic dynObject in dynAPIObjects)
                {
                    if (dynObject is ArrayList)
                    {
                        output.Add(ToTSObjects(dynObject));
                    }
                    else if (dynObject.GetType().ToString().StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
                    {
                        string converterName = dynObject.GetType().ToString() + "_";
                        var converterType = assembly.GetType(converterName);
                        var parameters = new object[] { dynObject };
                        var getTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                        output.Add(getTSObjectMethod.Invoke(null, parameters));
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
                throw new DynamicAPIException("Error in method ArrayListConverter.ToTSObjects() Input type: "
                                                                   + dynAPIObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
            }
        }

        public static ArrayList FromTSObjects(ArrayList tsObjects)
        {
            try
            {
                if (tsObjects.Count.Equals(0))
                    return new ArrayList();

                var output = new ArrayList(tsObjects.Count);
                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                foreach (dynamic tsObject in tsObjects)
                {
                    if (tsObject is ArrayList)
                    {
                        output.Add(FromTSObjects(tsObject));
                    }
                    else if (tsObject.GetType().ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
                    {
                        string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                        var converterType = assembly.GetType(converterName);
                        var parameters = new object[] { tsObject };
                        var fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);

                        output.Add(fromTSObjectMethod.Invoke(null, parameters));
                    }
                    else
                    {
                        output.Add(tsObject);
                    }
                }
                return output;
            }
            catch (Exception ex)
            {
                throw new DynamicAPIException("Error in method ArrayListConverter.FromTSObjects() Input type: "
                                                                    + tsObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
            }
        }
    }
}
