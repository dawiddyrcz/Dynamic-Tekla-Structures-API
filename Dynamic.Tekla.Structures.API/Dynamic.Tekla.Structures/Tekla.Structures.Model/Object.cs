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
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public abstract class Object 
    {


        public Dynamic.Tekla.Structures.Identifier Identifier
        {
            get
            {
                try
                {
                var value = teklaObject.Identifier;
                var value_ = Dynamic.Tekla.Structures.Identifier_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Identifier) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Identifier), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
                teklaObject.Identifier = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Identifier), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;






    }

    internal static class Object_
    {
        public static dynamic GetTSObject(Object dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Object FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Object)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ObjectArray_
    {
        public static dynamic GetTSObject(Object[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Object_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Object[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Object>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Object_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
