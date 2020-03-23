/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PreferredTextPlacingTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PointPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "PointPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase LeaderLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "LeaderLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "AlongLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase BaseLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "BaseLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase BaseLineWithArrowAtStartPointPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "BaseLineWithArrowAtStartPointPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase BaseLineWithArrowAtEndPointPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredTextPlacingTypes", "BaseLineWithArrowAtEndPointPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}





    }

    internal static class PreferredTextPlacingTypes_
    {
        public static dynamic GetTSObject(PreferredTextPlacingTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PreferredTextPlacingTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.PreferredTextPlacingTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
