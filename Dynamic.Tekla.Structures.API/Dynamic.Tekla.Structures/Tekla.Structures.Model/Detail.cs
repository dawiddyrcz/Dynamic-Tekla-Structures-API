//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

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
			set { teklaObject.Status = Dynamic.Tekla.Structures.ConnectionStatusEnum_.GetTSObject(value); }
		}

        

        

		public Detail()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Detail");
		}

		public System.Boolean SetPrimaryObject(Dynamic.Tekla.Structures.Model.ModelObject M)
			 => teklaObject.SetPrimaryObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M));

		public Dynamic.Tekla.Structures.Model.ModelObject GetPrimaryObject()
			 => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.GetPrimaryObject());

		public System.Boolean SetReferencePoint(Dynamic.Tekla.Structures.Geometry3d.Point ReferencePoint)
			 => teklaObject.SetReferencePoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ReferencePoint));

		public Dynamic.Tekla.Structures.Geometry3d.Point GetReferencePoint()
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.GetReferencePoint());

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();





    }

    internal static class Detail_
    {
        public static dynamic GetTSObject(Detail dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Detail FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Detail)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
