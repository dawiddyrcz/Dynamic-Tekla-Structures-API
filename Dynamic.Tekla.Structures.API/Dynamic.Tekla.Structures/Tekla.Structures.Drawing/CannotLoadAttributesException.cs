/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotLoadAttributesException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

		public System.String AttributeFile
		{
			get
			{
				try {
					return teklaObject.AttributeFile;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AttributeFile"); }
			}

		}

        

        

		internal CannotLoadAttributesException() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CannotLoadAttributesException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CannotLoadAttributesException(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotLoadAttributesException", args);
		}





    }

    internal static class CannotLoadAttributesException_
    {
        public static dynamic GetTSObject(CannotLoadAttributesException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CannotLoadAttributesException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CannotLoadAttributesException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CannotLoadAttributesExceptionArray_
    {
        public static dynamic GetTSObject(CannotLoadAttributesException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CannotLoadAttributesException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CannotLoadAttributesException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CannotLoadAttributesException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CannotLoadAttributesException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
