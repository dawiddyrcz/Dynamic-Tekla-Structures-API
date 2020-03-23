/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class Color 
    {

		public System.Double Red
		{
			get => teklaObject.Red;
			set { teklaObject.Red = value; }
		}

		public System.Double Green
		{
			get => teklaObject.Green;
			set { teklaObject.Green = value; }
		}

		public System.Double Blue
		{
			get => teklaObject.Blue;
			set { teklaObject.Blue = value; }
		}

		public System.Double Transparency
		{
			get => teklaObject.Transparency;
			set { teklaObject.Transparency = value; }
		}

        

        internal dynamic teklaObject;

		public Color()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Color");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Color(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Color(System.Double Red, System.Double Green, System.Double Blue)
		{
			var args = new object[3];
			args[0] = Red;
			args[1] = Green;
			args[2] = Blue;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Color", args);
		}
		public Color(System.Double Red, System.Double Green, System.Double Blue, System.Double Transparency)
		{
			var args = new object[4];
			args[0] = Red;
			args[1] = Green;
			args[2] = Blue;
			args[3] = Transparency;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Color", args);
		}





    }

    internal static class Color_
    {
        public static dynamic GetTSObject(Color dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Color FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.Color)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ColorArray_
    {
        public static dynamic GetTSObject(Color[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Color_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Color[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Color>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Color_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
