/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadLine  : Dynamic.Tekla.Structures.Model.Load
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Position1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position1", ex); }
			}
			set
			{
				try {
				teklaObject.Position1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position1", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position2", ex); }
			}
			set
			{
				try {
				teklaObject.Position2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position2", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.P1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P1", ex); }
			}
			set
			{
				try {
				teklaObject.P1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P1", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.P2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P2", ex); }
			}
			set
			{
				try {
				teklaObject.P2 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P2", ex); }
			}
		}

		public System.Double Torsion1
		{
			get
			{
				try {
					return teklaObject.Torsion1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Torsion1", ex); }
			}
			set
			{
				try {
					teklaObject.Torsion1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Torsion1", ex); }
			}
		}

		public System.Double Torsion2
		{
			get
			{
				try {
					return teklaObject.Torsion2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Torsion2", ex); }
			}
			set
			{
				try {
					teklaObject.Torsion2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Torsion2", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.LoadLine.LineLoadFormEnum LoadForm
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.LoadLine.LineLoadFormEnum_.FromTSObject(teklaObject.LoadForm);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadForm", ex); }
			}
			set
			{
				try {
				teklaObject.LoadForm = Dynamic.Tekla.Structures.Model.LoadLine.LineLoadFormEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadForm", ex); }
			}
		}

		public System.Double DistanceA
		{
			get
			{
				try {
					return teklaObject.DistanceA;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceA", ex); }
			}
			set
			{
				try {
					teklaObject.DistanceA = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceA", ex); }
			}
		}

		public System.Double DistanceB
		{
			get
			{
				try {
					return teklaObject.DistanceB;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceB", ex); }
			}
			set
			{
				try {
					teklaObject.DistanceB = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceB", ex); }
			}
		}

        

        

		public LoadLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadLine");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LoadLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum LineLoadFormEnum
    {
			LOAD_FORM_LINE_1,
			LOAD_FORM_LINE_2,
			LOAD_FORM_LINE_3,
			LOAD_FORM_LINE_4        
    }

    internal static class LineLoadFormEnum_
    {
        public static dynamic GetTSObject(LineLoadFormEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoadLine.LineLoadFormEnum").GetType();

            switch (dynEnum)
            {
				case LineLoadFormEnum.LOAD_FORM_LINE_1:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_1");
				case LineLoadFormEnum.LOAD_FORM_LINE_2:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_2");
				case LineLoadFormEnum.LOAD_FORM_LINE_3:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_3");
				case LineLoadFormEnum.LOAD_FORM_LINE_4:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_4");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LineLoadFormEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_FORM_LINE_1", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_1;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_2", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_2;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_3", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_3;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_4", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_4;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoadLine_
    {
        public static dynamic GetTSObject(LoadLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoadLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LoadLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadLineArray_
    {
        public static dynamic GetTSObject(LoadLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoadLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
