/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class EdgeChamfer  : Dynamic.Tekla.Structures.Model.Boolean
    {

		public Dynamic.Tekla.Structures.Model.Chamfer Chamfer
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Chamfer_.FromTSObject(teklaObject.Chamfer);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Chamfer", ex); }
			}
			set
			{
				try {
				teklaObject.Chamfer = Dynamic.Tekla.Structures.Model.Chamfer_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Chamfer", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstEnd
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.FirstEnd);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstEnd", ex); }
			}
			set
			{
				try {
				teklaObject.FirstEnd = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstEnd", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondEnd
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.SecondEnd);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondEnd", ex); }
			}
			set
			{
				try {
				teklaObject.SecondEnd = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondEnd", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum FirstChamferEndType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(teklaObject.FirstChamferEndType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstChamferEndType", ex); }
			}
			set
			{
				try {
				teklaObject.FirstChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstChamferEndType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum SecondChamferEndType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(teklaObject.SecondChamferEndType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondChamferEndType", ex); }
			}
			set
			{
				try {
				teklaObject.SecondChamferEndType = Dynamic.Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondChamferEndType", ex); }
			}
		}

		public System.Double SecondBevelDimension
		{
			get
			{
				try {
					return teklaObject.SecondBevelDimension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondBevelDimension", ex); }
			}
			set
			{
				try {
					teklaObject.SecondBevelDimension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SecondBevelDimension", ex); }
			}
		}

		public System.Double FirstBevelDimension
		{
			get
			{
				try {
					return teklaObject.FirstBevelDimension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstBevelDimension", ex); }
			}
			set
			{
				try {
					teklaObject.FirstBevelDimension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FirstBevelDimension", ex); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

        

        

		public EdgeChamfer()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public EdgeChamfer(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public EdgeChamfer(Dynamic.Tekla.Structures.Geometry3d.Point FirstEnd, Dynamic.Tekla.Structures.Geometry3d.Point SecondEnd)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(FirstEnd);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SecondEnd);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer", args);
		}




    public enum ChamferEndTypeEnum
    {
			FULL,
			STRAIGHT,
			BEVELLED        
    }

    internal static class ChamferEndTypeEnum_
    {
        public static dynamic GetTSObject(ChamferEndTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum").GetType();

            switch (dynEnum)
            {
				case ChamferEndTypeEnum.FULL:
					return System.Enum.Parse(tsType, "FULL");
				case ChamferEndTypeEnum.STRAIGHT:
					return System.Enum.Parse(tsType, "STRAIGHT");
				case ChamferEndTypeEnum.BEVELLED:
					return System.Enum.Parse(tsType, "BEVELLED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class EdgeChamfer_
    {
        public static dynamic GetTSObject(EdgeChamfer dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static EdgeChamfer FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.EdgeChamfer)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EdgeChamferArray_
    {
        public static dynamic GetTSObject(EdgeChamfer[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EdgeChamfer_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EdgeChamfer[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<EdgeChamfer>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EdgeChamfer_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
