/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.Automation
{

    public  class AutoDrawingRule 
    {

		public System.String Filename
		{
			get => teklaObject.Filename;
			set { teklaObject.Filename = value; }
		}

        

        internal dynamic teklaObject;

		public AutoDrawingRule() {}
		public AutoDrawingRule(System.String RuleFromFile)
		{
			var args = new object[1];
			args[0] = RuleFromFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Automation.AutoDrawingRule", args);
		}





    }

    internal static class AutoDrawingRule_
    {
        public static dynamic GetTSObject(AutoDrawingRule dynObject)
        {
            return dynObject.teklaObject;
        }

        public static AutoDrawingRule FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Automation.AutoDrawingRule)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
