/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarProperties 
    {


    public System.String Size
    {
        get
        {
            try
            {
                return teklaObject.Size;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Size = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex); 
            }
        }
    }

    public System.String Grade
    {
        get
        {
            try
            {
                return teklaObject.Grade;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Grade), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Grade = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Grade), ex); 
            }
        }
    }

    public System.String Name
    {
        get
        {
            try
            {
                return teklaObject.Name;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Name = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
            }
        }
    }

    public System.Int32 Class
    {
        get
        {
            try
            {
                return teklaObject.Class;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Class = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.NumberingSeries NumberingSeries
    {
        get
        {
            try
            {
                var value = teklaObject.NumberingSeries;
                var value_ = Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.NumberingSeries) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberingSeries), ex); 
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value);
                teklaObject.NumberingSeries = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberingSeries), ex); 
            }
        }
    }

    public System.Double BendingRadius
    {
        get
        {
            try
            {
                return teklaObject.BendingRadius;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BendingRadius), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.BendingRadius = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BendingRadius), ex); 
            }
        }
    }
        

        internal dynamic teklaObject;

		public RebarProperties()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarProperties");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarProperties(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RebarProperties_
    {
        public static dynamic GetTSObject(RebarProperties dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarProperties FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarProperties)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarPropertiesArray_
    {
        public static dynamic GetTSObject(RebarProperties[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarProperties_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarProperties[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarProperties>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarProperties_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
