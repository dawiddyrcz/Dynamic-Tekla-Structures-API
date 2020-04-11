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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GuidConversion(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Collections.Generic.Dictionary<System.Guid, System.Guid> GetGuidMapping()
{

    try
    {
        	var result = (System.Collections.Generic.Dictionary<System.Guid, System.Guid>) teklaObject.GetGuidMapping();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetGuidMapping), ex);
    }
}



public System.Guid GetNewGuid(
	System.Guid oldGuid
	)
{
	
    try
    {
        	var result = (System.Guid) teklaObject.GetNewGuid(oldGuid);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetNewGuid), ex);
    }
}






    }

    internal static class GuidConversion_
    {
        public static dynamic GetTSObject(GuidConversion dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GuidConversion FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Operations.GuidConversion)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GuidConversionArray_
    {
        public static dynamic GetTSObject(GuidConversion[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GuidConversion_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GuidConversion[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GuidConversion>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GuidConversion_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
