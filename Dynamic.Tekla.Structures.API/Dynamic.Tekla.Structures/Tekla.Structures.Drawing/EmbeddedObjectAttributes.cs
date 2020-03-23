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
			get => teklaObject.XScale;
			set { teklaObject.XScale = value; }
		}

		public System.Double YScale
		{
			get => teklaObject.YScale;
			set { teklaObject.YScale = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.EmbeddedObjectScalingOptions Scaling
		{
			get => Dynamic.Tekla.Structures.Drawing.EmbeddedObjectScalingOptions_.FromTSObject(teklaObject.Scaling);
			set { teklaObject.Scaling = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectScalingOptions_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame Frame
		{
			get => Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame_.FromTSObject(teklaObject.Frame);
			set { teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame_.GetTSObject(value); }
		}

        

        

		public EmbeddedObjectAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EmbeddedObjectAttributes");
		}
		public EmbeddedObjectAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EmbeddedObjectAttributes", args);
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

    internal static class EmbeddedObjectAttributes_
    {
        public static dynamic GetTSObject(EmbeddedObjectAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static EmbeddedObjectAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EmbeddedObjectAttributesArray_
    {
        public static dynamic GetTSObject(EmbeddedObjectAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EmbeddedObjectAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EmbeddedObjectAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<EmbeddedObjectAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EmbeddedObjectAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
