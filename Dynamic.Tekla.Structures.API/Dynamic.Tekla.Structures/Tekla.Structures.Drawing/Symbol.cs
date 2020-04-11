/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Symbol  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.InsertionPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InsertionPoint", ex); }
			}
			set
			{
				try {
				teklaObject.InsertionPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InsertionPoint", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.SymbolInfo SymbolInfo
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.SymbolInfo_.FromTSObject(teklaObject.SymbolInfo);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolInfo", ex); }
			}
			set
			{
				try {
				teklaObject.SymbolInfo = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolInfo", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingBase Placing
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(teklaObject.Placing);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Placing", ex); }
			}
			set
			{
				try {
				teklaObject.Placing = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Placing", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable", ex); }
			}
			set
			{
				try {
				teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable", ex); }
			}
		}

        

        

		internal Symbol() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Symbol(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Symbol(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol", args);
		}
		public Symbol(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol", args);
		}
		public Symbol(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.SymbolInfo SymbolInfo)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(SymbolInfo);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol", args);
		}
		public Symbol(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.SymbolInfo SymbolInfo, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(SymbolInfo);
			args[3] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol", args);
		}
		public Symbol(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.SymbolInfo SymbolInfo, Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes Attributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(SymbolInfo);
			args[3] = Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes_.GetTSObject(Attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol", args);
		}
		public Symbol(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint, Dynamic.Tekla.Structures.Drawing.SymbolInfo SymbolInfo, Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes Attributes, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(InsertionPoint);
			args[2] = Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(SymbolInfo);
			args[3] = Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes_.GetTSObject(Attributes);
			args[4] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol", args);
		}


public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
{

    try
    {
        	var result = teklaObject.GetObjectAlignedBoundingBox();

        	var _result = Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjectAlignedBoundingBox), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
{

    try
    {
        	var result = teklaObject.GetAxisAlignedBoundingBox();

        	var _result = Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAxisAlignedBoundingBox), ex);
    }
}



public System.Boolean MoveObjectRelative(
	Dynamic.Tekla.Structures.Geometry3d.Vector MoveVector_
	)
{
	var MoveVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(MoveVector_);
    try
    {
        	var result = teklaObject.MoveObjectRelative(MoveVector);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MoveObjectRelative), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
{

    try
    {
        	var result = teklaObject.GetObjects();

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
    }
}





    public  class SymbolAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
		}

		public System.Double Height
		{
			get
			{
				try {
					return teklaObject.Height;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height", ex); }
			}
			set
			{
				try {
					teklaObject.Height = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height", ex); }
			}
		}

		public System.Double Angle
		{
			get
			{
				try {
					return teklaObject.Angle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle", ex); }
			}
			set
			{
				try {
					teklaObject.Angle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame", ex); }
			}
			set
			{
				try {
				teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PreferredPlacing
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(teklaObject.PreferredPlacing);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PreferredPlacing", ex); }
			}
			set
			{
				try {
				teklaObject.PreferredPlacing = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PreferredPlacing", ex); }
			}
		}

        

        

		public SymbolAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol.SymbolAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SymbolAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SymbolAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Symbol.SymbolAttributes", args);
		}





    }

    internal static class SymbolAttributes_
    {
        public static dynamic GetTSObject(SymbolAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SymbolAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Symbol.SymbolAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SymbolAttributesArray_
    {
        public static dynamic GetTSObject(SymbolAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SymbolAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SymbolAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SymbolAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SymbolAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Symbol_
    {
        public static dynamic GetTSObject(Symbol dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Symbol FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Symbol)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SymbolArray_
    {
        public static dynamic GetTSObject(Symbol[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Symbol_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Symbol[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Symbol>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Symbol_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
