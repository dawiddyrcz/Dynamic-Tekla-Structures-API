/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class AttributesBase 
    {

        

        internal dynamic teklaObject;


		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}





    }

    internal static class AttributesBase_
    {
        public static dynamic GetTSObject(AttributesBase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static AttributesBase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.AttributesBase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AttributesBaseArray_
    {
        public static dynamic GetTSObject(AttributesBase[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AttributesBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AttributesBase[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<AttributesBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AttributesBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
