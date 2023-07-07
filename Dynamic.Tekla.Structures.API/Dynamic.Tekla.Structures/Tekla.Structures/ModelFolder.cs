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

namespace Dynamic.Tekla.Structures
{

    public  class ModelFolder  : Dynamic.Tekla.Structures.VirtualFolder
    {


        public Dynamic.Tekla.Structures.VirtualFolder AttributesFolder
        {
            get
            {
                try
                {
                var value = teklaObject.AttributesFolder;
                var value_ = Dynamic.Tekla.Structures.VirtualFolder_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.VirtualFolder) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AttributesFolder), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.VirtualFolder DrawingsFolder
        {
            get
            {
                try
                {
                var value = teklaObject.DrawingsFolder;
                var value_ = Dynamic.Tekla.Structures.VirtualFolder_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.VirtualFolder) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawingsFolder), ex); 
                }
            }
            
        }

        public static System.String AssemblyFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "AssemblyFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String AttributesFolderName
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "AttributesFolderName");
                return (System.String) value;
            }
            
        }
        public static System.String CastUnitFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "CastUnitFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String DatabaseFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "DatabaseFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String DrawingsFolderName
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "DrawingsFolderName");
                return (System.String) value;
            }
            
        }
        public static System.String ExtendedRulesetFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "ExtendedRulesetFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String GeneralArrangementFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "GeneralArrangementFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String ObjectDefinitionFile
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "ObjectDefinitionFile");
                return (System.String) value;
            }
            
        }
        public static System.String ObjectSettingsFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "ObjectSettingsFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String RulesetFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "RulesetFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String SelectFilterFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "SelectFilterFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String SinglePartFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "SinglePartFileExtension");
                return (System.String) value;
            }
            
        }
        public static System.String ViewFilterFileExtension
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModelFolder", "ViewFilterFileExtension");
                return (System.String) value;
            }
            
        }        

        

		internal ModelFolder() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelFolder(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ModelFolder(System.String folderPath, System.String searchPath)
		{
			var args = new object[2];
			args[0] = folderPath;
			args[1] = searchPath;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.ModelFolder", args);
		}


        public static System.Boolean ContainsModelDatabase(
			System.String modelFolder)
        {
            var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.ModelFolder", "ContainsModelDatabase", modelFolder);
            return result;
        }






    }

    internal static class ModelFolder_
    {
        public static dynamic GetTSObject(ModelFolder dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelFolder FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.ModelFolder)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelFolderArray_
    {
        public static dynamic GetTSObject(ModelFolder[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelFolder_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelFolder[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelFolder>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelFolder_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
