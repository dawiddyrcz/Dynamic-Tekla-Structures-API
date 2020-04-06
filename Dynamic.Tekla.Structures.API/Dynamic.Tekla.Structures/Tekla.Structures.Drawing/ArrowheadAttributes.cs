/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ArrowheadAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.ArrowheadPositions ArrowPosition
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ArrowheadPositions_.FromTSObject(teklaObject.ArrowPosition);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArrowPosition", ex); }
			}
			set
			{
				try {
				teklaObject.ArrowPosition = Dynamic.Tekla.Structures.Drawing.ArrowheadPositions_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArrowPosition", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ArrowheadTypes Head
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ArrowheadTypes_.FromTSObject(teklaObject.Head);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Head", ex); }
			}
			set
			{
				try {
				teklaObject.Head = Dynamic.Tekla.Structures.Drawing.ArrowheadTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Head", ex); }
			}
		}

		public System.Double Height
		{
			get
			{
				try {
					return teklaObject.Height;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height", ex); }
			}
			set
			{
				try {
					teklaObject.Height = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height", ex); }
			}
		}

		public System.Double Width
		{
			get
			{
				try {
					return teklaObject.Width;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width", ex); }
			}
			set
			{
				try {
					teklaObject.Width = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width", ex); }
			}
		}

        

        

		public ArrowheadAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ArrowheadAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ArrowheadAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ArrowheadAttributes(Dynamic.Tekla.Structures.Drawing.ArrowheadPositions arrowPosition, Dynamic.Tekla.Structures.Drawing.ArrowheadTypes head, System.Double height, System.Double width)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ArrowheadPositions_.GetTSObject(arrowPosition);
			args[1] = Dynamic.Tekla.Structures.Drawing.ArrowheadTypes_.GetTSObject(head);
			args[2] = height;
			args[3] = width;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ArrowheadAttributes", args);
		}





    }

    internal static class ArrowheadAttributes_
    {
        public static dynamic GetTSObject(ArrowheadAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ArrowheadAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ArrowheadAttributesArray_
    {
        public static dynamic GetTSObject(ArrowheadAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ArrowheadAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ArrowheadAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ArrowheadAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ArrowheadAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
