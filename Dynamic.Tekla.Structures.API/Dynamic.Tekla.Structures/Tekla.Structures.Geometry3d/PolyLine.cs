/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class PolyLine 
    {

		public System.Collections.ArrayList Points
		{
			get => teklaObject.Points;
			set { teklaObject.Points = value; }
		}

        

        internal dynamic teklaObject;

		internal PolyLine() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolyLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PolyLine(System.Collections.IEnumerable Points)
		{
			var args = new object[1];
			args[0] = Points;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolyLine", args);
		}

		public System.Double Length()
		{
			return teklaObject.Length();
		}





    }

    internal static class PolyLine_
    {
        public static dynamic GetTSObject(PolyLine dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static PolyLine FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.PolyLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolyLineArray_
    {
        public static dynamic GetTSObject(PolyLine[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolyLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolyLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<PolyLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolyLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
