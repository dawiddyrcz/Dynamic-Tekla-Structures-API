//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class EdgeChamfer 
    {

		public Dynamic.Tekla.Structures.Model.Chamfer Chamfer
		{
			get => new Dynamic.Tekla.Structures.Model.Chamfer(edgechamfer.Chamfer.GetTSObject());
			set { edgechamfer.Chamfer = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstEnd
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(edgechamfer.FirstEnd.GetTSObject());
			set { edgechamfer.FirstEnd = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondEnd
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(edgechamfer.SecondEnd.GetTSObject());
			set { edgechamfer.SecondEnd = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum FirstChamferEndType
		{
			get => Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(edgechamfer.FirstChamferEndType);
			set { edgechamfer.FirstChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum SecondChamferEndType
		{
			get => Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(edgechamfer.SecondChamferEndType);
			set { edgechamfer.SecondChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(value); }
		}

		public System.Double SecondBevelDimension
		{
			get => edgechamfer.SecondBevelDimension;
			set { edgechamfer.SecondBevelDimension = value; }
		}

		public System.Double FirstBevelDimension
		{
			get => edgechamfer.FirstBevelDimension;
			set { edgechamfer.FirstBevelDimension = value; }
		}

		public System.String Name
		{
			get => edgechamfer.Name;
			set { edgechamfer.Name = value; }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(edgechamfer.Father.GetTSObject());
			set { edgechamfer.Father = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => edgechamfer.ModificationTime;
			set { edgechamfer.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => edgechamfer.IsUpToDate;
			set { edgechamfer.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(edgechamfer.Identifier.GetTSObject());
			set { edgechamfer.Identifier = value.GetTSObject(); }
		}

        

        dynamic edgechamfer;
        
        public EdgeChamfer()
        {
            this.edgechamfer =  new Tekla.Structures.Model.EdgeChamfer();
        }

        public EdgeChamfer(dynamic tsObject)
        {
            this.edgechamfer = tsObject;
			this.Chamfer = new Dynamic.Tekla.Structures.Model.Chamfer(edgechamfer.Chamfer);
			this.FirstEnd = new Dynamic.Tekla.Structures.Geometry3d.Point(edgechamfer.FirstEnd);
			this.SecondEnd = new Dynamic.Tekla.Structures.Geometry3d.Point(edgechamfer.SecondEnd);
			this.FirstChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(edgechamfer.FirstChamferEndType);
			this.SecondChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(edgechamfer.SecondChamferEndType);
			this.SecondBevelDimension = edgechamfer.SecondBevelDimension;
			this.FirstBevelDimension = edgechamfer.FirstBevelDimension;
			this.Name = edgechamfer.Name;
			this.Father = new Dynamic.Tekla.Structures.Model.ModelObject(edgechamfer.Father);
			this.ModificationTime = edgechamfer.ModificationTime;
			this.IsUpToDate = edgechamfer.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(edgechamfer.Identifier);

        }


        public dynamic GetTSObject() => edgechamfer;

		public System.Boolean Insert()
			 => edgechamfer.Insert();

		public System.Boolean Select()
			 => edgechamfer.Select();

		public System.Boolean Modify()
			 => edgechamfer.Modify();

		public System.Boolean Delete()
			 => edgechamfer.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(edgechamfer.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(edgechamfer.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(edgechamfer.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => edgechamfer.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => edgechamfer.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => edgechamfer.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => edgechamfer.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => edgechamfer.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => edgechamfer.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => edgechamfer.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => edgechamfer.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => edgechamfer.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => edgechamfer.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => edgechamfer.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => edgechamfer.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => edgechamfer.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => edgechamfer.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => edgechamfer.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => edgechamfer.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => edgechamfer.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => edgechamfer.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => edgechamfer.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(edgechamfer.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => edgechamfer.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => edgechamfer.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => edgechamfer.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => edgechamfer.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => edgechamfer.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => edgechamfer.Equals(obj);

		public System.Int32 GetHashCode()
			 => edgechamfer.GetHashCode();

		public System.Type GetType()
			 => edgechamfer.GetType();

		public System.String ToString()
			 => edgechamfer.ToString();




    public enum ChamferEndTypeEnum
    {
			FULL,
			STRAIGHT,
			BEVELLED        
    }

    public static class ChamferEndTypeEnum_
    {
        public static dynamic GetTSObject(ChamferEndTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ChamferEndTypeEnum");

            switch (dynEnum)
            {
				case ChamferEndTypeEnum.FULL:
					return System.Enum.Parse(tsType, "FULL");
				case ChamferEndTypeEnum.STRAIGHT:
					return System.Enum.Parse(tsType, "STRAIGHT");
				case ChamferEndTypeEnum.BEVELLED:
					return System.Enum.Parse(tsType, "BEVELLED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ChamferEndTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("FULL", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.FULL;
			else if (tsEnumValue.Equals("STRAIGHT", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.STRAIGHT;
			else if (tsEnumValue.Equals("BEVELLED", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.BEVELLED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
