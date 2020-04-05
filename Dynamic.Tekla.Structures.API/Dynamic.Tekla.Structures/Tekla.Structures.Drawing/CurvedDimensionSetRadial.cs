/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CurvedDimensionSetRadial  : Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase
    {

		public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes_.GetTSObject(value); }
		}

        

        

		internal CurvedDimensionSetRadial() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CurvedDimensionSetRadial(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public  class CurvedDimensionSetRadialAttributes  : Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetBase.CurvedDimensionSetBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CurvedDimensionTypes CurvedDimensionType
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CurvedDimensionTypes_.FromTSObject(teklaObject.CurvedDimensionType);
			set { teklaObject.CurvedDimensionType = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CurvedDimensionTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes DimensionType
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.FromTSObject(teklaObject.DimensionType);
			set { teklaObject.DimensionType = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.GetTSObject(value); }
		}

        

        

		public CurvedDimensionSetRadialAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CurvedDimensionSetRadialAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CurvedDimensionSetRadialAttributes(System.Boolean SkipLoadingAttributes)
		{
			var args = new object[1];
			args[0] = SkipLoadingAttributes;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes", args);
		}
		public CurvedDimensionSetRadialAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes", args);
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

    internal static class CurvedDimensionSetRadialAttributes_
    {
        public static dynamic GetTSObject(CurvedDimensionSetRadialAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetRadialAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionSetRadialAttributesArray_
    {
        public static dynamic GetTSObject(CurvedDimensionSetRadialAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetRadialAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetRadialAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedDimensionSetRadialAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionSetRadialAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class CurvedDimensionSetRadial_
    {
        public static dynamic GetTSObject(CurvedDimensionSetRadial dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetRadial FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionSetRadialArray_
    {
        public static dynamic GetTSObject(CurvedDimensionSetRadial[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetRadial_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetRadial[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedDimensionSetRadial>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionSetRadial_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
