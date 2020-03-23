/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class InsidePartHorizontalPlacingType  : Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase
    {

        

        

		public InsidePartHorizontalPlacingType()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.InsidePartHorizontalPlacingType");
		}





    }

    internal static class InsidePartHorizontalPlacingType_
    {
        public static dynamic GetTSObject(InsidePartHorizontalPlacingType dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InsidePartHorizontalPlacingType FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.InsidePartHorizontalPlacingType)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InsidePartHorizontalPlacingTypeArray_
    {
        public static dynamic GetTSObject(InsidePartHorizontalPlacingType[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InsidePartHorizontalPlacingType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InsidePartHorizontalPlacingType[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<InsidePartHorizontalPlacingType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InsidePartHorizontalPlacingType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
