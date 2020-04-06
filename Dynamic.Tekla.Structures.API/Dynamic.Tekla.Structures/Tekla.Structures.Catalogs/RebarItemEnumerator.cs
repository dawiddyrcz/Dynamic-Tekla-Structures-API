/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class RebarItemEnumerator 
    {

		public Dynamic.Tekla.Structures.Catalogs.RebarItem Current
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(teklaObject.Current);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Current", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal RebarItemEnumerator() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarItemEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean MoveNext()
		{
			try {
			var result = teklaObject.MoveNext();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("MoveNext()", ex); }
		}

		public void Reset()
		{
			try {
			teklaObject.Reset();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Reset()", ex); }
		}

		public System.Int32 GetSize()
		{
			try {
			var result = teklaObject.GetSize();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSize()", ex); }
		}

		public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(System.String Grade, System.String Size, System.Double BendRadius)
		{
			var parameters = new object[3];
			parameters[0] = Grade;
			parameters[1] = Size;
			parameters[2] = BendRadius;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", parameters);
			return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(System.String Grade, System.String Size, System.String Usage)
		{
			var parameters = new object[3];
			parameters[0] = Grade;
			parameters[1] = Size;
			parameters[2] = Usage;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", parameters);
			return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(System.String Grade, System.String Size)
		{
			var parameters = new object[2];
			parameters[0] = Grade;
			parameters[1] = Size;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", parameters);
			return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(System.String Grade, System.Double Diameter, System.Double BendRadius, System.Boolean UseNominalDiameter)
		{
			var parameters = new object[4];
			parameters[0] = Grade;
			parameters[1] = Diameter;
			parameters[2] = BendRadius;
			parameters[3] = UseNominalDiameter;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", parameters);
			return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(System.String Grade, System.Double Diameter, System.String Usage, System.Boolean UseNominalDiameter)
		{
			var parameters = new object[4];
			parameters[0] = Grade;
			parameters[1] = Diameter;
			parameters[2] = Usage;
			parameters[3] = UseNominalDiameter;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", parameters);
			return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Catalogs.RebarItem SelectRebarItem(System.String Grade, System.Double Diameter, System.Boolean UseNominalDiameter)
		{
			var parameters = new object[3];
			parameters[0] = Grade;
			parameters[1] = Diameter;
			parameters[2] = UseNominalDiameter;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.RebarItemEnumerator", "SelectRebarItem", parameters);
			return Dynamic.Tekla.Structures.Catalogs.RebarItem_.FromTSObject(result);
		}





    }

    internal static class RebarItemEnumerator_
    {
        public static dynamic GetTSObject(RebarItemEnumerator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarItemEnumerator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarItemEnumeratorArray_
    {
        public static dynamic GetTSObject(RebarItemEnumerator[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarItemEnumerator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarItemEnumerator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarItemEnumerator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarItemEnumerator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
