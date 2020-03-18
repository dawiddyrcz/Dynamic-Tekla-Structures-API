//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class BinaryFilterExpressionCollection 
    {

		public System.Boolean IsSynchronized
		{
			get => binaryfilterexpressioncollection.IsSynchronized;
			set { binaryfilterexpressioncollection.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => binaryfilterexpressioncollection.SyncRoot;
			set { binaryfilterexpressioncollection.SyncRoot = value; }
		}

		public System.Int32 Count
		{
			get => binaryfilterexpressioncollection.Count;
			set { binaryfilterexpressioncollection.Count = value; }
		}

		public System.Boolean IsReadOnly
		{
			get => binaryfilterexpressioncollection.IsReadOnly;
			set { binaryfilterexpressioncollection.IsReadOnly = value; }
		}

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item
		{
			get => new Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem(binaryfilterexpressioncollection.Item);
			set { binaryfilterexpressioncollection.Item = value.GetTSObject(); }
		}

		public System.Boolean IsEnable
		{
			get => binaryfilterexpressioncollection.IsEnable;
			set { binaryfilterexpressioncollection.IsEnable = value; }
		}

        

        dynamic binaryfilterexpressioncollection;
        
        public BinaryFilterExpressionCollection()
        {
            this.binaryfilterexpressioncollection =  TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpressionCollection");
        }

        public BinaryFilterExpressionCollection(dynamic tsObject)
        {
            this.binaryfilterexpressioncollection = tsObject;
        }

        internal dynamic GetTSObject() => binaryfilterexpressioncollection;

		public System.Int32 IndexOf(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => binaryfilterexpressioncollection.IndexOf(Item.GetTSObject());

		public void Add(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => binaryfilterexpressioncollection.Add(Item.GetTSObject());

		public void Insert(System.Int32 Index, Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => binaryfilterexpressioncollection.Insert(Index, Item.GetTSObject());

		public System.Boolean Remove(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => binaryfilterexpressioncollection.Remove(Item.GetTSObject());

		public void RemoveAt(System.Int32 Index)
			 => binaryfilterexpressioncollection.RemoveAt(Index);

		public void Clear()
			 => binaryfilterexpressioncollection.Clear();

		public System.Boolean Contains(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Item)
			 => binaryfilterexpressioncollection.Contains(Item.GetTSObject());

		public void CopyTo(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem Array, System.Int32 ArrayIndex)
			 => binaryfilterexpressioncollection.CopyTo(Array.GetTSObject(), ArrayIndex);

		public System.Boolean IsFirst(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
			 => binaryfilterexpressioncollection.IsFirst(BinaryFilterExpressionItem.GetTSObject());

		public System.Boolean IsLast(Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem BinaryFilterExpressionItem)
			 => binaryfilterexpressioncollection.IsLast(BinaryFilterExpressionItem.GetTSObject());

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetFirst()
			 => new Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem(binaryfilterexpressioncollection.GetFirst());

		public Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem GetLast()
			 => new Dynamic.Tekla.Structures.Filtering.BinaryFilterExpressionItem(binaryfilterexpressioncollection.GetLast());





    }

}
    
