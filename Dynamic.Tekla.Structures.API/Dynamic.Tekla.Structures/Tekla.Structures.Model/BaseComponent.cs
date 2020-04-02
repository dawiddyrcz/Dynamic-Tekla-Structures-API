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
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Int32 Number
		{
			get => teklaObject.Number;
			set { teklaObject.Number = value; }
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
			teklaObject.SetAttribute(AttrName, StrValue);
		}

		public void SetAttribute(System.String AttrName, System.Int32 Value)
		{
			teklaObject.SetAttribute(AttrName, Value);
		}

		public void SetAttribute(System.String AttrName, System.Double DValue)
		{
			teklaObject.SetAttribute(AttrName, DValue);
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.String StrValue)
		{
			return teklaObject.GetAttribute(AttrName, ref StrValue);
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.Int32 Value)
		{
			return teklaObject.GetAttribute(AttrName, ref Value);
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.Double DValue)
		{
			return teklaObject.GetAttribute(AttrName, ref DValue);
		}

		public System.Boolean LoadAttributesFromFile(System.String Filename)
		{
			return teklaObject.LoadAttributesFromFile(Filename);
		}





    }

    internal static class BaseComponent_
    {
        public static dynamic GetTSObject(BaseComponent dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static BaseComponent FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BaseComponent_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BaseComponent[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<BaseComponent>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BaseComponent_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
