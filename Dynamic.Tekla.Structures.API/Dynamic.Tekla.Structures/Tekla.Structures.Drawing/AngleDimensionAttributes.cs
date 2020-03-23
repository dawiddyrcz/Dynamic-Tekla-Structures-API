/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class AngleDimensionAttributes  : Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.AngleTypes Type
		{
			get => Dynamic.Tekla.Structures.Drawing.AngleTypes_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Drawing.AngleTypes_.GetTSObject(value); }
		}

		public System.Int32 TriangleBase
		{
			get => teklaObject.TriangleBase;
			set { teklaObject.TriangleBase = value; }
		}

        

        

		public AngleDimensionAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimensionAttributes");
		}
		public AngleDimensionAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimensionAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}





    }

    internal static class AngleDimensionAttributes_
    {
        public static dynamic GetTSObject(AngleDimensionAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static AngleDimensionAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AngleDimensionAttributesArray_
    {
        public static dynamic GetTSObject(AngleDimensionAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AngleDimensionAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AngleDimensionAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<AngleDimensionAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AngleDimensionAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
