/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PickerInputObjectAndAPoint  : Dynamic.Tekla.Structures.Drawing.PickerInputObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point PickedPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PickedPoint);
			set { teklaObject.PickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public PickerInputObjectAndAPoint() {}
		public PickerInputObjectAndAPoint(Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject, Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(pickedObject);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pickedPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PickerInputObjectAndAPoint", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PickerInputObjectAndAPoint_
    {
        public static dynamic GetTSObject(PickerInputObjectAndAPoint dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PickerInputObjectAndAPoint FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.PickerInputObjectAndAPoint)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
