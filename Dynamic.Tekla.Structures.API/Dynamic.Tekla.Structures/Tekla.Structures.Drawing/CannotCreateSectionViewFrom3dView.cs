/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotCreateSectionViewFrom3dView  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public CannotCreateSectionViewFrom3dView() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CannotCreateSectionViewFrom3dView(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CannotCreateSectionViewFrom3dView(System.String Message)
		{
			var args = new object[1];
			args[0] = Message;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotCreateSectionViewFrom3dView", args);
		}





    }

    internal static class CannotCreateSectionViewFrom3dView_
    {
        public static dynamic GetTSObject(CannotCreateSectionViewFrom3dView dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static CannotCreateSectionViewFrom3dView FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CannotCreateSectionViewFrom3dView)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CannotCreateSectionViewFrom3dViewArray_
    {
        public static dynamic GetTSObject(CannotCreateSectionViewFrom3dView[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CannotCreateSectionViewFrom3dView_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CannotCreateSectionViewFrom3dView[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<CannotCreateSectionViewFrom3dView>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CannotCreateSectionViewFrom3dView_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
