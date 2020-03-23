/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class TemplateInfo  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

        

        

		public TemplateInfo()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TemplateInfo");
		}
		public TemplateInfo(System.String TemplateFile)
		{
			var args = new object[1];
			args[0] = TemplateFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TemplateInfo", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class TemplateInfo_
    {
        public static dynamic GetTSObject(TemplateInfo dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TemplateInfo FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.TemplateInfo)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    