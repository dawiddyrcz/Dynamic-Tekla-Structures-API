/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class IntList  : System.Collections.CollectionBase
    {

		public System.Int32 Item
		{
			get
			{
				try {
					return teklaObject.Item;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
			set
			{
				try {
					teklaObject.Item = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public IntList()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.IntList");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public IntList(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Int32 Add(
	System.Int32 value
	)
{
	
    try
    {
        	var result = (System.Int32) teklaObject.Add(value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Add), ex);
    }
}



public System.Boolean Contains(
	System.Int32 value
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.Contains(value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Contains), ex);
    }
}



public System.Int32 IndexOf(
	System.Int32 value
	)
{
	
    try
    {
        	var result = (System.Int32) teklaObject.IndexOf(value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IndexOf), ex);
    }
}



public System.Int32 IndexOf(
	System.Int32 value,
	System.Int32 startIndex
	)
{
	
	
    try
    {
        	var result = (System.Int32) teklaObject.IndexOf(value, startIndex);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IndexOf), ex);
    }
}



public System.Int32 IndexOf(
	System.Int32 value,
	System.Int32 startIndex,
	System.Int32 count
	)
{
	
	
	
    try
    {
        	var result = (System.Int32) teklaObject.IndexOf(value, startIndex, count);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IndexOf), ex);
    }
}



public void Insert(
	System.Int32 index,
	System.Int32 value
	)
{
	
	
    try
    {
        	teklaObject.Insert(index, value);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.IntList GetRange(
	System.Int32 index,
	System.Int32 count
	)
{
	
	
    try
    {
        	var result = teklaObject.GetRange(index, count);

        	var _result = Dynamic.Tekla.Structures.Drawing.IntList_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRange), ex);
    }
}



public System.Int32 LastIndexOf(
	System.Int32 value
	)
{
	
    try
    {
        	var result = (System.Int32) teklaObject.LastIndexOf(value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(LastIndexOf), ex);
    }
}



public System.Int32 LastIndexOf(
	System.Int32 value,
	System.Int32 startIndex
	)
{
	
	
    try
    {
        	var result = (System.Int32) teklaObject.LastIndexOf(value, startIndex);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(LastIndexOf), ex);
    }
}



public System.Int32 LastIndexOf(
	System.Int32 value,
	System.Int32 startIndex,
	System.Int32 count
	)
{
	
	
	
    try
    {
        	var result = (System.Int32) teklaObject.LastIndexOf(value, startIndex, count);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(LastIndexOf), ex);
    }
}



public void Remove(
	System.Int32 value
	)
{
	
    try
    {
        	teklaObject.Remove(value);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Remove), ex);
    }
}



public void RemoveRange(
	System.Int32 index,
	System.Int32 count
	)
{
	
	
    try
    {
        	teklaObject.RemoveRange(index, count);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveRange), ex);
    }
}



public System.Int32[] ToArray()
{

    try
    {
        	var result = (System.Int32[]) teklaObject.ToArray();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ToArray), ex);
    }
}



public System.Boolean IsEqual(
	System.Object ObjectToCompare
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.IsEqual(ObjectToCompare);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsEqual), ex);
    }
}






    }

    internal static class IntList_
    {
        public static dynamic GetTSObject(IntList dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IntList FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.IntList)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IntListArray_
    {
        public static dynamic GetTSObject(IntList[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IntList_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IntList[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IntList>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IntList_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
