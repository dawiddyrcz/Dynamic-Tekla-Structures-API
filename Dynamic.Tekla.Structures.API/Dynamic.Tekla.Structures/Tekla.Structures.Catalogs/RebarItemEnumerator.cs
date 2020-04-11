/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class RebarItemEnumerator 
    {

		public Dynamic.Tekla.Structures.Catalogs.RebarItem Current
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(teklaObject.Current);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Current", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal RebarItemEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarItemEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean MoveNext()
{

    try
    {
        	var result = teklaObject.MoveNext();

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



public System.Int32 GetSize()
{

    try
    {
        	var result = teklaObject.GetSize();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSize), ex);
    }
}



public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(
	System.String Grade,
	System.String Size,
	System.Double BendRadius
	)
{
	
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", Grade, Size, BendRadius);
	var _result = Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(
	System.String Grade,
	System.String Size,
	System.String Usage
	)
{
	
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", Grade, Size, Usage);
	var _result = Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(
	System.String Grade,
	System.String Size
	)
{
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", Grade, Size);
	var _result = Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(
	System.String Grade,
	System.Double Diameter,
	System.Double BendRadius,
	System.Boolean UseNominalDiameter
	)
{
	
	
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", Grade, Diameter, BendRadius, UseNominalDiameter);
	var _result = Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(
	System.String Grade,
	System.Double Diameter,
	System.String Usage,
	System.Boolean UseNominalDiameter
	)
{
	
	
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", Grade, Diameter, Usage, UseNominalDiameter);
	var _result = Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(
	System.String Grade,
	System.Double Diameter,
	System.Boolean UseNominalDiameter
	)
{
	
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", Grade, Diameter, UseNominalDiameter);
	var _result = Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
	return _result;
}






    }

    internal static class RebarItemEnumerator_
    {
        public static dynamic GetTSObject(RebarItemEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarItemEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarItemEnumeratorArray_
    {
        public static dynamic GetTSObject(RebarItemEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarItemEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarItemEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarItemEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarItemEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
