//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public  class BinaryFilterExpressionCollection  : Dynamic.Tekla.Structures.Filtering.FilterExpression
    {

		public System.Boolean IsSynchronized
		{
			get => teklaObject.IsSynchronized;
			set { teklaObject.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => teklaObject.SyncRoot;
			set { teklaObject.SyncRoot = value; }
		}

		public System.Int32 Count
		{
			get => teklaObject.Count;
			set { teklaObject.Count = value; }
		}

		public System.Boolean IsReadOnly
		{
			get => teklaObject.IsReadOnly;
			set { teklaObject.IsReadOnly = value; }
		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item
		{
			get => Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.Item);
			set { teklaObject.Item = Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(value); }
		}

		public System.Boolean IsEnable
		{
			get => teklaObject.IsEnable;
			set { teklaObject.IsEnable = value; }
		}

        

        internal dynamic teklaObject;

		public BinaryFilterExpressionCollection()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpressionCollection");
		}

		public System.Int32 IndexOf(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => teklaObject.IndexOf(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));

		public void Add(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => teklaObject.Add(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));

		public void Insert(System.Int32 Index, Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => teklaObject.Insert(Index, Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));

		public System.Boolean Remove(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => teklaObject.Remove(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));

		public void RemoveAt(System.Int32 Index)
			 => teklaObject.RemoveAt(Index);

		public void Clear()
			 => teklaObject.Clear();

		public System.Boolean Contains(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => teklaObject.Contains(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Item));

		public void CopyTo(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Array, System.Int32 ArrayIndex)
			 => teklaObject.CopyTo(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(Array), ArrayIndex);

		public System.Boolean IsFirst(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
			 => teklaObject.IsFirst(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(BinaryFilterExpressionItem));

		public System.Boolean IsLast(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
			 => teklaObject.IsLast(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.GetTSObject(BinaryFilterExpressionItem));

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetFirst()
			 => Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.GetFirst());

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetLast()
			 => Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem_.FromTSObject(teklaObject.GetLast());





    }

    internal static class BinaryFilterExpressionCollection_
    {
        public static dynamic GetTSObject(BinaryFilterExpressionCollection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BinaryFilterExpressionCollection FromTSObject(dynamic tsObject)
        {
            return new BinaryFilterExpressionCollection() { teklaObject = tsObject };
        }
    }


}
    
