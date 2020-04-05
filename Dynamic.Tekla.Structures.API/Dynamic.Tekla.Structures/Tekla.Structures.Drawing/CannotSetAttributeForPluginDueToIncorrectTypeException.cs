/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotSetAttributeForPluginDueToIncorrectTypeException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		internal CannotSetAttributeForPluginDueToIncorrectTypeException() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CannotSetAttributeForPluginDueToIncorrectTypeException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CannotSetAttributeForPluginDueToIncorrectTypeException(System.Type ExpectedType, System.Type GivenType)
		{
			var args = new object[2];
			args[0] = ExpectedType;
			args[1] = GivenType;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotSetAttributeForPluginDueToIncorrectTypeException", args);
		}





    }

    internal static class CannotSetAttributeForPluginDueToIncorrectTypeException_
    {
        public static dynamic GetTSObject(CannotSetAttributeForPluginDueToIncorrectTypeException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CannotSetAttributeForPluginDueToIncorrectTypeException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CannotSetAttributeForPluginDueToIncorrectTypeException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CannotSetAttributeForPluginDueToIncorrectTypeExceptionArray_
    {
        public static dynamic GetTSObject(CannotSetAttributeForPluginDueToIncorrectTypeException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CannotSetAttributeForPluginDueToIncorrectTypeException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CannotSetAttributeForPluginDueToIncorrectTypeException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CannotSetAttributeForPluginDueToIncorrectTypeException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CannotSetAttributeForPluginDueToIncorrectTypeException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
