/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PickerInterruptedException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public PickerInterruptedException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PickerInterruptedException");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PickerInterruptedException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class PickerInterruptedException_
    {
        public static dynamic GetTSObject(PickerInterruptedException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PickerInterruptedException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PickerInterruptedException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerInterruptedExceptionArray_
    {
        public static dynamic GetTSObject(PickerInterruptedException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PickerInterruptedException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PickerInterruptedException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PickerInterruptedException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PickerInterruptedException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
