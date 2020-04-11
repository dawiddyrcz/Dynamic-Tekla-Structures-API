/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class PickInput 
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

		internal PickInput() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PickInput(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class PickInput_
    {
        public static dynamic GetTSObject(PickInput dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PickInput FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.PickInput)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickInputArray_
    {
        public static dynamic GetTSObject(PickInput[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PickInput_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PickInput[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PickInput>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PickInput_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
