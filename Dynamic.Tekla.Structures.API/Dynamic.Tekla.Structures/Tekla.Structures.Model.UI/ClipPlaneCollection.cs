//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ClipPlaneCollection 
    {

		public System.Int32 Count
		{
			get => teklaObject.Count;
			set { teklaObject.Count = value; }
		}

		public System.Boolean IsSynchronized
		{
			get => teklaObject.IsSynchronized;
			set { teklaObject.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => teklaObject.SyncRoot;
			set { teklaObject.SyncRoot = value; }
		}

        

        internal dynamic teklaObject;

		public ClipPlaneCollection() {}

		public void CopyTo(System.Array array, System.Int32 index)
		{
			teklaObject.CopyTo(array, index);
		}





    }

    internal static class ClipPlaneCollection_
    {
        public static dynamic GetTSObject(ClipPlaneCollection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClipPlaneCollection FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.UI.ClipPlaneCollection)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
