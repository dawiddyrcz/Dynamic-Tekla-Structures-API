/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class CrossSection 
    {


    public Dynamic.Tekla.Structures.Catalogs.ProfileName Profile
    {
        get
        {
            try
            {
                var value = teklaObject.Profile;
                var value_ = Dynamic.Tekla.Structures.Catalogs.ProfileName_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Catalogs.ProfileName) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Profile), ex); 
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Catalogs.ProfileName_.GetTSObject(value);
                teklaObject.Profile = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Profile), ex); 
            }
        }
    }

    public System.Double Location
    {
        get
        {
            try
            {
                return teklaObject.Location;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Location), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Location = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Location), ex); 
            }
        }
    }

    public System.Double Length
    {
        get
        {
            try
            {
                return teklaObject.Length;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
            }
        }
        set
        {
            try
            {
                teklaObject.Length = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
            }
        }
    }

    public System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CrossSectionPoint> OuterSurface
    {
        get
        {
            try
            {
                var value = teklaObject.OuterSurface;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Catalogs.CrossSectionPoint>(value);
                return (System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CrossSectionPoint>) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OuterSurface), ex); 
            }
        }
        
    }

    public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> OuterSurfacePoints
    {
        get
        {
            try
            {
                var value = teklaObject.OuterSurfacePoints;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.Point>(value);
                return (System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point>) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OuterSurfacePoints), ex); 
            }
        }
        
    }

    public System.Collections.Generic.List<System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CrossSectionPoint>> InnerSurfaces
    {
        get
        {
            try
            {
                var value = teklaObject.InnerSurfaces;
                var value_ = ListConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CrossSectionPoint>>(value);
                return (System.Collections.Generic.List<System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CrossSectionPoint>>) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InnerSurfaces), ex); 
            }
        }
        
    }

    public System.Collections.Generic.List<System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point>> InnerSurfacePoints
    {
        get
        {
            try
            {
                var value = teklaObject.InnerSurfacePoints;
                var value_ = ListConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point>>(value);
                return (System.Collections.Generic.List<System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point>>) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InnerSurfacePoints), ex); 
            }
        }
        
    }
        

        internal dynamic teklaObject;

		internal CrossSection() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CrossSection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CrossSection(Dynamic.Tekla.Structures.Catalogs.ProfileName Profile)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Catalogs.ProfileName_.GetTSObject(Profile);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.CrossSection", args);
		}
		public CrossSection(System.String ProfileString)
		{
			var args = new object[1];
			args[0] = ProfileString;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.CrossSection", args);
		}


public System.Boolean Select(
	System.Double Location,
	System.Double Length
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Location, Length);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}






    }

    internal static class CrossSection_
    {
        public static dynamic GetTSObject(CrossSection dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CrossSection FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.CrossSection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CrossSectionArray_
    {
        public static dynamic GetTSObject(CrossSection[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CrossSection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CrossSection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CrossSection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CrossSection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
