/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BoltCircle  : Dynamic.Tekla.Structures.Model.BoltGroup
    {

		public System.Double NumberOfBolts
		{
			get => teklaObject.NumberOfBolts;
			set { teklaObject.NumberOfBolts = value; }
		}

		public System.Double Diameter
		{
			get => teklaObject.Diameter;
			set { teklaObject.Diameter = value; }
		}

        

        

		public BoltCircle()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltCircle");
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

    internal static class BoltCircle_
    {
        public static dynamic GetTSObject(BoltCircle dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BoltCircle FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BoltCircle)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
