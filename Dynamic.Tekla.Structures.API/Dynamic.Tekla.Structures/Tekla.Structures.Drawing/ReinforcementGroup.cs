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

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReinforcementGroup  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase
    {


        public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementGroupAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementGroupAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementGroupAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementGroupAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
        }

        public System.Double ReinforcementCustomPosition
        {
            get
            {
                try
                {
                return teklaObject.ReinforcementCustomPosition;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ReinforcementCustomPosition), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ReinforcementCustomPosition = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ReinforcementCustomPosition), ex); 
                }
            }
        }
        

        

		internal ReinforcementGroup() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcementGroup(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class ReinforcementGroup_
    {
        public static dynamic GetTSObject(ReinforcementGroup dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReinforcementGroup FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementGroup)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementGroupArray_
    {
        public static dynamic GetTSObject(ReinforcementGroup[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementGroup[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReinforcementGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
