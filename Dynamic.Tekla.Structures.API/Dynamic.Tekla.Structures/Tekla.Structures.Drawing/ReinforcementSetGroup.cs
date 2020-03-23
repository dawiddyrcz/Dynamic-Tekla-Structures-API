/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReinforcementSetGroup  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementSetGroupAttributes_.GetTSObject(value); }
		}

		public System.Double ReinforcementCustomPosition
		{
			get => teklaObject.ReinforcementCustomPosition;
			set { teklaObject.ReinforcementCustomPosition = value; }
		}

        

        

		public ReinforcementSetGroup() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> GetModelIdentifiers()
		{
			return teklaObject.GetModelIdentifiers();
		}





    }

    internal static class ReinforcementSetGroup_
    {
        public static dynamic GetTSObject(ReinforcementSetGroup dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementSetGroup FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementSetGroup)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementSetGroupArray_
    {
        public static dynamic GetTSObject(ReinforcementSetGroup[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementSetGroup_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementSetGroup[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementSetGroup>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementSetGroup_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
