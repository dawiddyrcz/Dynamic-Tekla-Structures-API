/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReportTemplateElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public Dynamic.Tekla.Structures.Drawing.TemplateInfo Template
		{
			get => Dynamic.Tekla.Structures.Drawing.TemplateInfo_.FromTSObject(teklaObject.Template);
			set { teklaObject.Template = Dynamic.Tekla.Structures.Drawing.TemplateInfo_.GetTSObject(value); }
		}

        

        

		public ReportTemplateElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReportTemplateElement");
		}
		public ReportTemplateElement(Dynamic.Tekla.Structures.Drawing.TemplateInfo Template)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.TemplateInfo_.GetTSObject(Template);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ReportTemplateElement", args);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.String GetUnformattedString()
		{
			return teklaObject.GetUnformattedString();
		}





    }

    internal static class ReportTemplateElement_
    {
        public static dynamic GetTSObject(ReportTemplateElement dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReportTemplateElement FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReportTemplateElement)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
