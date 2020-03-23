/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ArrowheadAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.ArrowheadPositions ArrowPosition
		{
			get => Dynamic.Tekla.Structures.Drawing.ArrowheadPositions_.FromTSObject(teklaObject.ArrowPosition);
			set { teklaObject.ArrowPosition = Dynamic.Tekla.Structures.Drawing.ArrowheadPositions_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ArrowheadTypes Head
		{
			get => Dynamic.Tekla.Structures.Drawing.ArrowheadTypes_.FromTSObject(teklaObject.Head);
			set { teklaObject.Head = Dynamic.Tekla.Structures.Drawing.ArrowheadTypes_.GetTSObject(value); }
		}

		public System.Double Height
		{
			get => teklaObject.Height;
			set { teklaObject.Height = value; }
		}

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

        

        

		public ArrowheadAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ArrowheadAttributes");
		}
		public ArrowheadAttributes(Dynamic.Tekla.Structures.Drawing.ArrowheadPositions arrowPosition, Dynamic.Tekla.Structures.Drawing.ArrowheadTypes head, System.Double height, System.Double width)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ArrowheadPositions_.GetTSObject(arrowPosition);
			args[1] = Dynamic.Tekla.Structures.Drawing.ArrowheadTypes_.GetTSObject(head);
			args[2] = height;
			args[3] = width;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ArrowheadAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ArrowheadAttributes_
    {
        public static dynamic GetTSObject(ArrowheadAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ArrowheadAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    