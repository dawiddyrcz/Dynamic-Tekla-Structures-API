/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PlacingTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PlacingBase AlongLinePlacing(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "AlongLinePlacing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PlacingBase BaseLinePlacing(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "BaseLinePlacing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PlacingBase LeaderLinePlacing(Dynamic.Tekla.Structures.Geometry3d.Point LeaderLineStartPoint)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(LeaderLineStartPoint);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "LeaderLinePlacing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PlacingBase PointPlacing()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PlacingTypes", "PointPlacing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(result);
		}





    }

    internal static class PlacingTypes_
    {
        public static dynamic GetTSObject(PlacingTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlacingTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlacingTypesArray_
    {
        public static dynamic GetTSObject(PlacingTypes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlacingTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlacingTypes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PlacingTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlacingTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
