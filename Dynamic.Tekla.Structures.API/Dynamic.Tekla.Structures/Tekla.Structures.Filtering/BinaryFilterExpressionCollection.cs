/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class BinaryFilterExpressionCollection  : Dynamic.Tekla.Structures.Filtering.FilterExpression
    {

		public System.Boolean IsSynchronized
		{
			get
			{
				try {
					return teklaObject.IsSynchronized;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSynchronized", ex); }
			}

		}

		public System.Object SyncRoot
		{
			get
			{
				try {
					return teklaObject.SyncRoot;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SyncRoot", ex); }
			}

		}

		public System.Int32 Count
		{
			get
			{
				try {
					return teklaObject.Count;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Count", ex); }
			}

		}

		public System.Boolean IsReadOnly
		{
			get
			{
				try {
					return teklaObject.IsReadOnly;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadOnly", ex); }
			}

		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.Item);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
			set
			{
				try {
				teklaObject.Item = Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
		}

        

        

		public BinaryFilterExpressionCollection()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpressionCollection");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BinaryFilterExpressionCollection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Int32 IndexOf(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			try {
			var result = teklaObject.IndexOf(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()", ex); }
		}

		public void Add(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			try {
			teklaObject.Add(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()", ex); }
		}

		public void Insert(System.Int32 Index, Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			try {
			teklaObject.Insert(Index, Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()", ex); }
		}

		public System.Boolean Remove(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			try {
			var result = teklaObject.Remove(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Remove()", ex); }
		}

		public void RemoveAt(System.Int32 Index)
		{
			try {
			teklaObject.RemoveAt(Index);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveAt()", ex); }
		}

		public void Clear()
		{
			try {
			teklaObject.Clear();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Clear()", ex); }
		}

		public System.Boolean Contains(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			try {
			var result = teklaObject.Contains(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Contains()", ex); }
		}

		public void CopyTo(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem[] Array, System.Int32 ArrayIndex)
		{
			try {
			teklaObject.CopyTo(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItemArray_.GetTSObject(Array), ArrayIndex);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CopyTo()", ex); }
		}

		public System.Boolean IsFirst(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
		{
			try {
			var result = teklaObject.IsFirst(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(BinaryFilterExpressionItem));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsFirst()", ex); }
		}

		public System.Boolean IsLast(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
		{
			try {
			var result = teklaObject.IsLast(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(BinaryFilterExpressionItem));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsLast()", ex); }
		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetFirst()
		{
			try {
			return Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.GetFirst());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetFirst()", ex); }
		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetLast()
		{
			try {
			return Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.GetLast());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetLast()", ex); }
		}





    }

    internal static class BinaryFilterExpressionCollection_
    {
        public static dynamic GetTSObject(BinaryFilterExpressionCollection dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BinaryFilterExpressionCollection FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionCollection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BinaryFilterExpressionCollectionArray_
    {
        public static dynamic GetTSObject(BinaryFilterExpressionCollection[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BinaryFilterExpressionCollection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BinaryFilterExpressionCollection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BinaryFilterExpressionCollection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BinaryFilterExpressionCollection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
