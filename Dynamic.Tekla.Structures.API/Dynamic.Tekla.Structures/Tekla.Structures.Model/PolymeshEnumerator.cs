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
			get
			{
				try {
					return teklaObject.Current;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Current"); }
			}

		}

        

        internal dynamic teklaObject;

		internal PolymeshEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolymeshEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean MoveNext()
		{
			try {
			return teklaObject.MoveNext();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("MoveNext()"); }
		}

		public void Reset()
		{
			try {
			teklaObject.Reset();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Reset()"); }
		}





    }

    internal static class PolymeshEnumerator_
    {
        public static dynamic GetTSObject(PolymeshEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolymeshEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PolymeshEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolymeshEnumeratorArray_
    {
        public static dynamic GetTSObject(PolymeshEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolymeshEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolymeshEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolymeshEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolymeshEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
