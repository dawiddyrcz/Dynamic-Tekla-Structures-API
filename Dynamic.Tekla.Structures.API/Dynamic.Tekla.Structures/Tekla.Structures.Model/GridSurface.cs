/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class GridSurface  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.GridBase Parent
		{
			get => Dynamic.Tekla.Structures.Model.GridBase_.FromTSObject(teklaObject.Parent);
			set { teklaObject.Parent = Dynamic.Tekla.Structures.Model.GridBase_.GetTSObject(value); }
		}

		public System.String Label
		{
			get => teklaObject.Label;
			set { teklaObject.Label = value; }
		}

		public System.Boolean IsMagnetic
		{
			get => teklaObject.IsMagnetic;
			set { teklaObject.IsMagnetic = value; }
		}

		public System.Double ExtensionLeft
		{
			get => teklaObject.ExtensionLeft;
			set { teklaObject.ExtensionLeft = value; }
		}

		public System.Double ExtensionRight
		{
			get => teklaObject.ExtensionRight;
			set { teklaObject.ExtensionRight = value; }
		}

		public System.Double ExtensionBelow
		{
			get => teklaObject.ExtensionBelow;
			set { teklaObject.ExtensionBelow = value; }
		}

		public System.Double ExtensionAbove
		{
			get => teklaObject.ExtensionAbove;
			set { teklaObject.ExtensionAbove = value; }
		}

		public System.Boolean DrawingVisibility
		{
			get => teklaObject.DrawingVisibility;
			set { teklaObject.DrawingVisibility = value; }
		}

		public System.Boolean IsManual
		{
			get => teklaObject.IsManual;
			set { teklaObject.IsManual = value; }
		}

        

        






    }

    internal static class GridSurface_
    {
        public static dynamic GetTSObject(GridSurface dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GridSurface FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.GridSurface)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridSurfaceArray_
    {
        public static dynamic GetTSObject(GridSurface[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridSurface_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridSurface[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GridSurface>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GridSurface_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
