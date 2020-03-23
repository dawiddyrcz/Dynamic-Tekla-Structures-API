/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Cloud  : Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject
    {

		public Dynamic.Tekla.Structures.Drawing.PointList Points
		{
			get => Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.Points);
			set { teklaObject.Points = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value); }
		}

		public System.Double Bulge
		{
			get => teklaObject.Bulge;
			set { teklaObject.Bulge = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.Cloud.CloudAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Cloud.CloudAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Cloud.CloudAttributes_.GetTSObject(value); }
		}

        

        

		public Cloud() {}
		public Cloud(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Drawing.PointList pointList, Dynamic.Tekla.Structures.Drawing.Cloud.CloudAttributes attributes)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList);
			args[2] = Dynamic.Tekla.Structures.Drawing.Cloud.CloudAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Cloud", args);
		}
		public Cloud(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Drawing.PointList pointList)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Cloud", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}




    public  class CloudAttributes  : Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject.ClosedGraphicObjectAttributes
    {

        

        

		public CloudAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Cloud.CloudAttributes");
		}
		public CloudAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Cloud.CloudAttributes", args);
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

    internal static class CloudAttributes_
    {
        public static dynamic GetTSObject(CloudAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CloudAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Cloud.CloudAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CloudAttributesArray_
    {
        public static dynamic GetTSObject(CloudAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CloudAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CloudAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CloudAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CloudAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Cloud_
    {
        public static dynamic GetTSObject(Cloud dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Cloud FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Cloud)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CloudArray_
    {
        public static dynamic GetTSObject(Cloud[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Cloud_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Cloud[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Cloud>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Cloud_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
