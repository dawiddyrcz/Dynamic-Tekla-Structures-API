/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class IModel 
    {

		public Dynamic.Tekla.Structures.ModelFolder Folder
		{
			get => Dynamic.Tekla.Structures.ModelFolder_.FromTSObject(teklaObject.Folder);

		}

		public System.String Name
		{
			get => teklaObject.Name;

		}

        

        internal dynamic teklaObject;


		public void add_Changed(System.EventHandler value)
		{
			teklaObject.add_Changed(value);
		}

		public void remove_Changed(System.EventHandler value)
		{
			teklaObject.remove_Changed(value);
		}

		public void add_Loaded(System.EventHandler value)
		{
			teklaObject.add_Loaded(value);
		}

		public void remove_Loaded(System.EventHandler value)
		{
			teklaObject.remove_Loaded(value);
		}

		public void add_Numbering(System.EventHandler value)
		{
			teklaObject.add_Numbering(value);
		}

		public void remove_Numbering(System.EventHandler value)
		{
			teklaObject.remove_Numbering(value);
		}

		public void add_Saved(System.EventHandler value)
		{
			teklaObject.add_Saved(value);
		}

		public void remove_Saved(System.EventHandler value)
		{
			teklaObject.remove_Saved(value);
		}





    }

    internal static class IModel_
    {
        public static dynamic GetTSObject(IModel dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IModel FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.IModel)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IModelArray_
    {
        public static dynamic GetTSObject(IModel[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IModel_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IModel[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IModel>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IModel_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    