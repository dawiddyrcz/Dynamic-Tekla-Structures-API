/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DimensionLink  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

        

        

		internal DimensionLink() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DimensionLink(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DimensionLink(Dynamic.Tekla.Structures.Drawing.StraightDimensionSet Dimension1, Dynamic.Tekla.Structures.Drawing.StraightDimensionSet Dimension2)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.GetTSObject(Dimension1);
			args[1] = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.GetTSObject(Dimension2);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionLink", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet GetDimension1()
		{
			return Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(teklaObject.GetDimension1());
		}

		public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet GetDimension2()
		{
			return Dynamic.Tekla.Structures.Drawing.StraightDimensionSet_.FromTSObject(teklaObject.GetDimension2());
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}





    }

    internal static class DimensionLink_
    {
        public static dynamic GetTSObject(DimensionLink dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DimensionLink FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionLink)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DimensionLinkArray_
    {
        public static dynamic GetTSObject(DimensionLink[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DimensionLink_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DimensionLink[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DimensionLink>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DimensionLink_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
