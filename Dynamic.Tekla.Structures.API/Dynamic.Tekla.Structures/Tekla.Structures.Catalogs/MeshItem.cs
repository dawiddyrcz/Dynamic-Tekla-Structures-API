/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class MeshItem 
    {

		public System.String Grade
		{
			get
			{
				try {
					return teklaObject.Grade;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade", ex); }
			}
			set
			{
				try {
					teklaObject.Grade = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade", ex); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public System.String DiameterLongitudinal
		{
			get
			{
				try {
					return teklaObject.DiameterLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterLongitudinal", ex); }
			}
			set
			{
				try {
					teklaObject.DiameterLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterLongitudinal", ex); }
			}
		}

		public System.String DistanceLongitudinal
		{
			get
			{
				try {
					return teklaObject.DistanceLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceLongitudinal", ex); }
			}
			set
			{
				try {
					teklaObject.DistanceLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceLongitudinal", ex); }
			}
		}

		public System.Double Length
		{
			get
			{
				try {
					return teklaObject.Length;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length", ex); }
			}
			set
			{
				try {
					teklaObject.Length = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length", ex); }
			}
		}

		public System.Double MinimumOverlappingLongitudinal
		{
			get
			{
				try {
					return teklaObject.MinimumOverlappingLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingLongitudinal", ex); }
			}
			set
			{
				try {
					teklaObject.MinimumOverlappingLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingLongitudinal", ex); }
			}
		}

		public System.Double MaximumOverlappingLongitudinal
		{
			get
			{
				try {
					return teklaObject.MaximumOverlappingLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingLongitudinal", ex); }
			}
			set
			{
				try {
					teklaObject.MaximumOverlappingLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingLongitudinal", ex); }
			}
		}

		public System.Double LeftOverhangLongitudinal
		{
			get
			{
				try {
					return teklaObject.LeftOverhangLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangLongitudinal", ex); }
			}
			set
			{
				try {
					teklaObject.LeftOverhangLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangLongitudinal", ex); }
			}
		}

		public System.Double RightOverhangLongitudinal
		{
			get
			{
				try {
					return teklaObject.RightOverhangLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangLongitudinal", ex); }
			}
			set
			{
				try {
					teklaObject.RightOverhangLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangLongitudinal", ex); }
			}
		}

		public System.String DiameterCross
		{
			get
			{
				try {
					return teklaObject.DiameterCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterCross", ex); }
			}
			set
			{
				try {
					teklaObject.DiameterCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterCross", ex); }
			}
		}

		public System.String DistanceCross
		{
			get
			{
				try {
					return teklaObject.DistanceCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceCross", ex); }
			}
			set
			{
				try {
					teklaObject.DistanceCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceCross", ex); }
			}
		}

		public System.Double Width
		{
			get
			{
				try {
					return teklaObject.Width;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width", ex); }
			}
			set
			{
				try {
					teklaObject.Width = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width", ex); }
			}
		}

		public System.Double MinimumOverlappingCross
		{
			get
			{
				try {
					return teklaObject.MinimumOverlappingCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingCross", ex); }
			}
			set
			{
				try {
					teklaObject.MinimumOverlappingCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingCross", ex); }
			}
		}

		public System.Double MaximumOverlappingCross
		{
			get
			{
				try {
					return teklaObject.MaximumOverlappingCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingCross", ex); }
			}
			set
			{
				try {
					teklaObject.MaximumOverlappingCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingCross", ex); }
			}
		}

		public System.Double LeftOverhangCross
		{
			get
			{
				try {
					return teklaObject.LeftOverhangCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangCross", ex); }
			}
			set
			{
				try {
					teklaObject.LeftOverhangCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangCross", ex); }
			}
		}

		public System.Double RightOverhangCross
		{
			get
			{
				try {
					return teklaObject.RightOverhangCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangCross", ex); }
			}
			set
			{
				try {
					teklaObject.RightOverhangCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangCross", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public MeshItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.MeshItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MeshItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean Select(
	System.String MeshName,
	System.String MeshGrade
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(MeshName, MeshGrade);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Export(
	ref System.String filename
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.Export(ref filename);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Export), ex);
    }
}






    }

    internal static class MeshItem_
    {
        public static dynamic GetTSObject(MeshItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MeshItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.MeshItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MeshItemArray_
    {
        public static dynamic GetTSObject(MeshItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MeshItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MeshItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MeshItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MeshItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
