/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ContainerElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get => Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
			set { teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value); }
		}

		public System.Int32 Count
		{
			get => teklaObject.Count;

		}

		public System.Boolean IsSynchronized
		{
			get => teklaObject.IsSynchronized;

		}

		public System.Object SyncRoot
		{
			get => teklaObject.SyncRoot;

		}

        

        

		public ContainerElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ContainerElement");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ContainerElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}

		public void CopyTo(System.Array array, System.Int32 index)
		{
			teklaObject.CopyTo(array, index);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public void Add(Dynamic.Tekla.Structures.Drawing.ElementBase value)
		{
			teklaObject.Add(Dynamic.Tekla.Structures.Drawing.ElementBase_.GetTSObject(value));
		}

		public void Clear()
		{
			teklaObject.Clear();
		}

		public System.String GetUnformattedString()
		{
			return teklaObject.GetUnformattedString();
		}





    }

    internal static class ContainerElement_
    {
        public static dynamic GetTSObject(ContainerElement dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ContainerElement FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ContainerElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ContainerElementArray_
    {
        public static dynamic GetTSObject(ContainerElement[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ContainerElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ContainerElement[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ContainerElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ContainerElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
