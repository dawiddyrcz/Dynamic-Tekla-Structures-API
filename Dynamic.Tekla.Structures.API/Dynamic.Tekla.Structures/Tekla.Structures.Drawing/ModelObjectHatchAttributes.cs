/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ModelObjectHatchAttributes  : Dynamic.Tekla.Structures.Drawing.HatchAttributes
    {

		public System.Boolean AutomaticScaling
		{
			get => teklaObject.AutomaticScaling;
			set { teklaObject.AutomaticScaling = value; }
		}

        

        

		public ModelObjectHatchAttributes() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ModelObjectHatchAttributes_
    {
        public static dynamic GetTSObject(ModelObjectHatchAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelObjectHatchAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelObjectHatchAttributesArray_
    {
        public static dynamic GetTSObject(ModelObjectHatchAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelObjectHatchAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelObjectHatchAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ModelObjectHatchAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelObjectHatchAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
