/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Detail  : Dynamic.Tekla.Structures.Model.BaseComponent
    {

		public System.Int32 Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
			set { teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.AutoDirectionTypeEnum AutoDirectionType
		{
			get => Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.FromTSObject(teklaObject.AutoDirectionType);
			set { teklaObject.AutoDirectionType = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.PositionTypeEnum PositionType
		{
			get => Dynamic.Tekla.Structures.PositionTypeEnum_.FromTSObject(teklaObject.PositionType);
			set { teklaObject.PositionType = Dynamic.Tekla.Structures.PositionTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.DetailTypeEnum DetailType
		{
			get => Dynamic.Tekla.Structures.DetailTypeEnum_.FromTSObject(teklaObject.DetailType);
			set { teklaObject.DetailType = Dynamic.Tekla.Structures.DetailTypeEnum_.GetTSObject(value); }
		}

		public System.String Code
		{
			get => teklaObject.Code;
			set { teklaObject.Code = value; }
		}

		public Dynamic.Tekla.Structures.ConnectionStatusEnum Status
		{
			get => Dynamic.Tekla.Structures.ConnectionStatusEnum_.FromTSObject(teklaObject.Status);

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

		public System.Boolean SetPrimaryObject(Dynamic.Tekla.Structures.Model.ModelObject M)
		{
			try {
			return teklaObject.SetPrimaryObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetPrimaryObject()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject GetPrimaryObject()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.GetPrimaryObject());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPrimaryObject()"); }
		}

		public System.Boolean SetReferencePoint(Dynamic.Tekla.Structures.Geometry3d.Point ReferencePoint)
		{
			try {
			return teklaObject.SetReferencePoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ReferencePoint));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetReferencePoint()"); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point GetReferencePoint()
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.GetReferencePoint());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetReferencePoint()"); }
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
    
