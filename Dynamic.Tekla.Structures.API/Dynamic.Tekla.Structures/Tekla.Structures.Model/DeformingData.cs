/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class DeformingData 
    {

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public System.Double Angle2
		{
			get => teklaObject.Angle2;
			set { teklaObject.Angle2 = value; }
		}

		public System.Double Cambering
		{
			get => teklaObject.Cambering;
			set { teklaObject.Cambering = value; }
		}

		public System.Double Shortening
		{
			get => teklaObject.Shortening;
			set { teklaObject.Shortening = value; }
		}

        

        internal dynamic teklaObject;

		public DeformingData()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.DeformingData");
		}





    }

    internal static class DeformingData_
    {
        public static dynamic GetTSObject(DeformingData dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DeformingData FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.DeformingData)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
