/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class ICurve 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

		public System.Double Length
		{
			get
			{
				try {
					return teklaObject.Length;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length"); }
			}

		}

        

        internal dynamic teklaObject;






    }

    internal static class ICurve_
    {
        public static dynamic GetTSObject(ICurve dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ICurve FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.ICurve)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ICurveArray_
    {
        public static dynamic GetTSObject(ICurve[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ICurve_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ICurve[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ICurve>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ICurve_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
