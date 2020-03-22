/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.UI
{

    public  class Events 
    {

        

        internal dynamic teklaObject;

		public Events()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events");
		}

		public void add_SelectionChange(Dynamic.Tekla.Structures.Drawing.UI.Events.SelectionChangeDelegate value)
		{
			teklaObject.add_SelectionChange(Dynamic.Tekla.Structures.Drawing.UI.Events.SelectionChangeDelegate_.GetTSObject(value));
		}

		public void remove_SelectionChange(Dynamic.Tekla.Structures.Drawing.UI.Events.SelectionChangeDelegate value)
		{
			teklaObject.remove_SelectionChange(Dynamic.Tekla.Structures.Drawing.UI.Events.SelectionChangeDelegate_.GetTSObject(value));
		}

		public void add_DrawingEditorOpened(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorOpenedDelegate value)
		{
			teklaObject.add_DrawingEditorOpened(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorOpenedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingEditorOpened(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorOpenedDelegate value)
		{
			teklaObject.remove_DrawingEditorOpened(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorOpenedDelegate_.GetTSObject(value));
		}

		public void add_DrawingEditorClosed(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorClosedDelegate value)
		{
			teklaObject.add_DrawingEditorClosed(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorClosedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingEditorClosed(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorClosedDelegate value)
		{
			teklaObject.remove_DrawingEditorClosed(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorClosedDelegate_.GetTSObject(value));
		}

		public void add_DrawingLoaded(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingLoadedDelegate value)
		{
			teklaObject.add_DrawingLoaded(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingLoadedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingLoaded(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingLoadedDelegate value)
		{
			teklaObject.remove_DrawingLoaded(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingLoadedDelegate_.GetTSObject(value));
		}

		public void add_DrawingListSelectionChanged(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingListSelectionChangedDelegate value)
		{
			teklaObject.add_DrawingListSelectionChanged(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingListSelectionChangedDelegate_.GetTSObject(value));
		}

		public void remove_DrawingListSelectionChanged(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingListSelectionChangedDelegate value)
		{
			teklaObject.remove_DrawingListSelectionChanged(Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingListSelectionChangedDelegate_.GetTSObject(value));
		}

		public void add_Interrupted(Dynamic.Tekla.Structures.Drawing.UI.Events.InterruptedDelegate value)
		{
			teklaObject.add_Interrupted(Dynamic.Tekla.Structures.Drawing.UI.Events.InterruptedDelegate_.GetTSObject(value));
		}

		public void remove_Interrupted(Dynamic.Tekla.Structures.Drawing.UI.Events.InterruptedDelegate value)
		{
			teklaObject.remove_Interrupted(Dynamic.Tekla.Structures.Drawing.UI.Events.InterruptedDelegate_.GetTSObject(value));
		}

		public void OnSelectionChange(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnSelectionChange(EventName, Parameters);
		}

		public void OnDrawingEditorOpen(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnDrawingEditorOpen(EventName, Parameters);
		}

		public void OnDrawingEditorClose(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnDrawingEditorClose(EventName, Parameters);
		}

		public void OnDrawingLoaded(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnDrawingLoaded(EventName, Parameters);
		}

		public void OnDrawingListSelectionChanged(System.String EventName, System.Object Parameters)
		{
			teklaObject.OnDrawingListSelectionChanged(EventName, Parameters);
		}

		public void OnInterrupted()
		{
			teklaObject.OnInterrupted();
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




    public  class SelectionChangeDelegate 
    {

        

        internal dynamic teklaObject;

		public SelectionChangeDelegate() {}
		public SelectionChangeDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events.SelectionChangeDelegate", args);
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

    internal static class SelectionChangeDelegate_
    {
        public static dynamic GetTSObject(SelectionChangeDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SelectionChangeDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.Events.SelectionChangeDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class DrawingEditorOpenedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingEditorOpenedDelegate() {}
		public DrawingEditorOpenedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events.DrawingEditorOpenedDelegate", args);
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

    internal static class DrawingEditorOpenedDelegate_
    {
        public static dynamic GetTSObject(DrawingEditorOpenedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingEditorOpenedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.Events.DrawingEditorOpenedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class DrawingEditorClosedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingEditorClosedDelegate() {}
		public DrawingEditorClosedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events.DrawingEditorClosedDelegate", args);
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

    internal static class DrawingEditorClosedDelegate_
    {
        public static dynamic GetTSObject(DrawingEditorClosedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingEditorClosedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.Events.DrawingEditorClosedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class DrawingLoadedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingLoadedDelegate() {}
		public DrawingLoadedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events.DrawingLoadedDelegate", args);
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

    internal static class DrawingLoadedDelegate_
    {
        public static dynamic GetTSObject(DrawingLoadedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingLoadedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.Events.DrawingLoadedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class DrawingListSelectionChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingListSelectionChangedDelegate() {}
		public DrawingListSelectionChangedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events.DrawingListSelectionChangedDelegate", args);
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

    internal static class DrawingListSelectionChangedDelegate_
    {
        public static dynamic GetTSObject(DrawingListSelectionChangedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingListSelectionChangedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.Events.DrawingListSelectionChangedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class InterruptedDelegate 
    {

        

        internal dynamic teklaObject;

		public InterruptedDelegate() {}
		public InterruptedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events.InterruptedDelegate", args);
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

    internal static class InterruptedDelegate_
    {
        public static dynamic GetTSObject(InterruptedDelegate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InterruptedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.Events.InterruptedDelegate)System.Activator.CreateInstance(type);
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
            var dynObject = (Tekla.Structures.Drawing.UI.Events)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
