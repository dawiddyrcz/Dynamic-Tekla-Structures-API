/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSet  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.RebarProperties RebarProperties
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarProperties_.FromTSObject(teklaObject.RebarProperties);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarProperties", ex); }
			}
			set
			{
				try {
				teklaObject.RebarProperties = Dynamic.Tekla.Structures.Model.RebarProperties_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarProperties", ex); }
			}
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarLegFace> LegFaces
		{
			get
			{
				try {
					return teklaObject.LegFaces;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LegFaces", ex); }
			}
			set
			{
				try {
					teklaObject.LegFaces = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LegFaces", ex); }
			}
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarGuideline> Guidelines
		{
			get
			{
				try {
					return teklaObject.Guidelines;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Guidelines", ex); }
			}
			set
			{
				try {
					teklaObject.Guidelines = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Guidelines", ex); }
			}
		}

		public System.Int32 LayerOrderNumber
		{
			get
			{
				try {
					return teklaObject.LayerOrderNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LayerOrderNumber", ex); }
			}
			set
			{
				try {
					teklaObject.LayerOrderNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LayerOrderNumber", ex); }
			}
		}

        

        

		public RebarSet()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSet");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarSet(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarSetAdditions()
{

    try
    {
        	var result = teklaObject.GetRebarSetAdditions();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarSetAdditions), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarModifiers()
{

    try
    {
        	var result = teklaObject.GetRebarModifiers();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarModifiers), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
{

    try
    {
        	var result = teklaObject.GetReinforcements();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReinforcements), ex);
    }
}






    }

    internal static class RebarSet_
    {
        public static dynamic GetTSObject(RebarSet dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSet FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarSet)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSetArray_
    {
        public static dynamic GetTSObject(RebarSet[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSet_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSet[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSet>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSet_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
