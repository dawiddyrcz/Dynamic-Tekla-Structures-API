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
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public System.Boolean AutomaticScaling
		{
			get => teklaObject.AutomaticScaling;
			set { teklaObject.AutomaticScaling = value; }
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

		public Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.Rotation RotationAxis
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.Rotation_.FromTSObject(teklaObject.RotationAxis);
			set { teklaObject.RotationAxis = Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.Rotation_.GetTSObject(value); }
		}

		public System.Boolean Exaggeration
		{
			get => teklaObject.Exaggeration;
			set { teklaObject.Exaggeration = value; }
		}

		public System.Boolean BendingRadius
		{
			get => teklaObject.BendingRadius;
			set { teklaObject.BendingRadius = value; }
		}

		public System.Boolean BendingAngle
		{
			get => teklaObject.BendingAngle;
			set { teklaObject.BendingAngle = value; }
		}

		public System.Boolean Dimensioning
		{
			get => teklaObject.Dimensioning;
			set { teklaObject.Dimensioning = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.EndSymbols EndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.EndSymbols_.FromTSObject(teklaObject.EndSymbolType);
			set { teklaObject.EndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement.EndSymbols_.GetTSObject(value); }
		}

        

        

		public ReinforcementPulloutElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementPulloutElement");
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.String GetUnformattedString()
		{
			return teklaObject.GetUnformattedString();
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ReinforcementPulloutElement_
    {
        public static dynamic GetTSObject(ReinforcementPulloutElement dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementPulloutElement FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementPulloutElement)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
