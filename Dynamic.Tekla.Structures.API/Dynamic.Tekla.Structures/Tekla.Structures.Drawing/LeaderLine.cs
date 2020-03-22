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
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PointList ElbowPoints
		{
			get => Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.ElbowPoints);
			set { teklaObject.ElbowPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LeaderLine.LeaderLineTypes LeaderLineType
		{
			get => Dynamic.Tekla.Structures.Drawing.LeaderLine.LeaderLineTypes_.FromTSObject(teklaObject.LeaderLineType);
			set { teklaObject.LeaderLineType = Dynamic.Tekla.Structures.Drawing.LeaderLine.LeaderLineTypes_.GetTSObject(value); }
		}

        

        

		public LeaderLine() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LeaderLine_
    {
        public static dynamic GetTSObject(LeaderLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LeaderLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.LeaderLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
