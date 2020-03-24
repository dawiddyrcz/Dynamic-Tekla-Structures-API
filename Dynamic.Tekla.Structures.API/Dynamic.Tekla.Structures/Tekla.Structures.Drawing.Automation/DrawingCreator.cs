/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.Automation
{

    public abstract class DrawingCreator 
    {

        

        internal dynamic teklaObject;


		public static System.Boolean CreateDrawings(Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule Rule, System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> aModelObjectIdentifier, out Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum OperationStatus)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule_.GetTSObject(Rule);
			parameters[1] = aModelObjectIdentifier;
			OperationStatus = new Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum();
			parameters[2] = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.GetTSObject(OperationStatus);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.Automation.DrawingCreator", "CreateDrawings", parameters);
			OperationStatus = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.FromTSObject(parameters[2]);
			return result;
		}

		public static System.Boolean CreateDrawings(Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule Rule, Dynamic.Tekla.Structures.Identifier ModelObjectIdentifier, out Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum OperationStatus)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule_.GetTSObject(Rule);
			parameters[1] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ModelObjectIdentifier);
			OperationStatus = new Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum();
			parameters[2] = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.GetTSObject(OperationStatus);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.Automation.DrawingCreator", "CreateDrawings", parameters);
			OperationStatus = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.FromTSObject(parameters[2]);
			return result;
		}

		public static System.Boolean CreateDrawings(Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule Rule, Dynamic.Tekla.Structures.Identifier ModelObjectIdentifier)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule_.GetTSObject(Rule);
			parameters[1] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ModelObjectIdentifier);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.Automation.DrawingCreator", "CreateDrawings", parameters);
			return result;
		}





    }

    internal static class DrawingCreator_
    {
        public static dynamic GetTSObject(DrawingCreator dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingCreator FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Automation.DrawingCreator)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingCreatorArray_
    {
        public static dynamic GetTSObject(DrawingCreator[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingCreator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingCreator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<DrawingCreator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingCreator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
