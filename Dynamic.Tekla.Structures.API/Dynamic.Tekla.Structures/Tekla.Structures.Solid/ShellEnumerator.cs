/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class ShellEnumerator 
    {

		public System.Object Current
		{
			get => teklaObject.Current;
			set { teklaObject.Current = value; }
		}

        

        internal dynamic teklaObject;

		public ShellEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class ShellEnumerator_
    {
        public static dynamic GetTSObject(ShellEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ShellEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Solid.ShellEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ShellEnumeratorArray_
    {
        public static dynamic GetTSObject(ShellEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ShellEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ShellEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ShellEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ShellEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
