/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class CurvedRebarGroup  : Dynamic.Tekla.Structures.Model.BaseRebarGroup
    {


        public Dynamic.Tekla.Structures.Model.Polygon Polygon
        {
            get
            {
                try
                {
                var value = teklaObject.Polygon;
                var value_ = Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.Polygon) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value);
                teklaObject.Polygon = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex); 
                }
            }
        }
        

        

		public CurvedRebarGroup()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CurvedRebarGroup");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CurvedRebarGroup(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class CurvedRebarGroup_
    {
        public static dynamic GetTSObject(CurvedRebarGroup dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedRebarGroup FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.CurvedRebarGroup)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedRebarGroupArray_
    {
        public static dynamic GetTSObject(CurvedRebarGroup[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedRebarGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedRebarGroup[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedRebarGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedRebarGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
