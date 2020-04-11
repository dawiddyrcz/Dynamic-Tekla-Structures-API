/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Forming
{

    public  class FormingStates 
    {

		public Dynamic.Tekla.Structures.Forming.DeformingType Deforming
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(teklaObject.Deforming);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Deforming", ex); }
			}
			set
			{
				try {
				teklaObject.Deforming = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Deforming", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Forming.FoldingType Folding
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Forming.FoldingType_.FromTSObject(teklaObject.Folding);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Folding", ex); }
			}
			set
			{
				try {
				teklaObject.Folding = Dynamic.Tekla.Structures.Forming.FoldingType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Folding", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Forming.WrappingType Wrapping
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Forming.WrappingType_.FromTSObject(teklaObject.Wrapping);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Wrapping", ex); }
			}
			set
			{
				try {
				teklaObject.Wrapping = Dynamic.Tekla.Structures.Forming.WrappingType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Wrapping", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public FormingStates()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FormingStates(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.DeformingType deforming)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(deforming);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.FoldingType folding)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Forming.FoldingType_.GetTSObject(folding);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.WrappingType wrapping)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Forming.WrappingType_.GetTSObject(wrapping);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.DeformingType deforming, Dynamic.Tekla.Structures.Forming.FoldingType folding, Dynamic.Tekla.Structures.Forming.WrappingType wrapping)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(deforming);
			args[1] = Dynamic.Tekla.Structures.Forming.FoldingType_.GetTSObject(folding);
			args[2] = Dynamic.Tekla.Structures.Forming.WrappingType_.GetTSObject(wrapping);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}


public System.Object Clone()
{

    try
    {
        	var result = (System.Object) teklaObject.Clone();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Clone), ex);
    }
}






    }

    internal static class FormingStates_
    {
        public static dynamic GetTSObject(FormingStates dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static FormingStates FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Forming.FormingStates)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FormingStatesArray_
    {
        public static dynamic GetTSObject(FormingStates[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FormingStates_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FormingStates[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<FormingStates>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FormingStates_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
