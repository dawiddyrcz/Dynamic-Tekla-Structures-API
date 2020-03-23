/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ClipPlane 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Location
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Location);
			set { teklaObject.Location = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
			set { teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.View View
		{
			get => Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(teklaObject.View);
			set { teklaObject.View = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public ClipPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ClipPlane");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ClipPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}





    }

    internal static class ClipPlane_
    {
        public static dynamic GetTSObject(ClipPlane dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClipPlane FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ClipPlane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClipPlaneArray_
    {
        public static dynamic GetTSObject(ClipPlane[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClipPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClipPlane[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ClipPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClipPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
