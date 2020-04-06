/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class EmbeddedObjectAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.Double XScale
		{
			get
			{
				try {
					return teklaObject.XScale;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("XScale", ex); }
			}
			set
			{
				try {
					teklaObject.XScale = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("XScale", ex); }
			}
		}

		public System.Double YScale
		{
			get
			{
				try {
					return teklaObject.YScale;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("YScale", ex); }
			}
			set
			{
				try {
					teklaObject.YScale = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("YScale", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.EmbeddedObjectScalingOptions Scaling
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.EmbeddedObjectScalingOptions_.FromTSObject(teklaObject.Scaling);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scaling", ex); }
			}
			set
			{
				try {
				teklaObject.Scaling = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectScalingOptions_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scaling", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame Frame
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame_.FromTSObject(teklaObject.Frame);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame", ex); }
			}
			set
			{
				try {
				teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame", ex); }
			}
		}

        

        

		public EmbeddedObjectAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EmbeddedObjectAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public EmbeddedObjectAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public EmbeddedObjectAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EmbeddedObjectAttributes", args);
		}





    }

    internal static class EmbeddedObjectAttributes_
    {
        public static dynamic GetTSObject(EmbeddedObjectAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static EmbeddedObjectAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EmbeddedObjectAttributesArray_
    {
        public static dynamic GetTSObject(EmbeddedObjectAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EmbeddedObjectAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EmbeddedObjectAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<EmbeddedObjectAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EmbeddedObjectAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
