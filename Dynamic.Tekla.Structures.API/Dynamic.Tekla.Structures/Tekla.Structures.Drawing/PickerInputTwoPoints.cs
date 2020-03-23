/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PickerInputTwoPoints  : Dynamic.Tekla.Structures.Drawing.PickerInputPointsWithinAView
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstPickedPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.FirstPickedPoint);
			set { teklaObject.FirstPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondPickedPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.SecondPickedPoint);
			set { teklaObject.SecondPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public PickerInputTwoPoints() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PickerInputTwoPoints(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PickerInputTwoPoints(Dynamic.Tekla.Structures.Drawing.ViewBase pickedView, Dynamic.Tekla.Structures.Geometry3d.Point firstPickedPoint, Dynamic.Tekla.Structures.Geometry3d.Point secondPickedPoint)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(firstPickedPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(secondPickedPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PickerInputTwoPoints", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PickerInputTwoPoints_
    {
        public static dynamic GetTSObject(PickerInputTwoPoints dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PickerInputTwoPoints FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PickerInputTwoPoints)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerInputTwoPointsArray_
    {
        public static dynamic GetTSObject(PickerInputTwoPoints[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PickerInputTwoPoints_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PickerInputTwoPoints[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PickerInputTwoPoints>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PickerInputTwoPoints_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
