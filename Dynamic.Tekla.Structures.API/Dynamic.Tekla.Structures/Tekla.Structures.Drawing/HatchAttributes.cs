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
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingHatchColors Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingHatchColors BackgroundColor
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.FromTSObject(teklaObject.BackgroundColor);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BackgroundColor", ex); }
			}
			set
			{
				try {
				teklaObject.BackgroundColor = Dynamic.Tekla.Structures.Drawing.DrawingHatchColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BackgroundColor", ex); }
			}
		}

		public System.Boolean DrawBackgroundColor
		{
			get
			{
				try {
					return teklaObject.DrawBackgroundColor;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawBackgroundColor", ex); }
			}
			set
			{
				try {
					teklaObject.DrawBackgroundColor = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawBackgroundColor", ex); }
			}
		}

		public System.Double Angle
		{
			get
			{
				try {
					return teklaObject.Angle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle", ex); }
			}
			set
			{
				try {
					teklaObject.Angle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle", ex); }
			}
		}

		public System.Int32 FactorType
		{
			get
			{
				try {
					return teklaObject.FactorType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FactorType", ex); }
			}
			set
			{
				try {
					teklaObject.FactorType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FactorType", ex); }
			}
		}

		public System.Double ScaleX
		{
			get
			{
				try {
					return teklaObject.ScaleX;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScaleX", ex); }
			}
			set
			{
				try {
					teklaObject.ScaleX = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScaleX", ex); }
			}
		}

		public System.Double ScaleY
		{
			get
			{
				try {
					return teklaObject.ScaleY;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScaleY", ex); }
			}
			set
			{
				try {
					teklaObject.ScaleY = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ScaleY", ex); }
			}
		}

        

        






    }

    internal static class HatchAttributes_
    {
        public static dynamic GetTSObject(HatchAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static HatchAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.HatchAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class HatchAttributesArray_
    {
        public static dynamic GetTSObject(HatchAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(HatchAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static HatchAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<HatchAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(HatchAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
