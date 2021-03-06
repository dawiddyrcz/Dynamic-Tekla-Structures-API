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
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures
{

    public abstract class IMainWindow 
    {


        public System.Boolean IsActive
        {
            get
            {
                try
                {
                return teklaObject.IsActive;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsActive), ex); 
                }
            }
            
        }

        public System.Boolean IsMinimized
        {
            get
            {
                try
                {
                return teklaObject.IsMinimized;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsMinimized), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;



        public void Activate()
        {
            
            try
            {
                teklaObject.Activate();
            
                
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Activate), ex);
            }
        }



        public void AttachChildForm(
			System.Windows.Forms.Form form)
        {
            
            try
            {
                teklaObject.AttachChildForm(form);
            
                
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AttachChildForm), ex);
            }
        }



        public void DetachChildForm(
			System.Windows.Forms.Form form)
        {
            
            try
            {
                teklaObject.DetachChildForm(form);
            
                
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DetachChildForm), ex);
            }
        }






    }

    internal static class IMainWindow_
    {
        public static dynamic GetTSObject(IMainWindow dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IMainWindow FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.IMainWindow)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IMainWindowArray_
    {
        public static dynamic GetTSObject(IMainWindow[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IMainWindow_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IMainWindow[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IMainWindow>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IMainWindow_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
