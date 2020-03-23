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

		public void add_SelectionChange(Dynamic.Tekla.Structures.Model.Events.SelectionChangeDelegate value)
		{
			teklaObject.add_SelectionChange(Dynamic.Tekla.Structures.Model.Events.SelectionChangeDelegate_.GetTSObject(value));
		}

		public void remove_SelectionChange(Dynamic.Tekla.Structures.Model.Events.SelectionChangeDelegate value)
		{
			teklaObject.remove_SelectionChange(Dynamic.Tekla.Structures.Model.Events.SelectionChangeDelegate_.GetTSObject(value));
		}

		public void add_CommandStatusChange(Dynamic.Tekla.Structures.Model.Events.CommandStatusChangeDelegate value)
		{
			teklaObject.add_CommandStatusChange(Dynamic.Tekla.Structures.Model.Events.CommandStatusChangeDelegate_.GetTSObject(value));
		}

		public void remove_CommandStatusChange(Dynamic.Tekla.Structures.Model.Events.CommandStatusChangeDelegate value)
		{
			teklaObject.remove_CommandStatusChange(Dynamic.Tekla.Structures.Model.Events.CommandStatusChangeDelegate_.GetTSObject(value));
		}

		public void add_TrackEvent(Dynamic.Tekla.Structures.Model.Events.TrackEventDelegate value)
		{
			teklaObject.add_TrackEvent(Dynamic.Tekla.Structures.Model.Events.TrackEventDelegate_.GetTSObject(value));
		}

		public void remove_TrackEvent(Dynamic.Tekla.Structures.Model.Events.TrackEventDelegate value)
		{
			teklaObject.remove_TrackEvent(Dynamic.Tekla.Structures.Model.Events.TrackEventDelegate_.GetTSObject(value));
		}

		public void add_PointInputChanged(Dynamic.Tekla.Structures.Model.Events.PointInputChangedDelegate value)
		{
			teklaObject.add_PointInputChanged(Dynamic.Tekla.Structures.Model.Events.PointInputChangedDelegate_.GetTSObject(value));
		}

		public void remove_PointInputChanged(Dynamic.Tekla.Structures.Model.Events.PointInputChangedDelegate value)
		{
			teklaObject.remove_PointInputChanged(Dynamic.Tekla.Structures.Model.Events.PointInputChangedDelegate_.GetTSObject(value));
		}

		public void add_ModelSave(Dynamic.Tekla.Structures.Model.Events.ModelSaveDelegate value)
		{
			teklaObject.add_ModelSave(Dynamic.Tekla.Structures.Model.Events.ModelSaveDelegate_.GetTSObject(value));
		}

		public void remove_ModelSave(Dynamic.Tekla.Structures.Model.Events.ModelSaveDelegate value)
		{
			teklaObject.remove_ModelSave(Dynamic.Tekla.Structures.Model.Events.ModelSaveDelegate_.GetTSObject(value));
		}

		public void add_ModelSaveAs(Dynamic.Tekla.Structures.Model.Events.ModelSaveAsDelegate value)
		{
			teklaObject.add_ModelSaveAs(Dynamic.Tekla.Structures.Model.Events.ModelSaveAsDelegate_.GetTSObject(value));
		}

		public void remove_ModelSaveAs(Dynamic.Tekla.Structures.Model.Events.ModelSaveAsDelegate value)
		{
			teklaObject.remove_ModelSaveAs(Dynamic.Tekla.Structures.Model.Events.ModelSaveAsDelegate_.GetTSObject(value));
		}

		public void add_ModelLoad(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate value)
		{
			teklaObject.add_ModelLoad(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate_.GetTSObject(value));
		}

		public void remove_ModelLoad(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate value)
		{
			teklaObject.remove_ModelLoad(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate_.GetTSObject(value));
		}

		public void add_ModelUnloading(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate value)
		{
			teklaObject.add_ModelUnloading(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate_.GetTSObject(value));
		}

		public void remove_ModelUnloading(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate value)
		{
			teklaObject.remove_ModelUnloading(Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate_.GetTSObject(value));
		}

		public void add_Numbering(Dynamic.Tekla.Structures.Model.Events.NumberingDelegate value)
		{
			teklaObject.add_Numbering(Dynamic.Tekla.Structures.Model.Events.NumberingDelegate_.GetTSObject(value));
		}

		public void remove_Numbering(Dynamic.Tekla.Structures.Model.Events.NumberingDelegate value)
		{
			teklaObject.remove_Numbering(Dynamic.Tekla.Structures.Model.Events.NumberingDelegate_.GetTSObject(value));
		}

		public void add_ModelChanged(Dynamic.Tekla.Structures.Model.Events.ModelChangedDelegate value)
		{
			teklaObject.add_ModelChanged(Dynamic.Tekla.Structures.Model.Events.ModelChangedDelegate_.GetTSObject(value));
		}

		public void remove_ModelChanged(Dynamic.Tekla.Structures.Model.Events.ModelChangedDelegate value)
		{
			teklaObject.remove_ModelChanged(Dynamic.Tekla.Structures.Model.Events.ModelChangedDelegate_.GetTSObject(value));
		}

		public void add_ModelObjectNumbered(Dynamic.Tekla.Structures.Model.Events.ModelObjectNumberedDelegate value)
		{
			teklaObject.add_ModelObjectNumbered(Dynamic.Tekla.Structures.Model.Events.ModelObjectNumberedDelegate_.GetTSObject(value));
		}

		public void remove_ModelObjectNumbered(Dynamic.Tekla.Structures.Model.Events.ModelObjectNumberedDelegate value)
		{
			teklaObject.remove_ModelObjectNumbered(Dynamic.Tekla.Structures.Model.Events.ModelObjectNumberedDelegate_.GetTSObject(value));
		}

		public void add_ModelObjectChanged(Dynamic.Tekla.Structures.Model.Events.ModelObjectChangedDelegate value)
		{
			teklaObject.add_ModelObjectChanged(Dynamic.Tekla.Structures.Model.Events.ModelObjectChangedDelegate_.GetTSObject(value));
		}

		public void remove_ModelObjectChanged(Dynamic.Tekla.Structures.Model.Events.ModelObjectChangedDelegate value)
		{
			teklaObject.remove_ModelObjectChanged(Dynamic.Tekla.Structures.Model.Events.ModelObjectChangedDelegate_.GetTSObject(value));
		}

		public void add_TeklaStructuresExit(Dynamic.Tekla.Structures.Model.Events.TeklaStructuresExitDelegate value)
		{
			teklaObject.add_TeklaStructuresExit(Dynamic.Tekla.Structures.Model.Events.TeklaStructuresExitDelegate_.GetTSObject(value));
		}

		public void remove_TeklaStructuresExit(Dynamic.Tekla.Structures.Model.Events.TeklaStructuresExitDelegate value)
		{
			teklaObject.remove_TeklaStructuresExit(Dynamic.Tekla.Structures.Model.Events.TeklaStructuresExitDelegate_.GetTSObject(value));
		}

		public void add_ClashCheckDone(Dynamic.Tekla.Structures.Model.Events.ClashCheckDoneDelegate value)
		{
			teklaObject.add_ClashCheckDone(Dynamic.Tekla.Structures.Model.Events.ClashCheckDoneDelegate_.GetTSObject(value));
		}

		public void remove_ClashCheckDone(Dynamic.Tekla.Structures.Model.Events.ClashCheckDoneDelegate value)
		{
			teklaObject.remove_ClashCheckDone(Dynamic.Tekla.Structures.Model.Events.ClashCheckDoneDelegate_.GetTSObject(value));
		}

		public void add_ClashDetected(Dynamic.Tekla.Structures.Model.Events.ClashDetectedDelegate value)
		{
			teklaObject.add_ClashDetected(Dynamic.Tekla.Structures.Model.Events.ClashDetectedDelegate_.GetTSObject(value));
		}

		public void remove_ClashDetected(Dynamic.Tekla.Structures.Model.Events.ClashDetectedDelegate value)
		{
			teklaObject.remove_ClashDetected(Dynamic.Tekla.Structures.Model.Events.ClashDetectedDelegate_.GetTSObject(value));
		}

		public void add_Interrupted(Dynamic.Tekla.Structures.Model.Events.InterruptedDelegate value)
		{
			teklaObject.add_Interrupted(Dynamic.Tekla.Structures.Model.Events.InterruptedDelegate_.GetTSObject(value));
		}

		public void remove_Interrupted(Dynamic.Tekla.Structures.Model.Events.InterruptedDelegate value)
		{
			teklaObject.remove_Interrupted(Dynamic.Tekla.Structures.Model.Events.InterruptedDelegate_.GetTSObject(value));
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
            return dynObject.teklaObject;
        }

        public static SelectionChangeDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.SelectionChangeDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class CommandStatusChangeDelegate 
    {

        

        internal dynamic teklaObject;

		public CommandStatusChangeDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static CommandStatusChangeDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.CommandStatusChangeDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class TrackEventDelegate 
    {

        

        internal dynamic teklaObject;

		public TrackEventDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static TrackEventDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.TrackEventDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ModelSaveDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelSaveDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static ModelSaveDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelSaveDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ModelSaveAsDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelSaveAsDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static ModelSaveAsDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelSaveAsDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ModelLoadDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelLoadDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static ModelLoadDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelLoadDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class NumberingDelegate 
    {

        

        internal dynamic teklaObject;

		public NumberingDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static NumberingDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.NumberingDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ModelChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelChangedDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static ModelChangedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelChangedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ModelObjectNumberedDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelObjectNumberedDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static ModelObjectNumberedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelObjectNumberedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ModelObjectChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public ModelObjectChangedDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static ModelObjectChangedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ModelObjectChangedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class TeklaStructuresExitDelegate 
    {

        

        internal dynamic teklaObject;

		public TeklaStructuresExitDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static TeklaStructuresExitDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.TeklaStructuresExitDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ClashCheckDoneDelegate 
    {

        

        internal dynamic teklaObject;

		public ClashCheckDoneDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static ClashCheckDoneDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ClashCheckDoneDelegate)System.Activator.CreateInstance(type);
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
            return dynObject.teklaObject;
        }

        public static ClashDetectedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.ClashDetectedDelegate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class PointInputChangedDelegate 
    {

        

        internal dynamic teklaObject;

		public PointInputChangedDelegate() {}
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
            return dynObject.teklaObject;
        }

        public static PointInputChangedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.PointInputChangedDelegate)System.Activator.CreateInstance(type);
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
            return dynObject.teklaObject;
        }

        public static InterruptedDelegate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Events.InterruptedDelegate)System.Activator.CreateInstance(type);
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
            var dynObject = (Dynamic.Tekla.Structures.Model.Events)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
