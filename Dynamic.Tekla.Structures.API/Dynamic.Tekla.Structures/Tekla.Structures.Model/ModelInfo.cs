/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ModelInfo 
    {

		public System.Double NorthDirection
		{
			get => teklaObject.NorthDirection;
			set { teklaObject.NorthDirection = value; }
		}

		public System.String ModelPath
		{
			get => teklaObject.ModelPath;
			set { teklaObject.ModelPath = value; }
		}

		public System.String ModelName
		{
			get => teklaObject.ModelName;
			set { teklaObject.ModelName = value; }
		}

		public System.Int32 CurrentPhase
		{
			get => teklaObject.CurrentPhase;
			set { teklaObject.CurrentPhase = value; }
		}

		public System.Boolean SharedModel
		{
			get => teklaObject.SharedModel;
			set { teklaObject.SharedModel = value; }
		}

		public System.Boolean SingleUserModel
		{
			get => teklaObject.SingleUserModel;
			set { teklaObject.SingleUserModel = value; }
		}

        

        internal dynamic teklaObject;

		public ModelInfo() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelInfo(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class ModelInfo_
    {
        public static dynamic GetTSObject(ModelInfo dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelInfo FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ModelInfo)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelInfoArray_
    {
        public static dynamic GetTSObject(ModelInfo[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelInfo[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ModelInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
