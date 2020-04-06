/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class HierarchicDefinition  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public System.String CustomType
		{
			get
			{
				try {
					return teklaObject.CustomType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CustomType", ex); }
			}
			set
			{
				try {
					teklaObject.CustomType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CustomType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.HierarchicDefinitionTypeEnum HierarchyType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.HierarchicDefinitionTypeEnum_.FromTSObject(teklaObject.HierarchyType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HierarchyType", ex); }
			}
			set
			{
				try {
				teklaObject.HierarchyType = Dynamic.Tekla.Structures.Model.HierarchicDefinitionTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HierarchyType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.HierarchicDefinition Father
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.HierarchicDefinition_.FromTSObject(teklaObject.Father);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father", ex); }
			}
			set
			{
				try {
				teklaObject.Father = Dynamic.Tekla.Structures.Model.HierarchicDefinition_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father", ex); }
			}
		}

		public System.String HierarchyIdentifier
		{
			get
			{
				try {
					return teklaObject.HierarchyIdentifier;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HierarchyIdentifier", ex); }
			}
			set
			{
				try {
					teklaObject.HierarchyIdentifier = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HierarchyIdentifier", ex); }
			}
		}

		public System.Boolean Drawable
		{
			get
			{
				try {
					return teklaObject.Drawable;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Drawable", ex); }
			}
			set
			{
				try {
					teklaObject.Drawable = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Drawable", ex); }
			}
		}

		public System.Collections.ArrayList HierarchicChildren
		{
			get
			{
				try {
					return TSActivator.ConvertArrayList(teklaObject.HierarchicChildren);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HierarchicChildren", ex); }
			}
			set
			{
				try {
					teklaObject.HierarchicChildren = TSActivator.ConvertToTSArrayList(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HierarchicChildren", ex); }
			}
		}

        

        

		public HierarchicDefinition()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinition");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public HierarchicDefinition(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public HierarchicDefinition(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinition", args);
		}

		public System.Boolean AddObjects(System.Collections.ArrayList Objects)
		{
			try {
			var result = teklaObject.AddObjects(TSActivator.ConvertToTSArrayList(Objects));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddObjects()", ex); }
		}

		public System.Boolean RemoveObjects(System.Collections.ArrayList Objects)
		{
			try {
			var result = teklaObject.RemoveObjects(TSActivator.ConvertToTSArrayList(Objects));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveObjects()", ex); }
		}





    }

    internal static class HierarchicDefinition_
    {
        public static dynamic GetTSObject(HierarchicDefinition dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static HierarchicDefinition FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.HierarchicDefinition)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class HierarchicDefinitionArray_
    {
        public static dynamic GetTSObject(HierarchicDefinition[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(HierarchicDefinition_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static HierarchicDefinition[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<HierarchicDefinition>();
            foreach(var tsItem in tsArray)
            {
                list.Add(HierarchicDefinition_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
