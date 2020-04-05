/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PourObject  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.Int32 Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public System.String PourNumber
		{
			get => teklaObject.PourNumber;
			set { teklaObject.PourNumber = value; }
		}

		public System.String PourType
		{
			get => teklaObject.PourType;
			set { teklaObject.PourType = value; }
		}

		public System.String ConcreteMixture
		{
			get => teklaObject.ConcreteMixture;
			set { teklaObject.ConcreteMixture = value; }
		}

        

        

		public PourObject()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PourObject");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PourObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
		{
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());
		}

		public Dynamic.Tekla.Structures.Model.PolymeshEnumerator GetPourPolymeshes()
		{
			return Dynamic.Tekla.Structures.Model.PolymeshEnumerator_.FromTSObject(teklaObject.GetPourPolymeshes());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetParts()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetParts());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjects()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
		}

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
		{
			return Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSurfaceObjects());
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
		}





    }

    internal static class PourObject_
    {
        public static dynamic GetTSObject(PourObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PourObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourObjectArray_
    {
        public static dynamic GetTSObject(PourObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
