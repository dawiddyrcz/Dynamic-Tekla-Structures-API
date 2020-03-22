/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PickerInputObject  : Dynamic.Tekla.Structures.Drawing.PickerInputWithinAView
    {

		public Dynamic.Tekla.Structures.Drawing.DrawingObject PickedObject
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(teklaObject.PickedObject);
			set { teklaObject.PickedObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(value); }
		}

        

        

		public PickerInputObject() {}
		public PickerInputObject(Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(pickedObject);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PickerInputObject", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PickerInputObject_
    {
        public static dynamic GetTSObject(PickerInputObject dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PickerInputObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PickerInputObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
