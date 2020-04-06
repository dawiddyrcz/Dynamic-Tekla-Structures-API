/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PointList  : System.Collections.CollectionBase
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Item
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Item);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
			set
			{
				try {
				teklaObject.Item = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public PointList()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PointList");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PointList(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Int32 Add(Dynamic.Tekla.Structures.Geometry3d.Point value)
		{
			try {
			var result = teklaObject.Add(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Add()", ex); }
		}

		public void AddRange(Dynamic.Tekla.Structures.Drawing.PointList value)
		{
			try {
			teklaObject.AddRange(Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddRange()", ex); }
		}

		public System.Boolean Contains(Dynamic.Tekla.Structures.Geometry3d.Point value)
		{
			try {
			var result = teklaObject.Contains(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Contains()", ex); }
		}

		public System.Int32 IndexOf(Dynamic.Tekla.Structures.Geometry3d.Point value)
		{
			try {
			var result = teklaObject.IndexOf(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()", ex); }
		}

		public System.Int32 IndexOf(Dynamic.Tekla.Structures.Geometry3d.Point value, System.Int32 startIndex)
		{
			try {
			var result = teklaObject.IndexOf(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value), startIndex);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()", ex); }
		}

		public System.Int32 IndexOf(Dynamic.Tekla.Structures.Geometry3d.Point value, System.Int32 startIndex, System.Int32 count)
		{
			try {
			var result = teklaObject.IndexOf(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value), startIndex, count);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IndexOf()", ex); }
		}

		public void Insert(System.Int32 index, Dynamic.Tekla.Structures.Geometry3d.Point value)
		{
			try {
			teklaObject.Insert(index, Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()", ex); }
		}

		public Dynamic.Tekla.Structures.Drawing.PointList GetRange(System.Int32 index, System.Int32 count)
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.GetRange(index, count));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetRange()", ex); }
		}

		public System.Int32 LastIndexOf(Dynamic.Tekla.Structures.Geometry3d.Point value)
		{
			try {
			var result = teklaObject.LastIndexOf(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()", ex); }
		}

		public System.Int32 LastIndexOf(Dynamic.Tekla.Structures.Geometry3d.Point value, System.Int32 startIndex)
		{
			try {
			var result = teklaObject.LastIndexOf(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value), startIndex);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()", ex); }
		}

		public System.Int32 LastIndexOf(Dynamic.Tekla.Structures.Geometry3d.Point value, System.Int32 startIndex, System.Int32 count)
		{
			try {
			var result = teklaObject.LastIndexOf(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value), startIndex, count);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LastIndexOf()", ex); }
		}

		public void Remove(Dynamic.Tekla.Structures.Geometry3d.Point value)
		{
			try {
			teklaObject.Remove(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value));
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

		public Dynamic.Tekla.Structures.Geometry3d.Point[] ToArray()
		{
			try {
			return Dynamic.Tekla.Structures.Geometry3d.PointArray_.FromTSObject(teklaObject.ToArray());
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

    internal static class PointList_
    {
        public static dynamic GetTSObject(PointList dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PointList FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PointList)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PointListArray_
    {
        public static dynamic GetTSObject(PointList[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PointList_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PointList[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PointList>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PointList_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
