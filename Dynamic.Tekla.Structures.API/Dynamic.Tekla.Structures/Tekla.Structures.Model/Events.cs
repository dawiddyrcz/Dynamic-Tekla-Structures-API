/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Events 
    {

        

        internal dynamic teklaObject;

		public Events()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Events(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public void OnSelectionChange(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnSelectionChange(eventName, parameters);
		}

		public void OnAnnotationSelectionChange(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnAnnotationSelectionChange(eventName, parameters);
		}

		public void OnCommandStatusChange(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnCommandStatusChange(eventName, parameters);
		}

		public void OnTrackEvent(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnTrackEvent(eventName, parameters);
		}

		public void OnPointInputChangedEvent(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnPointInputChangedEvent(eventName, parameters);
		}

		public void OnModelSave(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnModelSave(eventName, parameters);
		}

		public void OnModelSaveAs(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnModelSaveAs(eventName, parameters);
		}

		public void OnModelLoad(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnModelLoad(eventName, parameters);
		}

		public void OnModelUnloading(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnModelUnloading(eventName, parameters);
		}

		public void OnNumbering(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnNumbering(eventName, parameters);
		}

		public void OnModelObjectNumbered(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnModelObjectNumbered(eventName, parameters);
		}

		public void OnModelObjectChanged(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnModelObjectChanged(eventName, parameters);
		}

		public void OnDbCommit(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnDbCommit(eventName, parameters);
		}

		public void OnTeklaStructuresExit(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnTeklaStructuresExit(eventName, parameters);
		}

		public void OnClashCheckDone(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnClashCheckDone(eventName, parameters);
		}

		public void OnClashDetected(System.String eventName, System.Object[] parameters)
		{
			teklaObject.OnClashDetected(eventName, parameters);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.SelectionChangeDelegate", args);
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

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.SelectionChangeDelegate)System.Activator.CreateInstance(type, parameters);
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



    public  class CommandStatusChangeDelegate 
    {

        

        internal dynamic teklaObject;

		public CommandStatusChangeDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CommandStatusChangeDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CommandStatusChangeDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.CommandStatusChangeDelegate", args);
		}

		public void Invoke(System.String TSCommand, System.String TSCommandParam, System.Boolean Status)
		{
			teklaObject.Invoke(TSCommand, TSCommandParam, Status);
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class CommandStatusChangeDelegate_
    {
        public static dynamic GetTSObject(CommandStatusChangeDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static CommandStatusChangeDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.CommandStatusChangeDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CommandStatusChangeDelegateArray_
    {
        public static dynamic GetTSObject(CommandStatusChangeDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CommandStatusChangeDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CommandStatusChangeDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<CommandStatusChangeDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CommandStatusChangeDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class TrackEventDelegate 
    {

        

        internal dynamic teklaObject;

		public TrackEventDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TrackEventDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TrackEventDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.TrackEventDelegate", args);
		}

		public void Invoke(System.String Category, System.String Name, System.String Content)
		{
			teklaObject.Invoke(Category, Name, Content);
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class TrackEventDelegate_
    {
        public static dynamic GetTSObject(TrackEventDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static TrackEventDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.TrackEventDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TrackEventDelegateArray_
    {
        public static dynamic GetTSObject(TrackEventDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TrackEventDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TrackEventDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<TrackEventDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TrackEventDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ModelSaveDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelSaveDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelSaveDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelSaveDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ModelSaveDelegate", args);
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

    internal static class ModelSaveDelegate_
    {
        public static dynamic GetTSObject(ModelSaveDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ModelSaveDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelSaveDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelSaveDelegateArray_
    {
        public static dynamic GetTSObject(ModelSaveDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelSaveDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelSaveDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ModelSaveDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelSaveDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ModelSaveAsDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelSaveAsDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelSaveAsDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelSaveAsDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ModelSaveAsDelegate", args);
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

    internal static class ModelSaveAsDelegate_
    {
        public static dynamic GetTSObject(ModelSaveAsDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ModelSaveAsDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelSaveAsDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelSaveAsDelegateArray_
    {
        public static dynamic GetTSObject(ModelSaveAsDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelSaveAsDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelSaveAsDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ModelSaveAsDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelSaveAsDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ModelLoadDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelLoadDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelLoadDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelLoadDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ModelLoadDelegate", args);
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

    internal static class ModelLoadDelegate_
    {
        public static dynamic GetTSObject(ModelLoadDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ModelLoadDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelLoadDelegateArray_
    {
        public static dynamic GetTSObject(ModelLoadDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelLoadDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelLoadDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ModelLoadDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelLoadDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class NumberingDelegate 
    {

        

        internal dynamic teklaObject;

		public NumberingDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NumberingDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public NumberingDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.NumberingDelegate", args);
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

    internal static class NumberingDelegate_
    {
        public static dynamic GetTSObject(NumberingDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static NumberingDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.NumberingDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NumberingDelegateArray_
    {
        public static dynamic GetTSObject(NumberingDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NumberingDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NumberingDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<NumberingDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NumberingDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ModelChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelChangedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelChangedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelChangedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ModelChangedDelegate", args);
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

    internal static class ModelChangedDelegate_
    {
        public static dynamic GetTSObject(ModelChangedDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ModelChangedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelChangedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelChangedDelegateArray_
    {
        public static dynamic GetTSObject(ModelChangedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelChangedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelChangedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ModelChangedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelChangedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ModelObjectNumberedDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelObjectNumberedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelObjectNumberedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelObjectNumberedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ModelObjectNumberedDelegate", args);
		}

		public void Invoke(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> Objects)
		{
			teklaObject.Invoke(Objects);
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class ModelObjectNumberedDelegate_
    {
        public static dynamic GetTSObject(ModelObjectNumberedDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ModelObjectNumberedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelObjectNumberedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelObjectNumberedDelegateArray_
    {
        public static dynamic GetTSObject(ModelObjectNumberedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelObjectNumberedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelObjectNumberedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ModelObjectNumberedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelObjectNumberedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ModelObjectChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelObjectChangedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelObjectChangedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelObjectChangedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ModelObjectChangedDelegate", args);
		}

		public void Invoke(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ChangeData> Changes)
		{
			teklaObject.Invoke(Changes);
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class ModelObjectChangedDelegate_
    {
        public static dynamic GetTSObject(ModelObjectChangedDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ModelObjectChangedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelObjectChangedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelObjectChangedDelegateArray_
    {
        public static dynamic GetTSObject(ModelObjectChangedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelObjectChangedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelObjectChangedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ModelObjectChangedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelObjectChangedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class TeklaStructuresExitDelegate 
    {

        

        internal dynamic teklaObject;

		public TeklaStructuresExitDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TeklaStructuresExitDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TeklaStructuresExitDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.TeklaStructuresExitDelegate", args);
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

    internal static class TeklaStructuresExitDelegate_
    {
        public static dynamic GetTSObject(TeklaStructuresExitDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static TeklaStructuresExitDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.TeklaStructuresExitDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TeklaStructuresExitDelegateArray_
    {
        public static dynamic GetTSObject(TeklaStructuresExitDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructuresExitDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructuresExitDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<TeklaStructuresExitDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructuresExitDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ClashCheckDoneDelegate 
    {

        

        internal dynamic teklaObject;

		public ClashCheckDoneDelegate() {}
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ClashCheckDoneDelegate", args);
		}

		public void Invoke(System.Int32 NumbersOfClashes)
		{
			teklaObject.Invoke(NumbersOfClashes);
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class ClashCheckDoneDelegate_
    {
        public static dynamic GetTSObject(ClashCheckDoneDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ClashCheckDoneDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ClashCheckDoneDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClashCheckDoneDelegateArray_
    {
        public static dynamic GetTSObject(ClashCheckDoneDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClashCheckDoneDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClashCheckDoneDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
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

		public ClashDetectedDelegate() {}
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.ClashDetectedDelegate", args);
		}

		public void Invoke(Dynamic.Tekla.Structures.Model.ClashCheckData ClashData)
		{
			teklaObject.Invoke(Dynamic.Tekla.Structures.Model.ClashCheckData_.GetTSObject(ClashData));
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class ClashDetectedDelegate_
    {
        public static dynamic GetTSObject(ClashDetectedDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ClashDetectedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ClashDetectedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClashDetectedDelegateArray_
    {
        public static dynamic GetTSObject(ClashDetectedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClashDetectedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClashDetectedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ClashDetectedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClashDetectedDelegate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class PointInputChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public PointInputChangedDelegate() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PointInputChangedDelegate(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PointInputChangedDelegate(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.PointInputChangedDelegate", args);
		}

		public void Invoke(System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> Changes)
		{
			teklaObject.Invoke(Changes);
		}

		public void EndInvoke(System.IAsyncResult result)
		{
			teklaObject.EndInvoke(result);
		}





    }

    internal static class PointInputChangedDelegate_
    {
        public static dynamic GetTSObject(PointInputChangedDelegate dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static PointInputChangedDelegate FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.PointInputChangedDelegate)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PointInputChangedDelegateArray_
    {
        public static dynamic GetTSObject(PointInputChangedDelegate[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PointInputChangedDelegate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PointInputChangedDelegate[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<PointInputChangedDelegate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PointInputChangedDelegate_.FromTSObject(tsItem));
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events.InterruptedDelegate", args);
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

            var dynObject = (Dynamic.Tekla.Structures.Model.Events.InterruptedDelegate)System.Activator.CreateInstance(type, parameters);
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

            var dynObject = (Dynamic.Tekla.Structures.Model.Events)System.Activator.CreateInstance(type, parameters);
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
    
