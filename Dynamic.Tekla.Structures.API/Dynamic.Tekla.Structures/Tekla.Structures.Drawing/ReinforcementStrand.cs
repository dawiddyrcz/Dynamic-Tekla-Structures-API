/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ReinforcementStrand  : Dynamic.Tekla.Structures.Drawing.ReinforcementBase
    {

		public Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementStrandAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementStrandAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.ReinforcementBase.ReinforcementStrandAttributes_.GetTSObject(value); }
		}

		public System.Double ReinforcementCustomPosition
		{
			get => teklaObject.ReinforcementCustomPosition;
			set { teklaObject.ReinforcementCustomPosition = value; }
		}

        

        

		public ReinforcementStrand() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ReinforcementStrand_
    {
        public static dynamic GetTSObject(ReinforcementStrand dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementStrand FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ReinforcementStrand)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementStrandArray_
    {
        public static dynamic GetTSObject(ReinforcementStrand[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementStrand_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementStrand[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcementStrand>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementStrand_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
