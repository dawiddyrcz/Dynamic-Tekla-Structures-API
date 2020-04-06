/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class SpiralBeamDataException  : System.Exception
    {

		public Dynamic.Tekla.Structures.Model.SpiralBeam.ErrorStatus ErrorStatus
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.SpiralBeam.ErrorStatus_.FromTSObject(teklaObject.ErrorStatus);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ErrorStatus", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal SpiralBeamDataException() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SpiralBeamDataException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SpiralBeamDataException(Dynamic.Tekla.Structures.Model.SpiralBeam.ErrorStatus status, System.String message)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.SpiralBeam.ErrorStatus_.GetTSObject(status);
			args[1] = message;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeamDataException", args);
		}





    }

    internal static class SpiralBeamDataException_
    {
        public static dynamic GetTSObject(SpiralBeamDataException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SpiralBeamDataException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.SpiralBeamDataException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SpiralBeamDataExceptionArray_
    {
        public static dynamic GetTSObject(SpiralBeamDataException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SpiralBeamDataException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SpiralBeamDataException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SpiralBeamDataException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SpiralBeamDataException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
