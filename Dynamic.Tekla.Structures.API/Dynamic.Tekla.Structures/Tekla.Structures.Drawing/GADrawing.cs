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

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}





    }

    internal static class GADrawing_
    {
        public static dynamic GetTSObject(GADrawing dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GADrawing FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.GADrawing)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
