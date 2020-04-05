/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class LeaderLine  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			}
			set
			{
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			}
			set
			{
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PointList ElbowPoints
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.ElbowPoints);
			}
			set
			{
				teklaObject.ElbowPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LeaderLine.LeaderLineTypes LeaderLineType
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.LeaderLine.LeaderLineTypes_.FromTSObject(teklaObject.LeaderLineType);
			}
			set
			{
				teklaObject.LeaderLineType = Dynamic.Tekla.Structures.Drawing.LeaderLine.LeaderLineTypes_.GetTSObject(value);
			}
		}

        

        

		internal LeaderLine() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LeaderLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum LeaderLineTypes
    {
			Undefined,
			NormalLeaderLine,
			SupportLeaderLine,
			ExtensionLeaderLine        
    }

    internal static class LeaderLineTypes_
    {
        public static dynamic GetTSObject(LeaderLineTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.LeaderLine.LeaderLineTypes").GetType();

            switch (dynEnum)
            {
				case LeaderLineTypes.Undefined:
					return System.Enum.Parse(tsType, "Undefined");
				case LeaderLineTypes.NormalLeaderLine:
					return System.Enum.Parse(tsType, "NormalLeaderLine");
				case LeaderLineTypes.SupportLeaderLine:
					return System.Enum.Parse(tsType, "SupportLeaderLine");
				case LeaderLineTypes.ExtensionLeaderLine:
					return System.Enum.Parse(tsType, "ExtensionLeaderLine");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LeaderLineTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Undefined", System.StringComparison.InvariantCulture))
				return LeaderLineTypes.Undefined;
			else if (tsEnumValue.Equals("NormalLeaderLine", System.StringComparison.InvariantCulture))
				return LeaderLineTypes.NormalLeaderLine;
			else if (tsEnumValue.Equals("SupportLeaderLine", System.StringComparison.InvariantCulture))
				return LeaderLineTypes.SupportLeaderLine;
			else if (tsEnumValue.Equals("ExtensionLeaderLine", System.StringComparison.InvariantCulture))
				return LeaderLineTypes.ExtensionLeaderLine;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LeaderLine_
    {
        public static dynamic GetTSObject(LeaderLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LeaderLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LeaderLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LeaderLineArray_
    {
        public static dynamic GetTSObject(LeaderLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LeaderLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LeaderLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LeaderLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LeaderLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
