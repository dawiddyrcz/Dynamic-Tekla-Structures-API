/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.UI
{

    public  class DrawingObjectSelector 
    {

        

        internal dynamic teklaObject;

		internal DrawingObjectSelector() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingObjectSelector(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean SelectObject(
	Dynamic.Tekla.Structures.Drawing.DrawingObject DrawingObject_
	)
{
	var DrawingObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(DrawingObject_);
    try
    {
        	var result = (System.Boolean) teklaObject.SelectObject(DrawingObject);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SelectObject), ex);
    }
}



public System.Boolean SelectObjects(
	System.Collections.ArrayList DrawingObjects_,
	System.Boolean ExtendSelection
	)
{
	var DrawingObjects = ArrayListConverter.ToTSObjects(DrawingObjects_);
	
    try
    {
        	var result = (System.Boolean) teklaObject.SelectObjects(DrawingObjects, ExtendSelection);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SelectObjects), ex);
    }
}



public System.Boolean UnselectObject(
	Dynamic.Tekla.Structures.Drawing.DrawingObject DrawingObject_
	)
{
	var DrawingObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(DrawingObject_);
    try
    {
        	var result = (System.Boolean) teklaObject.UnselectObject(DrawingObject);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(UnselectObject), ex);
    }
}



public System.Boolean UnselectObjects(
	System.Collections.ArrayList DrawingObjects_
	)
{
	var DrawingObjects = ArrayListConverter.ToTSObjects(DrawingObjects_);
    try
    {
        	var result = (System.Boolean) teklaObject.UnselectObjects(DrawingObjects);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(UnselectObjects), ex);
    }
}



public System.Boolean UnselectAllObjects()
{

    try
    {
        	var result = (System.Boolean) teklaObject.UnselectAllObjects();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(UnselectAllObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetSelected()
{

    try
    {
        	var result = teklaObject.GetSelected();

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSelected), ex);
    }
}






    }

    internal static class DrawingObjectSelector_
    {
        public static dynamic GetTSObject(DrawingObjectSelector dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingObjectSelector FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.DrawingObjectSelector)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingObjectSelectorArray_
    {
        public static dynamic GetTSObject(DrawingObjectSelector[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingObjectSelector_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingObjectSelector[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DrawingObjectSelector>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingObjectSelector_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
