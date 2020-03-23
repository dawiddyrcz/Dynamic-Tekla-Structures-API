/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class SinglePartDrawing  : Dynamic.Tekla.Structures.Drawing.Drawing
    {

		public Dynamic.Tekla.Structures.Identifier PartIdentifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.PartIdentifier);
			set { teklaObject.PartIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

		public System.Int32 SheetNumber
		{
			get => teklaObject.SheetNumber;
			set { teklaObject.SheetNumber = value; }
		}

        

        

		public SinglePartDrawing() {}
		public SinglePartDrawing(Dynamic.Tekla.Structures.Identifier partIdentifier)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(partIdentifier);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SinglePartDrawing", args);
		}
		public SinglePartDrawing(Dynamic.Tekla.Structures.Identifier partIdentifier, System.String AttributeFile)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(partIdentifier);
			args[1] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SinglePartDrawing", args);
		}
		public SinglePartDrawing(Dynamic.Tekla.Structures.Identifier partIdentifier, System.Int32 sheetNumber)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(partIdentifier);
			args[1] = sheetNumber;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SinglePartDrawing", args);
		}
		public SinglePartDrawing(Dynamic.Tekla.Structures.Identifier partIdentifier, System.Int32 sheetNumber, System.String AttributeFile)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(partIdentifier);
			args[1] = sheetNumber;
			args[2] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SinglePartDrawing", args);
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

    internal static class SinglePartDrawing_
    {
        public static dynamic GetTSObject(SinglePartDrawing dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SinglePartDrawing FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.SinglePartDrawing)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    