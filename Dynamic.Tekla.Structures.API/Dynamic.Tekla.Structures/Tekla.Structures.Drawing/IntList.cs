/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class IntList  : System.Collections.CollectionBase
    {

		public System.Int32 Item
		{
			get
			{
				try {
					return teklaObject.Item;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item"); }
			}
			set
			{
				try {
					teklaObject.Item = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item"); }
			}
		}

        

        internal dynamic teklaObject;

		public IntList()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.IntList");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public IntList(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Int32 Add(System.Int32 value)
		{
			try {
			return teklaObject.Add(value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()"); }
		}

		public System.Boolean Contains(System.Int32 value)
		{
			try {
			return teklaObject.Contains(value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Contains()"); }
		}

		public System.Int32 IndexOf(System.Int32 value)
		{
			try {
			return teklaObject.IndexOf(value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()"); }
		}

		public System.Int32 IndexOf(System.Int32 value, System.Int32 startIndex)
		{
			try {
			return teklaObject.IndexOf(value, startIndex);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()"); }
		}

		public System.Int32 IndexOf(System.Int32 value, System.Int32 startIndex, System.Int32 count)
		{
			try {
			return teklaObject.IndexOf(value, startIndex, count);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()"); }
		}

		public void Insert(System.Int32 index, System.Int32 value)
		{
			try {
			teklaObject.Insert(index, value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.IntList GetRange(System.Int32 index, System.Int32 count)
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.IntList_.FromTSObject(teklaObject.GetRange(index, count));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetRange()"); }
		}

		public System.Int32 LastIndexOf(System.Int32 value)
		{
			try {
			return teklaObject.LastIndexOf(value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()"); }
		}

		public System.Int32 LastIndexOf(System.Int32 value, System.Int32 startIndex)
		{
			try {
			return teklaObject.LastIndexOf(value, startIndex);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()"); }
		}

		public System.Int32 LastIndexOf(System.Int32 value, System.Int32 startIndex, System.Int32 count)
		{
			try {
			return teklaObject.LastIndexOf(value, startIndex, count);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()"); }
		}

		public void Remove(System.Int32 value)
		{
			try {
			teklaObject.Remove(value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Remove()"); }
		}

		public void RemoveRange(System.Int32 index, System.Int32 count)
		{
			try {
			teklaObject.RemoveRange(index, count);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveRange()"); }
		}

		public System.Int32[] ToArray()
		{
			try {
			return teklaObject.ToArray();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ToArray()"); }
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			try {
			return teklaObject.IsEqual(ObjectToCompare);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsEqual()"); }
		}





    }

    internal static class IntList_
    {
        public static dynamic GetTSObject(IntList dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IntList FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.IntList)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IntListArray_
    {
        public static dynamic GetTSObject(IntList[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IntList_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IntList[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IntList>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IntList_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
