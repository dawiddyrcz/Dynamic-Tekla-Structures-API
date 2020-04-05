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
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
			set { teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.AutoDirectionTypeEnum AutoDirectionType
		{
			get => Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.FromTSObject(teklaObject.AutoDirectionType);
			set { teklaObject.AutoDirectionType = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.GetTSObject(value); }
		}

		public System.Boolean AutoPosition
		{
			get => teklaObject.AutoPosition;
			set { teklaObject.AutoPosition = value; }
		}

		public System.String Code
		{
			get => teklaObject.Code;
			set { teklaObject.Code = value; }
		}

		public System.Int32 Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public Dynamic.Tekla.Structures.ConnectionStatusEnum Status
		{
			get => Dynamic.Tekla.Structures.ConnectionStatusEnum_.FromTSObject(teklaObject.Status);

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

		public System.Boolean SetPrimaryObject(Dynamic.Tekla.Structures.Model.ModelObject M)
		{
			return teklaObject.SetPrimaryObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M));
		}

		public Dynamic.Tekla.Structures.Model.ModelObject GetPrimaryObject()
		{
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.GetPrimaryObject());
		}

		public System.Boolean SetSecondaryObject(Dynamic.Tekla.Structures.Model.ModelObject M)
		{
			return teklaObject.SetSecondaryObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M));
		}

		public System.Boolean SetSecondaryObjects(System.Collections.ArrayList Secondaries)
		{
			return teklaObject.SetSecondaryObjects(Secondaries);
		}

		public System.Collections.ArrayList GetSecondaryObjects()
		{
			return teklaObject.GetSecondaryObjects();
		}

		public System.Boolean SetInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			return teklaObject.SetInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint));
		}

		public System.Boolean GetStartAndEndPositions(ref Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, ref Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			return teklaObject.GetStartAndEndPositions(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint));
		}

		public System.Boolean SetInputPolygon(Dynamic.Tekla.Structures.Model.Polygon InputPolygon)
		{
			return teklaObject.SetInputPolygon(Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(InputPolygon));
		}

		public Dynamic.Tekla.Structures.Model.Polygon GetInputPolygon()
		{
			return Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.GetInputPolygon());
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
    
