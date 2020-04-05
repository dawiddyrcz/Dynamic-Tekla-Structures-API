/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarStrand  : Dynamic.Tekla.Structures.Model.Reinforcement
    {

		public System.String Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public System.Double PullPerStrand
		{
			get => teklaObject.PullPerStrand;
			set { teklaObject.PullPerStrand = value; }
		}

		public System.Collections.ArrayList Patterns
		{
			get => teklaObject.Patterns;
			set { teklaObject.Patterns = value; }
		}

		public System.Collections.ArrayList Unbondings
		{
			get => teklaObject.Unbondings;
			set { teklaObject.Unbondings = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Collections.ArrayList OnPlaneOffsets
		{
			get => teklaObject.OnPlaneOffsets;

		}

        

        

		public RebarStrand()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarStrand");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarStrand(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RebarStrand_
    {
        public static dynamic GetTSObject(RebarStrand dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarStrand FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarStrand)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarStrandArray_
    {
        public static dynamic GetTSObject(RebarStrand[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarStrand_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarStrand[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarStrand>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarStrand_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
