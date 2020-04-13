/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PickerInputWithinAView  : Dynamic.Tekla.Structures.Drawing.PickerInput
    {


        public Dynamic.Tekla.Structures.Drawing.ViewBase PickedView
        {
            get
            {
                try
                {
                var value = teklaObject.PickedView;
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ViewBase) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PickedView), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(value);
                teklaObject.PickedView = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PickedView), ex); 
                }
            }
        }
        

        






    }

    internal static class PickerInputWithinAView_
    {
        public static dynamic GetTSObject(PickerInputWithinAView dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PickerInputWithinAView FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PickerInputWithinAView)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerInputWithinAViewArray_
    {
        public static dynamic GetTSObject(PickerInputWithinAView[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PickerInputWithinAView_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PickerInputWithinAView[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PickerInputWithinAView>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PickerInputWithinAView_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
