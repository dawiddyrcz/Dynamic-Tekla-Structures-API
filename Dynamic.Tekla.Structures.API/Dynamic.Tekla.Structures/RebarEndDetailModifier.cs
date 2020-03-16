//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarEndDetailModifier 
    {

		public Dynamic.Tekla.Structures.Model.RebarHookDataNullable RebarHook
		{
			get => new Dynamic.Tekla.Structures.Model.RebarHookDataNullable(rebarenddetailmodifier.RebarHook.GetTSObject());
			set { rebarenddetailmodifier.RebarHook = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable RebarThreading
		{
			get => new Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable(rebarenddetailmodifier.RebarThreading.GetTSObject());
			set { rebarenddetailmodifier.RebarThreading = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable RebarLengthAdjustment
		{
			get => new Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable(rebarenddetailmodifier.RebarLengthAdjustment.GetTSObject());
			set { rebarenddetailmodifier.RebarLengthAdjustment = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.RebarCrankingNullable RebarCranking
		{
			get => new Dynamic.Tekla.Structures.Model.RebarCrankingNullable(rebarenddetailmodifier.RebarCranking.GetTSObject());
			set { rebarenddetailmodifier.RebarCranking = value.GetTSObject(); }
		}

		public System.Nullable<Dynamic.Tekla.Structures.Model.EndTypeEnum> EndType
		{
			get => rebarenddetailmodifier.EndType;
			set { rebarenddetailmodifier.EndType = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSet Father
		{
			get => new Dynamic.Tekla.Structures.Model.RebarSet(rebarenddetailmodifier.Father.GetTSObject());
			set { rebarenddetailmodifier.Father = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Contour Curve
		{
			get => new Dynamic.Tekla.Structures.Model.Contour(rebarenddetailmodifier.Curve.GetTSObject());
			set { rebarenddetailmodifier.Curve = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.BarsAffectedEnum BarsAffected
		{
			get => Dynamic.Tekla.Structures.Model.BarsAffectedEnum_.FromTSObject(rebarenddetailmodifier.BarsAffected);
			set { rebarenddetailmodifier.BarsAffected = Dynamic.Tekla.Structures.Model.BarsAffectedEnum_.FromTSObject(value); }
		}

		public System.Int32 FirstAffectedBar
		{
			get => rebarenddetailmodifier.FirstAffectedBar;
			set { rebarenddetailmodifier.FirstAffectedBar = value; }
		}

		public System.Nullable<System.DateTime> ModificationTime
		{
			get => rebarenddetailmodifier.ModificationTime;
			set { rebarenddetailmodifier.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => rebarenddetailmodifier.IsUpToDate;
			set { rebarenddetailmodifier.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(rebarenddetailmodifier.Identifier.GetTSObject());
			set { rebarenddetailmodifier.Identifier = value.GetTSObject(); }
		}

        

        dynamic rebarenddetailmodifier;
        
        public RebarEndDetailModifier()
        {
            this.rebarenddetailmodifier =  new Tekla.Structures.Model.RebarEndDetailModifier();
        }

        public RebarEndDetailModifier(dynamic tsObject)
        {
            this.rebarenddetailmodifier = tsObject;
			this.RebarHook = new Dynamic.Tekla.Structures.Model.RebarHookDataNullable(rebarenddetailmodifier.RebarHook);
			this.RebarThreading = new Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable(rebarenddetailmodifier.RebarThreading);
			this.RebarLengthAdjustment = new Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable(rebarenddetailmodifier.RebarLengthAdjustment);
			this.RebarCranking = new Dynamic.Tekla.Structures.Model.RebarCrankingNullable(rebarenddetailmodifier.RebarCranking);
			this.EndType = rebarenddetailmodifier.EndType;
			this.Father = new Dynamic.Tekla.Structures.Model.RebarSet(rebarenddetailmodifier.Father);
			this.Curve = new Dynamic.Tekla.Structures.Model.Contour(rebarenddetailmodifier.Curve);
			this.BarsAffected = Dynamic.Tekla.Structures.Model.BarsAffectedEnum_.FromTSObject(rebarenddetailmodifier.BarsAffected);
			this.FirstAffectedBar = rebarenddetailmodifier.FirstAffectedBar;
			this.ModificationTime = rebarenddetailmodifier.ModificationTime;
			this.IsUpToDate = rebarenddetailmodifier.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(rebarenddetailmodifier.Identifier);

        }


        public dynamic GetTSObject() => rebarenddetailmodifier;

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAffectedBars(Dynamic.Tekla.Structures.Model.AffectedRebarEnum whichEnd)
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(rebarenddetailmodifier.GetAffectedBars(whichEnd.GetTSObject()));

		public System.Boolean Insert()
			 => rebarenddetailmodifier.Insert();

		public System.Boolean Modify()
			 => rebarenddetailmodifier.Modify();

		public System.Boolean Delete()
			 => rebarenddetailmodifier.Delete();

		public System.Boolean Select()
			 => rebarenddetailmodifier.Select();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(rebarenddetailmodifier.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(rebarenddetailmodifier.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(rebarenddetailmodifier.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => rebarenddetailmodifier.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => rebarenddetailmodifier.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => rebarenddetailmodifier.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => rebarenddetailmodifier.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => rebarenddetailmodifier.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => rebarenddetailmodifier.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => rebarenddetailmodifier.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => rebarenddetailmodifier.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => rebarenddetailmodifier.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => rebarenddetailmodifier.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => rebarenddetailmodifier.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => rebarenddetailmodifier.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(rebarenddetailmodifier.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebarenddetailmodifier.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebarenddetailmodifier.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => rebarenddetailmodifier.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => rebarenddetailmodifier.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => rebarenddetailmodifier.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => rebarenddetailmodifier.Equals(obj);

		public System.Int32 GetHashCode()
			 => rebarenddetailmodifier.GetHashCode();

		public System.Type GetType()
			 => rebarenddetailmodifier.GetType();

		public System.String ToString()
			 => rebarenddetailmodifier.ToString();




    public enum EndTypeEnum
    {
			HOOK,
			CRANKING        
    }

    public static class EndTypeEnum_
    {
        public static dynamic GetTSObject(EndTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.EndTypeEnum");

            switch (dynEnum)
            {
				case EndTypeEnum.HOOK:
					return System.Enum.Parse(tsType, "HOOK");
				case EndTypeEnum.CRANKING:
					return System.Enum.Parse(tsType, "CRANKING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EndTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HOOK", System.StringComparison.InvariantCulture))
				return EndTypeEnum.HOOK;
			else if (tsEnumValue.Equals("CRANKING", System.StringComparison.InvariantCulture))
				return EndTypeEnum.CRANKING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
