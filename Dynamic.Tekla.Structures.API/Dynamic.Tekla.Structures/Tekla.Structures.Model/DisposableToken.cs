/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class DisposableToken 
    {

        

        internal dynamic teklaObject;

		internal DisposableToken() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DisposableToken(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DisposableToken(System.Action disposed)
		{
			var args = new object[1];
			args[0] = disposed;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.DisposableToken", args);
		}

		public void Dispose()
		{
			teklaObject.Dispose();
		}





    }

    internal static class DisposableToken_
    {
        public static dynamic GetTSObject(DisposableToken dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DisposableToken FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.DisposableToken)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DisposableTokenArray_
    {
        public static dynamic GetTSObject(DisposableToken[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DisposableToken_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DisposableToken[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DisposableToken>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DisposableToken_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
