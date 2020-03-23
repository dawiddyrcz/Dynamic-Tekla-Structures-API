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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PickerInputObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PickerInputObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerInputObjectArray_
    {
        public static dynamic GetTSObject(PickerInputObject[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PickerInputObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PickerInputObject[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PickerInputObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PickerInputObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
