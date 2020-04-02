/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class MeshItemEnumerator 
    {

		public Dynamic.Tekla.Structures.Catalogs.MeshItem Current
		{
			get => Dynamic.Tekla.Structures.Catalogs.MeshItem_.FromTSObject(teklaObject.Current);

		}

        

        internal dynamic teklaObject;

		internal MeshItemEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MeshItemEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}

		public System.Int32 GetSize()
		{
			return teklaObject.GetSize();
		}

		public static Dynamic.Tekla.Structures.Catalogs.MeshItem SelectMeshItem(System.String Name, System.String Grade)
		{
			var parameters = new object[2];
			parameters[0] = Name;
			parameters[1] = Grade;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.MeshItemEnumerator", "SelectMeshItem", parameters);
			return Dynamic.Tekla.Structures.Catalogs.MeshItem_.FromTSObject(result);
		}





    }

    internal static class MeshItemEnumerator_
    {
        public static dynamic GetTSObject(MeshItemEnumerator dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static MeshItemEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.MeshItemEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MeshItemEnumeratorArray_
    {
        public static dynamic GetTSObject(MeshItemEnumerator[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MeshItemEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MeshItemEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<MeshItemEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MeshItemEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
