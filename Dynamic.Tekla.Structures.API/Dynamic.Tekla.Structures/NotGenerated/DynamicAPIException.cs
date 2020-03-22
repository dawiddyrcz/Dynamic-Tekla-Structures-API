/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using System;

namespace Dynamic.Tekla.Structures
{
    public class DynamicAPIException : Exception
    {
        public DynamicAPIException(string message) : base (message)
        {

        }

        public DynamicAPIException(string message, Exception innerException) :base(message, innerException)
        {

        }

        public DynamicAPIException() : base()
        {
        }
    }
}
