/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class LoopEnumerator 
    {

		public Dynamic.Tekla.Structures.Solid.Loop Current
		{
			get => Dynamic.Tekla.Structures.Solid.Loop_.FromTSObject(teklaObject.Current);
			set { teklaObject.Current = Dynamic.Tekla.Structures.Solid.Loop_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public LoopEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class LoopEnumerator_
    {
        public static dynamic GetTSObject(LoopEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LoopEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Solid.LoopEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoopEnumeratorArray_
    {
        public static dynamic GetTSObject(LoopEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoopEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoopEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<LoopEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoopEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
