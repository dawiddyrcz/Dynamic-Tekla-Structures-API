/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class NewLineElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

        

        

		public NewLineElement()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.NewLineElement");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NewLineElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.String GetUnformattedString()
		{
			return teklaObject.GetUnformattedString();
		}





    }

    internal static class NewLineElement_
    {
        public static dynamic GetTSObject(NewLineElement dynObject)
        {
            return dynObject.teklaObject;
        }

        public static NewLineElement FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.NewLineElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NewLineElementArray_
    {
        public static dynamic GetTSObject(NewLineElement[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NewLineElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NewLineElement[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<NewLineElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NewLineElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
