/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class IPreferredPlacing 
    {

		public Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PreferredPlacing
		{
			get => Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(teklaObject.PreferredPlacing);
			set { teklaObject.PreferredPlacing = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;






    }

    internal static class IPreferredPlacing_
    {
        public static dynamic GetTSObject(IPreferredPlacing dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IPreferredPlacing FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.IPreferredPlacing)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    