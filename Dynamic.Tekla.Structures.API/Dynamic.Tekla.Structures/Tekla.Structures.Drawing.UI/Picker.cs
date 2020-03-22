/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.UI
{

    public  class Picker 
    {

        

        internal dynamic teklaObject;

		public Picker() {}

		public System.Boolean IsInteractive()
		{
			return teklaObject.IsInteractive();
		}

		public System.Tuple<Dynamic.Tekla.Structures.Geometry3d.Point, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoint(System.String prompt)
		{
			return teklaObject.PickPoint(prompt);
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoints(System.Int32 numberOfPicks, Dynamic.Tekla.Structures.Drawing.StringList prompts)
		{
			return teklaObject.PickPoints(numberOfPicks, Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts));
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoints(Dynamic.Tekla.Structures.Drawing.StringList prompts)
		{
			return teklaObject.PickPoints(Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts));
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase> PickObject(System.String prompt)
		{
			return teklaObject.PickObject(prompt);
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase, Dynamic.Tekla.Structures.Geometry3d.Point> PickObjectAndPoint(System.String prompt)
		{
			return teklaObject.PickObjectAndPoint(prompt);
		}





    }

    internal static class Picker_
    {
        public static dynamic GetTSObject(Picker dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Picker FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.Picker)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
