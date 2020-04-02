/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class DrawingEnumeratorBase 
    {

		public static System.Boolean AutoFetch
		{
			get => (System.Boolean) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.DrawingEnumeratorBase","AutoFetch");
			set { TSActivator.Set_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.DrawingEnumeratorBase","AutoFetch", value); }
		}

		public System.Boolean SelectInstances
		{
			get => teklaObject.SelectInstances;
			set { teklaObject.SelectInstances = value; }
		}

        

        internal dynamic teklaObject;


		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}

		public System.Int32 GetSize()
		{
			return teklaObject.GetSize();
		}





    }

    internal static class DrawingEnumeratorBase_
    {
        public static dynamic GetTSObject(DrawingEnumeratorBase dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingEnumeratorBase FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DrawingEnumeratorBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingEnumeratorBaseArray_
    {
        public static dynamic GetTSObject(DrawingEnumeratorBase[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingEnumeratorBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingEnumeratorBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DrawingEnumeratorBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingEnumeratorBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
