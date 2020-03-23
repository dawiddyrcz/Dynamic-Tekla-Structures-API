/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Offset 
    {

		public System.Double Dx
		{
			get => teklaObject.Dx;
			set { teklaObject.Dx = value; }
		}

		public System.Double Dy
		{
			get => teklaObject.Dy;
			set { teklaObject.Dy = value; }
		}

		public System.Double Dz
		{
			get => teklaObject.Dz;
			set { teklaObject.Dz = value; }
		}

        

        internal dynamic teklaObject;

		public Offset()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Offset");
		}





    }

    internal static class Offset_
    {
        public static dynamic GetTSObject(Offset dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Offset FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Offset)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
