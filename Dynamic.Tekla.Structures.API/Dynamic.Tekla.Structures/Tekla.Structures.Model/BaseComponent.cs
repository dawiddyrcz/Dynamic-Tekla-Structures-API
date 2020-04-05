/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BaseComponent  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public System.Int32 Number
		{
			get
			{
				try {
					return teklaObject.Number;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Number"); }
			}
			set
			{
				try {
					teklaObject.Number = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Number"); }
			}
		}

		public static System.Int32 CUSTOM_OBJECT_NUMBER
		{
			get => (System.Int32) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent","CUSTOM_OBJECT_NUMBER");

		}

		public static System.Int32 PLUGIN_OBJECT_NUMBER
		{
			get => (System.Int32) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent","PLUGIN_OBJECT_NUMBER");

		}

		public static System.String ConnectionCodeFromAttributeFile
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent","ConnectionCodeFromAttributeFile");

		}

		public static System.Int32 ClassFromAttributeFile
		{
			get => (System.Int32) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent","ClassFromAttributeFile");

		}

        

        


		public void SetAttribute(System.String AttrName, System.String StrValue)
		{
			try {
			teklaObject.SetAttribute(AttrName, StrValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAttribute()"); }
		}

		public void SetAttribute(System.String AttrName, System.Int32 Value)
		{
			try {
			teklaObject.SetAttribute(AttrName, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAttribute()"); }
		}

		public void SetAttribute(System.String AttrName, System.Double DValue)
		{
			try {
			teklaObject.SetAttribute(AttrName, DValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAttribute()"); }
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.String StrValue)
		{
			try {
			return teklaObject.GetAttribute(AttrName, ref StrValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAttribute()"); }
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.Int32 Value)
		{
			try {
			return teklaObject.GetAttribute(AttrName, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAttribute()"); }
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.Double DValue)
		{
			try {
			return teklaObject.GetAttribute(AttrName, ref DValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAttribute()"); }
		}

		public System.Boolean LoadAttributesFromFile(System.String Filename)
		{
			try {
			return teklaObject.LoadAttributesFromFile(Filename);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LoadAttributesFromFile()"); }
		}





    }

    internal static class BaseComponent_
    {
        public static dynamic GetTSObject(BaseComponent dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BaseComponent FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BaseComponent)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BaseComponentArray_
    {
        public static dynamic GetTSObject(BaseComponent[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BaseComponent_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BaseComponent[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BaseComponent>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BaseComponent_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
