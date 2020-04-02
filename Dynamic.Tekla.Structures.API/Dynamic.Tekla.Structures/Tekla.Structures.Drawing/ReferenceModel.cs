/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReferenceModel  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.ReferenceModel.ReferenceModelAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.ReferenceModel.ReferenceModelAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.ReferenceModel.ReferenceModelAttributes_.GetTSObject(value); }
		}

        

        

		internal ReferenceModel() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReferenceModel(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}




    public  class ReferenceModelAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
			set { teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypes LineType
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(teklaObject.LineType);
			set { teklaObject.LineType = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

        

        

		public ReferenceModelAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReferenceModel.ReferenceModelAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReferenceModelAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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

    internal static class ReferenceModelAttributes_
    {
        public static dynamic GetTSObject(ReferenceModelAttributes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModelAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReferenceModel.ReferenceModelAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelAttributesArray_
    {
        public static dynamic GetTSObject(ReferenceModelAttributes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModelAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModelAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ReferenceModelAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModelAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class ReferenceModel_
    {
        public static dynamic GetTSObject(ReferenceModel dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModel FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReferenceModel)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelArray_
    {
        public static dynamic GetTSObject(ReferenceModel[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModel_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModel[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ReferenceModel>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModel_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
