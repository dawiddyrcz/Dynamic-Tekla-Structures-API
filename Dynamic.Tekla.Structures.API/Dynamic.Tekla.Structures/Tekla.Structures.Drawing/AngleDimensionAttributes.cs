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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.AngleTypes_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Drawing.AngleTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
		}

		public System.Int32 TriangleBase
		{
			get
			{
				try {
					return teklaObject.TriangleBase;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TriangleBase"); }
			}
			set
			{
				try {
					teklaObject.TriangleBase = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TriangleBase"); }
			}
		}

        

        

		public AngleDimensionAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimensionAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public AngleDimensionAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public AngleDimensionAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleDimensionAttributes", args);
		}





    }

    internal static class AngleDimensionAttributes_
    {
        public static dynamic GetTSObject(AngleDimensionAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static AngleDimensionAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.AngleDimensionAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AngleDimensionAttributesArray_
    {
        public static dynamic GetTSObject(AngleDimensionAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AngleDimensionAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AngleDimensionAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<AngleDimensionAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AngleDimensionAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
