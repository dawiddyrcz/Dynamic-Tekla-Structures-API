/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

namespace Dynamic.Tekla.Structures
{
    public static class TypeConverter
    {
        //TODO tests
        public static System.Type ToTSObjects(System.Type input)
        {
            var typeName = TypeFullName.GetTypeFullName(input).Replace("Dynamic.Tekla.Structures.", "Tekla.Structures.");
            return TSActivator.GetTypeFromTypeName(typeName);
        }

        public static System.Type[] ToTSObjects(System.Type[] input)
        {
            var output = new System.Type[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = ToTSObjects(input[i]);
            }

            return output;
        }

        public static System.Type FromTSObjects(System.Type input)
        {
            var typeName = TypeFullName.GetTypeFullName(input).Replace("Tekla.Structures.", "Dynamic.Tekla.Structures.");
            return TSActivator.GetTypeFromTypeName(typeName);
        }

        public static System.Type[] FromTSObjects(System.Type[] input)
        {
            var output = new System.Type[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = FromTSObjects(input[i]);
            }

            return output;
        }
    }
}
