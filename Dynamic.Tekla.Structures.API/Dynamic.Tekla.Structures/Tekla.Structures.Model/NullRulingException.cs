/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class NullRulingException  : Dynamic.Tekla.Structures.Model.LoftedPlateOperationException
    {

        

        

		public NullRulingException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NullRulingException");
		}





    }

    internal static class NullRulingException_
    {
        public static dynamic GetTSObject(NullRulingException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static NullRulingException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.NullRulingException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NullRulingExceptionArray_
    {
        public static dynamic GetTSObject(NullRulingException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NullRulingException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NullRulingException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<NullRulingException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NullRulingException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
