/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class SpiralBeam  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisBasePoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.RotationAxisBasePoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxisBasePoint"); }
			}
			set
			{
				try {
				teklaObject.RotationAxisBasePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxisBasePoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisUpPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.RotationAxisUpPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxisUpPoint"); }
			}
			set
			{
				try {
				teklaObject.RotationAxisUpPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxisUpPoint"); }
			}
		}

		public System.Double TotalRise
		{
			get
			{
				try {
					return teklaObject.TotalRise;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TotalRise"); }
			}
			set
			{
				try {
					teklaObject.TotalRise = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TotalRise"); }
			}
		}

		public System.Double RotationAngle
		{
			get
			{
				try {
					return teklaObject.RotationAngle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAngle"); }
			}
			set
			{
				try {
					teklaObject.RotationAngle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAngle"); }
			}
		}

		public System.Double TwistAngleStart
		{
			get
			{
				try {
					return teklaObject.TwistAngleStart;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TwistAngleStart"); }
			}
			set
			{
				try {
					teklaObject.TwistAngleStart = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TwistAngleStart"); }
			}
		}

		public System.Double TwistAngleEnd
		{
			get
			{
				try {
					return teklaObject.TwistAngleEnd;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TwistAngleEnd"); }
			}
			set
			{
				try {
					teklaObject.TwistAngleEnd = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TwistAngleEnd"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationCenterPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.RotationCenterPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationCenterPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxisDirection
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.RotationAxisDirection);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAxisDirection"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

        

        

		public SpiralBeam()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SpiralBeam(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class SpiralBeam_
    {
        public static dynamic GetTSObject(SpiralBeam dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SpiralBeam FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.SpiralBeam)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SpiralBeamArray_
    {
        public static dynamic GetTSObject(SpiralBeam[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SpiralBeam_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SpiralBeam[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SpiralBeam>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SpiralBeam_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
