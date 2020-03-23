/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Size 
    {

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public System.Double Height
		{
			get => teklaObject.Height;
			set { teklaObject.Height = value; }
		}

        

        internal dynamic teklaObject;

		public Size()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Size");
		}
		public Size(System.Double Width, System.Double Height)
		{
			var args = new object[2];
			args[0] = Width;
			args[1] = Height;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Size", args);
		}





    }

    internal static class Size_
    {
        public static dynamic GetTSObject(Size dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Size FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Size)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SizeArray_
    {
        public static dynamic GetTSObject(Size[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Size_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Size[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Size>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Size_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
