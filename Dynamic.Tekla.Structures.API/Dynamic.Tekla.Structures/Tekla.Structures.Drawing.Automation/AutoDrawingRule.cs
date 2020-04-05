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
			get
			{
				try {
					return teklaObject.Filename;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Filename"); }
			}
			set
			{
				try {
					teklaObject.Filename = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Filename"); }
			}
		}

        

        internal dynamic teklaObject;

		internal AutoDrawingRule() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public AutoDrawingRule(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static AutoDrawingRule FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AutoDrawingRuleArray_
    {
        public static dynamic GetTSObject(AutoDrawingRule[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AutoDrawingRule_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AutoDrawingRule[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<AutoDrawingRule>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AutoDrawingRule_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
