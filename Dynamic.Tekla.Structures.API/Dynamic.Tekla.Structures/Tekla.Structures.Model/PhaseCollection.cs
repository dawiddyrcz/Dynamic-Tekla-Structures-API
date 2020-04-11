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
			get
			{
				try {
					return teklaObject.Count;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Count", ex); }
			}

		}

		public System.Boolean IsSynchronized
		{
			get
			{
				try {
					return teklaObject.IsSynchronized;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSynchronized", ex); }
			}

		}

		public System.Object SyncRoot
		{
			get
			{
				try {
					return teklaObject.SyncRoot;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SyncRoot", ex); }
			}

		}

        

        internal dynamic teklaObject;

		internal PhaseCollection() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PhaseCollection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public void CopyTo(
	System.Array Array_,
	System.Int32 Index
	)
{
	var Array = IEnumerableConverter.ToTSObjects<System.Array>(Array_);
	
    try
    {
        	teklaObject.CopyTo(Array, Index);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CopyTo), ex);
    }
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PhaseCollection FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PhaseCollection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PhaseCollectionArray_
    {
        public static dynamic GetTSObject(PhaseCollection[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PhaseCollection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PhaseCollection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PhaseCollection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PhaseCollection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
