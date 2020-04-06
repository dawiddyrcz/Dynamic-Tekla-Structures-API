/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class UserPropertyItemEnumerator 
    {

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyItem Current
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.UserPropertyItem_.FromTSObject(teklaObject.Current);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Current", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal UserPropertyItemEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public UserPropertyItemEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean MoveNext()
		{
			try {
			var result = teklaObject.MoveNext();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("MoveNext()", ex); }
		}

		public void Reset()
		{
			try {
			teklaObject.Reset();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Reset()", ex); }
		}

		public System.Int32 GetSize()
		{
			try {
			var result = teklaObject.GetSize();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSize()", ex); }
		}





    }

    internal static class UserPropertyItemEnumerator_
    {
        public static dynamic GetTSObject(UserPropertyItemEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static UserPropertyItemEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UserPropertyItemEnumeratorArray_
    {
        public static dynamic GetTSObject(UserPropertyItemEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UserPropertyItemEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UserPropertyItemEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<UserPropertyItemEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UserPropertyItemEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
