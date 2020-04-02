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
			get => teklaObject.Item;
			set { teklaObject.Item = value; }
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
			return teklaObject.Add(value);
		}

		public System.Boolean Contains(System.Int32 value)
		{
			return teklaObject.Contains(value);
		}

		public System.Int32 IndexOf(System.Int32 value)
		{
			return teklaObject.IndexOf(value);
		}

		public System.Int32 IndexOf(System.Int32 value, System.Int32 startIndex)
		{
			return teklaObject.IndexOf(value, startIndex);
		}

		public System.Int32 IndexOf(System.Int32 value, System.Int32 startIndex, System.Int32 count)
		{
			return teklaObject.IndexOf(value, startIndex, count);
		}

		public void Insert(System.Int32 index, System.Int32 value)
		{
			teklaObject.Insert(index, value);
		}

		public Dynamic.Tekla.Structures.Drawing.IntList GetRange(System.Int32 index, System.Int32 count)
		{
			return Dynamic.Tekla.Structures.Drawing.IntList_.FromTSObject(teklaObject.GetRange(index, count));
		}

		public System.Int32 LastIndexOf(System.Int32 value)
		{
			return teklaObject.LastIndexOf(value);
		}

		public System.Int32 LastIndexOf(System.Int32 value, System.Int32 startIndex)
		{
			return teklaObject.LastIndexOf(value, startIndex);
		}

		public System.Int32 LastIndexOf(System.Int32 value, System.Int32 startIndex, System.Int32 count)
		{
			return teklaObject.LastIndexOf(value, startIndex, count);
		}

		public void Remove(System.Int32 value)
		{
			teklaObject.Remove(value);
		}

		public void RemoveRange(System.Int32 index, System.Int32 count)
		{
			teklaObject.RemoveRange(index, count);
		}

		public System.Int32[] ToArray()
		{
			return teklaObject.ToArray();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class IntList_
    {
        public static dynamic GetTSObject(IntList dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static IntList FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IntList_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IntList[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<IntList>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IntList_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
