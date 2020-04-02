/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class ReferenceModelObjectAttributeEnumerator 
    {

		public System.Object Current
		{
			get => teklaObject.Current;

		}

        

        internal dynamic teklaObject;

		internal ReferenceModelObjectAttributeEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReferenceModelObjectAttributeEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ReferenceModelObjectAttributeEnumerator(Dynamic.Tekla.Structures.Model.ReferenceModelObject RMO)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.ReferenceModelObject_.GetTSObject(RMO);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttributeEnumerator", args);
		}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class ReferenceModelObjectAttributeEnumerator_
    {
        public static dynamic GetTSObject(ReferenceModelObjectAttributeEnumerator dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModelObjectAttributeEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttributeEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelObjectAttributeEnumeratorArray_
    {
        public static dynamic GetTSObject(ReferenceModelObjectAttributeEnumerator[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModelObjectAttributeEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModelObjectAttributeEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ReferenceModelObjectAttributeEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModelObjectAttributeEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
