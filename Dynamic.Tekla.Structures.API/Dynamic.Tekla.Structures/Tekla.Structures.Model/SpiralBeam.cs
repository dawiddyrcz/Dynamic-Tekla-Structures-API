//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class SpiralBeam  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisBasePoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.RotationAxisBasePoint);
			set { teklaObject.RotationAxisBasePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisUpPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.RotationAxisUpPoint);
			set { teklaObject.RotationAxisUpPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double TotalRise
		{
			get => teklaObject.TotalRise;
			set { teklaObject.TotalRise = value; }
		}

		public System.Double RotationAngle
		{
			get => teklaObject.RotationAngle;
			set { teklaObject.RotationAngle = value; }
		}

		public System.Double TwistAngleStart
		{
			get => teklaObject.TwistAngleStart;
			set { teklaObject.TwistAngleStart = value; }
		}

		public System.Double TwistAngleEnd
		{
			get => teklaObject.TwistAngleEnd;
			set { teklaObject.TwistAngleEnd = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationCenterPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.RotationCenterPoint);
			set { teklaObject.RotationCenterPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxisDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.RotationAxisDirection);
			set { teklaObject.RotationAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public SpiralBeam()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam");
		}
		public SpiralBeam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisBasePoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisUpPoint, System.Double totalRise, System.Double rotationAngle, System.Double twistAngleAtStart, System.Double twistAngleAtEnd)
		{
			var args = new object[7];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisBasePoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisUpPoint);
			args[3] = totalRise;
			args[4] = rotationAngle;
			args[5] = twistAngleAtStart;
			args[6] = twistAngleAtEnd;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam", args);
		}
		public SpiralBeam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisBasePoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisUpPoint, System.Double totalRise, System.Double rotationAngle)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisBasePoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisUpPoint);
			args[3] = totalRise;
			args[4] = rotationAngle;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam", args);
		}
		public SpiralBeam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisPoint, System.Double totalRise, System.Double rotationAngle)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisPoint);
			args[2] = totalRise;
			args[3] = rotationAngle;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam", args);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}




    public enum ErrorStatus
    {
			DataMissing,
			DefinitionPointsTooClose,
			DefinitionPointsCannotBeAligned,
			ZeroTotalRiseWithMore360Degrees        
    }

    internal static class ErrorStatus_
    {
        public static dynamic GetTSObject(ErrorStatus dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam.ErrorStatus").GetType();

            switch (dynEnum)
            {
				case ErrorStatus.DataMissing:
					return System.Enum.Parse(tsType, "DataMissing");
				case ErrorStatus.DefinitionPointsTooClose:
					return System.Enum.Parse(tsType, "DefinitionPointsTooClose");
				case ErrorStatus.DefinitionPointsCannotBeAligned:
					return System.Enum.Parse(tsType, "DefinitionPointsCannotBeAligned");
				case ErrorStatus.ZeroTotalRiseWithMore360Degrees:
					return System.Enum.Parse(tsType, "ZeroTotalRiseWithMore360Degrees");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ErrorStatus FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DataMissing", System.StringComparison.InvariantCulture))
				return ErrorStatus.DataMissing;
			else if (tsEnumValue.Equals("DefinitionPointsTooClose", System.StringComparison.InvariantCulture))
				return ErrorStatus.DefinitionPointsTooClose;
			else if (tsEnumValue.Equals("DefinitionPointsCannotBeAligned", System.StringComparison.InvariantCulture))
				return ErrorStatus.DefinitionPointsCannotBeAligned;
			else if (tsEnumValue.Equals("ZeroTotalRiseWithMore360Degrees", System.StringComparison.InvariantCulture))
				return ErrorStatus.ZeroTotalRiseWithMore360Degrees;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class SpiralBeam_
    {
        public static dynamic GetTSObject(SpiralBeam dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SpiralBeam FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.SpiralBeam)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
