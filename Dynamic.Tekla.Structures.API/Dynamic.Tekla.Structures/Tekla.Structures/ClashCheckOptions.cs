/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class ClashCheckOptions 
    {

		public System.Double BoltHeadDiameter
		{
			get => teklaObject.BoltHeadDiameter;
			set { teklaObject.BoltHeadDiameter = value; }
		}

		public System.Double NutThickness
		{
			get => teklaObject.NutThickness;
			set { teklaObject.NutThickness = value; }
		}

        

        internal dynamic teklaObject;

		public ClashCheckOptions()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.ClashCheckOptions");
		}





    }

    internal static class ClashCheckOptions_
    {
        public static dynamic GetTSObject(ClashCheckOptions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClashCheckOptions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.ClashCheckOptions)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
