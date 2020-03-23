/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PolymeshEnumerator 
    {

		public System.Object Current
		{
			get => teklaObject.Current;
			set { teklaObject.Current = value; }
		}

        

        internal dynamic teklaObject;

		public PolymeshEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class PolymeshEnumerator_
    {
        public static dynamic GetTSObject(PolymeshEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PolymeshEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.PolymeshEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolymeshEnumeratorArray_
    {
        public static dynamic GetTSObject(PolymeshEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolymeshEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolymeshEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PolymeshEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolymeshEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
