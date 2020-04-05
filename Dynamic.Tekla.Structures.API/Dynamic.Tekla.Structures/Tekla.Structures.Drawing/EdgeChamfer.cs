/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class EdgeChamfer  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.EdgeChamfer.EdgeChamferAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.EdgeChamfer.EdgeChamferAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.EdgeChamfer.EdgeChamferAttributes_.GetTSObject(value); }
		}

        

        

		internal EdgeChamfer() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public EdgeChamfer(dynamic tsObject, System.DateTime nonConflictParameter)
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




    public  class EdgeChamferAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes VisibleLines
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.VisibleLines);
			set { teklaObject.VisibleLines = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

        

        

		public EdgeChamferAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EdgeChamfer.EdgeChamferAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public EdgeChamferAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public EdgeChamferAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EdgeChamfer.EdgeChamferAttributes", args);
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

    internal static class EdgeChamferAttributes_
    {
        public static dynamic GetTSObject(EdgeChamferAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static EdgeChamferAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.EdgeChamfer.EdgeChamferAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EdgeChamferAttributesArray_
    {
        public static dynamic GetTSObject(EdgeChamferAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EdgeChamferAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EdgeChamferAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<EdgeChamferAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EdgeChamferAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
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

            var dynObject = (Dynamic.Tekla.Structures.Drawing.EdgeChamfer)System.Activator.CreateInstance(type, parameters);
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
    
