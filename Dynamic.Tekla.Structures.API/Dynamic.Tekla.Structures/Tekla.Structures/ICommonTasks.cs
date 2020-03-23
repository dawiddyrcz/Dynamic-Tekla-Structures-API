/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class ICommonTasks 
    {

        

        internal dynamic teklaObject;


		public void CreateGeneralArrangementDrawingFromTemplate(System.String name)
		{
			teklaObject.CreateGeneralArrangementDrawingFromTemplate(name);
		}

		public void OpenAssemblyDrawingProperties(System.String name)
		{
			teklaObject.OpenAssemblyDrawingProperties(name);
		}

		public void OpenAutoDrawingScript(System.String name)
		{
			teklaObject.OpenAutoDrawingScript(name);
		}

		public void OpenCastUnitDrawingProperties(System.String name)
		{
			teklaObject.OpenCastUnitDrawingProperties(name);
		}

		public void OpenDrawingList()
		{
			teklaObject.OpenDrawingList();
		}

		public void OpenGeneralArrangementDrawingProperties(System.String name)
		{
			teklaObject.OpenGeneralArrangementDrawingProperties(name);
		}

		public void OpenNumberingSettings()
		{
			teklaObject.OpenNumberingSettings();
		}

		public void OpenSinglePartDrawingProperties(System.String name)
		{
			teklaObject.OpenSinglePartDrawingProperties(name);
		}

		public void PerformNumbering(System.Boolean fullNumbering)
		{
			teklaObject.PerformNumbering(fullNumbering);
		}





    }

    internal static class ICommonTasks_
    {
        public static dynamic GetTSObject(ICommonTasks dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ICommonTasks FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.ICommonTasks)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ICommonTasksArray_
    {
        public static dynamic GetTSObject(ICommonTasks[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ICommonTasks_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ICommonTasks[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ICommonTasks>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ICommonTasks_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
