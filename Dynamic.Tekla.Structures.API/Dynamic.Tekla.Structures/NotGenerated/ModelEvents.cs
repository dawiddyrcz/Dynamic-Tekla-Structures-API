/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
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

        public event Events.TeklaStructuresExitDelegate TeklaStructuresExit;
        public event Events.SelectionChangeDelegate SelectionChange;
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
            teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Events");
            BindEventToMethod("SelectionChange", "TeklaObject_SelectionChange");
            BindEventToMethod("TeklaStructuresExit", "TeklaObject_TeklaStructuresExit");
            BindEventToMethod("Numbering", "TeklaObject_Numbering");
            BindEventToMethod("ModelUnloading", "TeklaObject_ModelUnloading");
            BindEventToMethod("ModelSaveAs", "TeklaObject_ModelSaveAs");
            BindEventToMethod("ModelSave", "TeklaObject_ModelSave");
            BindEventToMethod("ModelObjectNumbered", "TeklaObject_ModelObjectNumbered");
            BindEventToMethod("ModelObjectChanged", "TeklaObject_ModelObjectChanged");
            BindEventToMethod("Interrupted", "TeklaObject_Interrupted");
            BindEventToMethod("CommandStatusChange", "TeklaObject_CommandStatusChange");
            BindEventToMethod("ClashDetected", "TeklaObject_ClashDetected");
            BindEventToMethod("ClashCheckDone", "TeklaObject_ClashCheckDone");
        }

        private void BindEventToMethod(string eventName, string methodName)
        {
            var eventInfo = teklaObject.GetType().GetEvent(eventName);
            var delegateType = eventInfo.EventHandlerType;
            var methodInfo = typeof(Events).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            var delegateInstance = Delegate.CreateDelegate(delegateType, this, methodInfo);
            eventInfo.AddEventHandler(teklaObject, delegateInstance);
        }

        public void Register()
        {
            teklaObject.Register();
        }

        public void UnRegister()
        {
            teklaObject.UnRegister();
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
