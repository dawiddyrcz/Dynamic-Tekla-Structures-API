/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PlacingQuarterAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean TopLeft
		{
			get
			{
				try {
					return teklaObject.TopLeft;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TopLeft"); }
			}
			set
			{
				try {
					teklaObject.TopLeft = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TopLeft"); }
			}
		}

		public System.Boolean TopRight
		{
			get
			{
				try {
					return teklaObject.TopRight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TopRight"); }
			}
			set
			{
				try {
					teklaObject.TopRight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TopRight"); }
			}
		}

		public System.Boolean BottomLeft
		{
			get
			{
				try {
					return teklaObject.BottomLeft;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BottomLeft"); }
			}
			set
			{
				try {
					teklaObject.BottomLeft = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BottomLeft"); }
			}
		}

		public System.Boolean BottomRight
		{
			get
			{
				try {
					return teklaObject.BottomRight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BottomRight"); }
			}
			set
			{
				try {
					teklaObject.BottomRight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BottomRight"); }
			}
		}

        

        

		public PlacingQuarterAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingQuarterAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PlacingQuarterAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PlacingQuarterAttributes(System.Boolean TopLeft, System.Boolean TopRight, System.Boolean BottomLeft, System.Boolean BottomRight)
		{
			var args = new object[4];
			args[0] = TopLeft;
			args[1] = TopRight;
			args[2] = BottomLeft;
			args[3] = BottomRight;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingQuarterAttributes", args);
		}

		public System.Object Clone()
		{
			try {
			return teklaObject.Clone();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Clone()"); }
		}





    }

    internal static class PlacingQuarterAttributes_
    {
        public static dynamic GetTSObject(PlacingQuarterAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PlacingQuarterAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlacingQuarterAttributesArray_
    {
        public static dynamic GetTSObject(PlacingQuarterAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlacingQuarterAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlacingQuarterAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PlacingQuarterAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlacingQuarterAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
