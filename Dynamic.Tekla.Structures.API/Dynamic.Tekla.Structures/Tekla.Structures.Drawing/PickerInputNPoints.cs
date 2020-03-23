/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PickerInputNPoints  : Dynamic.Tekla.Structures.Drawing.PickerInputPointsWithinAView
    {

		public Dynamic.Tekla.Structures.Drawing.PointList PickedPoints
		{
			get => Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.PickedPoints);
			set { teklaObject.PickedPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value); }
		}

        

        

		public PickerInputNPoints() {}
		public PickerInputNPoints(Dynamic.Tekla.Structures.Drawing.ViewBase pickedView, Dynamic.Tekla.Structures.Drawing.PointList pickedPoints)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			args[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pickedPoints);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PickerInputNPoints", args);
		}





    }

    internal static class PickerInputNPoints_
    {
        public static dynamic GetTSObject(PickerInputNPoints dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PickerInputNPoints FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.PickerInputNPoints)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
