/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BoltXYList  : Dynamic.Tekla.Structures.Model.BoltGroup
    {

        

        

		public BoltXYList()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltXYList");
		}

		public System.Boolean AddBoltDistX(System.Double DistX)
		{
			return teklaObject.AddBoltDistX(DistX);
		}

		public System.Boolean AddBoltDistY(System.Double DistY)
		{
			return teklaObject.AddBoltDistY(DistY);
		}

		public System.Int32 GetBoltDistXCount()
		{
			return teklaObject.GetBoltDistXCount();
		}

		public System.Int32 GetBoltDistYCount()
		{
			return teklaObject.GetBoltDistYCount();
		}

		public System.Double GetBoltDistX(System.Int32 Index)
		{
			return teklaObject.GetBoltDistX(Index);
		}

		public System.Double GetBoltDistY(System.Int32 Index)
		{
			return teklaObject.GetBoltDistY(Index);
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

    internal static class BoltXYList_
    {
        public static dynamic GetTSObject(BoltXYList dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BoltXYList FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BoltXYList)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
