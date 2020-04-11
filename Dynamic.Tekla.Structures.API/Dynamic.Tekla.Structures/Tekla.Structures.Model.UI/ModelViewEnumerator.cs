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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(teklaObject.Current);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Current", ex); }
			}
		}

		public System.Int32 Count
		{
			get
			{
				try {
					return teklaObject.Count;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Count", ex); }
			}

		}

		public System.Int32 CurrentViewId
		{
			get
			{
				try {
					return teklaObject.CurrentViewId;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentViewId", ex); }
			}

		}

        

        internal dynamic teklaObject;

		internal ModelViewEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelViewEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean MoveNext()
{

    try
    {
        	var result = (System.Boolean) teklaObject.MoveNext();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MoveNext), ex);
    }
}



public void Reset()
{

    try
    {
        	teklaObject.Reset();

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Reset), ex);
    }
}






    }

    internal static class ModelViewEnumerator_
    {
        public static dynamic GetTSObject(ModelViewEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelViewEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelViewEnumeratorArray_
    {
        public static dynamic GetTSObject(ModelViewEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelViewEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelViewEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelViewEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelViewEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
