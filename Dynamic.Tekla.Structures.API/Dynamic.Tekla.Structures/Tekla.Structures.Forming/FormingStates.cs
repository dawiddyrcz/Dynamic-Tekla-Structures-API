/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Forming
{

    public  class FormingStates 
    {

		public Dynamic.Tekla.Structures.Forming.DeformingType Deforming
		{
			get => Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(teklaObject.Deforming);
			set { teklaObject.Deforming = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Forming.FoldingType Folding
		{
			get => Dynamic.Tekla.Structures.Forming.FoldingType_.FromTSObject(teklaObject.Folding);
			set { teklaObject.Folding = Dynamic.Tekla.Structures.Forming.FoldingType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Forming.WrappingType Wrapping
		{
			get => Dynamic.Tekla.Structures.Forming.WrappingType_.FromTSObject(teklaObject.Wrapping);
			set { teklaObject.Wrapping = Dynamic.Tekla.Structures.Forming.WrappingType_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public FormingStates()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates");
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.DeformingType deforming)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(deforming);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.FoldingType folding)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Forming.FoldingType_.GetTSObject(folding);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.WrappingType wrapping)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Forming.WrappingType_.GetTSObject(wrapping);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}
		public FormingStates(Dynamic.Tekla.Structures.Forming.DeformingType deforming, Dynamic.Tekla.Structures.Forming.FoldingType folding, Dynamic.Tekla.Structures.Forming.WrappingType wrapping)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(deforming);
			args[1] = Dynamic.Tekla.Structures.Forming.FoldingType_.GetTSObject(folding);
			args[2] = Dynamic.Tekla.Structures.Forming.WrappingType_.GetTSObject(wrapping);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Forming.FormingStates", args);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class FormingStates_
    {
        public static dynamic GetTSObject(FormingStates dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FormingStates FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Forming.FormingStates)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
