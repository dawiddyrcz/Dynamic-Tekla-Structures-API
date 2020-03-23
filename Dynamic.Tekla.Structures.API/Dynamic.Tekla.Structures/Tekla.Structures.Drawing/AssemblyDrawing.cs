/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class AssemblyDrawing  : Dynamic.Tekla.Structures.Drawing.Drawing
    {

		public Dynamic.Tekla.Structures.Identifier AssemblyIdentifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.AssemblyIdentifier);

		}

		public System.Int32 SheetNumber
		{
			get => teklaObject.SheetNumber;

		}

        

        

		public AssemblyDrawing() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public AssemblyDrawing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public AssemblyDrawing(Dynamic.Tekla.Structures.Identifier assemblyIdentifier)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(assemblyIdentifier);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AssemblyDrawing", args);
		}
		public AssemblyDrawing(Dynamic.Tekla.Structures.Identifier assemblyIdentifier, System.String AttributeFile)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(assemblyIdentifier);
			args[1] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AssemblyDrawing", args);
		}
		public AssemblyDrawing(Dynamic.Tekla.Structures.Identifier assemblyIdentifier, System.Int32 sheetNumber)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(assemblyIdentifier);
			args[1] = sheetNumber;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AssemblyDrawing", args);
		}
		public AssemblyDrawing(Dynamic.Tekla.Structures.Identifier assemblyIdentifier, System.Int32 sheetNumber, System.String AttributeFile)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(assemblyIdentifier);
			args[1] = sheetNumber;
			args[2] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AssemblyDrawing", args);
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





    }

    internal static class AssemblyDrawing_
    {
        public static dynamic GetTSObject(AssemblyDrawing dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static AssemblyDrawing FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.AssemblyDrawing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AssemblyDrawingArray_
    {
        public static dynamic GetTSObject(AssemblyDrawing[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AssemblyDrawing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AssemblyDrawing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<AssemblyDrawing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AssemblyDrawing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
