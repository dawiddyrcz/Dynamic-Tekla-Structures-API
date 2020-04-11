/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Seam  : Dynamic.Tekla.Structures.Model.BaseComponent
    {

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpVector", ex); }
			}
			set
			{
				try {
				teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpVector", ex); }
			}
		}

		public Dynamic.Tekla.Structures.AutoDirectionTypeEnum AutoDirectionType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.FromTSObject(teklaObject.AutoDirectionType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutoDirectionType", ex); }
			}
			set
			{
				try {
				teklaObject.AutoDirectionType = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutoDirectionType", ex); }
			}
		}

		public System.Boolean AutoPosition
		{
			get
			{
				try {
					return teklaObject.AutoPosition;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutoPosition", ex); }
			}
			set
			{
				try {
					teklaObject.AutoPosition = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutoPosition", ex); }
			}
		}

		public System.String Code
		{
			get
			{
				try {
					return teklaObject.Code;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Code", ex); }
			}
			set
			{
				try {
					teklaObject.Code = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Code", ex); }
			}
		}

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

		public Dynamic.Tekla.Structures.ConnectionStatusEnum Status
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.ConnectionStatusEnum_.FromTSObject(teklaObject.Status);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Status", ex); }
			}
		}

        

        

		public Seam()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Seam");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Seam(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean SetPrimaryObject(
	Dynamic.Tekla.Structures.Model.ModelObject M_
	)
{
	var M = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M_);
    try
    {
        	var result = (System.Boolean) teklaObject.SetPrimaryObject(M);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetPrimaryObject), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObject GetPrimaryObject()
{

    try
    {
        	var result = teklaObject.GetPrimaryObject();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPrimaryObject), ex);
    }
}



public System.Boolean SetSecondaryObject(
	Dynamic.Tekla.Structures.Model.ModelObject M_
	)
{
	var M = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M_);
    try
    {
        	var result = (System.Boolean) teklaObject.SetSecondaryObject(M);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetSecondaryObject), ex);
    }
}



public System.Boolean SetSecondaryObjects(
	System.Collections.ArrayList Secondaries_
	)
{
	var Secondaries = ArrayListConverter.ToTSObjects(Secondaries_);
    try
    {
        	var result = (System.Boolean) teklaObject.SetSecondaryObjects(Secondaries);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetSecondaryObjects), ex);
    }
}



public System.Collections.ArrayList GetSecondaryObjects()
{

    try
    {
        	var result = teklaObject.GetSecondaryObjects();

        	var _result = ArrayListConverter.FromTSObjects(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSecondaryObjects), ex);
    }
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



public System.Boolean SetInputPolygon(
	Dynamic.Tekla.Structures.Model.Polygon InputPolygon_
	)
{
	var InputPolygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(InputPolygon_);
    try
    {
        	var result = (System.Boolean) teklaObject.SetInputPolygon(InputPolygon);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetInputPolygon), ex);
    }
}



public Dynamic.Tekla.Structures.Model.Polygon GetInputPolygon()
{

    try
    {
        	var result = teklaObject.GetInputPolygon();

        	var _result = Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetInputPolygon), ex);
    }
}






    }

    internal static class Seam_
    {
        public static dynamic GetTSObject(Seam dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Seam FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Seam)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SeamArray_
    {
        public static dynamic GetTSObject(Seam[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Seam_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Seam[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Seam>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Seam_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
