/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ModelViewEnumerator 
    {

		public Dynamic.Tekla.Structures.Model.UI.View Current
		{
			get => Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(teklaObject.Current);
			set { teklaObject.Current = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value); }
		}

		public System.Int32 Count
		{
			get => teklaObject.Count;
			set { teklaObject.Count = value; }
		}

		public System.Int32 CurrentViewId
		{
			get => teklaObject.CurrentViewId;
			set { teklaObject.CurrentViewId = value; }
		}

        

        internal dynamic teklaObject;

		public ModelViewEnumerator() {}

		public System.Boolean MoveNext()
		{
			return teklaObject.MoveNext();
		}

		public void Reset()
		{
			teklaObject.Reset();
		}





    }

    internal static class ModelViewEnumerator_
    {
        public static dynamic GetTSObject(ModelViewEnumerator dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelViewEnumerator FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
