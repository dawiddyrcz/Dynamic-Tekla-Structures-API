/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class StraightDimensionSet  : Dynamic.Tekla.Structures.Drawing.DimensionSetBase
    {


        public Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
        }

        public System.Double Distance
        {
            get
            {
                try
                {
                return teklaObject.Distance;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Distance), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Distance = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Distance), ex); 
                }
            }
        }

        public System.Double LeftTagLineOffset
        {
            get
            {
                try
                {
                return teklaObject.LeftTagLineOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftTagLineOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LeftTagLineOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftTagLineOffset), ex); 
                }
            }
        }

        public System.Double RightTagLineOffset
        {
            get
            {
                try
                {
                return teklaObject.RightTagLineOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightTagLineOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.RightTagLineOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightTagLineOffset), ex); 
                }
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
            var result = (System.Collections.Generic.List<System.String>) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.StraightDimensionSet", "GetAllExcludePartsAccordingToFilter");
            return result;
        }





    public  class StraightDimensionSetAttributes  : Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes
    {


        public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes CombinedDimension
        {
            get
            {
                try
                {
                var value = teklaObject.CombinedDimension;
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CombinedDimension), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes_.GetTSObject(value);
                teklaObject.CombinedDimension = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CombinedDimension), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes DimensionType
        {
            get
            {
                try
                {
                var value = teklaObject.DimensionType;
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DimensionType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.GetTSObject(value);
                teklaObject.DimensionType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DimensionType), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes ExtensionLine
        {
            get
            {
                try
                {
                var value = teklaObject.ExtensionLine;
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLine), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes_.GetTSObject(value);
                teklaObject.ExtensionLine = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLine), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes ShortDimension
        {
            get
            {
                try
                {
                var value = teklaObject.ShortDimension;
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShortDimension), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes_.GetTSObject(value);
                teklaObject.ShortDimension = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShortDimension), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTag
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTag;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTag), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTag = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTag), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTagA
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTagA;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagA), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTagA = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagA), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTagB
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTagB;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagB), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTagB = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagB), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTagC
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTagC;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagC), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTagC = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagC), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTagD
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTagD;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagD), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTagD = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagD), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTagE
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTagE;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagE), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTagE = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagE), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTagF
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTagF;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagF), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTagF = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagF), ex); 
                }
            }
        }

        public System.Boolean IncludePartCountInTagG
        {
            get
            {
                try
                {
                return teklaObject.IncludePartCountInTagG;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagG), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IncludePartCountInTagG = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncludePartCountInTagG), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftUpperTag
        {
            get
            {
                try
                {
                var value = teklaObject.LeftUpperTag;
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ContainerElement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftUpperTag), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
                teklaObject.LeftUpperTag = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftUpperTag), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftMiddleTag
        {
            get
            {
                try
                {
                var value = teklaObject.LeftMiddleTag;
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ContainerElement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftMiddleTag), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
                teklaObject.LeftMiddleTag = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftMiddleTag), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ContainerElement RightUpperTag
        {
            get
            {
                try
                {
                var value = teklaObject.RightUpperTag;
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ContainerElement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightUpperTag), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
                teklaObject.RightUpperTag = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightUpperTag), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ContainerElement RightMiddleTag
        {
            get
            {
                try
                {
                var value = teklaObject.RightMiddleTag;
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ContainerElement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightMiddleTag), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
                teklaObject.RightMiddleTag = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightMiddleTag), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftLowerTag
        {
            get
            {
                try
                {
                var value = teklaObject.LeftLowerTag;
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ContainerElement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftLowerTag), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
                teklaObject.LeftLowerTag = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftLowerTag), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ContainerElement RightLowerTag
        {
            get
            {
                try
                {
                var value = teklaObject.RightLowerTag;
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ContainerElement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightLowerTag), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value);
                teklaObject.RightLowerTag = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightLowerTag), ex); 
                }
            }
        }

        public System.String ExcludePartsAccordingToFilter
        {
            get
            {
                try
                {
                return teklaObject.ExcludePartsAccordingToFilter;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExcludePartsAccordingToFilter), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ExcludePartsAccordingToFilter = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExcludePartsAccordingToFilter), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes Exaggeration
        {
            get
            {
                try
                {
                var value = teklaObject.Exaggeration;
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Exaggeration), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.GetTSObject(value);
                teklaObject.Exaggeration = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Exaggeration), ex); 
                }
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
    
