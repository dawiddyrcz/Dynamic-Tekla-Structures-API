/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CustomLineType  : Dynamic.Tekla.Structures.Drawing.LineTypes
    {

		public System.String Name
		{
			get => teklaObject.Name;

		}

		public System.String Description
		{
			get => teklaObject.Description;

		}

		public System.Collections.Generic.List<System.Double> LineDescription
		{
			get => teklaObject.LineDescription;
			set { teklaObject.LineDescription = value; }
		}

        

        

		internal CustomLineType() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomLineType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


		public static System.Boolean operator ==(Dynamic.Tekla.Structures.Drawing.CustomLineType o1, Dynamic.Tekla.Structures.Drawing.CustomLineType o2)
		{
			if (o1 is null) throw new System.ArgumentNullException("o1");
			if (o2 is null) throw new System.ArgumentNullException("o2");
			var o1Tek = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(o2);
			return o1Tek == o2Tek;
		}
		public static System.Boolean operator !=(Dynamic.Tekla.Structures.Drawing.CustomLineType o1, Dynamic.Tekla.Structures.Drawing.CustomLineType o2)
		{
			if (o1 is null) throw new System.ArgumentNullException("o1");
			if (o2 is null) throw new System.ArgumentNullException("o2");
			var o1Tek = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Drawing.CustomLineType_.GetTSObject(o2);
			return o1Tek != o2Tek;
		}



    }

    internal static class CustomLineType_
    {
        public static dynamic GetTSObject(CustomLineType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CustomLineType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CustomLineType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomLineTypeArray_
    {
        public static dynamic GetTSObject(CustomLineType[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomLineType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomLineType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CustomLineType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomLineType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
