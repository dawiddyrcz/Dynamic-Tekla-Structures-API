/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ModelObject  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Identifier ModelIdentifier
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.ModelIdentifier);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelIdentifier"); }
			}
			set
			{
				try {
				teklaObject.ModelIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelIdentifier"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable"); }
			}
			set
			{
				try {
				teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable"); }
			}
		}

        

        






    }

    internal static class ModelObject_
    {
        public static dynamic GetTSObject(ModelObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ModelObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelObjectArray_
    {
        public static dynamic GetTSObject(ModelObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
