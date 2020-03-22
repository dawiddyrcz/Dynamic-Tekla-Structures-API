/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSet  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.RebarProperties RebarProperties
		{
			get => Dynamic.Tekla.Structures.Model.RebarProperties_.FromTSObject(teklaObject.RebarProperties);
			set { teklaObject.RebarProperties = Dynamic.Tekla.Structures.Model.RebarProperties_.GetTSObject(value); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarLegFace> LegFaces
		{
			get => teklaObject.LegFaces;
			set { teklaObject.LegFaces = value; }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarGuideline> Guidelines
		{
			get => teklaObject.Guidelines;
			set { teklaObject.Guidelines = value; }
		}

		public System.Int32 LayerOrderNumber
		{
			get => teklaObject.LayerOrderNumber;
			set { teklaObject.LayerOrderNumber = value; }
		}

        

        

		public RebarSet()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSet");
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

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarSetAdditions()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetRebarSetAdditions());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarModifiers()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetRebarModifiers());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetReinforcements());
		}





    }

    internal static class RebarSet_
    {
        public static dynamic GetTSObject(RebarSet dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarSet FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.RebarSet)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
