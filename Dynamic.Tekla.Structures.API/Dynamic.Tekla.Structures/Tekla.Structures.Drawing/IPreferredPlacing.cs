/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class IPreferredPlacing 
    {

		public Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PreferredPlacing
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(teklaObject.PreferredPlacing);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PreferredPlacing"); }
			}
			set
			{
				try {
				teklaObject.PreferredPlacing = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PreferredPlacing"); }
			}
		}

        

        internal dynamic teklaObject;






    }

    internal static class IPreferredPlacing_
    {
        public static dynamic GetTSObject(IPreferredPlacing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IPreferredPlacing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.IPreferredPlacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IPreferredPlacingArray_
    {
        public static dynamic GetTSObject(IPreferredPlacing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IPreferredPlacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IPreferredPlacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IPreferredPlacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IPreferredPlacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
