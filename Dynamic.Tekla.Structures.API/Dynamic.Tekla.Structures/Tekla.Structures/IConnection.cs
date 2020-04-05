/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class IConnection 
    {

		public System.Boolean IsActive
		{
			get
			{
				try {
					return teklaObject.IsActive;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsActive"); }
			}

		}

        

        internal dynamic teklaObject;






    }

    internal static class IConnection_
    {
        public static dynamic GetTSObject(IConnection dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IConnection FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.IConnection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IConnectionArray_
    {
        public static dynamic GetTSObject(IConnection[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IConnection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IConnection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IConnection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IConnection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
