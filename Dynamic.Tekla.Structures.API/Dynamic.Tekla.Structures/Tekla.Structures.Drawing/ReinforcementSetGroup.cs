/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReinforcementSetGroup  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
		}

		public System.Double ReinforcementCustomPosition
		{
			get
			{
				try {
					return teklaObject.ReinforcementCustomPosition;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ReinforcementCustomPosition"); }
			}
			set
			{
				try {
					teklaObject.ReinforcementCustomPosition = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ReinforcementCustomPosition"); }
			}
		}

        

        

		internal ReinforcementSetGroup() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementSetGroup(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> GetModelIdentifiers()
		{
			try {
			var result = teklaObject.GetModelIdentifiers();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetModelIdentifiers()"); }
		}





    }

    internal static class ReinforcementSetGroup_
    {
        public static dynamic GetTSObject(ReinforcementSetGroup dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReinforcementSetGroup FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementSetGroup)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementSetGroupArray_
    {
        public static dynamic GetTSObject(ReinforcementSetGroup[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementSetGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementSetGroup[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReinforcementSetGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementSetGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
