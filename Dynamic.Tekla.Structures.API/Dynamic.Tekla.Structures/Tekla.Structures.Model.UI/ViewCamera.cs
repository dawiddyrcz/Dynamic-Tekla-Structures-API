/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ViewCamera 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Location
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Location);
			set { teklaObject.Location = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector DirectionVector
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.DirectionVector);
			set { teklaObject.DirectionVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
			set { teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Double FieldOfView
		{
			get => teklaObject.FieldOfView;
			set { teklaObject.FieldOfView = value; }
		}

		public System.Double ZoomFactor
		{
			get => teklaObject.ZoomFactor;
			set { teklaObject.ZoomFactor = value; }
		}

		public Dynamic.Tekla.Structures.Model.UI.View View
		{
			get => Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(teklaObject.View);
			set { teklaObject.View = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public ViewCamera()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewCamera");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewCamera(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}





    }

    internal static class ViewCamera_
    {
        public static dynamic GetTSObject(ViewCamera dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ViewCamera FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ViewCamera)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewCameraArray_
    {
        public static dynamic GetTSObject(ViewCamera[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewCamera_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewCamera[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ViewCamera>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewCamera_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
