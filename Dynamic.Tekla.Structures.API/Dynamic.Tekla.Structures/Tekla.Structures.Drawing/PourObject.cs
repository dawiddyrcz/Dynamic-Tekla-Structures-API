/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PourObject  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.PourObject.PourAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.PourObject.PourAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.PourObject.PourAttributes_.GetTSObject(value); }
		}

        

        

		internal PourObject() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PourObject(dynamic tsObject, System.DateTime nonConflictParameter)
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




    public  class PourAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

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

		public System.Boolean DrawChamfers
		{
			get => teklaObject.DrawChamfers;
			set { teklaObject.DrawChamfers = value; }
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

		public Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes FaceHatch
		{
			get => Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.FromTSObject(teklaObject.FaceHatch);
			set { teklaObject.FaceHatch = Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes SectionFaceHatch
		{
			get => Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.FromTSObject(teklaObject.SectionFaceHatch);
			set { teklaObject.SectionFaceHatch = Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.GetTSObject(value); }
		}

        

        

		public PourAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PourObject.PourAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PourAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PourAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PourObject.PourAttributes", args);
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

    internal static class PourAttributes_
    {
        public static dynamic GetTSObject(PourAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PourObject.PourAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourAttributesArray_
    {
        public static dynamic GetTSObject(PourAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class PourObject_
    {
        public static dynamic GetTSObject(PourObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PourObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourObjectArray_
    {
        public static dynamic GetTSObject(PourObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
