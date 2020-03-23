/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class IPlacing 
    {

		public Dynamic.Tekla.Structures.Drawing.PlacingBase Placing
		{
			get => Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(teklaObject.Placing);
			set { teklaObject.Placing = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;






    }

    internal static class IPlacing_
    {
        public static dynamic GetTSObject(IPlacing dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IPlacing FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.IPlacing)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IPlacingArray_
    {
        public static dynamic GetTSObject(IPlacing[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IPlacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IPlacing[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IPlacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IPlacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
