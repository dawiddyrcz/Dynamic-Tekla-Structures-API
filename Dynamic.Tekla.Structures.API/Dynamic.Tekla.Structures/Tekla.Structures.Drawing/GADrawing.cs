/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class GADrawing  : Dynamic.Tekla.Structures.Drawing.Drawing
    {

        

        

		public GADrawing()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.GADrawing");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GADrawing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public GADrawing(System.String Name, System.String AttributeFile)
		{
			var args = new object[2];
			args[0] = Name;
			args[1] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.GADrawing", args);
		}
		public GADrawing(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.GADrawing", args);
		}
		public GADrawing(System.String AttributeFile, Dynamic.Tekla.Structures.Drawing.Size SheetSize)
		{
			var args = new object[2];
			args[0] = AttributeFile;
			args[1] = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(SheetSize);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.GADrawing", args);
		}





    }

    internal static class GADrawing_
    {
        public static dynamic GetTSObject(GADrawing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GADrawing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.GADrawing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GADrawingArray_
    {
        public static dynamic GetTSObject(GADrawing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GADrawing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GADrawing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GADrawing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GADrawing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
