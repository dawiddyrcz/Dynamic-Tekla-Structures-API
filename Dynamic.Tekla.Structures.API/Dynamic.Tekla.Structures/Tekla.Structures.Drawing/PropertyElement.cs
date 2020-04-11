/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PropertyElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public System.String Value
		{
			get
			{
				try {
					return teklaObject.Value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value", ex); }
			}
			set
			{
				try {
					teklaObject.Value = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font", ex); }
			}
			set
			{
				try {
				teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PropertyType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(teklaObject.PropertyType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PropertyType", ex); }
			}
			set
			{
				try {
				teklaObject.PropertyType = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PropertyType", ex); }
			}
		}

        

        

		internal PropertyElement() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PropertyElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PropertyElement(Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PropertyType)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.GetTSObject(PropertyType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PropertyElement", args);
		}




    public  class PropertyElementType 
    {

        

        internal dynamic teklaObject;

		internal PropertyElementType() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PropertyElementType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean IsEqual(
	System.Object ObjectToCompare
	)
{
	
    try
    {
        	var result = teklaObject.IsEqual(ObjectToCompare);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsEqual), ex);
    }
}





    public abstract class BoltMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType BoltLength()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "BoltLength");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType BoltDiameter()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "BoltDiameter");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType HoleDiameter()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "HoleDiameter");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Material");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Standard()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Standard");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ShortName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "ShortName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType FullName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "FullName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType AssemblyType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "AssemblyType");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType NumberOfBolts()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "NumberOfBolts");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotLengthX()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotLengthX");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotLengthY()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotLengthY");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotHeight()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotHeight");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotLength()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotLength");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Size()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Size");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Countersunk()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Countersunk");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType GageOfOutstandingLeg()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "GageOfOutstandingLeg");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CenterToCenterDistance()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "CenterToCenterDistance");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class BoltMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(BoltMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BoltMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BoltMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(BoltMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BoltMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BoltMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BoltMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BoltMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class PartMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType AssemblyPosition()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "AssemblyPosition");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PartPosition()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "PartPosition");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Profile()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Profile");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Material");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Name");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Class");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Finish()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Finish");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Size()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Size");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Length()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Length");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Camber()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Camber");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType FittingsNsFs()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "FittingsNsFs");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType FaceDirection()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "FaceDirection");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType GageOfOutstandingLeg()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "GageOfOutstandingLeg");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CenterToCenterDistance()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "CenterToCenterDistance");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType RotationAngle()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "RotationAngle");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class PartMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(PartMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PartMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PartMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(PartMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PartMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PartMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PartMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PartMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class ReinforcementMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Name");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Grade()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Grade");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Diameter()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Diameter");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Class");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Length()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Length");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Number()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Number");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Position()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Position");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Shape()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Shape");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Weight()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Weight");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Cc()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Cc");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMin()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcMin");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMax()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcMax");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcExact()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcExact");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcTarget()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcTarget");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class ReinforcementMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ReinforcementMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReinforcementMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(ReinforcementMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReinforcementMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class ReinforcementMeshMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Name");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Grade()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Grade");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Size()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Size");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Class");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType MeshLength()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "MeshLength");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType MeshWidth()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "MeshWidth");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Number()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Number");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Position()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Position");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Shape()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Shape");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Weight()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Weight");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcLongitudinal()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcLongitudinal");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMinLongitudinal()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMinLongitudinal");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMaxLongitudinal()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMaxLongitudinal");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcExactLongitudinal()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcExactLongitudinal");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcCrossing()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcCrossing");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMinCrossing()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMinCrossing");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMaxCrossing()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMaxCrossing");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcExactCrossing()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcExactCrossing");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DiameterLongitudinal()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "DiameterLongitudinal");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DiameterCrossing()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "DiameterCrossing");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class ReinforcementMeshMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ReinforcementMeshMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReinforcementMeshMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcementMeshMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(ReinforcementMeshMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcementMeshMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcementMeshMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReinforcementMeshMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcementMeshMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class MergedMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType BlockPrefix()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "BlockPrefix");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SingleMarkContent()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "SingleMarkContent");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DistancesBetweenGroups()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "DistancesBetweenGroups");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SymbolSeparatingBlocksInMarks()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "SymbolSeparatingBlocksInMarks");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class MergedMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(MergedMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MergedMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MergedMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(MergedMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MergedMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MergedMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MergedMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MergedMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class SurfacingMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Name");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Material");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Class");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Code()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Code");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SurfaceTreatmentName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "SurfaceTreatmentName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class SurfacingMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(SurfacingMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SurfacingMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfacingMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(SurfacingMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SurfacingMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SurfacingMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SurfacingMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SurfacingMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class ChamferMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "Name");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Length()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "Length");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DX()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "DX");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DY()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "DY");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class ChamferMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ChamferMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ChamferMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ChamferMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(ChamferMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ChamferMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ChamferMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ChamferMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ChamferMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class ConnectionMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Code()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "Code");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "Name");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DSTVCode()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "DSTVCode");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ConnectionNumber()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "ConnectionNumber");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType RunningNumber()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "RunningNumber");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Group()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "Group");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ConnectionError()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "ConnectionError");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class ConnectionMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ConnectionMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ConnectionMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ConnectionMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(ConnectionMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ConnectionMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ConnectionMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ConnectionMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ConnectionMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class DetailMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DetailName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes", "DetailName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes", "SourceDrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes", "SourceDrawingNameWhenMoved");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class DetailMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(DetailMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DetailMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DetailMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(DetailMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DetailMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DetailMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DetailMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DetailMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class SectionMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SectionName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes", "SectionName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes", "SourceDrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes", "SourceDrawingNameWhenMoved");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class SectionMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(SectionMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SectionMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(SectionMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SectionMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class ViewLabelMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ViewName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "ViewName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Scale()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "Scale");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "DrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "SourceDrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "SourceDrawingNameWhenMoved");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class ViewLabelMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ViewLabelMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewLabelMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewLabelMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(ViewLabelMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewLabelMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewLabelMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewLabelMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewLabelMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class DetailViewLabelMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DetailName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "DetailName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Scale()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "Scale");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "DrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "SourceDrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "SourceDrawingNameWhenMoved");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class DetailViewLabelMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(DetailViewLabelMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DetailViewLabelMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DetailViewLabelMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(DetailViewLabelMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DetailViewLabelMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DetailViewLabelMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DetailViewLabelMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DetailViewLabelMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class SectionViewLabelMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SectionName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "SectionName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Scale()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "Scale");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "DrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "SourceDrawingName");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "SourceDrawingNameWhenMoved");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class SectionViewLabelMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(SectionViewLabelMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SectionViewLabelMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionViewLabelMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(SectionViewLabelMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionViewLabelMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionViewLabelMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SectionViewLabelMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionViewLabelMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public abstract class PourMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "Material");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "Name");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "Class");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PourNumber()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "PourNumber");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PourType()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "PourType");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PourConcreteMixture()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "PourConcreteMixture");
	var _result = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
	return _result;
}






    }

    internal static class PourMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(PourMarkPropertyElementTypes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PourMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PourMarkPropertyElementTypesArray_
    {
        public static dynamic GetTSObject(PourMarkPropertyElementTypes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PourMarkPropertyElementTypes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PourMarkPropertyElementTypes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PourMarkPropertyElementTypes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PourMarkPropertyElementTypes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class PropertyElementType_
    {
        public static dynamic GetTSObject(PropertyElementType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PropertyElementType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PropertyElementTypeArray_
    {
        public static dynamic GetTSObject(PropertyElementType[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PropertyElementType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PropertyElementType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PropertyElementType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PropertyElementType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class PropertyElement_
    {
        public static dynamic GetTSObject(PropertyElement dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PropertyElement FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.PropertyElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PropertyElementArray_
    {
        public static dynamic GetTSObject(PropertyElement[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PropertyElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PropertyElement[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PropertyElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PropertyElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
