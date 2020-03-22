/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class PickerInputWithinAView  : Dynamic.Tekla.Structures.Drawing.PickerInput
    {

		public Dynamic.Tekla.Structures.Drawing.ViewBase PickedView
		{
			get => Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(teklaObject.PickedView);
			set { teklaObject.PickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(value); }
		}

        

        


		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PickerInputWithinAView_
    {
        public static dynamic GetTSObject(PickerInputWithinAView dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PickerInputWithinAView FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PickerInputWithinAView)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
