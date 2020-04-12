/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing.Automation
{

    public abstract class DrawingCreator 
    {

        

        internal dynamic teklaObject;



public static System.Boolean CreateDrawings(
	Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule Rule_,
	System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> aModelObjectIdentifier_,
	out Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum OperationStatus_
	)
{
	var Rule = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule_.GetTSObject(Rule_);
	var aModelObjectIdentifier = ListConverter.ToTSObjects(aModelObjectIdentifier_);
	var OperationStatus = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.GetTSObject(0);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.Automation.DrawingCreator", "CreateDrawings", Rule, aModelObjectIdentifier, ref OperationStatus);
	OperationStatus_ = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.FromTSObject(OperationStatus);
	return result;
}



public static System.Boolean CreateDrawings(
	Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule Rule_,
	Dynamic.Tekla.Structures.Identifier ModelObjectIdentifier_,
	out Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum OperationStatus_
	)
{
	var Rule = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule_.GetTSObject(Rule_);
	var ModelObjectIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ModelObjectIdentifier_);
	var OperationStatus = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.GetTSObject(0);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.Automation.DrawingCreator", "CreateDrawings", Rule, ModelObjectIdentifier, ref OperationStatus);
	OperationStatus_ = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum_.FromTSObject(OperationStatus);
	return result;
}



public static System.Boolean CreateDrawings(
	Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule Rule_,
	Dynamic.Tekla.Structures.Identifier ModelObjectIdentifier_
	)
{
	var Rule = Dynamic.Tekla.Structures.Drawing.Automation.AutoDrawingRule_.GetTSObject(Rule_);
	var ModelObjectIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ModelObjectIdentifier_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.Automation.DrawingCreator", "CreateDrawings", Rule, ModelObjectIdentifier);
	return result;
}






    }

    internal static class DrawingCreator_
    {
        public static dynamic GetTSObject(DrawingCreator dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingCreator FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingCreator_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingCreator[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DrawingCreator>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingCreator_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
