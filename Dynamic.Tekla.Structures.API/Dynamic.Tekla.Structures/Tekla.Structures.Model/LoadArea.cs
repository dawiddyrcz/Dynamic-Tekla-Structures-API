/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadArea  : Dynamic.Tekla.Structures.Model.Load
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

		public Dynamic.Tekla.Structures.Geometry3d.Point Position3
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position3);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position3", ex); }
			}
			set
			{
				try {
				teklaObject.Position3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position3", ex); }
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

		public Dynamic.Tekla.Structures.Geometry3d.Vector P3
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.P3);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P3", ex); }
			}
			set
			{
				try {
				teklaObject.P3 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P3", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P4
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.P4);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P4", ex); }
			}
			set
			{
				try {
				teklaObject.P4 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("P4", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum LoadForm
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum_.FromTSObject(teklaObject.LoadForm);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadForm", ex); }
			}
			set
			{
				try {
				teklaObject.LoadForm = Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum_.GetTSObject(value);
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

        

        

		public LoadArea()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadArea");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LoadArea(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum AreaLoadFormEnum
    {
			LOAD_FORM_AREA_PARALLELOGRAM,
			LOAD_FORM_AREA_TRIANGLE        
    }

    internal static class AreaLoadFormEnum_
    {
        public static dynamic GetTSObject(AreaLoadFormEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoadArea.AreaLoadFormEnum").GetType();

            switch (dynEnum)
            {
				case AreaLoadFormEnum.LOAD_FORM_AREA_PARALLELOGRAM:
					return System.Enum.Parse(tsType, "LOAD_FORM_AREA_PARALLELOGRAM");
				case AreaLoadFormEnum.LOAD_FORM_AREA_TRIANGLE:
					return System.Enum.Parse(tsType, "LOAD_FORM_AREA_TRIANGLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AreaLoadFormEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_FORM_AREA_PARALLELOGRAM", System.StringComparison.InvariantCulture))
				return AreaLoadFormEnum.LOAD_FORM_AREA_PARALLELOGRAM;
			else if (tsEnumValue.Equals("LOAD_FORM_AREA_TRIANGLE", System.StringComparison.InvariantCulture))
				return AreaLoadFormEnum.LOAD_FORM_AREA_TRIANGLE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoadArea_
    {
        public static dynamic GetTSObject(LoadArea dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoadArea FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LoadArea)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadAreaArray_
    {
        public static dynamic GetTSObject(LoadArea[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadArea_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadArea[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoadArea>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadArea_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
