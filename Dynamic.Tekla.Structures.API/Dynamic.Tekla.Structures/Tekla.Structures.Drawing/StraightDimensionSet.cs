/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class StraightDimensionSet  : Dynamic.Tekla.Structures.Drawing.DimensionSetBase
    {

		public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
		}

		public System.Double Distance
		{
			get
			{
				try {
					return teklaObject.Distance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance"); }
			}
			set
			{
				try {
					teklaObject.Distance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Distance"); }
			}
		}

		public System.Double LeftTagLineOffset
		{
			get
			{
				try {
					return teklaObject.LeftTagLineOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftTagLineOffset"); }
			}
			set
			{
				try {
					teklaObject.LeftTagLineOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftTagLineOffset"); }
			}
		}

		public System.Double RightTagLineOffset
		{
			get
			{
				try {
					return teklaObject.RightTagLineOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightTagLineOffset"); }
			}
			set
			{
				try {
					teklaObject.RightTagLineOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightTagLineOffset"); }
			}
		}

        

        

		internal StraightDimensionSet() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StraightDimensionSet(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public static System.Collections.Generic.List<System.String> GetAllExcludePartsAccordingToFilter()
		{
			var parameters = new object[0];
			var result = (System.Collections.Generic.List<System.String>) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.StraightDimensionSet", "GetAllExcludePartsAccordingToFilter", parameters);
			return result;
		}




    public  class StraightDimensionSetAttributes  : Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes CombinedDimension
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes_.FromTSObject(teklaObject.CombinedDimension);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CombinedDimension"); }
			}
			set
			{
				try {
				teklaObject.CombinedDimension = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CombinedDimension"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes DimensionType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.FromTSObject(teklaObject.DimensionType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionType"); }
			}
			set
			{
				try {
				teklaObject.DimensionType = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DimensionType"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes ExtensionLine
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes_.FromTSObject(teklaObject.ExtensionLine);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLine"); }
			}
			set
			{
				try {
				teklaObject.ExtensionLine = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLine"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes ShortDimension
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes_.FromTSObject(teklaObject.ShortDimension);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShortDimension"); }
			}
			set
			{
				try {
				teklaObject.ShortDimension = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShortDimension"); }
			}
		}

		public System.Boolean IncludePartCountInTag
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTag;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTag"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTag = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTag"); }
			}
		}

		public System.Boolean IncludePartCountInTagA
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTagA;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagA"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTagA = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagA"); }
			}
		}

		public System.Boolean IncludePartCountInTagB
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTagB;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagB"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTagB = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagB"); }
			}
		}

		public System.Boolean IncludePartCountInTagC
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTagC;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagC"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTagC = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagC"); }
			}
		}

		public System.Boolean IncludePartCountInTagD
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTagD;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagD"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTagD = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagD"); }
			}
		}

		public System.Boolean IncludePartCountInTagE
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTagE;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagE"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTagE = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagE"); }
			}
		}

		public System.Boolean IncludePartCountInTagF
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTagF;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagF"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTagF = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagF"); }
			}
		}

		public System.Boolean IncludePartCountInTagG
		{
			get
			{
				try {
					return teklaObject.IncludePartCountInTagG;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagG"); }
			}
			set
			{
				try {
					teklaObject.IncludePartCountInTagG = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IncludePartCountInTagG"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftUpperTag
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.LeftUpperTag);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftUpperTag"); }
			}
			set
			{
				try {
				teklaObject.LeftUpperTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftUpperTag"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftMiddleTag
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.LeftMiddleTag);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftMiddleTag"); }
			}
			set
			{
				try {
				teklaObject.LeftMiddleTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftMiddleTag"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement RightUpperTag
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.RightUpperTag);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightUpperTag"); }
			}
			set
			{
				try {
				teklaObject.RightUpperTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightUpperTag"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement RightMiddleTag
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.RightMiddleTag);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightMiddleTag"); }
			}
			set
			{
				try {
				teklaObject.RightMiddleTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightMiddleTag"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftLowerTag
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.LeftLowerTag);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftLowerTag"); }
			}
			set
			{
				try {
				teklaObject.LeftLowerTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftLowerTag"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement RightLowerTag
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.RightLowerTag);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightLowerTag"); }
			}
			set
			{
				try {
				teklaObject.RightLowerTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightLowerTag"); }
			}
		}

		public System.String ExcludePartsAccordingToFilter
		{
			get
			{
				try {
					return teklaObject.ExcludePartsAccordingToFilter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExcludePartsAccordingToFilter"); }
			}
			set
			{
				try {
					teklaObject.ExcludePartsAccordingToFilter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExcludePartsAccordingToFilter"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes Exaggeration
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.FromTSObject(teklaObject.Exaggeration);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Exaggeration"); }
			}
			set
			{
				try {
				teklaObject.Exaggeration = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Exaggeration"); }
			}
		}

        

        

		public StraightDimensionSetAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StraightDimensionSetAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public StraightDimensionSetAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes", args);
		}
		public StraightDimensionSetAttributes(Dynamic.Tekla.Structures.Drawing.ModelObject modelObject)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes", args);
		}
		public StraightDimensionSetAttributes(Dynamic.Tekla.Structures.Drawing.ModelObject modelObject, System.String AttributesFile)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ModelObject_.GetTSObject(modelObject);
			args[1] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes", args);
		}





    }

    internal static class StraightDimensionSetAttributes_
    {
        public static dynamic GetTSObject(StraightDimensionSetAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StraightDimensionSetAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StraightDimensionSetAttributesArray_
    {
        public static dynamic GetTSObject(StraightDimensionSetAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StraightDimensionSetAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StraightDimensionSetAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StraightDimensionSetAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StraightDimensionSetAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class StraightDimensionSet_
    {
        public static dynamic GetTSObject(StraightDimensionSet dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StraightDimensionSet FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.StraightDimensionSet)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StraightDimensionSetArray_
    {
        public static dynamic GetTSObject(StraightDimensionSet[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StraightDimensionSet_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StraightDimensionSet[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StraightDimensionSet>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StraightDimensionSet_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
