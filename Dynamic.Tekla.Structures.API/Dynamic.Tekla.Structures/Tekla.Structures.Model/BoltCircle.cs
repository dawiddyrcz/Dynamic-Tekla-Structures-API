/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BoltCircle  : Dynamic.Tekla.Structures.Model.BoltGroup
    {

		public System.Double NumberOfBolts
		{
			get => teklaObject.NumberOfBolts;
			set { teklaObject.NumberOfBolts = value; }
		}

		public System.Double Diameter
		{
			get => teklaObject.Diameter;
			set { teklaObject.Diameter = value; }
		}

        

        

		public BoltCircle()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltCircle");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BoltCircle(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class BoltCircle_
    {
        public static dynamic GetTSObject(BoltCircle dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BoltCircle FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BoltCircle)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BoltCircleArray_
    {
        public static dynamic GetTSObject(BoltCircle[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BoltCircle_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BoltCircle[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BoltCircle>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BoltCircle_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
