/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ContainerElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame"); }
			}
			set
			{
				try {
				teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame"); }
			}
		}

		public System.Int32 Count
		{
			get
			{
				try {
					return teklaObject.Count;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Count"); }
			}

		}

		public System.Boolean IsSynchronized
		{
			get
			{
				try {
					return teklaObject.IsSynchronized;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSynchronized"); }
			}

		}

		public System.Object SyncRoot
		{
			get
			{
				try {
					return teklaObject.SyncRoot;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SyncRoot"); }
			}

		}

        

        

		public ContainerElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ContainerElement");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ContainerElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public void CopyTo(System.Array array, System.Int32 index)
		{
			try {
			teklaObject.CopyTo(array, index);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CopyTo()"); }
		}

		public void Add(Dynamic.Tekla.Structures.Drawing.ElementBase value)
		{
			try {
			teklaObject.Add(Dynamic.Tekla.Structures.Drawing.ElementBase_.GetTSObject(value));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()"); }
		}

		public void Clear()
		{
			try {
			teklaObject.Clear();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Clear()"); }
		}





    }

    internal static class ContainerElement_
    {
        public static dynamic GetTSObject(ContainerElement dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ContainerElement FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ContainerElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ContainerElementArray_
    {
        public static dynamic GetTSObject(ContainerElement[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ContainerElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ContainerElement[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ContainerElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ContainerElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
