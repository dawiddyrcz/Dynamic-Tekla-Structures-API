/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Operations
{

    public  class GuidConversion 
    {

        

        internal dynamic teklaObject;

		public GuidConversion()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.GuidConversion");
		}

		public System.Collections.Generic.Dictionary<System.Guid, System.Guid> GetGuidMapping()
		{
			return teklaObject.GetGuidMapping();
		}

		public System.Guid GetNewGuid(System.Guid oldGuid)
		{
			return teklaObject.GetNewGuid(oldGuid);
		}





    }

    internal static class GuidConversion_
    {
        public static dynamic GetTSObject(GuidConversion dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GuidConversion FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Operations.GuidConversion)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
