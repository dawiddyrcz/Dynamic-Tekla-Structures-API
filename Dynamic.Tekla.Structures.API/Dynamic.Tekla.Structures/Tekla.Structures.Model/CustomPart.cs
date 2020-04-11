/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class CustomPart  : Dynamic.Tekla.Structures.Model.BaseComponent
    {

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position", ex); }
			}
			set
			{
				try {
				teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position", ex); }
			}
		}

        

        

		public CustomPart()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CustomPart");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomPart(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CustomPart(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CustomPart", args);
		}


public System.Boolean SetInputPositions(
	Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
	Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_
	)
{
	var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
	var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
    try
    {
        	var result = (System.Boolean) teklaObject.SetInputPositions(StartPoint, EndPoint);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetInputPositions), ex);
    }
}



public System.Boolean GetStartAndEndPositions(
	ref Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
	ref Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_
	)
{
	var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
	var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
    try
    {
        	var result = (System.Boolean) teklaObject.GetStartAndEndPositions(ref StartPoint, ref EndPoint);
	StartPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(StartPoint);
	EndPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(EndPoint);
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetStartAndEndPositions), ex);
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



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
{

    try
    {
        	var result = teklaObject.GetComponents();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetComponents), ex);
    }
}






    }

    internal static class CustomPart_
    {
        public static dynamic GetTSObject(CustomPart dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CustomPart FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.CustomPart)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomPartArray_
    {
        public static dynamic GetTSObject(CustomPart[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomPart_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomPart[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CustomPart>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomPart_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
