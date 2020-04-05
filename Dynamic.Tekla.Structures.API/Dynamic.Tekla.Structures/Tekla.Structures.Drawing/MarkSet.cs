/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class MarkSet  : Dynamic.Tekla.Structures.Drawing.MarkBase
    {

		public Dynamic.Tekla.Structures.Drawing.MarkSet.MarkSetAttributes Attributes
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.MarkSet.MarkSetAttributes_.FromTSObject(teklaObject.Attributes);
			}
			set
			{
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.MarkSet.MarkSetAttributes_.GetTSObject(value);
			}
		}

        

        

		internal MarkSet() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MarkSet(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public  class MarkSetAttributes  : Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes
    {

        

        

		public MarkSetAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.MarkSet.MarkSetAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MarkSetAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class MarkSetAttributes_
    {
        public static dynamic GetTSObject(MarkSetAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MarkSetAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.MarkSet.MarkSetAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MarkSetAttributesArray_
    {
        public static dynamic GetTSObject(MarkSetAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MarkSetAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MarkSetAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MarkSetAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MarkSetAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class MarkSet_
    {
        public static dynamic GetTSObject(MarkSet dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MarkSet FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.MarkSet)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MarkSetArray_
    {
        public static dynamic GetTSObject(MarkSet[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MarkSet_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MarkSet[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MarkSet>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MarkSet_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
