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
			set { teklaObject.Current = value; }
		}

        

        internal dynamic teklaObject;

		public ReferenceModelObjectAttributeEnumerator() {}
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
            return dynObject.teklaObject;
        }

        public static ReferenceModelObjectAttributeEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttributeEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelObjectAttributeEnumeratorArray_
    {
        public static dynamic GetTSObject(ReferenceModelObjectAttributeEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModelObjectAttributeEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModelObjectAttributeEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReferenceModelObjectAttributeEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModelObjectAttributeEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
