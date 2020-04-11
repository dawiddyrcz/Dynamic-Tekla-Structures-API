/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class TeklaStructuresSettings 
    {

        

        internal dynamic teklaObject;

		public TeklaStructuresSettings()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresSettings");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TeklaStructuresSettings(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public static System.Boolean GetAdvancedOption(
	System.String VariableName,
	ref System.Boolean Value
	)
{
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
	
	return result;
}



public static System.Boolean GetAdvancedOption(
	System.String VariableName,
	ref System.Int32 Value
	)
{
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
	
	return result;
}



public static System.Boolean GetAdvancedOption(
	System.String VariableName,
	ref System.String Value
	)
{
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
	
	return result;
}



public static System.Boolean GetAdvancedOption(
	System.String VariableName,
	ref System.Double Value
	)
{
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
	
	return result;
}



public static System.Boolean GetOptions(
	ref Dynamic.Tekla.Structures.ClashCheckOptions Options_
	)
{
	var Options = Dynamic.Tekla.Structures.ClashCheckOptions_.GetTSObject(Options_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetOptions", ref Options);
	Options_ = Dynamic.Tekla.Structures.ClashCheckOptions_.FromTSObject(Options);
	return result;
}



public static System.Boolean SetOptions(
	Dynamic.Tekla.Structures.ClashCheckOptions Options_
	)
{
	var Options = Dynamic.Tekla.Structures.ClashCheckOptions_.GetTSObject(Options_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "SetOptions", Options);
	return result;
}



public static System.Boolean GetOptions(
	ref Dynamic.Tekla.Structures.ComponentOptions Options_
	)
{
	var Options = Dynamic.Tekla.Structures.ComponentOptions_.GetTSObject(Options_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetOptions", ref Options);
	Options_ = Dynamic.Tekla.Structures.ComponentOptions_.FromTSObject(Options);
	return result;
}



public static System.Boolean SetOptions(
	Dynamic.Tekla.Structures.ComponentOptions Options_
	)
{
	var Options = Dynamic.Tekla.Structures.ComponentOptions_.GetTSObject(Options_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "SetOptions", Options);
	return result;
}



public static System.Boolean IsToolOptionOn(
	System.String toolOptionName
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "IsToolOptionOn", toolOptionName);
	return result;
}



public static System.Boolean IsPourEnabled()
{
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "IsPourEnabled");
	return result;
}





    public  class InvalidPathCallback 
    {

        

        internal dynamic teklaObject;

		internal InvalidPathCallback() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public InvalidPathCallback(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public InvalidPathCallback(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresSettings.InvalidPathCallback", args);
		}


public void Invoke(
	System.String advancedOption,
	System.String invalidString,
	System.String exceptionMessage
	)
{
	
	
	
    try
    {
        	teklaObject.Invoke(advancedOption, invalidString, exceptionMessage);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Invoke), ex);
    }
}



public void EndInvoke(
	System.IAsyncResult presult
	)
{
	
    try
    {
        	teklaObject.EndInvoke(presult);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(EndInvoke), ex);
    }
}






    }

    internal static class InvalidPathCallback_
    {
        public static dynamic GetTSObject(InvalidPathCallback dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static InvalidPathCallback FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresSettings.InvalidPathCallback)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InvalidPathCallbackArray_
    {
        public static dynamic GetTSObject(InvalidPathCallback[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InvalidPathCallback_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InvalidPathCallback[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<InvalidPathCallback>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InvalidPathCallback_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class ToolOptionNames 
    {

		public static System.String All
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","All");

		}

		public static System.String Joints
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Joints");

		}

		public static System.String Parts
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Parts");

		}

		public static System.String Surfaces
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Surfaces");

		}

		public static System.String Points
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Points");

		}

		public static System.String ConstructionLines
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","ConstructionLines");

		}

		public static System.String ReferenceModels
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","ReferenceModels");

		}

		public static System.String Grid
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Grid");

		}

		public static System.String GridLine
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","GridLine");

		}

		public static System.String Weldings
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Weldings");

		}

		public static System.String Cuts
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Cuts");

		}

		public static System.String Views
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Views");

		}

		public static System.String Screws
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Screws");

		}

		public static System.String SingleScrews
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","SingleScrews");

		}

		public static System.String Rebars
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Rebars");

		}

		public static System.String RebarGroup
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","RebarGroup");

		}

		public static System.String RebarSingle
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","RebarSingle");

		}

		public static System.String PourBreaks
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","PourBreaks");

		}

		public static System.String Planes
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Planes");

		}

		public static System.String Distances
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Distances");

		}

		public static System.String Loads
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","Loads");

		}

		public static System.String AnalysisParts
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","AnalysisParts");

		}

		public static System.String AnalysisNodes
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","AnalysisNodes");

		}

		public static System.String AnalysisNodeLinks
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","AnalysisNodeLinks");

		}

		public static System.String CustomObjects
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","CustomObjects");

		}

		public static System.String ObjectsInJoints
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","ObjectsInJoints");

		}

		public static System.String SelectAssemblies
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","SelectAssemblies");

		}

		public static System.String SelectObjectsInAssemblies
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","SelectObjectsInAssemblies");

		}

		public static System.String SelectTasks
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","SelectTasks");

		}

		public static System.String DisplaySelectionFilterDialog
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","DisplaySelectionFilterDialog");

		}

		public static System.String DirectManipulation
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresSettings.ToolOptionNames","DirectManipulation");

		}

        

        internal dynamic teklaObject;






    }

    internal static class ToolOptionNames_
    {
        public static dynamic GetTSObject(ToolOptionNames dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ToolOptionNames FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresSettings.ToolOptionNames)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ToolOptionNamesArray_
    {
        public static dynamic GetTSObject(ToolOptionNames[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ToolOptionNames_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ToolOptionNames[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ToolOptionNames>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ToolOptionNames_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class TeklaStructuresSettings_
    {
        public static dynamic GetTSObject(TeklaStructuresSettings dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TeklaStructuresSettings FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresSettings)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TeklaStructuresSettingsArray_
    {
        public static dynamic GetTSObject(TeklaStructuresSettings[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TeklaStructuresSettings_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TeklaStructuresSettings[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TeklaStructuresSettings>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TeklaStructuresSettings_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
