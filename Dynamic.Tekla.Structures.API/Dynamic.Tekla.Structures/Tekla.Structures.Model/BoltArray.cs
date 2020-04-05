/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BoltArray  : Dynamic.Tekla.Structures.Model.BoltGroup
    {

        

        

		public BoltArray()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltArray");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BoltArray(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean AddBoltDistX(System.Double DistX)
		{
			try {
			return teklaObject.AddBoltDistX(DistX);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddBoltDistX()"); }
		}

		public System.Boolean AddBoltDistY(System.Double DistY)
		{
			try {
			return teklaObject.AddBoltDistY(DistY);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddBoltDistY()"); }
		}

		public System.Boolean RemoveBoltDistX(System.Int32 Index)
		{
			try {
			return teklaObject.RemoveBoltDistX(Index);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveBoltDistX()"); }
		}

		public System.Boolean RemoveBoltDistY(System.Int32 Index)
		{
			try {
			return teklaObject.RemoveBoltDistY(Index);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveBoltDistY()"); }
		}

		public System.Int32 GetBoltDistXCount()
		{
			try {
			return teklaObject.GetBoltDistXCount();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetBoltDistXCount()"); }
		}

		public System.Int32 GetBoltDistYCount()
		{
			try {
			return teklaObject.GetBoltDistYCount();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetBoltDistYCount()"); }
		}

		public System.Double GetBoltDistX(System.Int32 Index)
		{
			try {
			return teklaObject.GetBoltDistX(Index);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetBoltDistX()"); }
		}

		public System.Double GetBoltDistY(System.Int32 Index)
		{
			try {
			return teklaObject.GetBoltDistY(Index);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetBoltDistY()"); }
		}

		public System.Boolean SetBoltDistX(System.Int32 Index, System.Double DistX)
		{
			try {
			return teklaObject.SetBoltDistX(Index, DistX);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetBoltDistX()"); }
		}

		public System.Boolean SetBoltDistY(System.Int32 Index, System.Double DistY)
		{
			try {
			return teklaObject.SetBoltDistY(Index, DistY);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetBoltDistY()"); }
		}





    }

    internal static class BoltArray_
    {
        public static dynamic GetTSObject(BoltArray dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BoltArray FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BoltArray)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BoltArrayArray_
    {
        public static dynamic GetTSObject(BoltArray[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BoltArray_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BoltArray[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BoltArray>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BoltArray_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
