/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.ClashChecker
{

    public abstract class ClashChekerEvent 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Model.ClashCheckHandler GetClashCheckHandler()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.ClashChecker.ClashChekerEvent", "GetClashCheckHandler", parameters);
			return Dynamic.Tekla.Structures.Model.ClashCheckHandler_.FromTSObject(result);
		}




    public  class ClashCheckDoneDelegate 
    {

        

        internal dynamic teklaObject;

		internal ClashCheckDoneDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ClashCheckDoneDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ClashCheckDoneDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashCheckDoneDelegate", args);
		}

		public void Invoke(System.Int32 nClashes)
		{
			try {
			teklaObject.Invoke(nClashes);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Invoke()"); }
		}

		public void EndInvoke(System.IAsyncResult resultt)
		{
			try {
			teklaObject.EndInvoke(resultt);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("EndInvoke()"); }
		}





    }

    internal static class ClashCheckDoneDelegate_
    {
        public static dynamic GetTSObject(ClashCheckDoneDelegate dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ClashCheckDoneDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashCheckDoneDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClashCheckDoneDelegateArray_
    {
        public static dynamic GetTSObject(ClashCheckDoneDelegate[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClashCheckDoneDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClashCheckDoneDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ClashCheckDoneDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClashCheckDoneDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ClashDetectedDelegate 
    {

        

        internal dynamic teklaObject;

		internal ClashDetectedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ClashDetectedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ClashDetectedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashDetectedDelegate", args);
		}

		public void Invoke(Dynamic.Tekla.Structures.Model.ClashCheckData ClashData)
		{
			try {
			teklaObject.Invoke(Dynamic.Tekla.Structures.Model.ClashCheckData_.GetTSObject(ClashData));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Invoke()"); }
		}

		public void EndInvoke(System.IAsyncResult resultt)
		{
			try {
			teklaObject.EndInvoke(resultt);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("EndInvoke()"); }
		}





    }

    internal static class ClashDetectedDelegate_
    {
        public static dynamic GetTSObject(ClashDetectedDelegate dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ClashDetectedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashDetectedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClashDetectedDelegateArray_
    {
        public static dynamic GetTSObject(ClashDetectedDelegate[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClashDetectedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClashDetectedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ClashDetectedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClashDetectedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class ClashChekerEvent_
    {
        public static dynamic GetTSObject(ClashChekerEvent dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ClashChekerEvent FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ClashChecker.ClashChekerEvent)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClashChekerEventArray_
    {
        public static dynamic GetTSObject(ClashChekerEvent[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClashChekerEvent_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClashChekerEvent[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ClashChekerEvent>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClashChekerEvent_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
