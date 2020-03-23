/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class GeometrySectionEnumerator 
    {

		public Dynamic.Tekla.Structures.Model.GeometrySection Current
		{
			get => Dynamic.Tekla.Structures.Model.GeometrySection_.FromTSObject(teklaObject.Current);
			set { teklaObject.Current = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public GeometrySectionEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class GeometrySectionEnumerator_
    {
        public static dynamic GetTSObject(GeometrySectionEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GeometrySectionEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GeometrySectionEnumeratorArray_
    {
        public static dynamic GetTSObject(GeometrySectionEnumerator[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GeometrySectionEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GeometrySectionEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<GeometrySectionEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GeometrySectionEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
