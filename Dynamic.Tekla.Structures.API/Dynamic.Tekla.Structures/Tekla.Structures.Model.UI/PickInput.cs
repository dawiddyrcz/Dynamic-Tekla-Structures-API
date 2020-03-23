/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class PickInput 
    {

		public System.Int32 Count
		{
			get => teklaObject.Count;
			set { teklaObject.Count = value; }
		}

		public System.Boolean IsSynchronized
		{
			get => teklaObject.IsSynchronized;
			set { teklaObject.IsSynchronized = value; }
		}

		public System.Object SyncRoot
		{
			get => teklaObject.SyncRoot;
			set { teklaObject.SyncRoot = value; }
		}

        

        internal dynamic teklaObject;

		public PickInput() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PickInput(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public void CopyTo(System.Array array, System.Int32 index)
		{
			teklaObject.CopyTo(array, index);
		}





    }

    internal static class PickInput_
    {
        public static dynamic GetTSObject(PickInput dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PickInput FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.PickInput)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickInputArray_
    {
        public static dynamic GetTSObject(PickInput[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PickInput_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PickInput[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PickInput>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PickInput_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
