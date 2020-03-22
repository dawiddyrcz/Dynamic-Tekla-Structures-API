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
            return dynObject.teklaObject;
        }

        public static PourObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.PourObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
