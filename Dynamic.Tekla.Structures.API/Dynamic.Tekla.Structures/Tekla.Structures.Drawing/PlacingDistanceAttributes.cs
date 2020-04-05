/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PlacingDistanceAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Double SearchMargin
		{
			get
			{
				try {
					return teklaObject.SearchMargin;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SearchMargin"); }
			}
			set
			{
				try {
					teklaObject.SearchMargin = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SearchMargin"); }
			}
		}

		public System.Double MinimalDistance
		{
			get
			{
				try {
					return teklaObject.MinimalDistance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimalDistance"); }
			}
			set
			{
				try {
					teklaObject.MinimalDistance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimalDistance"); }
			}
		}

		public System.Double MaximalDistance
		{
			get
			{
				try {
					return teklaObject.MaximalDistance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximalDistance"); }
			}
			set
			{
				try {
					teklaObject.MaximalDistance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximalDistance"); }
			}
		}

        

        

		public PlacingDistanceAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDistanceAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PlacingDistanceAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PlacingDistanceAttributes(System.Double searchMargin, System.Double minimalDistance)
		{
			var args = new object[2];
			args[0] = searchMargin;
			args[1] = minimalDistance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDistanceAttributes", args);
		}
		public PlacingDistanceAttributes(System.Double searchMargin, System.Double minimalDistance, System.Double maximalDistance)
		{
			var args = new object[3];
			args[0] = searchMargin;
			args[1] = minimalDistance;
			args[2] = maximalDistance;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDistanceAttributes", args);
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

    internal static class PlacingDistanceAttributes_
    {
        public static dynamic GetTSObject(PlacingDistanceAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PlacingDistanceAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlacingDistanceAttributesArray_
    {
        public static dynamic GetTSObject(PlacingDistanceAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlacingDistanceAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlacingDistanceAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PlacingDistanceAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlacingDistanceAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
