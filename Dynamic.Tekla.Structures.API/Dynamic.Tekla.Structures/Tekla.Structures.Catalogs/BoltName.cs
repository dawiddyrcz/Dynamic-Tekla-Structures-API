/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class BoltName 
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

        

        internal dynamic teklaObject;

		public BoltName()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.BoltName");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BoltName(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class BoltName_
    {
        public static dynamic GetTSObject(BoltName dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static BoltName FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.BoltName)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BoltNameArray_
    {
        public static dynamic GetTSObject(BoltName[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BoltName_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BoltName[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<BoltName>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BoltName_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    