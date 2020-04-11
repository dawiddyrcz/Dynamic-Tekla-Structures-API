/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.UI
{

    public  class Picker 
    {

        

        internal dynamic teklaObject;

		internal Picker() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Picker(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean IsInteractive()
{

    try
    {
        	var result = (System.Boolean) teklaObject.IsInteractive();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsInteractive), ex);
    }
}



public void PickPoint(
	System.String prompt,
	out Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_
	)
{
	
	var pickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
    try
    {
        	teklaObject.PickPoint(prompt, out pickedPoint, out pickedView);
	pickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(pickedPoint);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickPoint), ex);
    }
}



public System.Tuple<Dynamic.Tekla.Structures.Geometry3d.Point, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoint(
	System.String prompt
	)
{
	
    try
    {
        	var result = teklaObject.PickPoint(prompt);

        	var _result = TupleConverter.FromTSObject<Dynamic.Tekla.Structures.Geometry3d.Point, Dynamic.Tekla.Structures.Drawing.ViewBase>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickPoint), ex);
    }
}



public void PickTwoPoints(
	System.String firstPrompt,
	System.String secondPrompt,
	out Dynamic.Tekla.Structures.Geometry3d.Point firstPickedPoint_,
	out Dynamic.Tekla.Structures.Geometry3d.Point secondPickedPoint_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_
	)
{
	
	
	var firstPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
	var secondPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
    try
    {
        	teklaObject.PickTwoPoints(firstPrompt, secondPrompt, out firstPickedPoint, out secondPickedPoint, out pickedView);
	firstPickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(firstPickedPoint);
	secondPickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(secondPickedPoint);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickTwoPoints), ex);
    }
}



public void PickThreePoints(
	System.String firstPrompt,
	System.String secondPrompt,
	System.String thirdPrompt,
	out Dynamic.Tekla.Structures.Geometry3d.Point firstPickedPoint_,
	out Dynamic.Tekla.Structures.Geometry3d.Point secondPickedPoint_,
	out Dynamic.Tekla.Structures.Geometry3d.Point thirdPickedPoint_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_
	)
{
	
	
	
	var firstPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
	var secondPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
	var thirdPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
    try
    {
        	teklaObject.PickThreePoints(firstPrompt, secondPrompt, thirdPrompt, out firstPickedPoint, out secondPickedPoint, out thirdPickedPoint, out pickedView);
	firstPickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(firstPickedPoint);
	secondPickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(secondPickedPoint);
	thirdPickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(thirdPickedPoint);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickThreePoints), ex);
    }
}



public void PickPoints(
	System.Int32 numberOfPicks,
	Dynamic.Tekla.Structures.Drawing.StringList prompts_,
	out Dynamic.Tekla.Structures.Drawing.PointList pickedPoints_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_
	)
{
	
	var prompts = Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts_);
	var pickedPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
    try
    {
        	teklaObject.PickPoints(numberOfPicks, prompts, out pickedPoints, out pickedView);
	pickedPoints_ = Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(pickedPoints);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickPoints), ex);
    }
}



public System.Tuple<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoints(
	System.Int32 numberOfPicks,
	Dynamic.Tekla.Structures.Drawing.StringList prompts_
	)
{
	
	var prompts = Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts_);
    try
    {
        	var result = teklaObject.PickPoints(numberOfPicks, prompts);

        	var _result = TupleConverter.FromTSObject<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickPoints), ex);
    }
}



public void PickPoints(
	Dynamic.Tekla.Structures.Drawing.StringList prompts_,
	out Dynamic.Tekla.Structures.Drawing.PointList pickedPoints_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_
	)
{
	var prompts = Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts_);
	var pickedPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
    try
    {
        	teklaObject.PickPoints(prompts, out pickedPoints, out pickedView);
	pickedPoints_ = Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(pickedPoints);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickPoints), ex);
    }
}



public System.Tuple<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoints(
	Dynamic.Tekla.Structures.Drawing.StringList prompts_
	)
{
	var prompts = Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts_);
    try
    {
        	var result = teklaObject.PickPoints(prompts);

        	var _result = TupleConverter.FromTSObject<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickPoints), ex);
    }
}



public void PickObject(
	System.String prompt,
	out Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_
	)
{
	
	var pickedObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
    try
    {
        	teklaObject.PickObject(prompt, out pickedObject, out pickedView);
	pickedObject_ = Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(pickedObject);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickObject), ex);
    }
}



public System.Tuple<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase> PickObject(
	System.String prompt
	)
{
	
    try
    {
        	var result = teklaObject.PickObject(prompt);

        	var _result = TupleConverter.FromTSObject<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickObject), ex);
    }
}



public void PickObject(
	System.String prompt,
	out Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_,
	out Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint_
	)
{
	
	var pickedObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
	var pickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
    try
    {
        	teklaObject.PickObject(prompt, out pickedObject, out pickedView, out pickedPoint);
	pickedObject_ = Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(pickedObject);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
	pickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(pickedPoint);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickObject), ex);
    }
}



public System.Tuple<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase, Dynamic.Tekla.Structures.Geometry3d.Point> PickObjectAndPoint(
	System.String prompt
	)
{
	
    try
    {
        	var result = teklaObject.PickObjectAndPoint(prompt);

        	var _result = TupleConverter.FromTSObject<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase, Dynamic.Tekla.Structures.Geometry3d.Point>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickObjectAndPoint), ex);
    }
}



public void PickObject(
	System.String prompt,
	System.Type[] typeFilter_,
	out Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject_,
	out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView_,
	out Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint_
	)
{
	
	var typeFilter = TypeConverter.ToTSObjects(typeFilter_);
	var pickedObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(null);
	var pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(null);
	var pickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(null);
    try
    {
        	teklaObject.PickObject(prompt, typeFilter, out pickedObject, out pickedView, out pickedPoint);
	pickedObject_ = Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(pickedObject);
	pickedView_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(pickedView);
	pickedPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(pickedPoint);
        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PickObject), ex);
    }
}






    }

    internal static class Picker_
    {
        public static dynamic GetTSObject(Picker dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Picker FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Picker)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerArray_
    {
        public static dynamic GetTSObject(Picker[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Picker_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Picker[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Picker>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Picker_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
