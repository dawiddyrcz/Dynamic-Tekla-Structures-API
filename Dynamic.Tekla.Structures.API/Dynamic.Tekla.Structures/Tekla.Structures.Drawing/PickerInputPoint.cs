/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PickerInputPoint  : Dynamic.Tekla.Structures.Drawing.PickerInputPointsWithinAView
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point PickedPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PickedPoint);
			set { teklaObject.PickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		internal PickerInputPoint() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PickerInputPoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PickerInputPoint(Dynamic.Tekla.Structures.Drawing.ViewBase pickedView, Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pickedPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PickerInputPoint", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PickerInputPoint_
    {
        public static dynamic GetTSObject(PickerInputPoint dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static PickerInputPoint FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PickerInputPoint)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerInputPointArray_
    {
        public static dynamic GetTSObject(PickerInputPoint[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PickerInputPoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PickerInputPoint[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<PickerInputPoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PickerInputPoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
