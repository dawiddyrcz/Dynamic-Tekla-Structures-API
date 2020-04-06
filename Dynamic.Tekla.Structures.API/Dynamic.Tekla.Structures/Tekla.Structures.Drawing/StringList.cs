/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class StringList  : System.Collections.CollectionBase
    {

		public System.String Item
		{
			get
			{
				try {
					return teklaObject.Item;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
			set
			{
				try {
					teklaObject.Item = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public StringList()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StringList");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StringList(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public StringList(System.Int32 Capacity)
		{
			var args = new object[1];
			args[0] = Capacity;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StringList", args);
		}

		public System.Int32 Add(System.String value)
		{
			try {
			var result = teklaObject.Add(value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()", ex); }
		}

		public System.Boolean Contains(System.String value)
		{
			try {
			var result = teklaObject.Contains(value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Contains()", ex); }
		}

		public System.Int32 IndexOf(System.String value)
		{
			try {
			var result = teklaObject.IndexOf(value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()", ex); }
		}

		public System.Int32 IndexOf(System.String value, System.Int32 startIndex)
		{
			try {
			var result = teklaObject.IndexOf(value, startIndex);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()", ex); }
		}

		public System.Int32 IndexOf(System.String value, System.Int32 startIndex, System.Int32 count)
		{
			try {
			var result = teklaObject.IndexOf(value, startIndex, count);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()", ex); }
		}

		public void Insert(System.Int32 index, System.String value)
		{
			try {
			teklaObject.Insert(index, value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()", ex); }
		}

		public Dynamic.Tekla.Structures.Drawing.StringList GetRange(System.Int32 index, System.Int32 count)
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.StringList_.FromTSObject(teklaObject.GetRange(index, count));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetRange()", ex); }
		}

		public System.Int32 LastIndexOf(System.String value)
		{
			try {
			var result = teklaObject.LastIndexOf(value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()", ex); }
		}

		public System.Int32 LastIndexOf(System.String value, System.Int32 startIndex)
		{
			try {
			var result = teklaObject.LastIndexOf(value, startIndex);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()", ex); }
		}

		public System.Int32 LastIndexOf(System.String value, System.Int32 startIndex, System.Int32 count)
		{
			try {
			var result = teklaObject.LastIndexOf(value, startIndex, count);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()", ex); }
		}

		public void Remove(System.String value)
		{
			try {
			teklaObject.Remove(value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Remove()", ex); }
		}

		public void RemoveRange(System.Int32 index, System.Int32 count)
		{
			try {
			teklaObject.RemoveRange(index, count);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveRange()", ex); }
		}

		public System.String[] ToArray()
		{
			try {
			var result = teklaObject.ToArray();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ToArray()", ex); }
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			try {
			var result = teklaObject.IsEqual(ObjectToCompare);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsEqual()", ex); }
		}





    }

    internal static class StringList_
    {
        public static dynamic GetTSObject(StringList dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StringList FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.StringList)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StringListArray_
    {
        public static dynamic GetTSObject(StringList[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StringList_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StringList[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StringList>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StringList_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
