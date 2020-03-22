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
			get => Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes_.GetTSObject(value); }
		}

		public System.Double Distance
		{
			get => teklaObject.Distance;
			set { teklaObject.Distance = value; }
		}

		public System.Double LeftTagLineOffset
		{
			get => teklaObject.LeftTagLineOffset;
			set { teklaObject.LeftTagLineOffset = value; }
		}

		public System.Double RightTagLineOffset
		{
			get => teklaObject.RightTagLineOffset;
			set { teklaObject.RightTagLineOffset = value; }
		}

        

        

		public StraightDimensionSet() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public static System.Collections.Generic.List<System.String> GetAllExcludePartsAccordingToFilter()
		{
			var parameters = new object[0];
			var result = (System.Collections.Generic.List<System.String>) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.StraightDimensionSet", "GetAllExcludePartsAccordingToFilter", parameters);
			return result;
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}




    public  class StraightDimensionSetAttributes  : Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes CombinedDimension
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes_.FromTSObject(teklaObject.CombinedDimension);
			set { teklaObject.CombinedDimension = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes DimensionType
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.FromTSObject(teklaObject.DimensionType);
			set { teklaObject.DimensionType = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes ExtensionLine
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes_.FromTSObject(teklaObject.ExtensionLine);
			set { teklaObject.ExtensionLine = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes ShortDimension
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes_.FromTSObject(teklaObject.ShortDimension);
			set { teklaObject.ShortDimension = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes_.GetTSObject(value); }
		}

		public System.Boolean IncludePartCountInTag
		{
			get => teklaObject.IncludePartCountInTag;
			set { teklaObject.IncludePartCountInTag = value; }
		}

		public System.Boolean IncludePartCountInTagA
		{
			get => teklaObject.IncludePartCountInTagA;
			set { teklaObject.IncludePartCountInTagA = value; }
		}

		public System.Boolean IncludePartCountInTagB
		{
			get => teklaObject.IncludePartCountInTagB;
			set { teklaObject.IncludePartCountInTagB = value; }
		}

		public System.Boolean IncludePartCountInTagC
		{
			get => teklaObject.IncludePartCountInTagC;
			set { teklaObject.IncludePartCountInTagC = value; }
		}

		public System.Boolean IncludePartCountInTagD
		{
			get => teklaObject.IncludePartCountInTagD;
			set { teklaObject.IncludePartCountInTagD = value; }
		}

		public System.Boolean IncludePartCountInTagE
		{
			get => teklaObject.IncludePartCountInTagE;
			set { teklaObject.IncludePartCountInTagE = value; }
		}

		public System.Boolean IncludePartCountInTagF
		{
			get => teklaObject.IncludePartCountInTagF;
			set { teklaObject.IncludePartCountInTagF = value; }
		}

		public System.Boolean IncludePartCountInTagG
		{
			get => teklaObject.IncludePartCountInTagG;
			set { teklaObject.IncludePartCountInTagG = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftUpperTag
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.LeftUpperTag);
			set { teklaObject.LeftUpperTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftMiddleTag
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.LeftMiddleTag);
			set { teklaObject.LeftMiddleTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement RightUpperTag
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.RightUpperTag);
			set { teklaObject.RightUpperTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement RightMiddleTag
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.RightMiddleTag);
			set { teklaObject.RightMiddleTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement LeftLowerTag
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.LeftLowerTag);
			set { teklaObject.LeftLowerTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement RightLowerTag
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.RightLowerTag);
			set { teklaObject.RightLowerTag = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

		public System.String ExcludePartsAccordingToFilter
		{
			get => teklaObject.ExcludePartsAccordingToFilter;
			set { teklaObject.ExcludePartsAccordingToFilter = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes Exaggeration
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.FromTSObject(teklaObject.Exaggeration);
			set { teklaObject.Exaggeration = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes_.GetTSObject(value); }
		}

        

        

		public StraightDimensionSetAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes");
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

		public System.Boolean LoadAttributes(System.String attributeFilename)
		{
			return teklaObject.LoadAttributes(attributeFilename);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class StraightDimensionSetAttributes_
    {
        public static dynamic GetTSObject(StraightDimensionSetAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static StraightDimensionSetAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.StraightDimensionSet.StraightDimensionSetAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class StraightDimensionSet_
    {
        public static dynamic GetTSObject(StraightDimensionSet dynObject)
        {
            return dynObject.teklaObject;
        }

        public static StraightDimensionSet FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.StraightDimensionSet)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
