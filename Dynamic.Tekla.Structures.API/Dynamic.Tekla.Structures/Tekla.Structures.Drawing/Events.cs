/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Events 
    {

		public System.Boolean HasDrawingUpdatedListeners
		{
			get => teklaObject.HasDrawingUpdatedListeners;
			set { teklaObject.HasDrawingUpdatedListeners = value; }
		}

        

        internal dynamic teklaObject;

		public Events()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events");
		}

		public void add_DrawingInserted(Dynamic.Tekla.Structures.Drawing.Events.DrawingInsertedDelegate value)
		{
			teklaObject.add_DrawingInserted(Dynamic.Tekla.Structures.Drawing.Events.DrawingInsertedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingInserted(Dynamic.Tekla.Structures.Drawing.Events.DrawingInsertedDelegate value)
		{
			teklaObject.remove_DrawingInserted(Dynamic.Tekla.Structures.Drawing.Events.DrawingInsertedDelegate_.GetTSObject(value));
		}

		public void add_DrawingDeleted(Dynamic.Tekla.Structures.Drawing.Events.DrawingDeletedDelegate value)
		{
			teklaObject.add_DrawingDeleted(Dynamic.Tekla.Structures.Drawing.Events.DrawingDeletedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingDeleted(Dynamic.Tekla.Structures.Drawing.Events.DrawingDeletedDelegate value)
		{
			teklaObject.remove_DrawingDeleted(Dynamic.Tekla.Structures.Drawing.Events.DrawingDeletedDelegate_.GetTSObject(value));
		}

		public void add_DrawingStatusChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate value)
		{
			teklaObject.add_DrawingStatusChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingStatusChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate value)
		{
			teklaObject.remove_DrawingStatusChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate_.GetTSObject(value));
		}

		public void add_DrawingChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate value)
		{
			teklaObject.add_DrawingChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate value)
		{
			teklaObject.remove_DrawingChanged(Dynamic.Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate_.GetTSObject(value));
		}

		public void add_DrawingUpdated(Dynamic.Tekla.Structures.Drawing.Events.DrawingUpdatedDelegate value)
		{
			teklaObject.add_DrawingUpdated(Dynamic.Tekla.Structures.Drawing.Events.DrawingUpdatedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingUpdated(Dynamic.Tekla.Structures.Drawing.Events.DrawingUpdatedDelegate value)
		{
			teklaObject.remove_DrawingUpdated(Dynamic.Tekla.Structures.Drawing.Events.DrawingUpdatedDelegate_.GetTSObject(value));
		}

		public void OnDrawingInserted(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnDrawingInserted(EventName, Parameters);
		}

		public void OnDrawingDeleted(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnDrawingDeleted(EventName, Parameters);
		}

		public void OnDrawingStatusChanged(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnDrawingStatusChanged(EventName, Parameters);
		}

		public void OnDrawingChanged(System.String eventName, System.Object parameters)
		{
			teklaObject.OnDrawingChanged(eventName, parameters);
		}

		public void OnDrawingUpdated(System.String eventName, System.Object parameters)
		{
			teklaObject.OnDrawingUpdated(eventName, parameters);
		}

		public System.Object InitializeLifetimeService()
		{
			return teklaObject.InitializeLifetimeService();
		}

		public void Register()
		{
			teklaObject.Register();
		}

		public void UnRegister()
		{
			teklaObject.UnRegister();
		}




    public enum DrawingUpdateTypeEnum
    {
			INSERTED,
			MODIFIED,
			DELETED        
    }

    internal static class DrawingUpdateTypeEnum_
    {
        public static dynamic GetTSObject(DrawingUpdateTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events.DrawingUpdateTypeEnum").GetType();

            switch (dynEnum)
            {
				case DrawingUpdateTypeEnum.INSERTED:
					return System.Enum.Parse(tsType, "INSERTED");
				case DrawingUpdateTypeEnum.MODIFIED:
					return System.Enum.Parse(tsType, "MODIFIED");
				case DrawingUpdateTypeEnum.DELETED:
					return System.Enum.Parse(tsType, "DELETED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DrawingUpdateTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("INSERTED", System.StringComparison.InvariantCulture))
				return DrawingUpdateTypeEnum.INSERTED;
			else if (tsEnumValue.Equals("MODIFIED", System.StringComparison.InvariantCulture))
				return DrawingUpdateTypeEnum.MODIFIED;
			else if (tsEnumValue.Equals("DELETED", System.StringComparison.InvariantCulture))
				return DrawingUpdateTypeEnum.DELETED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class DrawingInsertedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingInsertedDelegate() {}
		public DrawingInsertedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events.DrawingInsertedDelegate", args);
		}

		public void Invoke()
		{
			teklaObject.Invoke();
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class DrawingInsertedDelegate_
    {
        public static dynamic GetTSObject(DrawingInsertedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingInsertedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Events.DrawingInsertedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class DrawingDeletedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingDeletedDelegate() {}
		public DrawingDeletedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events.DrawingDeletedDelegate", args);
		}

		public void Invoke()
		{
			teklaObject.Invoke();
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class DrawingDeletedDelegate_
    {
        public static dynamic GetTSObject(DrawingDeletedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingDeletedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Events.DrawingDeletedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class DrawingStatusChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingStatusChangedDelegate() {}
		public DrawingStatusChangedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate", args);
		}

		public void Invoke()
		{
			teklaObject.Invoke();
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class DrawingStatusChangedDelegate_
    {
        public static dynamic GetTSObject(DrawingStatusChangedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingStatusChangedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Events.DrawingStatusChangedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class DrawingUpdatedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingUpdatedDelegate() {}
		public DrawingUpdatedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events.DrawingUpdatedDelegate", args);
		}

		public void Invoke(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Drawing.Events.DrawingUpdateTypeEnum type)
		{
			teklaObject.Invoke(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing), Dynamic.Tekla.Structures.Drawing.Events.DrawingUpdateTypeEnum_.GetTSObject(type));
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class DrawingUpdatedDelegate_
    {
        public static dynamic GetTSObject(DrawingUpdatedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingUpdatedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Events.DrawingUpdatedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class Events_
    {
        public static dynamic GetTSObject(Events dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Events FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Events)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
