/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReinforcementPulloutElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font", ex); }
			}
			set
			{
				try {
				teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font", ex); }
			}
		}

		public System.Boolean AutomaticScaling
		{
			get
			{
				try {
					return teklaObject.AutomaticScaling;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutomaticScaling", ex); }
			}
			set
			{
				try {
					teklaObject.AutomaticScaling = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AutomaticScaling", ex); }
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

		public Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.Rotation RotationAxis
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.Rotation_.FromTSObject(teklaObject.RotationAxis);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxis", ex); }
			}
			set
			{
				try {
				teklaObject.RotationAxis = Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.Rotation_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxis", ex); }
			}
		}

		public System.Boolean Exaggeration
		{
			get
			{
				try {
					return teklaObject.Exaggeration;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Exaggeration", ex); }
			}
			set
			{
				try {
					teklaObject.Exaggeration = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Exaggeration", ex); }
			}
		}

		public System.Boolean BendingRadius
		{
			get
			{
				try {
					return teklaObject.BendingRadius;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendingRadius", ex); }
			}
			set
			{
				try {
					teklaObject.BendingRadius = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendingRadius", ex); }
			}
		}

		public System.Boolean BendingAngle
		{
			get
			{
				try {
					return teklaObject.BendingAngle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendingAngle", ex); }
			}
			set
			{
				try {
					teklaObject.BendingAngle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BendingAngle", ex); }
			}
		}

		public System.Boolean Dimensioning
		{
			get
			{
				try {
					return teklaObject.Dimensioning;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Dimensioning", ex); }
			}
			set
			{
				try {
					teklaObject.Dimensioning = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Dimensioning", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.EndSymbols EndSymbolType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.EndSymbols_.FromTSObject(teklaObject.EndSymbolType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndSymbolType", ex); }
			}
			set
			{
				try {
				teklaObject.EndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.EndSymbols_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndSymbolType", ex); }
			}
		}

        

        

		public ReinforcementPulloutElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementPulloutElement");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementPulloutElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum EndSymbols
    {
			NONE,
			SINGLE,
			BOTH        
    }

    internal static class EndSymbols_
    {
        public static dynamic GetTSObject(EndSymbols dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementPulloutElement.EndSymbols").GetType();

            switch (dynEnum)
            {
				case EndSymbols.NONE:
					return System.Enum.Parse(tsType, "NONE");
				case EndSymbols.SINGLE:
					return System.Enum.Parse(tsType, "SINGLE");
				case EndSymbols.BOTH:
					return System.Enum.Parse(tsType, "BOTH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EndSymbols FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NONE", System.StringComparison.InvariantCulture))
				return EndSymbols.NONE;
			else if (tsEnumValue.Equals("SINGLE", System.StringComparison.InvariantCulture))
				return EndSymbols.SINGLE;
			else if (tsEnumValue.Equals("BOTH", System.StringComparison.InvariantCulture))
				return EndSymbols.BOTH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum Rotation
    {
			Automatic,
			Plane,
			Global        
    }

    internal static class Rotation_
    {
        public static dynamic GetTSObject(Rotation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementPulloutElement.Rotation").GetType();

            switch (dynEnum)
            {
				case Rotation.Automatic:
					return System.Enum.Parse(tsType, "Automatic");
				case Rotation.Plane:
					return System.Enum.Parse(tsType, "Plane");
				case Rotation.Global:
					return System.Enum.Parse(tsType, "Global");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Rotation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Automatic", System.StringComparison.InvariantCulture))
				return Rotation.Automatic;
			else if (tsEnumValue.Equals("Plane", System.StringComparison.InvariantCulture))
				return Rotation.Plane;
			else if (tsEnumValue.Equals("Global", System.StringComparison.InvariantCulture))
				return Rotation.Global;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ReinforcementPulloutElement_
    {
        public static dynamic GetTSObject(ReinforcementPulloutElement dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReinforcementPulloutElement FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementPulloutElementArray_
    {
        public static dynamic GetTSObject(ReinforcementPulloutElement[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementPulloutElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementPulloutElement[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReinforcementPulloutElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementPulloutElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
