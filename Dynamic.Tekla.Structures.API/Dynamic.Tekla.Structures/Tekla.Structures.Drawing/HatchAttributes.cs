/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class HatchAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingHatchColors Color
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingHatchColors BackgroundColor
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.FromTSObject(teklaObject.BackgroundColor);
			set { teklaObject.BackgroundColor = Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.GetTSObject(value); }
		}

		public System.Boolean DrawBackgroundColor
		{
			get => teklaObject.DrawBackgroundColor;
			set { teklaObject.DrawBackgroundColor = value; }
		}

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public System.Int32 FactorType
		{
			get => teklaObject.FactorType;
			set { teklaObject.FactorType = value; }
		}

		public System.Double ScaleX
		{
			get => teklaObject.ScaleX;
			set { teklaObject.ScaleX = value; }
		}

		public System.Double ScaleY
		{
			get => teklaObject.ScaleY;
			set { teklaObject.ScaleY = value; }
		}

        

        






    }

    internal static class HatchAttributes_
    {
        public static dynamic GetTSObject(HatchAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static HatchAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.HatchAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class HatchAttributesArray_
    {
        public static dynamic GetTSObject(HatchAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(HatchAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static HatchAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<HatchAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(HatchAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
