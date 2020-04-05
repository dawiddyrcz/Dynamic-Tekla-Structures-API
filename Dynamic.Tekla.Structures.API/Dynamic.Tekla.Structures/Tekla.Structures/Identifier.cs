/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class Identifier 
    {

		public System.Int32 ID
		{
			get => teklaObject.ID;
			set { teklaObject.ID = value; }
		}

		public System.Int32 ID2
		{
			get => teklaObject.ID2;
			set { teklaObject.ID2 = value; }
		}

		public System.Guid GUID
		{
			get => teklaObject.GUID;
			set { teklaObject.GUID = value; }
		}

        

        internal dynamic teklaObject;

		public Identifier()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Identifier(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Identifier(System.Int32 id)
		{
			var args = new object[1];
			args[0] = id;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier", args);
		}
		public Identifier(System.Guid guid)
		{
			var args = new object[1];
			args[0] = guid;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier", args);
		}
		public Identifier(System.String guid)
		{
			var args = new object[1];
			args[0] = guid;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier", args);
		}

		public System.Boolean IsValid()
		{
			return teklaObject.IsValid();
		}





    }

    internal static class Identifier_
    {
        public static dynamic GetTSObject(Identifier dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Identifier FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Identifier)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IdentifierArray_
    {
        public static dynamic GetTSObject(Identifier[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Identifier_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Identifier[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Identifier>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Identifier_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
