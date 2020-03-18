//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class ClipPlaneCollection 
    {

		public System.Int32 Count
		{
			get => clipplanecollection.Count;
			set { clipplanecollection.Count = value; }
		}

		public System.Boolean IsSynchronized
		{
			get => clipplanecollection.IsSynchronized;
			set { clipplanecollection.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => clipplanecollection.SyncRoot;
			set { clipplanecollection.SyncRoot = value; }
		}

        

        internal dynamic clipplanecollection;
        
        public ClipPlaneCollection()
        {
            this.clipplanecollection =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.ClipPlaneCollection");
        }

        internal ClipPlaneCollection(dynamic tsObject)
        {
            this.clipplanecollection = tsObject;
        }

		public void CopyTo(System.Array array, System.Int32 index)
			 => clipplanecollection.CopyTo(array, index);





    }

    internal static class ClipPlaneCollection_
    {
        public static dynamic GetTSObject(ClipPlaneCollection dynObject)
        {
            return dynObject.clipplanecollection;
        }

        public static ClipPlaneCollection FromTSObject(dynamic tsObject)
        {
            return new ClipPlaneCollection(tsObject);
        }
    }


}
    
