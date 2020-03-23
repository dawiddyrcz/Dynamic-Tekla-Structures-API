/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ElementBase 
    {

        

        internal dynamic teklaObject;


		public System.Object Clone()
		{
			return teklaObject.Clone();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.String GetUnformattedString()
		{
			return teklaObject.GetUnformattedString();
		}





    }

    internal static class ElementBase_
    {
        public static dynamic GetTSObject(ElementBase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ElementBase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ElementBase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ElementBaseArray_
    {
        public static dynamic GetTSObject(ElementBase[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ElementBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ElementBase[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ElementBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ElementBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
