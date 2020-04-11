/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BoltArray  : Dynamic.Tekla.Structures.Model.BoltGroup
    {

        

        

		public BoltArray()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltArray");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BoltArray(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean AddBoltDistX(
	System.Double DistX
	)
{
	
    try
    {
        	var result = teklaObject.AddBoltDistX(DistX);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddBoltDistX), ex);
    }
}



public System.Boolean AddBoltDistY(
	System.Double DistY
	)
{
	
    try
    {
        	var result = teklaObject.AddBoltDistY(DistY);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddBoltDistY), ex);
    }
}



public System.Boolean RemoveBoltDistX(
	System.Int32 Index
	)
{
	
    try
    {
        	var result = teklaObject.RemoveBoltDistX(Index);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveBoltDistX), ex);
    }
}



public System.Boolean RemoveBoltDistY(
	System.Int32 Index
	)
{
	
    try
    {
        	var result = teklaObject.RemoveBoltDistY(Index);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveBoltDistY), ex);
    }
}



public System.Int32 GetBoltDistXCount()
{

    try
    {
        	var result = teklaObject.GetBoltDistXCount();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistXCount), ex);
    }
}



public System.Int32 GetBoltDistYCount()
{

    try
    {
        	var result = teklaObject.GetBoltDistYCount();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistYCount), ex);
    }
}



public System.Double GetBoltDistX(
	System.Int32 Index
	)
{
	
    try
    {
        	var result = teklaObject.GetBoltDistX(Index);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistX), ex);
    }
}



public System.Double GetBoltDistY(
	System.Int32 Index
	)
{
	
    try
    {
        	var result = teklaObject.GetBoltDistY(Index);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistY), ex);
    }
}



public System.Boolean SetBoltDistX(
	System.Int32 Index,
	System.Double DistX
	)
{
	
	
    try
    {
        	var result = teklaObject.SetBoltDistX(Index, DistX);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetBoltDistX), ex);
    }
}



public System.Boolean SetBoltDistY(
	System.Int32 Index,
	System.Double DistY
	)
{
	
	
    try
    {
        	var result = teklaObject.SetBoltDistY(Index, DistY);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetBoltDistY), ex);
    }
}






    }

    internal static class BoltArray_
    {
        public static dynamic GetTSObject(BoltArray dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BoltArray FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BoltArray)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BoltArrayArray_
    {
        public static dynamic GetTSObject(BoltArray[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BoltArray_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BoltArray[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BoltArray>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BoltArray_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
