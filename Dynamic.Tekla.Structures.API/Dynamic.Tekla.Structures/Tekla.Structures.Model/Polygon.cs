/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Polygon 
    {

		public System.Collections.ArrayList Points
		{
			get
			{
				try {
					return TSActivator.ConvertArrayList(teklaObject.Points);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Points", ex); }
			}
			set
			{
				try {
					teklaObject.Points = TSActivator.ConvertToTSArrayList(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Points", ex); }
			}
		}

		public static System.Int32 MAX_POLYGON_POINTS
		{
			get => (System.Int32) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.Polygon","MAX_POLYGON_POINTS");

		}

		public static System.Int32 MIN_POLYGON_POINTS
		{
			get => (System.Int32) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.Polygon","MIN_POLYGON_POINTS");

		}

        

        internal dynamic teklaObject;

		public Polygon()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Polygon");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Polygon(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class Polygon_
    {
        public static dynamic GetTSObject(Polygon dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Polygon FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Polygon)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolygonArray_
    {
        public static dynamic GetTSObject(Polygon[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Polygon_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Polygon[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Polygon>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Polygon_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
