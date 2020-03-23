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
			get => Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(teklaObject.Polymesh);
			set { teklaObject.Polymesh = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value); }
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

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}





    }

    internal static class PourBreak_
    {
        public static dynamic GetTSObject(PourBreak dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PourBreak FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourBreak_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourBreak[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PourBreak>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourBreak_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
