/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PreferredMarkPlacingTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PointPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "PointPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLineOrWithLeaderLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongLineOrWithLeaderLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongLineOrWithLeaderLineAndParentObjectAlongPartPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase AlongPartCenteredPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "AlongPartCenteredPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartAlongPartPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartAlongPartPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartAlongPartOrWithLeaderLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartAlongPartOrWithLeaderLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartHorizontalPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartHorizontalPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase InsidePartHorizontalOrWithLeaderLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "InsidePartHorizontalOrWithLeaderLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase LeaderLinePlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "LeaderLinePlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase LeaderLineAndParentObjectAlongPartPlacingType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PreferredMarkPlacingTypes", "LeaderLineAndParentObjectAlongPartPlacingType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(result);
		}





    }

    internal static class PreferredMarkPlacingTypes_
    {
        public static dynamic GetTSObject(PreferredMarkPlacingTypes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static PreferredMarkPlacingTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PreferredMarkPlacingTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PreferredMarkPlacingTypesArray_
    {
        public static dynamic GetTSObject(PreferredMarkPlacingTypes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PreferredMarkPlacingTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PreferredMarkPlacingTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<PreferredMarkPlacingTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PreferredMarkPlacingTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
