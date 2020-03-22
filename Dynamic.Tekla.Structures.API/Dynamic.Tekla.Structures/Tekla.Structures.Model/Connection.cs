/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Connection  : Dynamic.Tekla.Structures.Model.BaseComponent
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

        

        

		public Connection()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Connection");
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

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}





    }

    internal static class Connection_
    {
        public static dynamic GetTSObject(Connection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Connection FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Connection)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
