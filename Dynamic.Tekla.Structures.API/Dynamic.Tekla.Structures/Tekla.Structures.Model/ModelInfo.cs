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
			get
			{
				try {
					return teklaObject.NorthDirection;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NorthDirection", ex); }
			}
			set
			{
				try {
					teklaObject.NorthDirection = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("NorthDirection", ex); }
			}
		}

		public System.String ModelPath
		{
			get
			{
				try {
					return teklaObject.ModelPath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelPath", ex); }
			}
			set
			{
				try {
					teklaObject.ModelPath = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelPath", ex); }
			}
		}

		public System.String ModelName
		{
			get
			{
				try {
					return teklaObject.ModelName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelName", ex); }
			}
			set
			{
				try {
					teklaObject.ModelName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelName", ex); }
			}
		}

		public System.Int32 CurrentPhase
		{
			get
			{
				try {
					return teklaObject.CurrentPhase;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentPhase", ex); }
			}
			set
			{
				try {
					teklaObject.CurrentPhase = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentPhase", ex); }
			}
		}

		public System.Boolean SharedModel
		{
			get
			{
				try {
					return teklaObject.SharedModel;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SharedModel", ex); }
			}

		}

		public System.Boolean SingleUserModel
		{
			get
			{
				try {
					return teklaObject.SingleUserModel;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SingleUserModel", ex); }
			}

		}

        

        internal dynamic teklaObject;

		internal ModelInfo() {}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelInfo FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelInfo[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
