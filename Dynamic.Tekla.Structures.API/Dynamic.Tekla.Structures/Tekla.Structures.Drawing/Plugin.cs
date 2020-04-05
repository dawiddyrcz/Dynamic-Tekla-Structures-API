/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Plugin  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

        

        

		internal Plugin() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Plugin(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Plugin(Dynamic.Tekla.Structures.Drawing.ViewBase View, System.String Name)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Name;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Plugin", args);
		}

		public void SetPickerInput(Dynamic.Tekla.Structures.Drawing.PluginPickerInput Input)
		{
			try {
			teklaObject.SetPickerInput(Dynamic.Tekla.Structures.Drawing.PluginPickerInput_.GetTSObject(Input));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetPickerInput()"); }
		}

		public System.Boolean ApplyStandardValues(System.String Filename)
		{
			try {
			return teklaObject.ApplyStandardValues(Filename);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ApplyStandardValues()"); }
		}

		public System.Boolean LoadStandardValues(System.String Filename)
		{
			try {
			return teklaObject.LoadStandardValues(Filename);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LoadStandardValues()"); }
		}

		public System.Boolean TrySetAttribute(System.String FieldName, System.Int32 fieldValue)
		{
			try {
			return teklaObject.TrySetAttribute(FieldName, fieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("TrySetAttribute()"); }
		}

		public System.Boolean TrySetAttribute(System.String FieldName, System.String fieldValue)
		{
			try {
			return teklaObject.TrySetAttribute(FieldName, fieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("TrySetAttribute()"); }
		}

		public System.Boolean TrySetAttribute(System.String FieldName, System.Double fieldValue)
		{
			try {
			return teklaObject.TrySetAttribute(FieldName, fieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("TrySetAttribute()"); }
		}

		public void SetAttribute(System.String FieldName, System.Int32 fieldValue)
		{
			try {
			teklaObject.SetAttribute(FieldName, fieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAttribute()"); }
		}

		public void SetAttribute(System.String FieldName, System.Double fieldValue)
		{
			try {
			teklaObject.SetAttribute(FieldName, fieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAttribute()"); }
		}

		public void SetAttribute(System.String FieldName, System.String fieldValue)
		{
			try {
			teklaObject.SetAttribute(FieldName, fieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAttribute()"); }
		}

		public System.Boolean TryGetAttribute(System.String FieldName, ref System.Int32 FieldValue)
		{
			try {
			return teklaObject.TryGetAttribute(FieldName, ref FieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("TryGetAttribute()"); }
		}

		public System.Int32 GetIntAttribute(System.String FieldName)
		{
			try {
			return teklaObject.GetIntAttribute(FieldName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIntAttribute()"); }
		}

		public System.Boolean TryGetAttribute(System.String FieldName, ref System.Double FieldValue)
		{
			try {
			return teklaObject.TryGetAttribute(FieldName, ref FieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("TryGetAttribute()"); }
		}

		public System.Double GetDoubleAttribute(System.String FieldName)
		{
			try {
			return teklaObject.GetDoubleAttribute(FieldName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDoubleAttribute()"); }
		}

		public System.Boolean TryGetAttribute(System.String FieldName, ref System.String FieldValue)
		{
			try {
			return teklaObject.TryGetAttribute(FieldName, ref FieldValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("TryGetAttribute()"); }
		}

		public System.String GetStringAttribute(System.String FieldName)
		{
			try {
			return teklaObject.GetStringAttribute(FieldName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetStringAttribute()"); }
		}





    }

    internal static class Plugin_
    {
        public static dynamic GetTSObject(Plugin dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Plugin FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Plugin)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PluginArray_
    {
        public static dynamic GetTSObject(Plugin[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Plugin_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Plugin[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Plugin>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Plugin_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
