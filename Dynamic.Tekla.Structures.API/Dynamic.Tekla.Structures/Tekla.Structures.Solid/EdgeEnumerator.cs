/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class EdgeEnumerator 
    {

		public System.Object Current
		{
			get => teklaObject.Current;
			set { teklaObject.Current = value; }
		}

        

        internal dynamic teklaObject;

		public EdgeEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class EdgeEnumerator_
    {
        public static dynamic GetTSObject(EdgeEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static EdgeEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Solid.EdgeEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EdgeEnumeratorArray_
    {
        public static dynamic GetTSObject(EdgeEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EdgeEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EdgeEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<EdgeEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EdgeEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
