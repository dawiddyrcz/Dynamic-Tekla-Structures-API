/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class CrossSectionPoint  : Dynamic.Tekla.Structures.Geometry3d.Point
    {

		public Dynamic.Tekla.Structures.Model.Chamfer Chamfer
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Chamfer_.FromTSObject(teklaObject.Chamfer);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Chamfer"); }
			}
			set
			{
				try {
				teklaObject.Chamfer = Dynamic.Tekla.Structures.Model.Chamfer_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Chamfer"); }
			}
		}

        

        

		public CrossSectionPoint()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.CrossSectionPoint");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CrossSectionPoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class CrossSectionPoint_
    {
        public static dynamic GetTSObject(CrossSectionPoint dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CrossSectionPoint FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.CrossSectionPoint)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CrossSectionPointArray_
    {
        public static dynamic GetTSObject(CrossSectionPoint[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CrossSectionPoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CrossSectionPoint[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CrossSectionPoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CrossSectionPoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
