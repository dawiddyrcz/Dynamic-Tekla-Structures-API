/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class UnitAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.Units Unit
		{
			get => Dynamic.Tekla.Structures.Drawing.Units_.FromTSObject(teklaObject.Unit);
			set { teklaObject.Unit = Dynamic.Tekla.Structures.Drawing.Units_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.FormatTypes Format
		{
			get => Dynamic.Tekla.Structures.Drawing.FormatTypes_.FromTSObject(teklaObject.Format);
			set { teklaObject.Format = Dynamic.Tekla.Structures.Drawing.FormatTypes_.GetTSObject(value); }
		}

        

        

		public UnitAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UnitAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public UnitAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public UnitAttributes(Dynamic.Tekla.Structures.Drawing.Units unit, Dynamic.Tekla.Structures.Drawing.FormatTypes format)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.Units_.GetTSObject(unit);
			args[1] = Dynamic.Tekla.Structures.Drawing.FormatTypes_.GetTSObject(format);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UnitAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class UnitAttributes_
    {
        public static dynamic GetTSObject(UnitAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static UnitAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UnitAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UnitAttributesArray_
    {
        public static dynamic GetTSObject(UnitAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UnitAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UnitAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<UnitAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UnitAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
