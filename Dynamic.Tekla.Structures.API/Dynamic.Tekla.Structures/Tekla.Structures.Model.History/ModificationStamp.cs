/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.History
{

    public  class ModificationStamp 
    {

		public System.Int32 LocalStamp
		{
			get => teklaObject.LocalStamp;
			set { teklaObject.LocalStamp = value; }
		}

		public System.Int32 ServerStamp
		{
			get => teklaObject.ServerStamp;
			set { teklaObject.ServerStamp = value; }
		}

		public System.String Guid
		{
			get => teklaObject.Guid;

		}

        

        internal dynamic teklaObject;

		public ModificationStamp()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.History.ModificationStamp");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModificationStamp(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModificationStamp(System.Int32 LocalStamp, System.Int32 ServerStamp)
		{
			var args = new object[2];
			args[0] = LocalStamp;
			args[1] = ServerStamp;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.History.ModificationStamp", args);
		}





    }

    internal static class ModificationStamp_
    {
        public static dynamic GetTSObject(ModificationStamp dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModificationStamp FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.History.ModificationStamp)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModificationStampArray_
    {
        public static dynamic GetTSObject(ModificationStamp[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModificationStamp_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModificationStamp[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ModificationStamp>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModificationStamp_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
