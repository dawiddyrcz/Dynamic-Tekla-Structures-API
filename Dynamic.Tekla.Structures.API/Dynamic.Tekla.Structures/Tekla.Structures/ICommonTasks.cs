/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class ICommonTasks 
    {

        

        internal dynamic teklaObject;



public void CreateGeneralArrangementDrawingFromTemplate(
	System.String name
	)
{
	
    try
    {
        	teklaObject.CreateGeneralArrangementDrawingFromTemplate(name);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateGeneralArrangementDrawingFromTemplate), ex);
    }
}



public void OpenAssemblyDrawingProperties(
	System.String name
	)
{
	
    try
    {
        	teklaObject.OpenAssemblyDrawingProperties(name);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(OpenAssemblyDrawingProperties), ex);
    }
}



public void OpenAutoDrawingScript(
	System.String name
	)
{
	
    try
    {
        	teklaObject.OpenAutoDrawingScript(name);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(OpenAutoDrawingScript), ex);
    }
}



public void OpenCastUnitDrawingProperties(
	System.String name
	)
{
	
    try
    {
        	teklaObject.OpenCastUnitDrawingProperties(name);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(OpenCastUnitDrawingProperties), ex);
    }
}



public void OpenDrawingList()
{

    try
    {
        	teklaObject.OpenDrawingList();

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(OpenDrawingList), ex);
    }
}



public void OpenGeneralArrangementDrawingProperties(
	System.String name
	)
{
	
    try
    {
        	teklaObject.OpenGeneralArrangementDrawingProperties(name);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(OpenGeneralArrangementDrawingProperties), ex);
    }
}



public void OpenNumberingSettings()
{

    try
    {
        	teklaObject.OpenNumberingSettings();

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(OpenNumberingSettings), ex);
    }
}



public void OpenSinglePartDrawingProperties(
	System.String name
	)
{
	
    try
    {
        	teklaObject.OpenSinglePartDrawingProperties(name);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(OpenSinglePartDrawingProperties), ex);
    }
}



public void PerformNumbering(
	System.Boolean fullNumbering
	)
{
	
    try
    {
        	teklaObject.PerformNumbering(fullNumbering);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PerformNumbering), ex);
    }
}






    }

    internal static class ICommonTasks_
    {
        public static dynamic GetTSObject(ICommonTasks dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ICommonTasks FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.ICommonTasks)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ICommonTasksArray_
    {
        public static dynamic GetTSObject(ICommonTasks[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ICommonTasks_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ICommonTasks[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ICommonTasks>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ICommonTasks_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
