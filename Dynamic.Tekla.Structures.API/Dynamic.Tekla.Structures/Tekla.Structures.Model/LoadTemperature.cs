/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadTemperature  : Dynamic.Tekla.Structures.Model.Load
    {

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(teklaObject.Spanning);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spanning"); }
			}
			set
			{
				try {
				teklaObject.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Spanning"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.PrimaryAxisDirection);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrimaryAxisDirection"); }
			}
			set
			{
				try {
				teklaObject.PrimaryAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PrimaryAxisDirection"); }
			}
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get
			{
				try {
					return teklaObject.AutomaticPrimaryAxisWeight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutomaticPrimaryAxisWeight"); }
			}
			set
			{
				try {
					teklaObject.AutomaticPrimaryAxisWeight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutomaticPrimaryAxisWeight"); }
			}
		}

		public System.Double Weight
		{
			get
			{
				try {
					return teklaObject.Weight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Weight"); }
			}
			set
			{
				try {
					teklaObject.Weight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Weight"); }
			}
		}

		public System.Double LoadDispersionAngle
		{
			get
			{
				try {
					return teklaObject.LoadDispersionAngle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadDispersionAngle"); }
			}
			set
			{
				try {
					teklaObject.LoadDispersionAngle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadDispersionAngle"); }
			}
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get
			{
				try {
					return teklaObject.CreateFixedSupportConditionsAutomatically;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreateFixedSupportConditionsAutomatically"); }
			}
			set
			{
				try {
					teklaObject.CreateFixedSupportConditionsAutomatically = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreateFixedSupportConditionsAutomatically"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position1"); }
			}
			set
			{
				try {
				teklaObject.Position1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position1"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position2"); }
			}
			set
			{
				try {
				teklaObject.Position2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position2"); }
			}
		}

		public System.Double TemperatureChangeForAxialElongation
		{
			get
			{
				try {
					return teklaObject.TemperatureChangeForAxialElongation;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TemperatureChangeForAxialElongation"); }
			}
			set
			{
				try {
					teklaObject.TemperatureChangeForAxialElongation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TemperatureChangeForAxialElongation"); }
			}
		}

		public System.Double TemperatureDifferentialTopToBottom
		{
			get
			{
				try {
					return teklaObject.TemperatureDifferentialTopToBottom;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TemperatureDifferentialTopToBottom"); }
			}
			set
			{
				try {
					teklaObject.TemperatureDifferentialTopToBottom = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TemperatureDifferentialTopToBottom"); }
			}
		}

		public System.Double TemperatureDifferentialSideToSide
		{
			get
			{
				try {
					return teklaObject.TemperatureDifferentialSideToSide;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TemperatureDifferentialSideToSide"); }
			}
			set
			{
				try {
					teklaObject.TemperatureDifferentialSideToSide = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TemperatureDifferentialSideToSide"); }
			}
		}

		public System.Double InitialAxialElongation
		{
			get
			{
				try {
					return teklaObject.InitialAxialElongation;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InitialAxialElongation"); }
			}
			set
			{
				try {
					teklaObject.InitialAxialElongation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InitialAxialElongation"); }
			}
		}

        

        

		public LoadTemperature()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadTemperature");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LoadTemperature(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class LoadTemperature_
    {
        public static dynamic GetTSObject(LoadTemperature dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoadTemperature FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LoadTemperature)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadTemperatureArray_
    {
        public static dynamic GetTSObject(LoadTemperature[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadTemperature_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadTemperature[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoadTemperature>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadTemperature_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
