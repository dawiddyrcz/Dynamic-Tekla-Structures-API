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
			get => teklaObject.IsSynchronized;

		}

		public System.Object SyncRoot
		{
			get => teklaObject.SyncRoot;

		}

		public System.Int32 Count
		{
			get => teklaObject.Count;

		}

		public System.Boolean IsReadOnly
		{
			get => teklaObject.IsReadOnly;

		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item
		{
			get => Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.Item);
			set { teklaObject.Item = Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(value); }
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
			return teklaObject.IndexOf(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
		}

		public void Add(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			teklaObject.Add(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
		}

		public void Insert(System.Int32 Index, Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			teklaObject.Insert(Index, Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
		}

		public System.Boolean Remove(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			return teklaObject.Remove(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
		}

		public void RemoveAt(System.Int32 Index)
		{
			teklaObject.RemoveAt(Index);
		}

		public void Clear()
		{
			teklaObject.Clear();
		}

		public System.Boolean Contains(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
		{
			return teklaObject.Contains(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));
		}

		public void CopyTo(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem[] Array, System.Int32 ArrayIndex)
		{
			teklaObject.CopyTo(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItemArray_.GetTSObject(Array), ArrayIndex);
		}

		public System.Boolean IsFirst(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
		{
			return teklaObject.IsFirst(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(BinaryFilterExpressionItem));
		}

		public System.Boolean IsLast(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
		{
			return teklaObject.IsLast(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(BinaryFilterExpressionItem));
		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetFirst()
		{
			return Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.GetFirst());
		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetLast()
		{
			return Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.GetLast());
		}





    }

    internal static class BinaryFilterExpressionCollection_
    {
        public static dynamic GetTSObject(BinaryFilterExpressionCollection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BinaryFilterExpressionCollection FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BinaryFilterExpressionCollection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BinaryFilterExpressionCollection[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<BinaryFilterExpressionCollection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BinaryFilterExpressionCollection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
