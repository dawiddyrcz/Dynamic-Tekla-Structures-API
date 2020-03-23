/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ReinforcementBase  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes_.GetTSObject(value); }
		}

        

        


		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}




    public enum ReinforcementRepresentationTypes
    {
			SingleLine,
			DoubleLine,
			Filled,
			Stick,
			OutLine,
			DoubleLineFilledEnds,
			SingleLineFilledEnds        
    }

    internal static class ReinforcementRepresentationTypes_
    {
        public static dynamic GetTSObject(ReinforcementRepresentationTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementRepresentationTypes").GetType();

            switch (dynEnum)
            {
				case ReinforcementRepresentationTypes.SingleLine:
					return System.Enum.Parse(tsType, "SingleLine");
				case ReinforcementRepresentationTypes.DoubleLine:
					return System.Enum.Parse(tsType, "DoubleLine");
				case ReinforcementRepresentationTypes.Filled:
					return System.Enum.Parse(tsType, "Filled");
				case ReinforcementRepresentationTypes.Stick:
					return System.Enum.Parse(tsType, "Stick");
				case ReinforcementRepresentationTypes.OutLine:
					return System.Enum.Parse(tsType, "OutLine");
				case ReinforcementRepresentationTypes.DoubleLineFilledEnds:
					return System.Enum.Parse(tsType, "DoubleLineFilledEnds");
				case ReinforcementRepresentationTypes.SingleLineFilledEnds:
					return System.Enum.Parse(tsType, "SingleLineFilledEnds");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ReinforcementRepresentationTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SingleLine", System.StringComparison.InvariantCulture))
				return ReinforcementRepresentationTypes.SingleLine;
			else if (tsEnumValue.Equals("DoubleLine", System.StringComparison.InvariantCulture))
				return ReinforcementRepresentationTypes.DoubleLine;
			else if (tsEnumValue.Equals("Filled", System.StringComparison.InvariantCulture))
				return ReinforcementRepresentationTypes.Filled;
			else if (tsEnumValue.Equals("Stick", System.StringComparison.InvariantCulture))
				return ReinforcementRepresentationTypes.Stick;
			else if (tsEnumValue.Equals("OutLine", System.StringComparison.InvariantCulture))
				return ReinforcementRepresentationTypes.OutLine;
			else if (tsEnumValue.Equals("DoubleLineFilledEnds", System.StringComparison.InvariantCulture))
				return ReinforcementRepresentationTypes.DoubleLineFilledEnds;
			else if (tsEnumValue.Equals("SingleLineFilledEnds", System.StringComparison.InvariantCulture))
				return ReinforcementRepresentationTypes.SingleLineFilledEnds;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ReinforcementVisibilityTypes
    {
			All,
			First,
			Last,
			FirstAndLast,
			OneInTheMiddle,
			TwoInTheMiddle,
			Customized        
    }

    internal static class ReinforcementVisibilityTypes_
    {
        public static dynamic GetTSObject(ReinforcementVisibilityTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes").GetType();

            switch (dynEnum)
            {
				case ReinforcementVisibilityTypes.All:
					return System.Enum.Parse(tsType, "All");
				case ReinforcementVisibilityTypes.First:
					return System.Enum.Parse(tsType, "First");
				case ReinforcementVisibilityTypes.Last:
					return System.Enum.Parse(tsType, "Last");
				case ReinforcementVisibilityTypes.FirstAndLast:
					return System.Enum.Parse(tsType, "FirstAndLast");
				case ReinforcementVisibilityTypes.OneInTheMiddle:
					return System.Enum.Parse(tsType, "OneInTheMiddle");
				case ReinforcementVisibilityTypes.TwoInTheMiddle:
					return System.Enum.Parse(tsType, "TwoInTheMiddle");
				case ReinforcementVisibilityTypes.Customized:
					return System.Enum.Parse(tsType, "Customized");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ReinforcementVisibilityTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("All", System.StringComparison.InvariantCulture))
				return ReinforcementVisibilityTypes.All;
			else if (tsEnumValue.Equals("First", System.StringComparison.InvariantCulture))
				return ReinforcementVisibilityTypes.First;
			else if (tsEnumValue.Equals("Last", System.StringComparison.InvariantCulture))
				return ReinforcementVisibilityTypes.Last;
			else if (tsEnumValue.Equals("FirstAndLast", System.StringComparison.InvariantCulture))
				return ReinforcementVisibilityTypes.FirstAndLast;
			else if (tsEnumValue.Equals("OneInTheMiddle", System.StringComparison.InvariantCulture))
				return ReinforcementVisibilityTypes.OneInTheMiddle;
			else if (tsEnumValue.Equals("TwoInTheMiddle", System.StringComparison.InvariantCulture))
				return ReinforcementVisibilityTypes.TwoInTheMiddle;
			else if (tsEnumValue.Equals("Customized", System.StringComparison.InvariantCulture))
				return ReinforcementVisibilityTypes.Customized;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum StraightEndSymbolTypes
    {
			NoSymbol,
			HooksOnInnerSide,
			HooksOnOuterSide,
			HookOnReinforcementStartOuterSide,
			HookOnReinforcementStartInnerSide,
			FullHooks        
    }

    internal static class StraightEndSymbolTypes_
    {
        public static dynamic GetTSObject(StraightEndSymbolTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes").GetType();

            switch (dynEnum)
            {
				case StraightEndSymbolTypes.NoSymbol:
					return System.Enum.Parse(tsType, "NoSymbol");
				case StraightEndSymbolTypes.HooksOnInnerSide:
					return System.Enum.Parse(tsType, "HooksOnInnerSide");
				case StraightEndSymbolTypes.HooksOnOuterSide:
					return System.Enum.Parse(tsType, "HooksOnOuterSide");
				case StraightEndSymbolTypes.HookOnReinforcementStartOuterSide:
					return System.Enum.Parse(tsType, "HookOnReinforcementStartOuterSide");
				case StraightEndSymbolTypes.HookOnReinforcementStartInnerSide:
					return System.Enum.Parse(tsType, "HookOnReinforcementStartInnerSide");
				case StraightEndSymbolTypes.FullHooks:
					return System.Enum.Parse(tsType, "FullHooks");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static StraightEndSymbolTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NoSymbol", System.StringComparison.InvariantCulture))
				return StraightEndSymbolTypes.NoSymbol;
			else if (tsEnumValue.Equals("HooksOnInnerSide", System.StringComparison.InvariantCulture))
				return StraightEndSymbolTypes.HooksOnInnerSide;
			else if (tsEnumValue.Equals("HooksOnOuterSide", System.StringComparison.InvariantCulture))
				return StraightEndSymbolTypes.HooksOnOuterSide;
			else if (tsEnumValue.Equals("HookOnReinforcementStartOuterSide", System.StringComparison.InvariantCulture))
				return StraightEndSymbolTypes.HookOnReinforcementStartOuterSide;
			else if (tsEnumValue.Equals("HookOnReinforcementStartInnerSide", System.StringComparison.InvariantCulture))
				return StraightEndSymbolTypes.HookOnReinforcementStartInnerSide;
			else if (tsEnumValue.Equals("FullHooks", System.StringComparison.InvariantCulture))
				return StraightEndSymbolTypes.FullHooks;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum HookedEndSymbolTypes
    {
			NoHook,
			HalfHook,
			FullHook        
    }

    internal static class HookedEndSymbolTypes_
    {
        public static dynamic GetTSObject(HookedEndSymbolTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes").GetType();

            switch (dynEnum)
            {
				case HookedEndSymbolTypes.NoHook:
					return System.Enum.Parse(tsType, "NoHook");
				case HookedEndSymbolTypes.HalfHook:
					return System.Enum.Parse(tsType, "HalfHook");
				case HookedEndSymbolTypes.FullHook:
					return System.Enum.Parse(tsType, "FullHook");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static HookedEndSymbolTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NoHook", System.StringComparison.InvariantCulture))
				return HookedEndSymbolTypes.NoHook;
			else if (tsEnumValue.Equals("HalfHook", System.StringComparison.InvariantCulture))
				return HookedEndSymbolTypes.HalfHook;
			else if (tsEnumValue.Equals("FullHook", System.StringComparison.InvariantCulture))
				return HookedEndSymbolTypes.FullHook;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class ReinforcementSingleAttributes  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes ReinforcementVisibility
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.FromTSObject(teklaObject.ReinforcementVisibility);
			set { teklaObject.ReinforcementVisibility = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes StraightEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.FromTSObject(teklaObject.StraightEndSymbolType);
			set { teklaObject.StraightEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes HookedEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.FromTSObject(teklaObject.HookedEndSymbolType);
			set { teklaObject.HookedEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.GetTSObject(value); }
		}

        

        

		public ReinforcementSingleAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSingleAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementSingleAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ReinforcementSingleAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSingleAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementSingleAttributes_
    {
        public static dynamic GetTSObject(ReinforcementSingleAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementSingleAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSingleAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementSingleAttributesArray_
    {
        public static dynamic GetTSObject(ReinforcementSingleAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementSingleAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementSingleAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementSingleAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementSingleAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ReinforcementGroupAttributes  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes ReinforcementVisibility
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.FromTSObject(teklaObject.ReinforcementVisibility);
			set { teklaObject.ReinforcementVisibility = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes StraightEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.FromTSObject(teklaObject.StraightEndSymbolType);
			set { teklaObject.StraightEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes HookedEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.FromTSObject(teklaObject.HookedEndSymbolType);
			set { teklaObject.HookedEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.GetTSObject(value); }
		}

        

        

		public ReinforcementGroupAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementGroupAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementGroupAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ReinforcementGroupAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementGroupAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementGroupAttributes_
    {
        public static dynamic GetTSObject(ReinforcementGroupAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementGroupAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementGroupAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementGroupAttributesArray_
    {
        public static dynamic GetTSObject(ReinforcementGroupAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementGroupAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementGroupAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementGroupAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementGroupAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ReinforcementSetGroupAttributes  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes ReinforcementVisibility
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.FromTSObject(teklaObject.ReinforcementVisibility);
			set { teklaObject.ReinforcementVisibility = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes StraightEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.FromTSObject(teklaObject.StraightEndSymbolType);
			set { teklaObject.StraightEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes HookedEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.FromTSObject(teklaObject.HookedEndSymbolType);
			set { teklaObject.HookedEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.GetTSObject(value); }
		}

        

        

		public ReinforcementSetGroupAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementSetGroupAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ReinforcementSetGroupAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementSetGroupAttributes_
    {
        public static dynamic GetTSObject(ReinforcementSetGroupAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementSetGroupAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementSetGroupAttributesArray_
    {
        public static dynamic GetTSObject(ReinforcementSetGroupAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementSetGroupAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementSetGroupAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementSetGroupAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementSetGroupAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ReinforcementStrandAttributes  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes ReinforcementVisibility
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.FromTSObject(teklaObject.ReinforcementVisibility);
			set { teklaObject.ReinforcementVisibility = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes StraightEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.FromTSObject(teklaObject.StraightEndSymbolType);
			set { teklaObject.StraightEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.StraightEndSymbolTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes HookedEndSymbolType
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.FromTSObject(teklaObject.HookedEndSymbolType);
			set { teklaObject.HookedEndSymbolType = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.HookedEndSymbolTypes_.GetTSObject(value); }
		}

        

        

		public ReinforcementStrandAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementStrandAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementStrandAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ReinforcementStrandAttributes(System.Boolean SkipLoadingAttributes)
		{
			var args = new object[1];
			args[0] = SkipLoadingAttributes;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementStrandAttributes", args);
		}
		public ReinforcementStrandAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementStrandAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementStrandAttributes_
    {
        public static dynamic GetTSObject(ReinforcementStrandAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementStrandAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementStrandAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementStrandAttributesArray_
    {
        public static dynamic GetTSObject(ReinforcementStrandAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementStrandAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementStrandAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementStrandAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementStrandAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ReinforcementMeshAttributes  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes MeshReinforcementVisibilityLongitudinal
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.FromTSObject(teklaObject.MeshReinforcementVisibilityLongitudinal);
			set { teklaObject.MeshReinforcementVisibilityLongitudinal = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes MeshReinforcementVisibilityCrossing
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.FromTSObject(teklaObject.MeshReinforcementVisibilityCrossing);
			set { teklaObject.MeshReinforcementVisibilityCrossing = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementVisibilityTypes_.GetTSObject(value); }
		}

		public System.Int32 MeshReinforcementSymbolIndex
		{
			get => teklaObject.MeshReinforcementSymbolIndex;
			set { teklaObject.MeshReinforcementSymbolIndex = value; }
		}

		public System.Double MeshReinforcementSymbolSize
		{
			get => teklaObject.MeshReinforcementSymbolSize;
			set { teklaObject.MeshReinforcementSymbolSize = value; }
		}

        

        

		public ReinforcementMeshAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementMeshAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementMeshAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ReinforcementMeshAttributes(System.Boolean SkipLoadingAttributes)
		{
			var args = new object[1];
			args[0] = SkipLoadingAttributes;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementMeshAttributes", args);
		}
		public ReinforcementMeshAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReinforcementBase.ReinforcementMeshAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementMeshAttributes_
    {
        public static dynamic GetTSObject(ReinforcementMeshAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementMeshAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementMeshAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementMeshAttributesArray_
    {
        public static dynamic GetTSObject(ReinforcementMeshAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementMeshAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementMeshAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementMeshAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementMeshAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class ReinforcementBaseAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementRepresentationTypes ReinforcementRepresentation
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementRepresentationTypes_.FromTSObject(teklaObject.ReinforcementRepresentation);
			set { teklaObject.ReinforcementRepresentation = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementRepresentationTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes VisibleLines
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.VisibleLines);
			set { teklaObject.VisibleLines = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes HiddenLines
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.HiddenLines);
			set { teklaObject.HiddenLines = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public System.Boolean HideLinesHiddenByPart
		{
			get => teklaObject.HideLinesHiddenByPart;
			set { teklaObject.HideLinesHiddenByPart = value; }
		}

		public System.Boolean HideLinesHiddenByReinforcement
		{
			get => teklaObject.HideLinesHiddenByReinforcement;
			set { teklaObject.HideLinesHiddenByReinforcement = value; }
		}

		public System.String CustomPresentation
		{
			get => teklaObject.CustomPresentation;
			set { teklaObject.CustomPresentation = value; }
		}

        

        


		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementBaseAttributes_
    {
        public static dynamic GetTSObject(ReinforcementBaseAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementBaseAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementBaseAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementBaseAttributesArray_
    {
        public static dynamic GetTSObject(ReinforcementBaseAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementBaseAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementBaseAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementBaseAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementBaseAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class ReinforcementBase_
    {
        public static dynamic GetTSObject(ReinforcementBase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementBase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementBaseArray_
    {
        public static dynamic GetTSObject(ReinforcementBase[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementBase[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
