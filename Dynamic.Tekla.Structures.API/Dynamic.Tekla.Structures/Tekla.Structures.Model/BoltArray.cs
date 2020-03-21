//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class BoltArray  : Dynamic.Tekla.Structures.Model.BoltGroup
    {

        

        

		public BoltArray()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltArray");
		}

		public System.Boolean AddBoltDistX(System.Double DistX)
		{
			return teklaObject.AddBoltDistX(DistX);
		}

		public System.Boolean AddBoltDistY(System.Double DistY)
		{
			return teklaObject.AddBoltDistY(DistY);
		}

		public System.Boolean RemoveBoltDistX(System.Int32 Index)
		{
			return teklaObject.RemoveBoltDistX(Index);
		}

		public System.Boolean RemoveBoltDistY(System.Int32 Index)
		{
			return teklaObject.RemoveBoltDistY(Index);
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

		public System.Boolean SetBoltDistX(System.Int32 Index, System.Double DistX)
		{
			return teklaObject.SetBoltDistX(Index, DistX);
		}

		public System.Boolean SetBoltDistY(System.Int32 Index, System.Double DistY)
		{
			return teklaObject.SetBoltDistY(Index, DistY);
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

    internal static class BoltArray_
    {
        public static dynamic GetTSObject(BoltArray dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BoltArray FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BoltArray)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
