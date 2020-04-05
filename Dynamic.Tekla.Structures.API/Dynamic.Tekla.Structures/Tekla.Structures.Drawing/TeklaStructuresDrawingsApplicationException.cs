/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class TeklaStructuresDrawingsApplicationException  : System.ApplicationException
    {

        

        internal dynamic teklaObject;

		internal TeklaStructuresDrawingsApplicationException() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TeklaStructuresDrawingsApplicationException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TeklaStructuresDrawingsApplicationException(System.String Message)
		{
			var args = new object[1];
			args[0] = Message;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException", args);
		}





    }

    internal static class TeklaStructuresDrawingsApplicationException_
    {
        public static dynamic GetTSObject(TeklaStructuresDrawingsApplicationException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TeklaStructuresDrawingsApplicationException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TeklaStructuresDrawingsApplicationExceptionArray_
    {
        public static dynamic GetTSObject(TeklaStructuresDrawingsApplicationException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructuresDrawingsApplicationException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructuresDrawingsApplicationException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TeklaStructuresDrawingsApplicationException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructuresDrawingsApplicationException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
