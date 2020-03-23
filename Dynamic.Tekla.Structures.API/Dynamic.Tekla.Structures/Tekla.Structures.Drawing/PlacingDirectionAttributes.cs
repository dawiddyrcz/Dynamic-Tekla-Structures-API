/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PlacingDirectionAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean Positive
		{
			get => teklaObject.Positive;
			set { teklaObject.Positive = value; }
		}

		public System.Boolean Negative
		{
			get => teklaObject.Negative;
			set { teklaObject.Negative = value; }
		}

        

        

		public PlacingDirectionAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDirectionAttributes");
		}
		public PlacingDirectionAttributes(System.Boolean positive, System.Boolean negative)
		{
			var args = new object[2];
			args[0] = positive;
			args[1] = negative;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PlacingDirectionAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PlacingDirectionAttributes_
    {
        public static dynamic GetTSObject(PlacingDirectionAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlacingDirectionAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.PlacingDirectionAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlacingDirectionAttributesArray_
    {
        public static dynamic GetTSObject(PlacingDirectionAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlacingDirectionAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlacingDirectionAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PlacingDirectionAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlacingDirectionAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
