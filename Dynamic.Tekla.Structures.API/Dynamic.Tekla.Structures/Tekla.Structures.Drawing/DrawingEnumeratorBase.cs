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

		public System.Boolean AutoFetch
		{
			get => teklaObject.AutoFetch;
			set { teklaObject.AutoFetch = value; }
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
            return dynObject.teklaObject;
        }

        public static DrawingEnumeratorBase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.DrawingEnumeratorBase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
