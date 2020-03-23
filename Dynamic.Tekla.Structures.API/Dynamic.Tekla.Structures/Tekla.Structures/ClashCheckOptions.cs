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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ClashCheckOptions(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class ClashCheckOptions_
    {
        public static dynamic GetTSObject(ClashCheckOptions dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ClashCheckOptions FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.ClashCheckOptions)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClashCheckOptionsArray_
    {
        public static dynamic GetTSObject(ClashCheckOptions[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClashCheckOptions_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClashCheckOptions[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ClashCheckOptions>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClashCheckOptions_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
