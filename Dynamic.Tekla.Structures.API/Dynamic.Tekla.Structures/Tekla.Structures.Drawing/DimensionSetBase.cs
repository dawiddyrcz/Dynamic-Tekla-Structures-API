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

    public abstract class DimensionSetBase  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {


        public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes) value_;
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
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
        {
            get
            {
                try
                {
                var value = teklaObject.Hideable;
                var value_ = Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.Hideable) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hideable), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value);
                teklaObject.Hideable = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hideable), ex); 
                }
            }
        }
        

        



        public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
        {
            
            try
            {
                var result = teklaObject.GetObjects();
            
                var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
            }
        }



        public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects(
			System.Type[] TypeFilter_)
        {
            var TypeFilter = TypeConverter.ToTSObjects(TypeFilter_);
            try
            {
                var result = teklaObject.GetObjects(TypeFilter);
            
                var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
            }
        }



        public System.Boolean AddToDimensionSet(
			Dynamic.Tekla.Structures.Drawing.DimensionSetBase SetToAdd_)
        {
            var SetToAdd = Dynamic.Tekla.Structures.Drawing.DimensionSetBase_.GetTSObject(SetToAdd_);
            try
            {
                var result = (System.Boolean) teklaObject.AddToDimensionSet(SetToAdd);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddToDimensionSet), ex);
            }
        }






    }

    internal static class DimensionSetBase_
    {
        public static dynamic GetTSObject(DimensionSetBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DimensionSetBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionSetBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DimensionSetBaseArray_
    {
        public static dynamic GetTSObject(DimensionSetBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DimensionSetBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DimensionSetBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DimensionSetBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DimensionSetBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
