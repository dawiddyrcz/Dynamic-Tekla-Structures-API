/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Model
{
    public class Events
    {
        public delegate void TeklaStructuresExitDelegate();
        public delegate void SelectionChangeDelegate();
        public delegate void NumberingDelegate();
        public delegate void ModelSaveDelegate();
        public delegate void ModelSaveAsDelegate();
        public delegate void ModelObjectNumberedDelegate(List<ModelObject> Objects);
        public delegate void ModelObjectChangedDelegate(List<ChangeData> Changes);
        public delegate void ModelLoadDelegate();
        public delegate void ModelChangedDelegate();
        public delegate void InterruptedDelegate();
        public delegate void CommandStatusChangeDelegate(string TSCommand, string TSCommandParam, bool Status);
        public delegate void ClashDetectedDelegate(ClashCheckData ClashData);
        public delegate void ClashCheckDoneDelegate(int NumbersOfClashes);

        public event Events.SelectionChangeDelegate SelectionChange;
        public event Events.TeklaStructuresExitDelegate TeklaStructuresExit;
        public event Events.NumberingDelegate Numbering;
        public event Events.ModelLoadDelegate ModelUnloading;
        public event Events.ModelSaveAsDelegate ModelSaveAs;
        public event Events.ModelSaveDelegate ModelSave;
        public event Events.ModelObjectNumberedDelegate ModelObjectNumbered;
        public event Events.ModelObjectChangedDelegate ModelObjectChanged;
        public event Events.ModelLoadDelegate ModelLoad;
        public event Events.ModelChangedDelegate ModelChanged;
        public event Events.InterruptedDelegate Interrupted;
        public event Events.CommandStatusChangeDelegate CommandStatusChange;
        public event Events.ClashDetectedDelegate ClashDetected;
        public event Events.ClashCheckDoneDelegate ClashCheckDone;

        private dynamic teklaObject;

        public Events()
        {
            NewTeklaObject();
        }

        private void NewTeklaObject()
        {
            teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events");
        }

        private void BindEventToMethod(string eventName, string methodName)
        {
            var eventInfo = teklaObject.GetType().GetEvent(eventName);
            if (eventInfo is null)
                throw new DynamicAPINotFoundException("Could not find event: \"" + eventName + "\" in current version of the Tekla API"); 

            var delegateType = eventInfo.EventHandlerType;
            var methodInfo = typeof(Events).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            var delegateInstance = Delegate.CreateDelegate(delegateType, this, methodInfo);
            eventInfo.AddEventHandler(teklaObject, delegateInstance);
        }

        public void Register()
        {
            if (SelectionChange != null) BindEventToMethod("SelectionChange", "TeklaObject_SelectionChange");
            if (TeklaStructuresExit != null) BindEventToMethod("TeklaStructuresExit", "TeklaObject_TeklaStructuresExit");
            if (Numbering != null) BindEventToMethod("Numbering", "TeklaObject_Numbering");
            if (ModelUnloading != null) BindEventToMethod("ModelUnloading", "TeklaObject_ModelUnloading");
            if (ModelSaveAs != null) BindEventToMethod("ModelSaveAs", "TeklaObject_ModelSaveAs");
            if (ModelSave != null) BindEventToMethod("ModelSave", "TeklaObject_ModelSave");
            if (ModelObjectNumbered != null) BindEventToMethod("ModelObjectNumbered", "TeklaObject_ModelObjectNumbered");
            if (ModelObjectChanged != null) BindEventToMethod("ModelObjectChanged", "TeklaObject_ModelObjectChanged");
            if (ModelLoad != null) BindEventToMethod("ModelLoad", "TeklaObject_ModelLoad");
            if (ModelChanged != null) BindEventToMethod("ModelChanged", "TeklaObject_ModelChanged");
            if (Interrupted != null) BindEventToMethod("Interrupted", "TeklaObject_Interrupted");
            if (CommandStatusChange != null) BindEventToMethod("CommandStatusChange", "TeklaObject_CommandStatusChange");
            if (ClashDetected != null) BindEventToMethod("ClashDetected", "TeklaObject_ClashDetected");
            if (ClashCheckDone != null) BindEventToMethod("ClashCheckDone", "TeklaObject_ClashCheckDone");

            try
            {
                teklaObject.Register();
            }
            catch (Exception ex)
            {
                throw new DynamicAPIException("Internal error: " + ex.Message, ex);
            }
        }

        public void UnRegister()
        {
            try
            {
                teklaObject.UnRegister();
                NewTeklaObject();
            }
            catch (Exception ex)
            {
                throw new DynamicAPIException("Internal error: " + ex.Message, ex);
            }
        }

        private void TeklaObject_ClashCheckDone(int NumbersOfClashes)
        {
            ClashCheckDone?.Invoke(NumbersOfClashes);
        }

        private void TeklaObject_ClashDetected(dynamic ClashData)
        {
            if (ClashDetected != null)
            {
                var clashCheckData = ClashCheckData_.FromTSObject(ClashData);
                ClashDetected?.Invoke(clashCheckData);
            }
        }

        private void TeklaObject_CommandStatusChange(string TSCommand, string TSCommandParam, bool Status)
        {
            CommandStatusChange?.Invoke(TSCommand, TSCommandParam, Status);
        }

        private void TeklaObject_Interrupted()
        {
            Interrupted?.Invoke();
        }
        private void TeklaObject_ModelChanged()
        {
            ModelChanged?.Invoke();
        }

        private void TeklaObject_ModelLoad()
        {
            ModelLoad?.Invoke();
        }

        private void TeklaObject_ModelObjectChanged(dynamic Changes)
        {
            if (ModelObjectChanged != null)
            {
                var changeDataList = new List<ChangeData>();
                foreach (dynamic tsModelObject in Changes)
                {
                    changeDataList.Add(ChangeData_.FromTSObject(tsModelObject));
                }

                ModelObjectChanged?.Invoke(changeDataList);
            }
        }

        private void TeklaObject_ModelObjectNumbered(dynamic Objects)
        {
            if (ModelObjectNumbered != null)
            {
                var modelObjectList = new List<ModelObject>();
                foreach (dynamic tsModelObject in Objects)
                {
                    modelObjectList.Add(ModelObject_.FromTSObject(tsModelObject));
                }

                ModelObjectNumbered?.Invoke(modelObjectList);
            }
        }

        private void TeklaObject_ModelSave()
        {
            ModelSave?.Invoke();
        }

        private void TeklaObject_ModelSaveAs()
        {
            ModelSaveAs?.Invoke();
        }

        private void TeklaObject_ModelUnloading()
        {
            ModelUnloading?.Invoke();
        }

        private void TeklaObject_Numbering()
        {
            Numbering?.Invoke();
        }

        private void TeklaObject_SelectionChange()
        {
            SelectionChange?.Invoke();
        }

        private void TeklaObject_TeklaStructuresExit()
        {
            TeklaStructuresExit?.Invoke();
        }

    }
}
