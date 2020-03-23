/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class DimensionBase  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get => Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
			set { teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value); }
		}

        

        


		public Dynamic.Tekla.Structures.Drawing.DimensionSetBase GetDimensionSet()
		{
			return Dynamic.Tekla.Structures.Drawing.DimensionSetBase_.FromTSObject(teklaObject.GetDimensionSet());
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBase GetDimensionSet(System.Boolean Select)
		{
			return Dynamic.Tekla.Structures.Drawing.DimensionSetBase_.FromTSObject(teklaObject.GetDimensionSet(Select));
		}





    }

    internal static class DimensionBase_
    {
        public static dynamic GetTSObject(DimensionBase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DimensionBase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionBase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    