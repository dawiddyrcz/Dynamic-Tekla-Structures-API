/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using System;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Drawing.UI
{
    public class Events
    {
        public delegate void SelectionChangeDelegate();
        public delegate void InterruptedDelegate();
        public delegate void DrawingLoadedDelegate();
        public delegate void DrawingListSelectionChangedDelegate();
        public delegate void DrawingEditorOpenedDelegate();
        public delegate void DrawingEditorClosedDelegate();

        public event Events.SelectionChangeDelegate SelectionChange;
        public event Events.InterruptedDelegate Interrupted;
        public event Events.DrawingLoadedDelegate DrawingLoaded;
        public event Events.DrawingListSelectionChangedDelegate DrawingListSelectionChanged;
        public event Events.DrawingEditorOpenedDelegate DrawingEditorOpened;
        public event Events.DrawingEditorClosedDelegate DrawingEditorClosed;

        private dynamic teklaObject;

        public Events()
        {
            NewTeklaObject();
        }

        private void NewTeklaObject()
        {
            teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UI.Events");
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
            if (SelectionChange != null) BindEventToMethod("SelectionChange", "TeklaObject_SelectionChange");
            if (Interrupted != null) BindEventToMethod("Interrupted", "TeklaObject_Interrupted");
            if (DrawingLoaded != null) BindEventToMethod("DrawingLoaded", "TeklaObject_DrawingLoaded");
            if (DrawingListSelectionChanged != null) BindEventToMethod("DrawingListSelectionChanged", "TeklaObject_DrawingEditorOpened");
            if (DrawingEditorOpened != null) BindEventToMethod("DrawingEditorOpened", "TeklaObject_DrawingEditorClosed");
            teklaObject.Register();
        }

        public void UnRegister()
        {
            teklaObject.UnRegister();
            NewTeklaObject();
        }

        private void TeklaObject_SelectionChange()
        {
            SelectionChange?.Invoke();
        }

        private void TeklaObject_Interrupted()
        {
            Interrupted?.Invoke();
        }

        private void TeklaObject_DrawingLoaded()
        {
            DrawingLoaded?.Invoke();
        }

        private void TeklaObject_DrawingListSelectionChanged()
        {
            DrawingListSelectionChanged?.Invoke();
        }

        private void TeklaObject_DrawingEditorOpened()
        {
            DrawingEditorOpened?.Invoke();
        }

        private void TeklaObject_DrawingEditorClosed()
        {
            DrawingEditorClosed?.Invoke();
        }
    }
}
