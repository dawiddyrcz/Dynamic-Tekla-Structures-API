/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PourBreak  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Polymesh
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(teklaObject.Polymesh);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polymesh"); }
			}
			set
			{
				try {
				teklaObject.Polymesh = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polymesh"); }
			}
		}

        

        

		public PourBreak()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PourBreak");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PourBreak(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class PourBreak_
    {
        public static dynamic GetTSObject(PourBreak dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourBreak FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PourBreak)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourBreakArray_
    {
        public static dynamic GetTSObject(PourBreak[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourBreak_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourBreak[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourBreak>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourBreak_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
