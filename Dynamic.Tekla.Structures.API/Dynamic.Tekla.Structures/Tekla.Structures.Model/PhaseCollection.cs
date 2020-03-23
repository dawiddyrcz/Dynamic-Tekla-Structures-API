/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PhaseCollection 
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

		public PhaseCollection() {}

		public void CopyTo(System.Array Array, System.Int32 Index)
		{
			teklaObject.CopyTo(Array, Index);
		}


        public System.Collections.IEnumerator GetEnumerator()
        {
            var list = new System.Collections.Generic.List<Phase>();
            foreach (var tsPhase in teklaObject)
            {
                list.Add(Phase_.FromTSObject(tsPhase));
            }
            return list.GetEnumerator();
        }





    }

    internal static class PhaseCollection_
    {
        public static dynamic GetTSObject(PhaseCollection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PhaseCollection FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.PhaseCollection)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PhaseCollectionArray_
    {
        public static dynamic GetTSObject(PhaseCollection[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PhaseCollection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PhaseCollection[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PhaseCollection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PhaseCollection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
