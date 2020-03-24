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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Events(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public void OnSelectionChange(System.String EventName, System.Object[] Parameters)
		{
			teklaObject.OnSelectionChange(EventName, Parameters);
		}

		public void OnDrawingEditorOpen(System.String EventName, System.Object[] Parameters)
		{
			teklaObject.OnDrawingEditorOpen(EventName, Parameters);
		}

		public void OnDrawingEditorClose(System.String EventName, System.Object[] Parameters)
		{
			teklaObject.OnDrawingEditorClose(EventName, Parameters);
		}

		public void OnDrawingLoaded(System.String EventName, System.Object[] Parameters)
		{
			teklaObject.OnDrawingLoaded(EventName, Parameters);
		}

		public void OnDrawingListSelectionChanged(System.String EventName, System.Object[] Parameters)
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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SelectionChangeDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static SelectionChangeDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Events.SelectionChangeDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SelectionChangeDelegateArray_
    {
        public static dynamic GetTSObject(SelectionChangeDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SelectionChangeDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SelectionChangeDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<SelectionChangeDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SelectionChangeDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class DrawingEditorOpenedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingEditorOpenedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingEditorOpenedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingEditorOpenedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorOpenedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingEditorOpenedDelegateArray_
    {
        public static dynamic GetTSObject(DrawingEditorOpenedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingEditorOpenedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingEditorOpenedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DrawingEditorOpenedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingEditorOpenedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class DrawingEditorClosedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingEditorClosedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingEditorClosedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingEditorClosedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingEditorClosedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingEditorClosedDelegateArray_
    {
        public static dynamic GetTSObject(DrawingEditorClosedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingEditorClosedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingEditorClosedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DrawingEditorClosedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingEditorClosedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class DrawingLoadedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingLoadedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingLoadedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingLoadedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingLoadedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingLoadedDelegateArray_
    {
        public static dynamic GetTSObject(DrawingLoadedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingLoadedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingLoadedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DrawingLoadedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingLoadedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class DrawingListSelectionChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public DrawingListSelectionChangedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingListSelectionChangedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingListSelectionChangedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Events.DrawingListSelectionChangedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingListSelectionChangedDelegateArray_
    {
        public static dynamic GetTSObject(DrawingListSelectionChangedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingListSelectionChangedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingListSelectionChangedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DrawingListSelectionChangedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingListSelectionChangedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class InterruptedDelegate 
    {

        

        internal dynamic teklaObject;

		public InterruptedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public InterruptedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static InterruptedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Events.InterruptedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InterruptedDelegateArray_
    {
        public static dynamic GetTSObject(InterruptedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InterruptedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InterruptedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<InterruptedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InterruptedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Events_
    {
        public static dynamic GetTSObject(Events dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Events FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Events)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EventsArray_
    {
        public static dynamic GetTSObject(Events[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Events_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Events[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Events>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Events_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
