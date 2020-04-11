/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ComponentInput 
    {

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

		public System.Boolean IsSynchronized
		{
			get
			{
				try {
					return teklaObject.IsSynchronized;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSynchronized", ex); }
			}

		}

		public System.Object SyncRoot
		{
			get
			{
				try {
					return teklaObject.SyncRoot;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SyncRoot", ex); }
			}

		}

        

        internal dynamic teklaObject;

		public ComponentInput()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ComponentInput");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ComponentInput(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean AddOneInputPosition(
	Dynamic.Tekla.Structures.Geometry3d.Point P_
	)
{
	var P = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P_);
    try
    {
        	var result = teklaObject.AddOneInputPosition(P);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddOneInputPosition), ex);
    }
}



public System.Boolean AddTwoInputPositions(
	Dynamic.Tekla.Structures.Geometry3d.Point Position1_,
	Dynamic.Tekla.Structures.Geometry3d.Point Position2_
	)
{
	var Position1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Position1_);
	var Position2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Position2_);
    try
    {
        	var result = teklaObject.AddTwoInputPositions(Position1, Position2);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddTwoInputPositions), ex);
    }
}



public System.Boolean AddInputPolygon(
	Dynamic.Tekla.Structures.Model.Polygon P_
	)
{
	var P = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(P_);
    try
    {
        	var result = teklaObject.AddInputPolygon(P);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddInputPolygon), ex);
    }
}



public System.Boolean AddInputObject(
	Dynamic.Tekla.Structures.Model.ModelObject M_
	)
{
	var M = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(M_);
    try
    {
        	var result = teklaObject.AddInputObject(M);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddInputObject), ex);
    }
}



public System.Boolean AddInputObjects(
	System.Collections.ArrayList Objects_
	)
{
	var Objects = ArrayListConverter.ToTSObjects(Objects_);
    try
    {
        	var result = teklaObject.AddInputObjects(Objects);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddInputObjects), ex);
    }
}



public void CopyTo(
	System.Array array_,
	System.Int32 index
	)
{
	var array = IEnumerableConverter.ToTSObjects<System.Array>(array_);
	
    try
    {
        	teklaObject.CopyTo(array, index);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CopyTo), ex);
    }
}






    }

    internal static class ComponentInput_
    {
        public static dynamic GetTSObject(ComponentInput dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ComponentInput FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ComponentInput)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ComponentInputArray_
    {
        public static dynamic GetTSObject(ComponentInput[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ComponentInput_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ComponentInput[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ComponentInput>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ComponentInput_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
