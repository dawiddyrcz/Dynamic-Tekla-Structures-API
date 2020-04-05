/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class Loop 
    {

        

        internal dynamic teklaObject;

		internal Loop() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Loop(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Solid.VertexEnumerator GetVertexEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.VertexEnumerator_.FromTSObject(teklaObject.GetVertexEnumerator());
		}





    }

    internal static class Loop_
    {
        public static dynamic GetTSObject(Loop dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Loop FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Solid.Loop)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoopArray_
    {
        public static dynamic GetTSObject(Loop[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Loop_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Loop[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Loop>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Loop_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
