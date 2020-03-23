/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ClipPlaneCollection 
    {

		public System.Int32 Count
		{
			get => teklaObject.Count;

		}

		public System.Boolean IsSynchronized
		{
			get => teklaObject.IsSynchronized;

		}

		public System.Object SyncRoot
		{
			get => teklaObject.SyncRoot;

		}

        

        internal dynamic teklaObject;

		public ClipPlaneCollection() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ClipPlaneCollection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClipPlaneCollectionArray_
    {
        public static dynamic GetTSObject(ClipPlaneCollection[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClipPlaneCollection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClipPlaneCollection[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ClipPlaneCollection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClipPlaneCollection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
