/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class CustomPart  : Dynamic.Tekla.Structures.Model.BaseComponent
    {

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value); }
		}

        

        

		public CustomPart()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CustomPart");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomPart(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CustomPart(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CustomPart", args);
		}

		public System.Boolean SetInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			return teklaObject.SetInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint));
		}

		public System.Boolean GetStartAndEndPositions(ref Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, ref Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
		{
			return teklaObject.GetStartAndEndPositions(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint));
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetComponents());
		}





    }

    internal static class CustomPart_
    {
        public static dynamic GetTSObject(CustomPart dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CustomPart FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.CustomPart)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomPartArray_
    {
        public static dynamic GetTSObject(CustomPart[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomPart_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomPart[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CustomPart>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomPart_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
