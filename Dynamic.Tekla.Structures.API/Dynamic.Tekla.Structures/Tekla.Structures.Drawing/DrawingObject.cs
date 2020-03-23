/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class DrawingObject  : Dynamic.Tekla.Structures.Drawing.DatabaseObject
    {

		public Dynamic.Tekla.Structures.Drawing.AttributesBase Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.AttributesBase_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.AttributesBase_.GetTSObject(value); }
		}

        

        


		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetRelatedObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetRelatedObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetRelatedObjects(System.Type[] typeFilter)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetRelatedObjects(typeFilter));
		}

		public Dynamic.Tekla.Structures.Drawing.ViewBase GetView()
		{
			return Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(teklaObject.GetView());
		}

		public Dynamic.Tekla.Structures.Drawing.Drawing GetDrawing()
		{
			return Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.GetDrawing());
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public  class NoAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

        

        

		public NoAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingObject.NoAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NoAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public NoAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingObject.NoAttributes", args);
		}

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class NoAttributes_
    {
        public static dynamic GetTSObject(NoAttributes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static NoAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingObject.NoAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NoAttributesArray_
    {
        public static dynamic GetTSObject(NoAttributes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NoAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NoAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<NoAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NoAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class DrawingObject_
    {
        public static dynamic GetTSObject(DrawingObject dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingObject FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingObjectArray_
    {
        public static dynamic GetTSObject(DrawingObject[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DrawingObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
