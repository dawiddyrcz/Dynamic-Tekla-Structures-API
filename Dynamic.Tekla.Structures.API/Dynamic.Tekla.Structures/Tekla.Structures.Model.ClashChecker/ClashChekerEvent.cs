//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.ClashChecker
{

    public abstract class ClashChekerEvent 
    {

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Model.ClashCheckHandler GetClashCheckHandler()
			 => Dynamic.Tekla.Structures.Model.ClashCheckHandler_.FromTSObject(teklaObject.GetClashCheckHandler());




    public  class ClashCheckDoneDelegate 
    {

        

        internal dynamic teklaObject;

		public ClashCheckDoneDelegate() {}
		public ClashCheckDoneDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashCheckDoneDelegate", args);
		}

		public void Invoke(System.Int32 nClashes)
			 => teklaObject.Invoke(nClashes);

		public void EndInvoke(System.IAsyncResult result)
			 => teklaObject.EndInvoke(result);





    }

    internal static class ClashCheckDoneDelegate_
    {
        public static dynamic GetTSObject(ClashCheckDoneDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClashCheckDoneDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashCheckDoneDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ClashDetectedDelegate 
    {

        

        internal dynamic teklaObject;

		public ClashDetectedDelegate() {}
		public ClashDetectedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashDetectedDelegate", args);
		}

		public void Invoke(Dynamic.Tekla.Structures.Model.ClashCheckData ClashData)
			 => teklaObject.Invoke(Dynamic.Tekla.Structures.Model.ClashCheckData_.GetTSObject(ClashData));

		public void EndInvoke(System.IAsyncResult result)
			 => teklaObject.EndInvoke(result);





    }

    internal static class ClashDetectedDelegate_
    {
        public static dynamic GetTSObject(ClashDetectedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClashDetectedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ClashChecker.ClashChekerEvent.ClashDetectedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class ClashChekerEvent_
    {
        public static dynamic GetTSObject(ClashChekerEvent dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClashChekerEvent FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ClashChecker.ClashChekerEvent)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
