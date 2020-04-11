/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class SingleRebar  : Dynamic.Tekla.Structures.Model.Reinforcement
    {

		public System.String Size
		{
			get
			{
				try {
					return teklaObject.Size;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size", ex); }
			}
			set
			{
				try {
					teklaObject.Size = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Size", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.StartHook);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartHook", ex); }
			}
			set
			{
				try {
				teklaObject.StartHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartHook", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.EndHook);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndHook", ex); }
			}
			set
			{
				try {
				teklaObject.EndHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndHook", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon", ex); }
			}
			set
			{
				try {
				teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon", ex); }
			}
		}

        

        

		public SingleRebar()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SingleRebar");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SingleRebar(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public Dynamic.Tekla.Structures.Model.RebarSet GetRebarSet()
{

    try
    {
        	var result = teklaObject.GetRebarSet();

        	var _result = Dynamic.Tekla.Structures.Model.RebarSet_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarSet), ex);
    }
}






    }

    internal static class SingleRebar_
    {
        public static dynamic GetTSObject(SingleRebar dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SingleRebar FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.SingleRebar)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SingleRebarArray_
    {
        public static dynamic GetTSObject(SingleRebar[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SingleRebar_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SingleRebar[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SingleRebar>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SingleRebar_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
