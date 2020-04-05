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
			get => teklaObject.Grade;
			set { teklaObject.Grade = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String DiameterLongitudinal
		{
			get => teklaObject.DiameterLongitudinal;
			set { teklaObject.DiameterLongitudinal = value; }
		}

		public System.String DistanceLongitudinal
		{
			get => teklaObject.DistanceLongitudinal;
			set { teklaObject.DistanceLongitudinal = value; }
		}

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public System.Double MinimumOverlappingLongitudinal
		{
			get => teklaObject.MinimumOverlappingLongitudinal;
			set { teklaObject.MinimumOverlappingLongitudinal = value; }
		}

		public System.Double MaximumOverlappingLongitudinal
		{
			get => teklaObject.MaximumOverlappingLongitudinal;
			set { teklaObject.MaximumOverlappingLongitudinal = value; }
		}

		public System.Double LeftOverhangLongitudinal
		{
			get => teklaObject.LeftOverhangLongitudinal;
			set { teklaObject.LeftOverhangLongitudinal = value; }
		}

		public System.Double RightOverhangLongitudinal
		{
			get => teklaObject.RightOverhangLongitudinal;
			set { teklaObject.RightOverhangLongitudinal = value; }
		}

		public System.String DiameterCross
		{
			get => teklaObject.DiameterCross;
			set { teklaObject.DiameterCross = value; }
		}

		public System.String DistanceCross
		{
			get => teklaObject.DistanceCross;
			set { teklaObject.DistanceCross = value; }
		}

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public System.Double MinimumOverlappingCross
		{
			get => teklaObject.MinimumOverlappingCross;
			set { teklaObject.MinimumOverlappingCross = value; }
		}

		public System.Double MaximumOverlappingCross
		{
			get => teklaObject.MaximumOverlappingCross;
			set { teklaObject.MaximumOverlappingCross = value; }
		}

		public System.Double LeftOverhangCross
		{
			get => teklaObject.LeftOverhangCross;
			set { teklaObject.LeftOverhangCross = value; }
		}

		public System.Double RightOverhangCross
		{
			get => teklaObject.RightOverhangCross;
			set { teklaObject.RightOverhangCross = value; }
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
			return teklaObject.Select(MeshName, MeshGrade);
		}

		public System.Boolean Export(ref System.String filename)
		{
			return teklaObject.Export(ref filename);
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
    
