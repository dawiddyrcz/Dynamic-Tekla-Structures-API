/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadPoint  : Dynamic.Tekla.Structures.Model.Load
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Position
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position"); }
			}
			set
			{
				try {
				teklaObject.Position = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.P);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P"); }
			}
			set
			{
				try {
				teklaObject.P = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Moment
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Moment);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Moment"); }
			}
			set
			{
				try {
				teklaObject.Moment = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Moment"); }
			}
		}

        

        

		public LoadPoint()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadPoint");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LoadPoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class LoadPoint_
    {
        public static dynamic GetTSObject(LoadPoint dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoadPoint FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LoadPoint)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadPointArray_
    {
        public static dynamic GetTSObject(LoadPoint[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadPoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadPoint[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoadPoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadPoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
