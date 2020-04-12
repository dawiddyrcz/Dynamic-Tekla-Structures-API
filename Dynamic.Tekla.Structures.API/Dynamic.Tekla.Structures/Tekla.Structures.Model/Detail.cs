/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class Detail  : Dynamic.Tekla.Structures.Model.BaseComponent
    {


    public System.Int32 Class
    {
        get
        {
            try
            {
                return teklaObject.Class;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Class = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
    {
        get
        {
            try
            {
                var value = teklaObject.UpVector;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex); 
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.UpVector = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.AutoDirectionTypeEnum AutoDirectionType
    {
        get
        {
            try
            {
                var value = teklaObject.AutoDirectionType;
                var value_ = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.AutoDirectionTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoDirectionType), ex); 
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.GetTSObject(value);
                teklaObject.AutoDirectionType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoDirectionType), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.PositionTypeEnum PositionType
    {
        get
        {
            try
            {
                var value = teklaObject.PositionType;
                var value_ = Dynamic.Tekla.Structures.PositionTypeEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.PositionTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PositionType), ex); 
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.PositionTypeEnum_.GetTSObject(value);
                teklaObject.PositionType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PositionType), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.DetailTypeEnum DetailType
    {
        get
        {
            try
            {
                var value = teklaObject.DetailType;
                var value_ = Dynamic.Tekla.Structures.DetailTypeEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.DetailTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DetailType), ex); 
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.DetailTypeEnum_.GetTSObject(value);
                teklaObject.DetailType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DetailType), ex); 
            }
        }
    }

    public System.String Code
    {
        get
        {
            try
            {
                return teklaObject.Code;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Code), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Code = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Code), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.ConnectionStatusEnum Status
    {
        get
        {
            try
            {
                var value = teklaObject.Status;
                var value_ = Dynamic.Tekla.Structures.ConnectionStatusEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.ConnectionStatusEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Status), ex); 
            }
        }
        
    }
        

        

		public Detail()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Detail");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Detail(dynamic tsObject, System.DateTime nonConflictParameter)
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



public System.Boolean SetReferencePoint(
	Dynamic.Tekla.Structures.Geometry3d.Point ReferencePoint_
	)
{
	var ReferencePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ReferencePoint_);
    try
    {
        	var result = (System.Boolean) teklaObject.SetReferencePoint(ReferencePoint);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetReferencePoint), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Point GetReferencePoint()
{

    try
    {
        	var result = teklaObject.GetReferencePoint();

        	var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReferencePoint), ex);
    }
}






    }

    internal static class Detail_
    {
        public static dynamic GetTSObject(Detail dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Detail FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Detail)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DetailArray_
    {
        public static dynamic GetTSObject(Detail[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Detail_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Detail[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Detail>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Detail_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
