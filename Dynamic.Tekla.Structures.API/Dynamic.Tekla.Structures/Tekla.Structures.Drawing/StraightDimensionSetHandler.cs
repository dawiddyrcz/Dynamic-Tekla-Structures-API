/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class StraightDimensionSetHandler 
    {

        

        internal dynamic teklaObject;

		public StraightDimensionSetHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimensionSetHandler");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StraightDimensionSetHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(
	Dynamic.Tekla.Structures.Drawing.ViewBase View_,
	Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
	Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection_,
	System.Double Distance,
	Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes Attributes_
	)
{
	var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
	var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
	var UpDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection_);
	
	var Attributes = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(Attributes_);
    try
    {
        	var result = teklaObject.CreateDimensionSet(View, DimensionPoints, UpDirection, Distance, Attributes);

        	var _result = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateDimensionSet), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(
	Dynamic.Tekla.Structures.Drawing.ViewBase View_,
	Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
	Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection_,
	System.Double Distance,
	System.Double LeftTagLineOffset,
	System.Double RightTagLineOffset,
	Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes Attributes_
	)
{
	var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
	var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
	var UpDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection_);
	
	
	
	var Attributes = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(Attributes_);
    try
    {
        	var result = teklaObject.CreateDimensionSet(View, DimensionPoints, UpDirection, Distance, LeftTagLineOffset, RightTagLineOffset, Attributes);

        	var _result = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateDimensionSet), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(
	Dynamic.Tekla.Structures.Drawing.ViewBase View_,
	Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
	Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection_,
	System.Double Distance
	)
{
	var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
	var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
	var UpDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection_);
	
    try
    {
        	var result = teklaObject.CreateDimensionSet(View, DimensionPoints, UpDirection, Distance);

        	var _result = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateDimensionSet), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet CreateDimensionSet(
	Dynamic.Tekla.Structures.Drawing.ViewBase View_,
	Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
	Dynamic.Tekla.Structures.Geometry3d.Vector UpDirection_,
	System.Double Distance,
	System.Double LeftTagLineOffset,
	System.Double RightTagLineOffset
	)
{
	var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
	var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
	var UpDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(UpDirection_);
	
	
	
    try
    {
        	var result = teklaObject.CreateDimensionSet(View, DimensionPoints, UpDirection, Distance, LeftTagLineOffset, RightTagLineOffset);

        	var _result = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateDimensionSet), ex);
    }
}






    }

    internal static class StraightDimensionSetHandler_
    {
        public static dynamic GetTSObject(StraightDimensionSetHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StraightDimensionSetHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimensionSetHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StraightDimensionSetHandlerArray_
    {
        public static dynamic GetTSObject(StraightDimensionSetHandler[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StraightDimensionSetHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StraightDimensionSetHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StraightDimensionSetHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StraightDimensionSetHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
