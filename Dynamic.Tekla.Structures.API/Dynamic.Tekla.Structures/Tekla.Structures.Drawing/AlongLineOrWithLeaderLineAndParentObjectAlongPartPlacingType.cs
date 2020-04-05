/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType  : Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase
    {

        

        

		public AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType_
    {
        public static dynamic GetTSObject(AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingTypeArray_
    {
        public static dynamic GetTSObject(AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
