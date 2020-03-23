/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CurvedDimensionSetOrthogonal  : Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase
    {

		public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes_.GetTSObject(value); }
		}

        

        

		public CurvedDimensionSetOrthogonal() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public  class CurvedDimensionSetOrthogonalAttributes  : Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase.CurvedDimensionSetBaseAttributes
    {

        

        

		public CurvedDimensionSetOrthogonalAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes");
		}
		public CurvedDimensionSetOrthogonalAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes", args);
		}

		public System.Boolean LoadAttributes(System.String attributeFilename)
		{
			return teklaObject.LoadAttributes(attributeFilename);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class CurvedDimensionSetOrthogonalAttributes_
    {
        public static dynamic GetTSObject(CurvedDimensionSetOrthogonalAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetOrthogonalAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class CurvedDimensionSetOrthogonal_
    {
        public static dynamic GetTSObject(CurvedDimensionSetOrthogonal dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetOrthogonal FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    