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

namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class ReferenceModelObjectAttributeEnumerator 
    {


        public System.Object Current
        {
            get
            {
                try
                {
                return teklaObject.Current;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Current), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal ReferenceModelObjectAttributeEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReferenceModelObjectAttributeEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ReferenceModelObjectAttributeEnumerator(Dynamic.Tekla.Structures.Model.ReferenceModelObject RMO)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.ReferenceModelObject_.GetTSObject(RMO);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttributeEnumerator", args);
		}


        public System.Boolean MoveNext()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.MoveNext();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MoveNext), ex);
            }
        }



        public void Reset()
        {
            
            try
            {
                teklaObject.Reset();
            
                
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Reset), ex);
            }
        }






    }

    internal static class ReferenceModelObjectAttributeEnumerator_
    {
        public static dynamic GetTSObject(ReferenceModelObjectAttributeEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModelObjectAttributeEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttributeEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelObjectAttributeEnumeratorArray_
    {
        public static dynamic GetTSObject(ReferenceModelObjectAttributeEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModelObjectAttributeEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModelObjectAttributeEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReferenceModelObjectAttributeEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModelObjectAttributeEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
