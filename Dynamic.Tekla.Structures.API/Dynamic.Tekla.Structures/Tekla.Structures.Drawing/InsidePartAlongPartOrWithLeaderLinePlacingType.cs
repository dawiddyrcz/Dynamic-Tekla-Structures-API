/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class InsidePartAlongPartOrWithLeaderLinePlacingType  : Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase
    {

        

        

		public InsidePartAlongPartOrWithLeaderLinePlacingType()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.InsidePartAlongPartOrWithLeaderLinePlacingType");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public InsidePartAlongPartOrWithLeaderLinePlacingType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class InsidePartAlongPartOrWithLeaderLinePlacingType_
    {
        public static dynamic GetTSObject(InsidePartAlongPartOrWithLeaderLinePlacingType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static InsidePartAlongPartOrWithLeaderLinePlacingType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.InsidePartAlongPartOrWithLeaderLinePlacingType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InsidePartAlongPartOrWithLeaderLinePlacingTypeArray_
    {
        public static dynamic GetTSObject(InsidePartAlongPartOrWithLeaderLinePlacingType[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InsidePartAlongPartOrWithLeaderLinePlacingType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InsidePartAlongPartOrWithLeaderLinePlacingType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<InsidePartAlongPartOrWithLeaderLinePlacingType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InsidePartAlongPartOrWithLeaderLinePlacingType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
