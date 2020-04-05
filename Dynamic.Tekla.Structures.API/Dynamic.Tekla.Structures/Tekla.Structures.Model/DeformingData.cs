/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class DeformingData 
    {

		public System.Double Angle
		{
			get
			{
				try {
					return teklaObject.Angle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle"); }
			}
			set
			{
				try {
					teklaObject.Angle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle"); }
			}
		}

		public System.Double Angle2
		{
			get
			{
				try {
					return teklaObject.Angle2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle2"); }
			}
			set
			{
				try {
					teklaObject.Angle2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle2"); }
			}
		}

		public System.Double Cambering
		{
			get
			{
				try {
					return teklaObject.Cambering;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Cambering"); }
			}
			set
			{
				try {
					teklaObject.Cambering = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Cambering"); }
			}
		}

		public System.Double Shortening
		{
			get
			{
				try {
					return teklaObject.Shortening;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Shortening"); }
			}
			set
			{
				try {
					teklaObject.Shortening = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Shortening"); }
			}
		}

        

        internal dynamic teklaObject;

		public DeformingData()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.DeformingData");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DeformingData(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class DeformingData_
    {
        public static dynamic GetTSObject(DeformingData dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DeformingData FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.DeformingData)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DeformingDataArray_
    {
        public static dynamic GetTSObject(DeformingData[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DeformingData_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DeformingData[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DeformingData>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DeformingData_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
