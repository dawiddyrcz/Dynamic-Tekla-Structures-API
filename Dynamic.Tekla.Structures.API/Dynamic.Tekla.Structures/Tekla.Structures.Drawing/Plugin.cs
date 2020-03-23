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

        

        

		public Plugin() {}
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

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public void SetPickerInput(Dynamic.Tekla.Structures.Drawing.PluginPickerInput Input)
		{
			teklaObject.SetPickerInput(Dynamic.Tekla.Structures.Drawing.PluginPickerInput_.GetTSObject(Input));
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean ApplyStandardValues(System.String Filename)
		{
			return teklaObject.ApplyStandardValues(Filename);
		}

		public System.Boolean LoadStandardValues(System.String Filename)
		{
			return teklaObject.LoadStandardValues(Filename);
		}

		public System.Boolean TrySetAttribute(System.String FieldName, System.Int32 fieldValue)
		{
			return teklaObject.TrySetAttribute(FieldName, fieldValue);
		}

		public System.Boolean TrySetAttribute(System.String FieldName, System.String fieldValue)
		{
			return teklaObject.TrySetAttribute(FieldName, fieldValue);
		}

		public System.Boolean TrySetAttribute(System.String FieldName, System.Double fieldValue)
		{
			return teklaObject.TrySetAttribute(FieldName, fieldValue);
		}

		public void SetAttribute(System.String FieldName, System.Int32 fieldValue)
		{
			teklaObject.SetAttribute(FieldName, fieldValue);
		}

		public void SetAttribute(System.String FieldName, System.Double fieldValue)
		{
			teklaObject.SetAttribute(FieldName, fieldValue);
		}

		public void SetAttribute(System.String FieldName, System.String fieldValue)
		{
			teklaObject.SetAttribute(FieldName, fieldValue);
		}

		public System.Boolean TryGetAttribute(System.String FieldName, ref System.Int32 FieldValue)
		{
			return teklaObject.TryGetAttribute(FieldName, ref FieldValue);
		}

		public System.Int32 GetIntAttribute(System.String FieldName)
		{
			return teklaObject.GetIntAttribute(FieldName);
		}

		public System.Boolean TryGetAttribute(System.String FieldName, ref System.Double FieldValue)
		{
			return teklaObject.TryGetAttribute(FieldName, ref FieldValue);
		}

		public System.Double GetDoubleAttribute(System.String FieldName)
		{
			return teklaObject.GetDoubleAttribute(FieldName);
		}

		public System.Boolean TryGetAttribute(System.String FieldName, ref System.String FieldValue)
		{
			return teklaObject.TryGetAttribute(FieldName, ref FieldValue);
		}

		public System.String GetStringAttribute(System.String FieldName)
		{
			return teklaObject.GetStringAttribute(FieldName);
		}





    }

    internal static class Plugin_
    {
        public static dynamic GetTSObject(Plugin dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Plugin FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Plugin_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Plugin[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Plugin>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Plugin_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
