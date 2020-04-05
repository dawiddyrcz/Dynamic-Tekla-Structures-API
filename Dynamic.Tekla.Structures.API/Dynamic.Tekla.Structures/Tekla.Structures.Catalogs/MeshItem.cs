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
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade"); }
			}
			set
			{
				try {
					teklaObject.Grade = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Grade"); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public System.String DiameterLongitudinal
		{
			get
			{
				try {
					return teklaObject.DiameterLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.DiameterLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterLongitudinal"); }
			}
		}

		public System.String DistanceLongitudinal
		{
			get
			{
				try {
					return teklaObject.DistanceLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.DistanceLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceLongitudinal"); }
			}
		}

		public System.Double Length
		{
			get
			{
				try {
					return teklaObject.Length;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length"); }
			}
			set
			{
				try {
					teklaObject.Length = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length"); }
			}
		}

		public System.Double MinimumOverlappingLongitudinal
		{
			get
			{
				try {
					return teklaObject.MinimumOverlappingLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.MinimumOverlappingLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingLongitudinal"); }
			}
		}

		public System.Double MaximumOverlappingLongitudinal
		{
			get
			{
				try {
					return teklaObject.MaximumOverlappingLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.MaximumOverlappingLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingLongitudinal"); }
			}
		}

		public System.Double LeftOverhangLongitudinal
		{
			get
			{
				try {
					return teklaObject.LeftOverhangLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.LeftOverhangLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangLongitudinal"); }
			}
		}

		public System.Double RightOverhangLongitudinal
		{
			get
			{
				try {
					return teklaObject.RightOverhangLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.RightOverhangLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangLongitudinal"); }
			}
		}

		public System.String DiameterCross
		{
			get
			{
				try {
					return teklaObject.DiameterCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterCross"); }
			}
			set
			{
				try {
					teklaObject.DiameterCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DiameterCross"); }
			}
		}

		public System.String DistanceCross
		{
			get
			{
				try {
					return teklaObject.DistanceCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceCross"); }
			}
			set
			{
				try {
					teklaObject.DistanceCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DistanceCross"); }
			}
		}

		public System.Double Width
		{
			get
			{
				try {
					return teklaObject.Width;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width"); }
			}
			set
			{
				try {
					teklaObject.Width = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width"); }
			}
		}

		public System.Double MinimumOverlappingCross
		{
			get
			{
				try {
					return teklaObject.MinimumOverlappingCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingCross"); }
			}
			set
			{
				try {
					teklaObject.MinimumOverlappingCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MinimumOverlappingCross"); }
			}
		}

		public System.Double MaximumOverlappingCross
		{
			get
			{
				try {
					return teklaObject.MaximumOverlappingCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingCross"); }
			}
			set
			{
				try {
					teklaObject.MaximumOverlappingCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MaximumOverlappingCross"); }
			}
		}

		public System.Double LeftOverhangCross
		{
			get
			{
				try {
					return teklaObject.LeftOverhangCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangCross"); }
			}
			set
			{
				try {
					teklaObject.LeftOverhangCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangCross"); }
			}
		}

		public System.Double RightOverhangCross
		{
			get
			{
				try {
					return teklaObject.RightOverhangCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangCross"); }
			}
			set
			{
				try {
					teklaObject.RightOverhangCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangCross"); }
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

		public System.Boolean Select(System.String MeshName, System.String MeshGrade)
		{
			try {
			return teklaObject.Select(MeshName, MeshGrade);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Export(ref System.String filename)
		{
			try {
			return teklaObject.Export(ref filename);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Export()"); }
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
    
