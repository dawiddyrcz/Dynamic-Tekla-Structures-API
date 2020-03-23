/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSetAddition  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarLegFace> LegFaces
		{
			get => teklaObject.LegFaces;
			set { teklaObject.LegFaces = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSet Father
		{
			get => Dynamic.Tekla.Structures.Model.RebarSet_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.RebarSet_.GetTSObject(value); }
		}

        

        

		public RebarSetAddition()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSetAddition");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarSetAddition(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}





    }

    internal static class RebarSetAddition_
    {
        public static dynamic GetTSObject(RebarSetAddition dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarSetAddition FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarSetAddition)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSetAdditionArray_
    {
        public static dynamic GetTSObject(RebarSetAddition[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSetAddition_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSetAddition[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RebarSetAddition>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSetAddition_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
