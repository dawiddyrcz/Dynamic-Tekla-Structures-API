/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PlacingAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean IsFixed
		{
			get => teklaObject.IsFixed;
			set { teklaObject.IsFixed = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes PlacingDistance
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.FromTSObject(teklaObject.PlacingDistance);
			}
			set
			{
				teklaObject.PlacingDistance = Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes PlacingQuarter
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes_.FromTSObject(teklaObject.PlacingQuarter);
			}
			set
			{
				teklaObject.PlacingQuarter = Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes_.GetTSObject(value);
			}
		}

        

        

		public PlacingAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PlacingAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PlacingAttributes(System.Boolean IsFixed, Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes PlacingDistance, Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes PlacingQuarter)
		{
			var args = new object[3];
			args[0] = IsFixed;
			args[1] = Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.GetTSObject(PlacingDistance);
			args[2] = Dynamic.Tekla.Structures.Drawing.PlacingQuarterAttributes_.GetTSObject(PlacingQuarter);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingAttributes", args);
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

    internal static class PlacingAttributes_
    {
        public static dynamic GetTSObject(PlacingAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PlacingAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlacingAttributesArray_
    {
        public static dynamic GetTSObject(PlacingAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlacingAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlacingAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PlacingAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlacingAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
