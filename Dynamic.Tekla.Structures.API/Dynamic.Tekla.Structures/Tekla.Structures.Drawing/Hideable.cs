/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Hideable 
    {

		public System.Boolean IsHidden
		{
			get => teklaObject.IsHidden;
			set { teklaObject.IsHidden = value; }
		}

        

        internal dynamic teklaObject;

		public Hideable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Hideable");
		}

		public void HideFromDrawingView()
		{
			teklaObject.HideFromDrawingView();
		}

		public void HideFromDrawing()
		{
			teklaObject.HideFromDrawing();
		}

		public void ShowInDrawingView()
		{
			teklaObject.ShowInDrawingView();
		}

		public void ShowInDrawing()
		{
			teklaObject.ShowInDrawing();
		}




    public enum HiddenFlags
    {
			NotHidden,
			HiddenBySelf,
			HiddenByParent        
    }

    internal static class HiddenFlags_
    {
        public static dynamic GetTSObject(HiddenFlags dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Hideable.HiddenFlags").GetType();

            switch (dynEnum)
            {
				case HiddenFlags.NotHidden:
					return System.Enum.Parse(tsType, "NotHidden");
				case HiddenFlags.HiddenBySelf:
					return System.Enum.Parse(tsType, "HiddenBySelf");
				case HiddenFlags.HiddenByParent:
					return System.Enum.Parse(tsType, "HiddenByParent");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static HiddenFlags FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NotHidden", System.StringComparison.InvariantCulture))
				return HiddenFlags.NotHidden;
			else if (tsEnumValue.Equals("HiddenBySelf", System.StringComparison.InvariantCulture))
				return HiddenFlags.HiddenBySelf;
			else if (tsEnumValue.Equals("HiddenByParent", System.StringComparison.InvariantCulture))
				return HiddenFlags.HiddenByParent;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ShouldBeHiddenFlags
    {
			ShouldNotBeHidden,
			HideFromDrawingView,
			HideFromDrawing,
			ShowInDrawingView,
			ShowInDrawing        
    }

    internal static class ShouldBeHiddenFlags_
    {
        public static dynamic GetTSObject(ShouldBeHiddenFlags dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Hideable.ShouldBeHiddenFlags").GetType();

            switch (dynEnum)
            {
				case ShouldBeHiddenFlags.ShouldNotBeHidden:
					return System.Enum.Parse(tsType, "ShouldNotBeHidden");
				case ShouldBeHiddenFlags.HideFromDrawingView:
					return System.Enum.Parse(tsType, "HideFromDrawingView");
				case ShouldBeHiddenFlags.HideFromDrawing:
					return System.Enum.Parse(tsType, "HideFromDrawing");
				case ShouldBeHiddenFlags.ShowInDrawingView:
					return System.Enum.Parse(tsType, "ShowInDrawingView");
				case ShouldBeHiddenFlags.ShowInDrawing:
					return System.Enum.Parse(tsType, "ShowInDrawing");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ShouldBeHiddenFlags FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ShouldNotBeHidden", System.StringComparison.InvariantCulture))
				return ShouldBeHiddenFlags.ShouldNotBeHidden;
			else if (tsEnumValue.Equals("HideFromDrawingView", System.StringComparison.InvariantCulture))
				return ShouldBeHiddenFlags.HideFromDrawingView;
			else if (tsEnumValue.Equals("HideFromDrawing", System.StringComparison.InvariantCulture))
				return ShouldBeHiddenFlags.HideFromDrawing;
			else if (tsEnumValue.Equals("ShowInDrawingView", System.StringComparison.InvariantCulture))
				return ShouldBeHiddenFlags.ShowInDrawingView;
			else if (tsEnumValue.Equals("ShowInDrawing", System.StringComparison.InvariantCulture))
				return ShouldBeHiddenFlags.ShowInDrawing;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Hideable_
    {
        public static dynamic GetTSObject(Hideable dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Hideable FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Hideable)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class HideableArray_
    {
        public static dynamic GetTSObject(Hideable[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Hideable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Hideable[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Hideable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Hideable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
