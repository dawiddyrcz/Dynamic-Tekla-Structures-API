/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarLegFace 
    {

		public System.Int32 Id
		{
			get
			{
				try {
					return teklaObject.Id;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Id", ex); }
			}
			set
			{
				try {
					teklaObject.Id = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Id", ex); }
			}
		}

		public System.Double AdditonalOffset
		{
			get
			{
				try {
					return teklaObject.AdditonalOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AdditonalOffset", ex); }
			}
			set
			{
				try {
					teklaObject.AdditonalOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AdditonalOffset", ex); }
			}
		}

		public System.Int32 LayerOrderNumber
		{
			get
			{
				try {
					return teklaObject.LayerOrderNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LayerOrderNumber", ex); }
			}
			set
			{
				try {
					teklaObject.LayerOrderNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LayerOrderNumber", ex); }
			}
		}

		public System.Boolean Reversed
		{
			get
			{
				try {
					return teklaObject.Reversed;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Reversed", ex); }
			}
			set
			{
				try {
					teklaObject.Reversed = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Reversed", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Contour", ex); }
			}
			set
			{
				try {
				teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Contour", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public RebarLegFace()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLegFace");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarLegFace(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public RebarLegFace(Dynamic.Tekla.Structures.Model.Contour contour)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(contour);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLegFace", args);
		}





    }

    internal static class RebarLegFace_
    {
        public static dynamic GetTSObject(RebarLegFace dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarLegFace FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarLegFace)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarLegFaceArray_
    {
        public static dynamic GetTSObject(RebarLegFace[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarLegFace_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarLegFace[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarLegFace>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarLegFace_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
