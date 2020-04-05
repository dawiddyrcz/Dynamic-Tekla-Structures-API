/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class LeaderLineAndParentObjectAlongPartPlacingType  : Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase
    {

        

        

		public LeaderLineAndParentObjectAlongPartPlacingType()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LeaderLineAndParentObjectAlongPartPlacingType");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LeaderLineAndParentObjectAlongPartPlacingType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class LeaderLineAndParentObjectAlongPartPlacingType_
    {
        public static dynamic GetTSObject(LeaderLineAndParentObjectAlongPartPlacingType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LeaderLineAndParentObjectAlongPartPlacingType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LeaderLineAndParentObjectAlongPartPlacingType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LeaderLineAndParentObjectAlongPartPlacingTypeArray_
    {
        public static dynamic GetTSObject(LeaderLineAndParentObjectAlongPartPlacingType[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LeaderLineAndParentObjectAlongPartPlacingType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LeaderLineAndParentObjectAlongPartPlacingType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LeaderLineAndParentObjectAlongPartPlacingType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LeaderLineAndParentObjectAlongPartPlacingType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
