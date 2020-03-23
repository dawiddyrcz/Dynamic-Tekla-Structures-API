/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Mark  : Dynamic.Tekla.Structures.Drawing.MarkBase
    {

		public Dynamic.Tekla.Structures.Drawing.Mark.MarkAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Mark.MarkAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Mark.MarkAttributes_.GetTSObject(value); }
		}

        

        

		public Mark() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Mark(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Mark(Dynamic.Tekla.Structures.Drawing.ModelObject modelObject)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Mark", args);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public  class MarkAttributes  : Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.ContainerElement Content
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.Content);
			set { teklaObject.Content = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

        

        

		public MarkAttributes() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MarkAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public MarkAttributes(Dynamic.Tekla.Structures.Drawing.ModelObject modelObject)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Mark.MarkAttributes", args);
		}
		public MarkAttributes(Dynamic.Tekla.Structures.Drawing.ModelObject modelObject, System.String AttributesFile)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			args[1] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Mark.MarkAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean LoadAttributes(System.String attributeFilename)
		{
			return teklaObject.LoadAttributes(attributeFilename);
		}





    }

    internal static class MarkAttributes_
    {
        public static dynamic GetTSObject(MarkAttributes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static MarkAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Mark.MarkAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MarkAttributesArray_
    {
        public static dynamic GetTSObject(MarkAttributes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MarkAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MarkAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<MarkAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MarkAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Mark_
    {
        public static dynamic GetTSObject(Mark dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Mark FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Mark)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MarkArray_
    {
        public static dynamic GetTSObject(Mark[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Mark_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Mark[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Mark>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Mark_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
