/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PourObject  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.Int32 Class
		{
			get
			{
				try {
					return teklaObject.Class;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class", ex); }
			}
			set
			{
				try {
					teklaObject.Class = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class", ex); }
			}
		}

		public System.String PourNumber
		{
			get
			{
				try {
					return teklaObject.PourNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourNumber", ex); }
			}
			set
			{
				try {
					teklaObject.PourNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourNumber", ex); }
			}
		}

		public System.String PourType
		{
			get
			{
				try {
					return teklaObject.PourType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourType", ex); }
			}
			set
			{
				try {
					teklaObject.PourType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourType", ex); }
			}
		}

		public System.String ConcreteMixture
		{
			get
			{
				try {
					return teklaObject.ConcreteMixture;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConcreteMixture", ex); }
			}
			set
			{
				try {
					teklaObject.ConcreteMixture = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConcreteMixture", ex); }
			}
		}

        

        

		public PourObject()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PourObject");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PourObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public Dynamic.Tekla.Structures.Model.Solid GetSolid()
{

    try
    {
        	var result = teklaObject.GetSolid();

        	var _result = Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
    }
}



public Dynamic.Tekla.Structures.Model.PolymeshEnumerator GetPourPolymeshes()
{

    try
    {
        	var result = teklaObject.GetPourPolymeshes();

        	var _result = Dynamic.Tekla.Structures.Model.PolymeshEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPourPolymeshes), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetParts()
{

    try
    {
        	var result = teklaObject.GetParts();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetParts), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjects()
{

    try
    {
        	var result = teklaObject.GetObjects();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
{

    try
    {
        	var result = teklaObject.GetFatherPourUnit();

        	var _result = Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFatherPourUnit), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
{

    try
    {
        	var result = teklaObject.GetSurfaceObjects();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSurfaceObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
{

    try
    {
        	var result = teklaObject.GetAssembly();

        	var _result = Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAssembly), ex);
    }
}






    }

    internal static class PourObject_
    {
        public static dynamic GetTSObject(PourObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PourObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourObjectArray_
    {
        public static dynamic GetTSObject(PourObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
