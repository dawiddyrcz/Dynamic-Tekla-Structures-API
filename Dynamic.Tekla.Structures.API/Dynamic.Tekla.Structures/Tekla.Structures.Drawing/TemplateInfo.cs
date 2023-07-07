/*Copyright (C) Yury Isachenkov 2023
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class TemplateInfo  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {


        public System.String Name
        {
            get
            {
                try
                {
                return teklaObject.Name;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Name = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
        }

        public static Dynamic.Tekla.Structures.Drawing.TemplateInfo Default
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.TemplateInfo", "Default");
                var value_ = Dynamic.Tekla.Structures.Drawing.TemplateInfo_.FromTSObject(value);
	return (Dynamic.Tekla.Structures.Drawing.TemplateInfo) value_;
            }
            set
            {
                var value_ = Dynamic.Tekla.Structures.Drawing.TemplateInfo_.GetTSObject(value);
                PropertyInvoker.SetStaticPropertyOrFieldValue("Tekla.Structures.Drawing.TemplateInfo", "Default", value_);
            }
        }        

        

		public TemplateInfo()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TemplateInfo");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TemplateInfo(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TemplateInfo(System.String TemplateFile)
		{
			var args = new object[1];
			args[0] = TemplateFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.TemplateInfo", args);
		}





    }

    internal static class TemplateInfo_
    {
        public static dynamic GetTSObject(TemplateInfo dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TemplateInfo FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.TemplateInfo)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TemplateInfoArray_
    {
        public static dynamic GetTSObject(TemplateInfo[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TemplateInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TemplateInfo[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TemplateInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TemplateInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
