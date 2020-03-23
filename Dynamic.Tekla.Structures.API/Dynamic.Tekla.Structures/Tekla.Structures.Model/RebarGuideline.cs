/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarGuideline 
    {

		public System.Int32 Id
		{
			get => teklaObject.Id;
			set { teklaObject.Id = value; }
		}

		public Dynamic.Tekla.Structures.Model.Contour Curve
		{
			get => Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Curve);
			set { teklaObject.Curve = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarSpacing Spacing
		{
			get => Dynamic.Tekla.Structures.Model.RebarSpacing_.FromTSObject(teklaObject.Spacing);
			set { teklaObject.Spacing = Dynamic.Tekla.Structures.Model.RebarSpacing_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public RebarGuideline()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGuideline");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarGuideline(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RebarGuideline_
    {
        public static dynamic GetTSObject(RebarGuideline dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static RebarGuideline FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarGuideline)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarGuidelineArray_
    {
        public static dynamic GetTSObject(RebarGuideline[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarGuideline_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarGuideline[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<RebarGuideline>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarGuideline_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
