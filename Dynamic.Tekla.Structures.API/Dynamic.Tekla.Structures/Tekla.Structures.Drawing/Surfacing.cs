/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Surfacing  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.Surfacing.SurfacingAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Surfacing.SurfacingAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Surfacing.SurfacingAttributes_.GetTSObject(value); }
		}

        

        

		public Surfacing() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Surfacing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
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




    public enum Representation
    {
			Outline,
			Symbol,
			WorkshopForm,
			Exact,
			BoundingBox,
			BaseBox        
    }

    internal static class Representation_
    {
        public static dynamic GetTSObject(Representation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Surfacing.Representation").GetType();

            switch (dynEnum)
            {
				case Representation.Outline:
					return System.Enum.Parse(tsType, "Outline");
				case Representation.Symbol:
					return System.Enum.Parse(tsType, "Symbol");
				case Representation.WorkshopForm:
					return System.Enum.Parse(tsType, "WorkshopForm");
				case Representation.Exact:
					return System.Enum.Parse(tsType, "Exact");
				case Representation.BoundingBox:
					return System.Enum.Parse(tsType, "BoundingBox");
				case Representation.BaseBox:
					return System.Enum.Parse(tsType, "BaseBox");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Representation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Outline", System.StringComparison.InvariantCulture))
				return Representation.Outline;
			else if (tsEnumValue.Equals("Symbol", System.StringComparison.InvariantCulture))
				return Representation.Symbol;
			else if (tsEnumValue.Equals("WorkshopForm", System.StringComparison.InvariantCulture))
				return Representation.WorkshopForm;
			else if (tsEnumValue.Equals("Exact", System.StringComparison.InvariantCulture))
				return Representation.Exact;
			else if (tsEnumValue.Equals("BoundingBox", System.StringComparison.InvariantCulture))
				return Representation.BoundingBox;
			else if (tsEnumValue.Equals("BaseBox", System.StringComparison.InvariantCulture))
				return Representation.BaseBox;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class SurfacingAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.Surfacing.Representation Representation
		{
			get => Dynamic.Tekla.Structures.Drawing.Surfacing.Representation_.FromTSObject(teklaObject.Representation);
			set { teklaObject.Representation = Dynamic.Tekla.Structures.Drawing.Surfacing.Representation_.GetTSObject(value); }
		}

		public System.Boolean ShowPattern
		{
			get => teklaObject.ShowPattern;
			set { teklaObject.ShowPattern = value; }
		}

		public System.Boolean DrawHiddenLines
		{
			get => teklaObject.DrawHiddenLines;
			set { teklaObject.DrawHiddenLines = value; }
		}

		public System.Boolean DrawOwnHiddenLines
		{
			get => teklaObject.DrawOwnHiddenLines;
			set { teklaObject.DrawOwnHiddenLines = value; }
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

        

        

		public SurfacingAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Surfacing.SurfacingAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SurfacingAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SurfacingAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Surfacing.SurfacingAttributes", args);
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

    internal static class SurfacingAttributes_
    {
        public static dynamic GetTSObject(SurfacingAttributes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static SurfacingAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Surfacing.SurfacingAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfacingAttributesArray_
    {
        public static dynamic GetTSObject(SurfacingAttributes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SurfacingAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SurfacingAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<SurfacingAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SurfacingAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Surfacing_
    {
        public static dynamic GetTSObject(Surfacing dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Surfacing FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Surfacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfacingArray_
    {
        public static dynamic GetTSObject(Surfacing[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Surfacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Surfacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Surfacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Surfacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
