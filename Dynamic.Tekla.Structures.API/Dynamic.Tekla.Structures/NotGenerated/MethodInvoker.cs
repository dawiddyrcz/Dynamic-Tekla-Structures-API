/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using System;

namespace Dynamic.Tekla.Structures
{
    public static class MethodInvoker
    {
        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, out object param1)
        {
            param1 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, out System.Collections.Generic.Dictionary<string, double> param1)
        {
            param1 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = (System.Collections.Generic.Dictionary<string, double>)parameters[0];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, out System.Collections.Generic.Dictionary<string, int> param1)
        {
            param1 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = (System.Collections.Generic.Dictionary<string, int>)parameters[0];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, out System.Collections.Generic.Dictionary<string, string> param1)
        {
            param1 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = (System.Collections.Generic.Dictionary<string, string>)parameters[0];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, out object param2)
        {
            param2 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2};
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, out System.Collections.Generic.Dictionary<string, double> param2)
        {
            param2 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = (System.Collections.Generic.Dictionary<string, double>)parameters[1];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, out System.Collections.Generic.Dictionary<string, int> param2)
        {
            param2 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = (System.Collections.Generic.Dictionary<string, int>)parameters[1];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, out System.Collections.Generic.Dictionary<string, string> param2)
        {
            param2 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = (System.Collections.Generic.Dictionary<string, string>)parameters[1];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, out object param2, out object param3)
        {
            param2 = null;
            param3 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 , param3};
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, object param2, out object param3, out object param4)
        {
            param3 = null;
            param4 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, out object param2, out object param3, out object param4)
        {
            param2 = null;
            param3 = null;
            param4 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, object param2, out object param3, out object param4, out object param5)
        {
            param3 = null;
            param4 = null;
            param5 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4 , param5};
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            return result;
        }

        public static object InvokeMethod(string typeName, string methodName, dynamic teklaObject, object param1, object param2, object param3, out object param4, out object param5, out object param6, out object param7)
        {
            param4 = null;
            param5 = null;
            param6 = null;
            param7 = null;
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4, param5, param6, param7 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(teklaObject, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            return result;
        }

        //**************************************************************


        public static object InvokeStaticMethod(string typeName, string methodName)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { };
            var method =TSActivator.GetMethod(methodName, parameters, type);

            var result =  method.Invoke(null, parameters);
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, ref object param1)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            return result;
        }

        
        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            ref bool param2)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = (bool)parameters[1];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            ref double param2)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = (double)parameters[1];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1,
            ref int param2)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = (int)parameters[1];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1,
            ref string param2)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = (string)parameters[1];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            ref object param2)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2 , param3};
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, ref object param3)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, object param4)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, object param4, object param5)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4, param5 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, object param4, object param5, object param6)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4, param5, param6 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, object param4, object param5, object param6, object param7)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4, param5, param6, param7 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, object param4, object param5, object param6, ref object param7)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] { param1, param2, param3, param4, param5, param6, param7 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1,
            object param2, object param3, object param4, object param5, object param6, object param7, 
            object param8)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref string param4, object param5, object param6, object param7,
            object param8)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = (string)parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            ref string param2, object param3, object param4, object param5, object param6, object param7,
            object param8)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = (string)parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8, object param9)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8, param9 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            ref object param8, ref object param9)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8, param9 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8, object param9, object param10)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            param10 = parameters[9];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8, ref object param9, ref object param10)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            param10 = parameters[9];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1,
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8, object param9, object param10, object param11)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[] 
            { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            param10 = parameters[9];
            param11 = parameters[10];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8, object param9, ref object param10, ref object param11)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[]
            { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            param10 = parameters[9];
            param11 = parameters[10];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8, object param9, object param10, object param11, object param12)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[]
            { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11,
            param12 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            param10 = parameters[9];
            param11 = parameters[10];
            param12 = parameters[11];
            return result;
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object param1, 
            object param2, object param3, ref object param4, object param5, object param6, object param7,
            object param8, object param9, object param10, object param11, object param12, object param13)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var parameters = new object[]
            { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11,
            param12, param13 };
            var method = TSActivator.GetMethod(methodName, parameters, type);

            var result = method.Invoke(null, parameters);
            param1 = parameters[0];
            param2 = parameters[1];
            param3 = parameters[2];
            param4 = parameters[3];
            param5 = parameters[4];
            param6 = parameters[5];
            param7 = parameters[6];
            param8 = parameters[7];
            param9 = parameters[8];
            param10 = parameters[9];
            param11 = parameters[10];
            param12 = parameters[11];
            param13 = parameters[12];
            return result;
        }
    }
}
