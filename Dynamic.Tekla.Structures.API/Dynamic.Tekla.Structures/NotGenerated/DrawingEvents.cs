/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using System;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Drawing
{
    public class Events
    {
        public delegate void DrawingUpdatedDelegate(Drawing drawing, Events.DrawingUpdateTypeEnum type);
        public delegate void DrawingStatusChangedDelegate();
        public delegate void DrawingInsertedDelegate();
        public delegate void DrawingDeletedDelegate();

        public event Events.DrawingUpdatedDelegate DrawingUpdated;
        public event Events.DrawingStatusChangedDelegate DrawingStatusChanged;
        public event Events.DrawingInsertedDelegate DrawingInserted;
        public event Events.DrawingDeletedDelegate DrawingDeleted;
        public event Events.DrawingStatusChangedDelegate DrawingChanged;

        private dynamic teklaObject;

        public Events()
        {
            teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events");
            BindEventToMethod("DrawingChanged", "TeklaObject_DrawingChanged");
            BindEventToMethod("DrawingDeleted", "TeklaObject_DrawingDeleted");
            BindEventToMethod("DrawingInserted", "TeklaObject_DrawingInserted");
            BindEventToMethod("DrawingStatusChanged", "TeklaObject_DrawingStatusChanged");
            BindEventToMethod("DrawingUpdated", "TeklaObject_DrawingUpdated");
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

        private void TeklaObject_DrawingUpdated(dynamic tsDrawing, dynamic tsDrawingUpdateTypeEnum)
        {
            if (DrawingUpdated != null)
            {
                var drawing = Drawing_.FromTSObject(tsDrawing);
                var drawingUpdateTypeEnum = DrawingUpdateTypeEnum_.FromTSObject(tsDrawingUpdateTypeEnum);
                DrawingUpdated?.Invoke(drawing, drawingUpdateTypeEnum);
            }
        }

        private void TeklaObject_DrawingStatusChanged()
        {
            DrawingStatusChanged?.Invoke();
        }

        private void TeklaObject_DrawingInserted()
        {
            DrawingInserted?.Invoke();
        }

        private void TeklaObject_DrawingDeleted()
        {
            DrawingDeleted?.Invoke();
        }

        private void TeklaObject_DrawingChanged()
        {
            DrawingChanged?.Invoke();
        }


        public enum DrawingUpdateTypeEnum
        {
            INSERTED = 0,
            MODIFIED = 1,
            DELETED = 2,
        }

        internal static class DrawingUpdateTypeEnum_
        {
            public static dynamic GetTSObject(DrawingUpdateTypeEnum dynEnum)
            {
                var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Events.DrawingUpdateTypeEnum_").GetType();

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




    }
}
