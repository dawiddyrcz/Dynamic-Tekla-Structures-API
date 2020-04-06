/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class IDrawing 
    {

		public Dynamic.Tekla.Structures.Drawing.Drawing Current
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.Current);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Current"); }
			}
		}

		public System.Collections.Generic.ICollection<Dynamic.Tekla.Structures.Drawing.Drawing> Drawings
		{
			get
			{
				try {
					return teklaObject.Drawings;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Drawings"); }
			}

		}

		public System.Boolean IsEditorOpen
		{
			get
			{
				try {
					return teklaObject.IsEditorOpen;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsEditorOpen"); }
			}

		}

        

        internal dynamic teklaObject;


		public System.Boolean Close()
		{
			try {
			var result = teklaObject.Close();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Close()"); }
		}

		public System.Boolean Close(System.Boolean saveBeforeClosing)
		{
			try {
			var result = teklaObject.Close(saveBeforeClosing);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Close()"); }
		}

		public System.Boolean Open(Dynamic.Tekla.Structures.Drawing.Drawing drawing)
		{
			try {
			var result = teklaObject.Open(Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Open()"); }
		}

		public System.Boolean Save()
		{
			try {
			var result = teklaObject.Save();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Save()"); }
		}





    }

    internal static class IDrawing_
    {
        public static dynamic GetTSObject(IDrawing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IDrawing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.IDrawing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IDrawingArray_
    {
        public static dynamic GetTSObject(IDrawing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IDrawing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IDrawing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IDrawing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IDrawing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
