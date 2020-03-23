/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class AlongPartCenteredPlacingType  : Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase
    {

        

        

		public AlongPartCenteredPlacingType()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AlongPartCenteredPlacingType");
		}





    }

    internal static class AlongPartCenteredPlacingType_
    {
        public static dynamic GetTSObject(AlongPartCenteredPlacingType dynObject)
        {
            return dynObject.teklaObject;
        }

        public static AlongPartCenteredPlacingType FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.AlongPartCenteredPlacingType)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AlongPartCenteredPlacingTypeArray_
    {
        public static dynamic GetTSObject(AlongPartCenteredPlacingType[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AlongPartCenteredPlacingType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AlongPartCenteredPlacingType[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<AlongPartCenteredPlacingType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AlongPartCenteredPlacingType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
